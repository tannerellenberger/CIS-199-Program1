using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalLength;
            double height;
            int doors;
            int windows;
            int paint;

            const int doorSubtraction = 20;
            const int windowSubtraction = 15;
            const double paintDivision = 350;

            string totalLengthAsString;
            string heightAsString;
            string doorsAsString;
            string windowsAsString;
            string paintAsString;
            string minPaintAsString;

            double squareFeet;
            double squareFeet1;
            double squareFeet2;
            double squareFeet3;
            double minPaint;



            Console.WriteLine("Welcome to the Handy-Dandy Paint Estimator ");
            WriteLine("");

            Write("Enter the total length of walls (in feet):");
            totalLengthAsString = ReadLine();
            totalLength = Convert.ToDouble(totalLengthAsString);

            Write("Enter the total height of the walls (in feet):");
            heightAsString = ReadLine();
            height = Convert.ToDouble(heightAsString);

            Write("Enter the number of doors (non-neg int):");
            doorsAsString = ReadLine();
            doors = Convert.ToInt32(doorsAsString);

            Write("Enter the number of windows (non-neg int):");
            windowsAsString = ReadLine();
            windows = Convert.ToInt32(windowsAsString);

            Write("Enter the number of coats of paint (non-neg int):");
            paintAsString = ReadLine();
            paint = Convert.ToInt32(paintAsString);

            WriteLine("");
            WriteLine($"You need a minimum of {minPaint} gallons of paint ");
            

            WriteLine("You'll need to buy {0} gallons, though");



            //Calculations
            squareFeet = height * totalLength;
            squareFeet1 = squareFeet - doorSubtraction;
            squareFeet2 = squareFeet1 - windowSubtraction;
            squareFeet3 = paint * squareFeet2;
            minPaint = squareFeet3 / paintDivision






        }
    }
}
