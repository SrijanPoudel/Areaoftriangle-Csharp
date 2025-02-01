//Written by Shrijan Paudel
//Date : 01/26

// Area of Triangle of Farmer field


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Triange_
{
    public class Program
    {


        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.WriteLine("Enter a Width of Field");
            double widthh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a Height of Field");
            double heightt = Convert.ToDouble(Console.ReadLine());

            triangle.Width = widthh;
            triangle.Height = heightt;

            double area = triangle.CalcArea();
            if (area > 0)
            {
                Console.WriteLine($"Width is {widthh}, Height is {heightt} ,Area of Triangle is {area} ");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}

