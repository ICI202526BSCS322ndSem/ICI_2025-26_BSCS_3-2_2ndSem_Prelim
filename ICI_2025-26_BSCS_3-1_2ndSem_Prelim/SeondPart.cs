using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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

            student Student1 = new student();
            student Student2 = new student();

            Student1.STUDENT_NUMBER = "2023-0899-IC";
            Student1.STUDENT_NAME = "Carl Angelo P. Costanios";
            Student1.COURSE = "BSCS";
            Student1.YEAR_LEVEL = 3;
            Student1.SECTION = 2;
            Student1.FAVORITE_FILIPINO_HERO = "Heneral Luna";

            Console.WriteLine("Student Number: " + Student1.STUDENT_NUMBER);
            Console.WriteLine("Student Name: " + Student1.STUDENT_NAME);
            Console.WriteLine("Course: " + Student1.COURSE);
            Console.WriteLine("Year Level: " + Student1.YEAR_LEVEL);
            Console.WriteLine("Section: " + Student1.SECTION);
            Console.WriteLine("Favorite Filipino Hero: " + Student1.FAVORITE_FILIPINO_HERO);


            Student2 = Student1;

            Student2.STUDENT_NAME = "Vijay P. Costanios";
            Student2.FAVORITE_FILIPINO_HERO = "Lapu-Lapu";

            Console.WriteLine("Student Number: " + Student1.STUDENT_NUMBER);
            Console.WriteLine("Student Name: " + Student1.STUDENT_NAME);
            Console.WriteLine("Course: " + Student1.COURSE);
            Console.WriteLine("Year Level: " + Student1.YEAR_LEVEL);
            Console.WriteLine("Section: " + Student1.SECTION);
            Console.WriteLine("Favorite Filipino Hero: " + Student1.FAVORITE_FILIPINO_HERO);
            Console.WriteLine("Student Number: " + Student2.STUDENT_NUMBER);
            Console.WriteLine("Student Name: " + Student2.STUDENT_NAME);
            Console.WriteLine("Course: " + Student2.COURSE);
            Console.WriteLine("Year Level: " + Student2.YEAR_LEVEL);
            Console.WriteLine("Section: " + Student2.SECTION);
            Console.WriteLine("Favorite Filipino Hero: " + Student2.FAVORITE_FILIPINO_HERO);


        }
        public struct student
        {
            public string STUDENT_NUMBER;
            public string STUDENT_NAME;
            public string COURSE;
            public int YEAR_LEVEL;
            public int SECTION;
            public string FAVORITE_FILIPINO_HERO;
        }
    }
}
