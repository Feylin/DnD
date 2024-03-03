using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLogic
{
    public class Repository : IRepository
    {
        private readonly RNGCryptoServiceProvider _gen;

        public Repository()
        {
            _gen = new RNGCryptoServiceProvider();
        }

        public int Random(int min, int max)
        {
            // switch min and max around
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }
            if (min == max)
                throw new DivideByZeroException("The two parameteres can't be equal to each other");

            byte[] buffer = new byte[sizeof(Int32)];
            //RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            //rand.GetBytes(buffer);
            _gen.GetBytes(buffer);
            int random = BitConverter.ToInt32(buffer, 0);

            return (Math.Abs(random % (max - min)) + min);
        }

        public BE_Race[] Races()
        {
            BE_Race[] races =
            {
                new BE_Race("Dragonborn", "M", 6, null, null, null, null, "Normal"),
                new BE_Race("Dwarf", "M", 5, null, null, null, null, "Low-light"),
                new BE_Race("Eladrin", "M", 6, null, null, null, null, "Low-light"),
                new BE_Race("Elf", "M", 7, null, null, null, null, "Low-light"),
                new BE_Race("Half-Elf", "M", 6, null, null, null, null, "Low-light"),
                new BE_Race("Halfling", "S", 6, null, null, null, null, "Normal"),
                new BE_Race("Human", "M", 6, null, 1, 1, 1, "Normal"),
                new BE_Race("Tiefling", "M", 6, null, null, null, null, "Low-light")
            };

            return races;
        }

        public BE_Class[] Classes()
        {
            BE_Class[] classes =
            {
                new BE_Class("Cleric", null, null, null, 2),
                new BE_Class("Fighter", null, 2, null, null),
                new BE_Class("Paladin", null, 1, 1, 1),
                new BE_Class("Ranger", null, 1, 1, null),
                new BE_Class("Rogue", null, null, 2, null),
                new BE_Class("Warlock", null, null, 1, 1),
                new BE_Class("Warlord", null, 1, null, 1),
                new BE_Class("Wizard", null, null, null, 2)
            };

            return classes;
        }
    }
}
