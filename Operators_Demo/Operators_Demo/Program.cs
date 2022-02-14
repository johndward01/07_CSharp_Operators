using System;

namespace Operators_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //double answer = num1 % num2;
            //Console.WriteLine(answer);

            // num1 = num1 + 10;
            //num1 += 10;

            //// num1 = num1 - 3;
            //num1 -= 3;

            //// num1 = num1 * 2;
            //num1 *= 2;

            //// num1 = num1 / 4;
            //num1 /= 4;

            //// num1 = num1 % 2;
            //num1 %= 2;

            //Console.WriteLine(num1);

            // 14 % 3 = 0

            //ModulusExample1(14, 3);

            // num1 = num1 + 1;
            // num1 += 1;


            // Relational Operators

            int x = 3;
            int y = 3;

            //// is equal 
            //bool answer = x == y;
            //Console.WriteLine(answer); 

            //// is not equal
            //bool answer1 = x != y; 
            //Console.WriteLine(answer1); 

            //// greater than
            //bool answer2 = x > y;
            //Console.WriteLine(answer2); 

            //// less than
            //bool answer3 = x < y;
            //Console.WriteLine(answer3); 

            //// gtoe
            //bool answer4 = x >= y;
            //Console.WriteLine(answer4); 

            //// ltoe
            //bool answer5 = 2 <= y ;
            //Console.WriteLine(answer5);


            // Logical Operators

            // && AND Operator
            bool a1 = (x == y) && (x > 0);
            //Console.WriteLine(a1);

            // || OR Operator
            bool a2 = x != y || x > 0;
            //Console.WriteLine(a2);

            //// ! NOT Operator
            //bool a3 = x == y;
            //Console.WriteLine(!a3);

            //Console.WriteLine(!true);

            int a = 10; 
            int b = 10;
            int answer = a %= b;

            if (a == b)
            {
                Console.WriteLine(answer);
            }

        }

        public static void ModulusExample1(int x, int y)
        {
            Console.WriteLine(x % y); 
        }

        public static string Greet(string firstName, string lastName)
        {
            return $"Hello, {firstName} {lastName}.";
        }
    }
}
