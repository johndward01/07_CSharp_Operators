using System;
using System.Security.Cryptography.X509Certificates;

namespace Operator_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 
            //Create a simple program named OperatorExercise in your repos folder 
            //to write out the results of addition, subtraction, multiplication, division operations. 

            //write out the results in the following form: if a = 17 and b = 4, print the following:	
            //  --> 17/4 is 4 remainder 1

            //int a = 17;
            //int b = 4;
            //int quotient = a / b;
            //int remainder = a % b;
            //Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            //Console.WriteLine();
            //Console.WriteLine();


            ////Exercise 2
            //Console.Write("Please enter the radius: ");
            //string input = Console.ReadLine();
            //double radius = double.Parse(input);
            //double area = AreaOfCircle(radius);
            //Console.WriteLine(area);


            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);

        }

        //Exercise 2
        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }


        //bonus method --> Can you call this method? (HINT: it's almost identicle to the AreaOfCircle Method)
        public static void Something()
        {
            Console.WriteLine("This method writes out 0 - 9 to the console");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {                    
                Console.WriteLine(i);
                Console.WriteLine();
            }          
           
        } 

    }
}
