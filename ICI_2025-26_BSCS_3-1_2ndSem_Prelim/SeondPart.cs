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
    public class Student
    {
        public string StudentNumber;
        public string StudentName;
        public string Course;
        public int YearLevel;
        public int Section;
        public string FavoriteFilipinoHero;
    }
    internal class SeondPart
    {
        public void Build()
        {
            //Console.WriteLine("SECOND PART");

            Student student1 = new Student();
            student1.StudentNumber = "19999-09876";
            student1.StudentName = "veejervs";
            student1.Course = "BSComputer Science";
            student1.YearLevel = 3;
            student1.Section = 1;
            student1.FavoriteFilipinoHero = "Jose Rizal";
            Student1(student1);

            Console.WriteLine("");
            Console.WriteLine("");
            Student student2 = new Student();
            student2 = student1;

            student2.StudentName = "jenarddo";
            student2.FavoriteFilipinoHero = "Bonifacio";
            Student1(student1);
            Student2(student1, student2);
        }

        private static void Student1(Student student1)
        {
            Console.WriteLine("Student 1");
            Console.WriteLine("Name :" + student1.StudentName + ", Student Number :" + student1.StudentNumber);
            Console.WriteLine("Course: " + student1.Course + ", Year Level: " + student1.YearLevel + ", Section: " + student1.Section + ", Favorite Filipino Hero: " + student1.FavoriteFilipinoHero);
        }

        private static void Student2(Student student1, Student student2)
        {
            Console.WriteLine("Student 2");
            Console.WriteLine("Name :" + student2.StudentName + ", Student Number :" + student1.StudentNumber);
            Console.WriteLine("Course: " + student1.Course + ", Year Level: " + student1.YearLevel + ", Section: " + student1.Section + ", Favorite Filipino Hero: " + student2.FavoriteFilipinoHero);
        }
    }
}
