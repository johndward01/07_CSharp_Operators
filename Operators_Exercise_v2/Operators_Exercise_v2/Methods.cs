using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Exercise_v2;

internal class Methods
{
    public static void Exercise1_Division()
    {
        int a = 17;
        int b = 4;
        int quotient = a / b;
        int remainder = a % b;
        string theAnswer = (a == 17 && b == 4) ? $"{a} / {b} is {quotient} remainder {remainder}" : "something else....";
        Console.WriteLine(theAnswer);
        //if (a == 17 && b == 4)
        //{
        //    Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
        //}
        //else
        //{
        //    Console.WriteLine("something else....");
        //}
    }

    public static double AreaOfCircle()
    {
        Console.Write("Please enter the radius for the circle: ");
        double radius = double.Parse(Console.ReadLine());
        AddSpaces(2);
        var area = Math.PI * Math.Pow(radius, 2);
        Console.Write($"The area of this circle is: {Math.Round(area, 2)}");
        AddSpaces(3);
        return area;
    }

    public static void AddSpaces(int numberOfSpaces)
    {
        while (numberOfSpaces > 0)
        {
            Console.WriteLine();
            numberOfSpaces--;
        }
    }
}
