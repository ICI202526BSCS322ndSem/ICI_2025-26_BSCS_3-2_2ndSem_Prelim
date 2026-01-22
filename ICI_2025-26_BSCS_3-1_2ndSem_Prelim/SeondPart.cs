using System;
using System.Collections.Generic;
using System.Linq;
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

            student1.studnum = "6769";
            student1.studname = "Ace";
            student1.course = "BSCS";
            student1.yearlevel = 2026;
            student1.section = 3-2;
            student1.favefilipinohero = "Jose Rizal";
            Console.WriteLine(student1.studnum);
            Console.WriteLine(student1.studname);
            Console.WriteLine(student1.course);
            Console.WriteLine(student1.yearlevel);
            Console.WriteLine(student1.section);
            Console.WriteLine(student1.favefilipinohero);
            Console.WriteLine("  ");

            student2 = student1;

            student2.studname = "Goku";
            student2.favefilipinohero = "Lapu Lapu";
            Console.WriteLine(student2.studnum);
            Console.WriteLine(student2.studname);
            Console.WriteLine(student2.course);
            Console.WriteLine(student2.yearlevel);
            Console.WriteLine(student2.section);
            Console.WriteLine(student2.favefilipinohero);

        }

        public class Student()
        {
            public string studnum;
            public string studname;
            public string course;
            public int yearlevel;
            public int section;
            public string favefilipinohero;

        }

    }
}
