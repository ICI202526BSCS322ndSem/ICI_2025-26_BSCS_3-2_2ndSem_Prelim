using ICI_2025_26_BSCS_3_1_2ndSem_Prelim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI_2025_26_BSCS_3_1_2ndSem_Prelim
{

    class HeroClass
    {
        public int Health;
    }
    struct MinionStruct
    {
        public int Health;
    }

    class myMinion
    {
        static void Main(string[] args)
        {

            HeroClass hero = new HeroClass();
            hero.Health = 100;

            MinionStruct minion = new MinionStruct();
            minion.Health = 100;

            Console.WriteLine("Hero Health: " + hero.Health);
            Console.WriteLine("Minion Health: " + minion.Health);

            Console.ReadLine();
        }
    }




}

