using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


    internal class SecondPart
    {
        public void Build()
        {
            Student student1 = new Student();
            Student student2 = new Student();


            student1.number = "2023-0735-IC";
            student1.name = "Kevin Delacruz";
            student1.course = "BSCS ";
            student1.section = 2;
            student1.yearLevel = 3;
            student1.Hero = "Juan Luna";


            student2 = Print(student1);


            //Put your code here
        }

        private static Student Print(Student student1)
        {
            Student student2;
            Console.WriteLine(student1.number);
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.course);
            Console.WriteLine(student1.section);
            Console.WriteLine(student1.yearLevel);
            Console.WriteLine(student1.Hero);

            Console.WriteLine(" ");
            student2 = student1;

            student2.name = "Eugene";
            student2.Hero = "Lapu-Lapu";

            Console.WriteLine(student2.number);
            Console.WriteLine(student2.name);
            Console.WriteLine(student2.course);
            Console.WriteLine(student2.section);
            Console.WriteLine(student2.yearLevel);
            Console.WriteLine(student2.Hero);
            return student2;
        }

        public class Student
        {
            public string number;
            public string name;
            public string course;
            public int section;
            public int yearLevel;
            public string Hero;
        }

    }
}
