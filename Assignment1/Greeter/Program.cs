using System;

Console.WriteLine("Enter your Fullname: ");
string FullName = Console.ReadLine();

Console.Write("Enter your Date of Birth (yyyy/MM/dd): ");
string dobInput = Console.ReadLine();
DateTime dob;

if (DateTime.TryParse(dobInput, out dob))
{
    int years = DateTime.Now.Year - dob.Year;
    int months = DateTime.Now.Month - dob.Month;
    int days = DateTime.Now.Day - dob.Day;

    if (days < 0)
    {
        months--;
        days += DateTime.DaysInMonth(dob.Year, dob.Month);
    }

    if (months < 0)
    {
        years--;
        months += 12;
    }

    int weeks = days / 7;
    days -= weeks * 7;

    Console.WriteLine($"Hello, {FullName.ToUpper()} Ji!");
    Console.WriteLine($"Your DOB: {dob:dddd, dd MMMM yyyy}");
    Console.WriteLine($"Age as of now: {years} Years {months} Months {weeks} Weeks {days} Days");
}
else
{
    Console.WriteLine("Invalid date of birth format. Please enter a valid date in the format yyyy/MM/dd.");
}