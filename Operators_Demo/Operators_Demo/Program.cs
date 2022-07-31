using System;
using System.Collections.Generic;

namespace Operators_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //double x = 9;
            //double y = 10;
            //double answer = x / y;
            //Console.WriteLine(answer);

            //int a = 12;
            //int b = 2;
            //int answer = a % b; 
            //Console.WriteLine(answer);


            //int x = 10;
            //x++;
            //Console.WriteLine(++x);

            //int x = 4;
            //int y = 4;
            //bool answer = !string.IsNullOrEmpty("");
            //Console.WriteLine(answer);


            //int x = 2;
            //int y = 2;
            //bool answer = x != y || y > 3;
            //Console.WriteLine(!answer);

            //if (x == 1 || y != 0)
            //{
            //    Console.WriteLine();
            //}



            //int x = 3;
            //x %= 3;
            //Console.WriteLine(x);

            //int x = 20;
            //int y = 10;

            //// Syntax   Condition ? truescope : falsescope
            //var answer = (x > 0) ? "X is positive" : "x is negative";
            //Console.WriteLine(answer);

            //if (x > 0)
            //{
            //    Console.WriteLine("X is positive");
            //}
            //else if (x == 0)
            //{
            //    Console.WriteLine("X is 0");
            //}
            //else
            //{
            //    Console.WriteLine("x is negative");
            //}



            // var exampleValue = possiblyNullValue ?? someDefaultValue;

            //List<int?> list1 = new List<int?>(){ 1, 2 , null, 4};

            //foreach (var item in list1)
            //{
            //    int answer = item ?? 100;
            //    Console.WriteLine(answer);
            //}


            var list2 = new List<string>() { "abc", "def", "ghi" };
            List<string> list3 = null;

            list3?.Add("John");


            Console.WriteLine(list3[0]);










            //var list = new List<int>() { 1, 2, 3, 4, 5 };
            //int index = 0;

            //while (index < list.Count)
            //{
            //    Console.WriteLine(list[index]);
            //    index+=2;
            //}








            //double answer = num1 % num2;
            //Console.WriteLine(answer);

            //// num1 = num1 + 10;
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




            //// Relational Operators

            //int x = 3;
            //int y = 3;

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


            //// Logical Operators

            //// && AND Operator
            //bool a1 = (x == y) && (x > 0);
            //Console.WriteLine(a1);

            //// || OR Operator
            //bool a2 = x != y || x > 0;
            //Console.WriteLine(a2);

            //// ! NOT Operator
            //bool a3 = x == y;
            //Console.WriteLine(!a3);

            //Console.WriteLine(!true);

            //int a = 10; 
            //int b = 10;
            //int answer = a %= b;

            //if (a == b)
            //{
            //    Console.WriteLine(answer);
            //}

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
