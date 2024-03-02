using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is an online book store.\n");

        //  instance of Book
        Book generalBook = new Book("DotNet", 20.0m, 10.0m);
        Console.WriteLine($"Book Name: {generalBook.Title}");
        Console.WriteLine(generalBook.DisplayInfo());
        Console.WriteLine($"Discounted Price: ${generalBook.ApplyDiscount(generalBook.OriginalPrice)}");
        Console.WriteLine($"Category: {generalBook.GetBookCategory()}\n");

        //  instance of SpecialEditionBook
        SpecialEditionBook specialBook = new SpecialEditionBook("DotNetCore", 30.0m, 15.0m);
        Console.WriteLine($"Book Name: {specialBook.Title}");
        Console.WriteLine(specialBook.DisplayInfo());
        Console.WriteLine($"Discounted Price: ${specialBook.ApplyDiscount(specialBook.OriginalPrice)}");
        Console.WriteLine($"Category: {specialBook.GetBookCategory()}");
    }
}
