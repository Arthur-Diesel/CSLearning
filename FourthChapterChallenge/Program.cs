using System;
using System.Text;
using System.Text.RegularExpressions;

static bool IsPalindrome(string thestr)
{
    StringBuilder reversedString = new StringBuilder("", thestr.Length);
    string pattern = @"[\p{P}\s]";
    string cleanString = Regex.Replace(thestr, pattern, "").ToLower();

    for (int counter = cleanString.Length - 1; counter >= 0; counter--)
    {
        reversedString.Append(cleanString[counter]);
    }

    return reversedString.ToString().ToLower() == cleanString;
}

string[] teststrings = { "Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam." };
int palcount = 0;
foreach (string str in teststrings)
{
    bool learnerResult = IsPalindrome(str);
    if (learnerResult)
        palcount++;
}

Console.WriteLine(palcount);