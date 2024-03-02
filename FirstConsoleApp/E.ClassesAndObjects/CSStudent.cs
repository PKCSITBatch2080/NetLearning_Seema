using System;
//single inheritance
// Corrected Code
class CSStudent : Student, IGradeable  //Multiple Inheritance
{
    public CSStudent(string name, byte rn, string pTitle) : base(name, rn)
    {
        ProjectTitle = pTitle;
    }

    public string ProjectTitle { get; set; }
    public string InterWork { get; set; }

    public double GetGrade() => 3;
}

