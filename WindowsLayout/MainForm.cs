using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLayout
{
    public partial class MainForm : Form
    {
        string[] pictures;
        int currentPicture;
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
                ShowFiles(folderPath);
            }
        }
        public void ShowFiles(string path)
        {
            pictures = Directory.GetFiles(path);
            foreach (var file in pictures)
            {
                Console.WriteLine((string)file);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr=new StreamReader("currentPicture.txt"))
            {
                currentPicture = int.Parse(sr.ReadLine());
            }
        }

        private void skipPicture_Click(object sender, EventArgs e)
        {
            currentPicture++;
            ChangeLableCurrentPicture();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("currentPicture.txt", false)) 
            {
                sw.WriteLine(currentPicture);
            }
        }
    }
}
