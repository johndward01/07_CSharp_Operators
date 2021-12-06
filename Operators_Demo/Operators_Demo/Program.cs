using System;

namespace Operators_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

            //int x = 3;
            //int y = x++;
            //Console.WriteLine(y);
            
=======
            // Console.WriteLine() == output
            // Console.ReadLine() == input


            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Please enter your first name: ");
            //string firstName = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Please enter your last name: ");
            //string lastName = Console.ReadLine();


            //if (age < 18)
            //{
            //    Console.WriteLine("Let me see your ID!");
            //}
            //else if (age >= 18 && firstName == "John")
            //{
            //    Console.WriteLine("Welcome, Johnny boy!!!");
            //}
            //else if (age >= 18 && firstName == "Caprena")
            //{
            //    Console.WriteLine("Welcome, Caprena!!!");
            //}


            Console.WriteLine("What country are you from?");
            string country = Console.ReadLine();

            bool isNorthAmerica;

            switch (country.ToLower())
            {
                case "mexico":
                    isNorthAmerica = true;
                    Console.WriteLine("Mexico is in NorthAmerica");
                    break;
                case "canada":
                    isNorthAmerica = true;
                    Console.WriteLine("Canada is in NorthAmerica");
                    break;
                case "usa":
                    isNorthAmerica = true;
                    Console.WriteLine("The US is in NorthAmerica");
                    break;
                default:
                    isNorthAmerica = false;
                    Console.WriteLine("This country is not in NorthAmerica");
                    break;
            }

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = Convert.ToInt32(Console.ReadLine());


            int favoriteNumber = 77;














            // ***Unary Operator***

            //  Increment: The ‘++’ operator is used to increment the value of an integer. 
            //  When placed before the variable name (also called pre-increment operator), its value is incremented instantly. 
            //  For example, ++x(prefix).


            //x is 4 and y is 4

            ////  And when it is placed after the variable name (also called post-increment operator), 
            ////  its value is preserved temporarily until the execution of this statement and
            ////  it gets updated before the execution of the next statement. For example, x++(postfix).

            ////   z++ is a shorthand way of typing out z = z + 1
            //int z = 10;
            //z++;
            //Console.WriteLine(z);
            ////  Outputs 11

            ////  Decrement: The ‘--‘ operator is used to decrement the value of an integer. 
            ////  When placed before the variable name (also called pre-decrement operator), 
            ////  its value is decremented instantly. For example, --x.

            //int b = 5;
            //Console.WriteLine(--b);
            ////  Outputs 4

            ////  And when it is placed after the variable name (also called post-decrement operator), 
            ////  its value is preserved temporarily until the execution of this statement and
            ////  it gets updated before the execution of the next statement. For example, x--.

            //int a = 4;
            //Console.WriteLine(a--);
            ////  Outputs 4


            //// BONUS EXAMPLE (Comment out all the lines above and below if you want to only see this example)
            //int num1 = 4;
            //Console.WriteLine($"num1++: {num1++}"); //after this statement num1 = 5
            //Console.WriteLine($"++num1: {++num1}");

            //int num2 = 4;
            //Console.WriteLine($"num2--: {num2--}"); //after this statement num2 = 3
            //Console.WriteLine($"--num2: {--num2}");
            //-----------------------------------------------------------------------------------------------------------------------

            //  Relational Operator

            //  Relational operators are used for comparison of two values.

            //var number1 = 0;
            //var number2 = 0;
>>>>>>> 799b0b1df23c71621febf3bcc79eae8eece2ea59

            int num1 = 30;
            int num2 = 30;

            //if ( (num1 >= num2 && num2 != 100) || (num1 < 100) )
            //{
            //    Console.WriteLine("This statement was executed.");
            //}
            //Console.WriteLine("Moving on");


            //num1 += 30;
            //num1 -= 10;
            //num1 *= 2;
            //num1 /= 4;
            //num1 %= 5;

            //Console.WriteLine(num1);

            num1 = 10;

            // var x = condition ? truescope : falsescope;
            var result = num1 % 2 == 0 ? "This is an even number" : "This is an odd number";
            Console.WriteLine(result);


            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("This is an even number");
            //}
            //else
            //{
            //    Console.WriteLine("This is an odd number");
            //}

<<<<<<< HEAD
            


