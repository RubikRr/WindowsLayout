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
        public string nameOfPicture { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double x3 { get; set; }
        public double x4 { get; set; }
        public double x5 { get; set; }
        public double x6 { get; set; }
        public double x7 { get; set; }
        public double x8 { get; set; }


        public Window(string nameOfPicture)
        {
            this.nameOfPicture = nameOfPicture;
            x1=0;
            x2=0;
            x3=0;
            x4=0;
            x5=0;
            x6=0;
            x7=0;
            x8=0;
        }

        public Window(string nameOfPicture,double x1, double x2, double x3, double x4, double x5, double x6, double x7, double x8)
        {
            this.nameOfPicture = nameOfPicture;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.x5 = x5;
            this.x6 = x6;
            this.x7 = x7;
            this.x8 = x8;
        }
    }
}
