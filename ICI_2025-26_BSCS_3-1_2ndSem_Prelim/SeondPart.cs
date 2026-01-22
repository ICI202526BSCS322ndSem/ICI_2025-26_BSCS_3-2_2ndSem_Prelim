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

            Student student = new Student();
            string student.StudentNumber = "2025-12345";
            string student.StudentName = "Juan Dela Cruz";
            string student.Course = "BSCS";
            int student.YearLevel = 3;
            string student.Section = 1;
            string student.FavoriteFilipinoHero = "Jose Rizal";
            Console.WriteLine("Student 1 Details:");
            Console.WriteLine($"Student Number: {student.StudentNumber}");
            Console.WriteLine($"Student Name: {student.StudentName}");
            Console.WriteLine($"Course: {student.Course}");
            Console.WriteLine($"Year Level: {student.YearLevel}");
            Console.WriteLine($"Section: {student.Section}");
            Console.WriteLine($"Favorite Filipino Hero: {student.FavoriteFilipinoHero}");
            Console.WriteLine();
            
            Student student2 = student;
  
        }
    }
}
