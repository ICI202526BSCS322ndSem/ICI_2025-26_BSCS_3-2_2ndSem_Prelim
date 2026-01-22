using System;
using System.Collections.Generic;
using System.Linq;
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

            //Put your code here
            Student student1 = new Student();
            Student student2 = new Student();

            student2 = student1;

            student1.StudentNumber = "2023 - 0689";
            student1.Name = "Jerico";
            student1.Course = "Computer Science";
            student1.Year = 3;
            student1.Section = 2;
            student1.FavoriteFilipinoHero = "Luna";
            Console.WriteLine("Student 1");
            Console.WriteLine("Student Number: "+ student1.StudentNumber);
            Console.WriteLine("Name:" + student1.Name);
            Console.WriteLine("Course:" + student1.Course);
            Console.WriteLine("Year: " + student1.Year);
            Console.WriteLine("Section: " + student1.Section);
            Console.WriteLine("Favorite Filipino Hero: " + student1.FavoriteFilipinoHero);
            Console.WriteLine();
            student2.Name = "Guimban";
            student2.FavoriteFilipinoHero = "Rizal";
            Console.WriteLine("Student 1");
            Console.WriteLine("Student Number: " + student1.StudentNumber);
            Console.WriteLine("Name:" + student1.Name);
            Console.WriteLine("Course:" + student1.Course);
            Console.WriteLine("Year: " + student1.Year);
            Console.WriteLine("Section: " + student1.Section);
            Console.WriteLine("Favorite Filipino Hero: " + student1.FavoriteFilipinoHero);
            Console.WriteLine();
            Console.WriteLine("Student 2");
            Console.WriteLine("Student Number: " + student2.StudentNumber);
            Console.WriteLine("Name:" + student2.Name);
            Console.WriteLine("Course:" + student2.Course);
            Console.WriteLine("Year: " + student2.Year);
            Console.WriteLine("Section: " + student2.Section);
            Console.WriteLine("Favorite Filipino Hero: " + student2.FavoriteFilipinoHero);

        }
        public class Student
        {
            public string StudentNumber;
            public string Name;
            public string Course;
            public int Year;
            public int Section;
            public string FavoriteFilipinoHero;


        }
    }
}
