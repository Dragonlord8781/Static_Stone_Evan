using Static_Stone_Evan;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //program #
            Console.WriteLine("Program 13");

            //interger methods
            Console.WriteLine("Integer Methods");
            Console.WriteLine("15 + 88 is " + Calculate.Add(15,88));
            Console.WriteLine("12 - 57 is " + Calculate.Sub(12,57));
            Console.WriteLine("9 * 6 is " + Calculate.Mult(9, 6));
            Console.WriteLine("46 / 7 is " + Calculate.Div(46, 7));

            //float methods
            Console.WriteLine("Float Methods");
            Console.WriteLine("15.55 + 88.65 is " + Calculate.Add(15.55f, 88.65F));
            Console.WriteLine("1.22 - 57.83 is " + Calculate.Sub(1.22f, 57.83f));
            Console.WriteLine("9.21 * 6.24 is " + Calculate.Mult(9.21f, 6.24f));
            Console.WriteLine("46.68 / 7.37 is " + Calculate.Div(46.48f, 7.37f));


        }
    }
}