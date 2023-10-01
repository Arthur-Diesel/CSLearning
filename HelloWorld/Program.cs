/// XML Documentation!

// using System;

/*
Without namespace, it's called top level statements!
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) // Entry point (begin the program here) + string[] args is arguments inputted with the program start!
        {
            */
Console.WriteLine("Hello World!");
//Console.WriteLine("What's your name?");
// string? name = Console.ReadLine();
// if (String.IsNullOrEmpty(name))
// {
//     Console.WriteLine("Please, input your name next time!");
//     return;
// }
// Console.WriteLine("Hello, {0}!", name);
/*
}
}
}
*/

int i = 10;
long bigi = (long)i;
float f = 2.0f;
double doub = (double)f;
decimal d = 10.0m;
bool b = true;
char c = 'c';
string str = "str";

var x = 10; // Implicit!

dynamic dyn = 10;
dyn = true;

int[] ints = new int[5];
string[] strs = { "one", "two", "three" };

object obj = null;

string nullString = null;
nullString ??= "Yes!"; // nullString is null? then...

Console.WriteLine(obj ?? "Null!");
Console.WriteLine(nullString);

