using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLayout
{
    public class WindowCSV
    {
        string name;
       public int a=0;
       public int b=0;
        public int c=0;
        public int d=0;
        List<double> coordinates;

        public WindowCSV(string name, int a,int b,int c,int d)
        {
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            //this.coordinates = coordinates;
        }
    }
}
