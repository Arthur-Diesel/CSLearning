using System;
using Defining;

Book firstBook = new Book("Código Limpo", "Rick C Martin", 360);
Console.WriteLine(firstBook.GetDescription());
firstBook.Borrow();
// firstBook.Borrow();
firstBook.Return();
Console.WriteLine(firstBook.ToString());