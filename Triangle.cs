//Written by Shrijan Paudel
// 01/25/2005


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Triange_
{

    public class Triangle
    {
        private double height = 0;
        private double width = 0;

        public double Height
        {
            get { return this.height; }
            set { height = value; }
        }
        public double Width
        {
            get { return this.width; }
            set { width = value; }
        }

        public double CalcArea()
        {
            double area = 0.5 * Height * Width;

            return area;


        }
    }
}