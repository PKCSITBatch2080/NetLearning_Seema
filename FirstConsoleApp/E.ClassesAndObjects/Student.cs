using System;

class Student
{
    // Default Constructor
    public Student()
    {

    }

    // Parameterized constructor
    public Student(string n, byte rn)
    {
        name = n;
        RollNumber = rn;
    }
    public Student(string n, byte rn, DateTime Dob)
    {
        name = n;
        RollNumber = rn;
        dob = Dob;
    }

    public string name;
    public byte rollNumber;
    public byte RollNumber
    {
        get
        {
            return rollNumber;
        }
        set
        {
            if (value <= 100)
            {
                rollNumber = value;
            }
        }
    }

    public string Address {get; set; }      //Auto implemented property
    public DateTime dob;


    public virtual void DisplayInfo() 
    {
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Student Roll Number: {rollNumber}");
        Console.WriteLine($"Student Dob: {dob}");
        Console.WriteLine($"Student Address: {Address}");
    }
}