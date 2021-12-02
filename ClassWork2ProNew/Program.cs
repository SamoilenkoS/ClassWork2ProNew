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

        static bool IsSomethingValid(int n)
        {
            Console.WriteLine($"Value:{n}");
            if(n > 0)
            {
                return true;
            }

            return false;
        }

        static void IfExample()
        {
            // >, <, >=, <=, ==, !=
            // & - and
            // | - or
            int a = 0;
            int b = 5;
            if (a > 0 && IsSomethingValid(b))
            {
                Console.WriteLine("Both are greater than zero!");
            }
            else if (a == 0 || b == 0)
            {
                Console.WriteLine("One of them are zero");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("Both are lower than zero");
            }
        }

        static void SwitchExample()
        {
            Console.WriteLine("Enter 1 for task 1");
            Console.WriteLine("Enter 2 for task 2");
            Console.WriteLine("Enter 3 for task 3");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }

        static void TimePartExample()
        {
            int minutes = 55;
            if (minutes >= 0 && minutes <= 15)
            {
                Console.WriteLine(1);
            }
            else if (minutes > 15 && minutes <= 30)
            {
                Console.WriteLine(2);
            }
            else if (minutes > 30 && minutes <= 45)
            {
                Console.WriteLine(3);
            }
            else if (minutes > 45 && minutes <= 59)
            {
                Console.WriteLine(4);
            }
        }

        static void TernarExample()
        {
            int year = 1945;
            string message = year % 4 == 0 ? "Yes" : "No";
        }

        static bool IsTriangleExists(double a, double b, double c)
        {
            return
                (a + b) > c &&
                (a + c) > b &&
                (c + b) > a;
        }

        static void IfAndTest()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0 && (num < 10 || num > 20))
            {
                Console.WriteLine(num * num);
            }
            else
            {
                Console.WriteLine(num);
            }
        }

        static void Test()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0 && a != 0 && b != 0)
            {
                Console.WriteLine("Yes");
            }
        }

        static void CharExample()
        {
            char x = 'Z';
            if ((x >= 'A' && x <= 'Z') || (x >= 'a' && x <= 'z'))
            {
                Console.WriteLine("Letter!");
            }
            else
            {
                Console.WriteLine("Something else!");
            }
        }

        static void Main(string[] args)
        {//Ctrl + Shift + Space => call inteli sense

        }
    }
}
