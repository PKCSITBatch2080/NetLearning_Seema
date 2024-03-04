﻿using System;

Console.WriteLine(3687426);

DataTypes dt = new();
dt.Learn();

Methods m = new();
m.Greet("Hi");
m.CalculateBMI(233.3f, 343.34f);

var highest = m.GetMax(3.4, 5.6, 78.4, 23.4);
var highest2 = m.GetMax(3.4, 5.6);
var highest3 = m.GetMax(3.4, 5.6, 78.4, 23.4, 67.8);
var highest4 = m.GetMax(3.4);

Generics g = new();
g.Display<string>("abcdef");
g.Display<int>(786);

Student Semika = new Student();
Student Seema = new Student("Seema Poudel", 123);

Semika.RollNumber = 22;      // Assined
Seema.RollNumber = 223;    // Not Assigned

var rekha = new CSStudent ("Seema Poudel" , 23 ,"Hospital Managment System");
rekha.DisplayInfo();

var seema = new CyberSecurityStudent("seema poudel", 12, "HMS", "REDHAT");
seema.DisplayInfo();


