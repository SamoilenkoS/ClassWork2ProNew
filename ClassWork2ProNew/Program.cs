using System;

namespace ClassWork2ProNew
{
    class Program
    {
        static double CalculateEquation(double a, double b)
        {
            return (5 * a + b * b) / (b - a);
        }

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static (int division, int reminder) GetDivisionAndReminder(int a, int b)
        {
            return (a / b, a % b);
        }

        static double CalculateAnotherEquation(int a, double b, double c)
        {
            return Math.Round((c - b) / a, 2);
        }

        static void TestMain()
        {
            //string a = "Hello";
            //string b = "World";
            //string c;

            //Swap(ref a, ref b);

            //Console.WriteLine(a + b);

            //var result = GetDivisionAndReminder(5, 2);

            //Console.WriteLine(result);

            //(double k, double b) result = Task5(1, 2, 3, 4);
            //Console.WriteLine(result);

            //double calc = CalculateAnotherEquation
            //    (5, CalculateAnotherEquation(5, 4.4, 3), 3) * 5;

            //Console.WriteLine($"This is my string with {calc} value!");
        }

        static (double k, double b) Task5(
            double x1, double y1,
            double x2, double y2)
        {
            double k = (y2 - y1) / (x2 - x1);
            double b = -(x1 * y2 - x2 * y1) / (x2 - x1);

            return (k, b);
        }

        static void Main(string[] args)
        {//Ctrl + Shift + Space => call inteli sense


        }
    }
}
