using System;

float MilesToKm(float miles)
{
    return miles * 1.6f;
}

Console.WriteLine(MilesToKm(15));

void PrintName(string name)
{
    Console.WriteLine($"Hello {name}!");
}

PrintName("Arthur");

void PrintWithPrefix(string str, string prefix = ":>>")
{
    Console.WriteLine($"{prefix} {str}");
}

PrintWithPrefix("Hey!");
PrintWithPrefix("Hey!", prefix: ">");

void AppendTen(ref int value)
{
    value += 10;
    return;
}

int OverloadAppendTen(int value)
{
    int newValue = value;
    AppendTen(ref newValue);
    return newValue;
}

int value = 20;
AppendTen(ref value);
Console.WriteLine(value);

int anotherValue = 10;
Console.WriteLine(OverloadAppendTen(anotherValue));
Console.WriteLine(anotherValue);

static void Plus(int first, int second, out int returnedSum)
{
    returnedSum = first + second;
}

int sum;
Plus(10, 20, out sum);
Console.WriteLine(sum);

(string name, int age) person = ("Arthur", 21);
var anotherPerson = ("Arthur", 22);

static (string, int) GeneratePerson()
{
    return ("Arthur", 20);
}

(string, int) oldPerson = GeneratePerson();

Console.WriteLine(oldPerson.Item2);