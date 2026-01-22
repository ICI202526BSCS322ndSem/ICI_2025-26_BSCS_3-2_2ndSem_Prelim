using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ICI_2025_26_BSCS_3_1_2ndSem_Prelim.SeondPart;

namespace ICI_2025_26_BSCS_3_1_2ndSem_Prelim
{
    /*
    CREATE A STUDENT CLASS WITH THE FOLLOWING PROPERTIES

    STUDENT NUMBER (STRING)
    STUDENT NAME (STRING)
    COURSE (STRING)
    YEAR LEVEL (INTEGER)
    SECTION (INTEGER)
    FAVORITE FILIPINO HERO (STRING)


    create an instance of Student and name it student1;
    assign values to each property of student1;
    print the values of each property to the console in a readable format.

    create another instance of Student and name it student2;
    assign student1 to student2;
    change the Student Name and Favorite Filipino Hero properties of student2 to different values;
    
    print the values of each property of student1 to the console again to observe any changes.
    print the values of each property of student2 to the console to see the updated values.
    
    */

    internal class SeondPart
    {
        public void Build()
        {
            Console.WriteLine("SECOND PART");

            //Put your code here
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            student1.StudentNumber = "0723";
            student1.StudentName = "Carl";
            student1.Course = "Bscs";
            student1.YearLevel = 3;
            student1.Section = 2;
            student1.FavoriteFilipinoHero = "Rizal";

            student2 = student1;

            Console.WriteLine("Student 1 Details: " + student1.StudentNumber);
            Console.WriteLine("Student 1 Details: " + student1.Course);
            Console.WriteLine("Student 1 Details: " + student1.StudentName);
            Console.WriteLine("");

            student2.StudentNumber = "0724";
            student2.StudentName = "Nieva";
            student2.Course = "Bscs";

            Console.WriteLine("Student 2 Details: " + student2.StudentNumber);
            Console.WriteLine("Student 2 Details: " + student2.Course);
            Console.WriteLine("Student 2 Details: " + student2.StudentName);
            Console.WriteLine("");

            Console.WriteLine("Student 1 Details: " + student1.StudentNumber);
            Console.WriteLine("Student 1 Details: " + student2.StudentNumber);
        }
        public class Student
        {
            public string StudentNumber ;
            public string StudentName;
            public string Course;
            public int YearLevel;
            public int Section;
            public string FavoriteFilipinoHero;
        }
    }
}
