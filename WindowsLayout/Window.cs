using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLayout
{
    public class Window
    {
        string nameOfPicture;

        Point point1;
        Point point2;
        Point point3;
        Point point4;

        public Window(string nameOfPicture)
        {
            this.nameOfPicture = nameOfPicture;
            point1 = new Point(0, 0);
            point2 = new Point(0, 0);
            point3 = new Point(0, 0);
            point4 = new Point(0, 0);
        }

        public Window(string nameOfPicture, Point point1, Point point2, Point point3, Point point4)
        {
            this.nameOfPicture = nameOfPicture;
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }

        public List<double> GetListOfCoordinates()
        {
            List<double> listOfCoordinates = new List<double>();
            listOfCoordinates.AddRange(new double[] { point1.X, point1.Y, point2.X, point2.Y, point3.X, point3.Y, point4.X, point4.Y });
            return listOfCoordinates;
        }
    }
}
