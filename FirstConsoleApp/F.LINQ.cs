//LINQ - Language INtegrated Query

//Method Syntax = .Where, .Select
using System.Linq;
using System.Security.Cryptography.X509Certificates;
class LINQLearner
{

    void Learn()
    {
        
        int[] numbers = [3, 4, 5, 6 , 7, 8, 9, 10, 33];
        List<string> names = ["Seema" , "John", "David" , "Rita"] ;

        var s1 = new Student( "Seema", 1 , new DateTime(2002, 03, 20) );
        var s2 = new Student( "bita", 12 , new DateTime(2003, 03, 20) );
        var s3= new Student( "simran", 13 , new DateTime(2004, 03, 20) );
        var s4 = new Student( "bital", 14 , new DateTime(2005, 03, 20) );
        var s5= new Student( "sad", 15 , new DateTime(2006, 03, 20) );
        List<Student> students = [s1, s2, s3, s4, s5];

        //Get odd numbers from "numbers"

        var oddNumbers = numbers.Where( number => number % 2 == 1); //Lambda expression [works as filter]

        //Get squares of all items in "number"
        var squares = numbers.Select( x => x * x );//works as map

        //get squares of even numbers only
        var squaresOfEven= numbers.Where( number => number % 2 == 0).Select( x => x * x );


        //Query Syntax 
        var evenSquares = from x in numbers
                        where x % 2 == 0     
                        select x * x; 

        
        //Get all name initials

        var initialName = names.Select( name => name[0]);


        //Order names in ascending order

        var ascendingOrderOfName = names.OrderBy( x => x);

        //remove duplicacy
        var duplicacyRemove = names.Distinct();

        //Find students with name starting with "b"
        var bStudent = students.Where(student =>student.name.ToLower().StartsWith('b'));

        //Group the students with there dob
        var DOB = students. GroupBy( student => student.dob.Month);

        //Get youngest Student

        var Youngest = students.OrderByDescending(x => x.dob).First();
        Youngest = students.MaxBy(x => x.dob);

 
    }
}