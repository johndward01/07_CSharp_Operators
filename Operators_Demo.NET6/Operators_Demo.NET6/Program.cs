

#region Arithmetic && Assignment Operators

//x = x + y;
//x += y;

//z = z - y;
//z -= y;

//x = x * y;
//x *= y;

//x = x / y;
//x /= y;

//x = x % y;
//x %= y;

//x++;
//++x;

#endregion
#region Unary Operators
//double x = 15;
//double y = 6;

//double test = ++y - x++;
//Console.WriteLine(test);
//Console.WriteLine(x);


//int a = 1;
//int b = 2;

//int answer = a-- + ++b;
//Console.WriteLine(answer);
//Console.WriteLine(a);
//Console.WriteLine(b);


//int num1 = 7;

////num1 = num1 - 1;
//int answer = num1--;

//Console.WriteLine(answer);

#endregion


#region Null Coalescing Operator

//var exampleValue = possiblyNullValue ?? someDefaultValue;
string str1 = null;
string answer = str1 ?? "This will be the default value";
Console.WriteLine(answer);

#endregion
#region Null-Conditional Operator

List<string> myList = null;
 myList?.Add("myString");

#endregion


#region Ternary Operator
//int number1 = 10;
//int number2 = 8;
//bool z = true;
//string str1 = "1st Choice";
//string str2 = "2nd Choice";

//var theValue = number1 > 0 || !z ? str1 : str2;
//Console.WriteLine(theValue);


//if ( number1 > 0 || !z)
//{
//    Console.WriteLine("1st Choice");
//}
//else
//{
//    Console.WriteLine("2nd Choice");
//}

//bool answer = number1 == number2;
//Console.WriteLine(answer);


//int var1 = 100;
//int var2 = 200;

//if (!(var1 >= var2) || var2 == 200)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine("2nd Choice");
//}

//var myChoice = !(var1 >= var2) || var2 == 200 ? "true" : "2nd Choice";
//Console.WriteLine(myChoice);

#endregion






