using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ICI_2025_26_BSCS_3_1_2ndSem_Prelim.SeondPart;
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

    internal class SeondPart
    {
        public void Build()
        {
            Console.WriteLine("SECOND PART");

            
                Student student1 = new Student();
                Student student2 = new Student();
                Student student3 = new Student();


                student1.StudentNumber = "2023-1396-IC";
                student1.Name = "Jhonlloyd";
                student1.Course = "BSCS";
                student1.Year = 3;
                student1.Section = 2;
                student1.FavoriteFilipinoHero = "Jose Rizal";



                student2.StudentNumber = "2024-1245-IC";
                student2.Name = "Nhess";
                student2.Course = "BSCS";
                student2.Year = 3;
                student2.Section = 2;
                student2.FavoriteFilipinoHero = "Andres";

                Console.WriteLine("student1 Name: " + student1.Name);
                
                Console.WriteLine("student1 FavoriteFilipinoHero: " + student1.FavoriteFilipinoHero);
                


                student2.Name = "Nhess";
                student2.FavoriteFilipinoHero = "Andres";

                Console.WriteLine("student1 Name: " + student1.Name);
                Console.WriteLine("student2.Name: " + student2.Name);
                Console.WriteLine("student2.FavoriteFilipinoHero: " + student2.FavoriteFilipinoHero);

                Console.ReadKey();
            
        }
        public struct Student
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
    
