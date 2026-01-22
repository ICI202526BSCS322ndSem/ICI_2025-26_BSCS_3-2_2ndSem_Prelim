using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ICI_2025_26_BSCS_3_1_2ndSem_Prelim
{

    public class Student
    {
        public int Number;
        public string Name;
        public string Course;
        public int YEAR_LEVEL;
        public int Section;
        public string Favorite_Filipino_Hero;
    }
    internal class SeondPart
    {
        public void Build()
        {
            Console.WriteLine("Seond Part");
            Console.WriteLine("");


            Student student1 = new Student();
            student1.Number = 2023;
            student1.Name = "raga, jervee angelo";
            student1.Course = "BSCS";
            student1.YEAR_LEVEL = 3;
            student1.Section = 2;
            student1.Favorite_Filipino_Hero = "Heneral Antonio Luna";

            Console.WriteLine("My student id is " + student1.Number + " and my name is " + student1.Name + " I am currently part of " + student1.Course + student1.YEAR_LEVEL + student1.Section + " And my favorite Filipino hero is " + student1.Favorite_Filipino_Hero);
            Console.WriteLine("");

            Student student2 = new Student();
            student2.Number = 2024;
            student2.Name = "tabudlo, Jenard Phil";
            student2.Course = "BSCS";
            student2.YEAR_LEVEL = 3;
            student2.Section = 2;
            student2.Favorite_Filipino_Hero = "Heneral Antonio Luna";

            Console.WriteLine("My student id is " + student2.Number + " and my name is " + student2.Name + " I am currently part of " + student2.Course + student2.YEAR_LEVEL + student2.Section + " And my favorite Filipino hero is " + student2.Favorite_Filipino_Hero);
            Console.WriteLine("");







        }
    }
}
