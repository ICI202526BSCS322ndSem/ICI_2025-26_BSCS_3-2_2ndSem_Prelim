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

    //cretae your class here


    internal class SeondPart
    {
        public void Build()
        {
            Student student1 = new Student();
            Student student2 = new Student();

            student1.StudentNumber = "2026-1482";
            student1.StudentName = "Margarette Calixtro";
            student1.Course = "BSCS";
            student1.Yearlevel = 3;
            student1.Section = 2;
            student1.FavoriteFiipinoHero = "Dr. Jose Rizal";

            student2 = student1;

            Console.WriteLine("Student1 Name: " + student1.StudentName);
            Console.WriteLine("Student2 Name: " + student2.StudentName);

            student2.StudentName = "Karen Diaz";

            Console.WriteLine("Student1 Name: " + student1.StudentName);
            Console.WriteLine("Student2 Name: " + student2.StudentName);


            Console.ReadKey();
        }
   
    }
           public struct Student
        {
            public string StudentNumber;
            public string StudentName;
            public string Course;
            public int Yearlevel;
            public int Section;
            public string FavoriteFiipinoHero;

        }
    
}