=======
            //--------------------------------------------------------------------------------------------------------------------------

            //  Assignment Operator

            /*  Assignment operators are used to assign a value to a variable. 
                The left side operand of the assignment operator is a variable and
                the right side operand of the assignment operator is a value. 
                The value on the right side must be of the same data-type of the variable on the left side, 
                otherwise the compiler will raise an error. */

            //  = (Simple Assignment): This is the simplest assignment operator.

            //  We've been using simple assignment this whole time just look above (for example: Line 126)

            //  += (Add Assignment): This operator is a combination of ‘+’ and ‘=’ operators. 
            //      This operator first adds the current value of the variable on the left to the value on the right and 
            //      then assigns the result to the variable on the left.
            //      (a += b) same as (a = a + b) 
            //      If the initial value stored in "a" is 5 and "b" is 6. Then (a += 6) = 11.


            int num1 = 100;
            int num2 = 200;

            num2 = num1 + num2;
            //num2 += num1;


            //  -= (Subtract Assignment): This operator is a combination of ‘-‘ and ‘=’ operators. 
            //      This operator first subtracts the current value of the variable on the left from the value on the right and
            //      then assigns the result to the variable on the left.

            //      Example: a = 8 b = 6
            //      (a -= b) same as (a = a - b)  2 = 8 - 6
            //      If the initial value stored in a is 8. Then (a -= 6) = 2.

            //var a1 = 433323;
            //var b1 = 37747;
            //var answer2 = 0;

            //a1 -= b1; // a1 = a1 - b1

            ////  *= (Multiply Assignment): This operator is a combination of ‘*’ and ‘=’ operators. 
            ////      This operator first multiplies the current value of the variable on the left to the value on the right and
            ////      then assigns the result to the variable on the left.

            ////      Example:
            ////      (a *= b) same as (a = a * b)
            ////      If the initial value stored in a is 5. Then (a *= 6) = 30.
            //var a2 = 100;
            //var b2 = 50;
            //var answer3 = 0;

            //a2 *= b2; // a2 = a2 * b2;

            ////  /= (Division Assignment): This operator is a combination of ‘/’ and ‘=’ operators. 
            ////      This operator first divides the current value of the variable on the left by the value on the right and
            ////      then assigns the result to the variable on the left.

            //var a3 = 1000;
            //var b3 = 5;
            //var answer4 = 0;

            //a3 /= b3; // a3 = a3 / b3
            ////      Example:
            ////      (a /= b) same as (a = a / b)
            ////      If the initial value stored in a is 6. Then (a /= 2) = 3.

            ////  %= (Modulus Assignment): This operator is a combination of ‘%’ and ‘=’ operators. 
            ////      This operator first modulo the current value of the variable on the left by the value on the right and 
            ////      then assigns the result to the variable on the left.
            //var a4 = 22;
            //var b4 = 22;
            //var answer5 = 0;

            //a4 %= b4; // a4 = a4 % b4;
            //Console.WriteLine(a4 / b4); // 1 
            //Console.WriteLine(a4 % b4); // 0
            //      Example : a = 6
            //      (a %= b) same as (a = a % b) 
            //      If the initial value stored in a is 6. Then (a %= 2) = 0.

            //-----------------------------------------------------------------------------------------------------------------------

            // Ternary Operator

            // The ternary operator, also known as the Inline-if and is syntax sugar, 
            // is a shorthand version of if-else statement. 
            // The word ternary means composed of three parts, 
            // so it makes sense that this operator has THREE operands. 
            // It will return one of two values depending on the value of a Boolean expression.


            /*                                          Syntax:
                                            condition ? trueScope : falseScope;
                 
                Explanation :
                condition: It must be evaluated to true or false.
                If the condition is true,
                trueScope is evaluated and becomes the result.
                If the condition is false,
                falseScope is evaluated and becomes the result.
                 
                 
                Example:
            */


            //int i = 1;
            //string positiveMessage = (i > 0) ? "You are positive!" : "You're not positive";


            //string username = "";
            //string greeting = username != "" ? $"Hello, {username}!" : $"Hello, user! Btw.. you forgot to enter your name!";

            //if (username != "")
            //{
            //    greeting = $"Hello, {username}!";
            //}
            //else
            //{
            //    greeting = $"Hello, user! Btw.. you forgot to enter your name!";
            //}


>>>>>>> 799b0b1df23c71621febf3bcc79eae8eece2ea59
        }
    }
}
