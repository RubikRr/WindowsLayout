using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Drawing;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
//using CsvHelper;
//using CsvHelper.Configuration;

namespace WindowsLayout
{
    public partial class MainForm : Form
    {
        string[] pictures;
        int currentPicture;
        List<PointD> listOfCoordinates = new List<PointD>();

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ChangeLableCurrentPicture();
        }

        public void ChangeLableCurrentPicture()
        {
            lableCurrentPicture.Text = currentPicture.ToString();
        }

        private void chooseFolderWithPictures_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                pictures = Directory.GetFiles(folderPath);
                ShowImage();
                //ShowFiles(folderPath);
            }
        }

        //public void ShowFiles(string path)
        //{
        //    pictures = Directory.GetFiles(path);
        //    foreach (var file in pictures)
        //    {
        //        Console.WriteLine(file);
        //    }
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("currentPicture.txt"))
            {
                currentPicture = int.Parse(sr.ReadLine());
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //using (StreamWriter sw = new StreamWriter("currentPicture.txt", false)) 
            //{
            //    sw.WriteLine(currentPicture);
            //}
        }

        
        public void NextPicture()
        {
            try
            {


                currentPicture++;
                ChangeLableCurrentPicture();
                ShowImage();
                listOfCoordinates.Clear();
                NameAndCoordinates.Items.Clear();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Картинки закончились");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void skipPicture_Click(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void WithWindow_Click(object sender, EventArgs e)
        {

            Window window = new Window($"image{currentPicture}", listOfCoordinates[0].X, listOfCoordinates[0].Y, listOfCoordinates[1].X, listOfCoordinates[1].Y, listOfCoordinates[2].X, listOfCoordinates[2].Y, listOfCoordinates[3].X, listOfCoordinates[3].Y);
            //var list = new List<WindowCSV>();
            //list.Add(new WindowCSV("ff", 5, 2, 4, 8));
            //list.Add(new WindowCSV("fqqf", 1, 2, 3, 8));

            using (StreamWriter sw = new StreamWriter("windows.csv",true))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    // HasHeaderRecord = false,
                    Delimiter = ","
                };
                using (var csvWriter = new CsvWriter(sw, csvConfig))
                {
                    csvWriter.WriteRecord(window);
                    csvWriter.NextRecord();
                }

            }

            index++;
            NextPicture();

        }

        private void WithoutWindow_Click(object sender, EventArgs e)
        {

            Window window = new Window($"image{currentPicture}");
            using (StreamWriter sw = new StreamWriter("windows.csv", true))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    // HasHeaderRecord = false,
                    Delimiter = ","
                };
                using (var csvWriter = new CsvWriter(sw, csvConfig))
                {
                    csvWriter.WriteRecord(window);
                    csvWriter.NextRecord();
                }

            }
            index++;
            NextPicture();

        }
        public void ShowImage()
        {
            pictureBox.Image = Image.FromFile(pictures[currentPicture]);
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                double x = Cursor.Position.X;
                double y = Cursor.Position.Y;
                PointD point = new PointD(x, y);
                listOfCoordinates.Add(point);
                NameAndCoordinates.Items.Add(point.ToString());
                if (listOfCoordinates.Count == 4)
                {
                    MessageBox.Show("Окно выделено");
                }
            }
        }

        private void clearListBox_Click(object sender, EventArgs e)
        {
            NameAndCoordinates.Items.Clear();
        }


    }
}
