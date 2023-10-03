using System;
using System.Text;
using System.Globalization;

// See https://aka.ms/new-console-template for more information

string str = "String!";

Console.WriteLine(str.Length);
Console.WriteLine(str[str.Length - 1]);

string[] strings = { "Hello", "World!" };

Console.WriteLine(String.Concat(strings));
Console.WriteLine(String.Join(" ", strings));

Console.WriteLine(String.Compare("Heyyyy", "Heyyyy"));
Console.WriteLine(str.Equals("String!"));
Console.WriteLine(str.IndexOf("ing!"));
Console.WriteLine(str.Replace("r", ""));

// Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", 1234);
Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", 1234);
Console.WriteLine("{0,12}, {1,12}, {2,12}, {3,12}", 1, 2, 3, 4); // Columns!
// {0,12:C0} // Currency w/ 0 decimal cases!
// {0,12:P2} // Percentage!

Console.WriteLine($"{str}");
Console.WriteLine($"{10:C2}");

StringBuilder sb = new StringBuilder("Initial string.", 200); // Maximum String Capacity = 200!

int times = 10;

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length};");
sb.AppendLine();
sb.Append("Appeded Text!");
sb.AppendLine();
sb.AppendFormat("{0} times!", times); // Append formatted strings!
sb.AppendLine();
sb.AppendJoin(", ", strings);
sb.Replace("World!", "Mundo!");
Console.WriteLine(sb.ToString());
Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length};");

string decimalString = "3.000,10";

string anotherDecimalString = "1.000,00";

double number = double.Parse(decimalString);

// int targetNumber = int.Parse(anotherDecimalString, NumberStyles.Float);
int anotherTargetNumber = int.Parse(anotherDecimalString, NumberStyles.Float | NumberStyles.AllowThousands);

Console.WriteLine(number);
// Console.WriteLine(targetNumber);
Console.WriteLine(anotherTargetNumber);

bool isTrue = bool.Parse("True");

int targetNum;
Int32.TryParse("1", out targetNum);
