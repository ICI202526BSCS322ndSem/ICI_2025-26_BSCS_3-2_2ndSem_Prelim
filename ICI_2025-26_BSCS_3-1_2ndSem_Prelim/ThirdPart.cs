using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICI_2025_26_BSCS_3_1_2ndSem_Prelim
{
    internal class ThirdPart
    {
        public class HeroClass()
        {
            public int health = 0;
        }

        public struct MinionStruct()
        {
            public int health = 0;
        }

        public void Build()
        {
            HeroClass myhero = new HeroClass();
            myhero.health = 100;

            MinionStruct myMinion = new MinionStruct();
            myMinion.health = 100;

            Console.WriteLine($"Start: Hero Health = {myhero.health}, Minion Health = {myMinion.health}");

            myhero.health = 100;
            myMinion.health += 100;

            Console.WriteLine($"End:   Hero Health = {myhero.health}, Minion Health = {myMinion.health}");

            Console.Write("Input Damage: ");
            Console.ReadLine();

        }

        private static MinionStruct ApplyDamage(HeroClass myhero, MinionStruct myMinion)
        {
           
            return myMinion;

        }
    }
}
