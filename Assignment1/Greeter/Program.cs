using System;

Console.WriteLine("Enter your Fullname: ");
string FullName = Console.ReadLine();

Console.Write("Enter your Date of Birth (yyyy/MM/dd): ");
string dobInput = Console.ReadLine();

if (DateTime.TryParse(dobInput, out DateTime dob))
{
    string cFullName = FullName.ToUpper();
    Console.WriteLine($"Hello, {cFullName} Ji! Your date of birth is: {dob:MMMM dd, yyyy}");
}
else
{
    Console.WriteLine("Invalid date of birth format. Please enter a valid date in the format yyyy/MM/dd.");
}
