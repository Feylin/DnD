using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BE_Race
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int? Speed { get; set; }
        public int? Ac { get; set; }
        public int? Fort { get; set; }
        public int? Reflex { get; set; }
        public int? Will { get; set; }
        public string Senses { get; set; }

        public BE_Race(string name, string size, int? speed, int? ac, int? fort, int? reflex, int? will, string senses)
        {
            Name = name;
            Size = size;
            Speed = speed;
            Ac = ac;
            Fort = fort;
            Reflex = reflex;
            Will = will;
            Senses = senses;
        }

        public override bool Equals(object o)
        {
            if (ReferenceEquals(this, o)) return true;
            if (o.GetType() != typeof(BE_Race)) return false;

            var other = o as BE_Race;

            return other != null && (other.Name == Name
                                     && other.Size == Size
                                     && other.Speed == Speed
                                     && other.Ac == Ac
                                     && other.Fort == Fort
                                     && other.Reflex == Reflex
                                     && other.Will == Will
                                     && other.Senses == Senses);
        }

        public override int GetHashCode()
        {
            int hash = 4;

            hash = 19 * hash +
                   (string.IsNullOrWhiteSpace(Name) ? 0 : Name.GetHashCode());
            hash = 18 * hash +
                   (string.IsNullOrWhiteSpace(Size) ? 0 : Size.GetHashCode());
            hash = 17 * hash +
                   (null == Speed ? 0 : Speed.GetHashCode());
            hash = 16 * hash +
                   (null == Ac ? 0 : Ac.GetHashCode());
            hash = 15 * hash +
                   (null == Fort ? 0 : Fort.GetHashCode());
            hash = 14 * hash +
                   (null == Reflex ? 0 : Reflex.GetHashCode());
            hash = 13 * hash +
                   (null == Will ? 0 : Will.GetHashCode());
            hash = 12 * hash +
                   (string.IsNullOrWhiteSpace(Senses) ? 0 : Senses.GetHashCode());

            return hash;
        }

        public int CompareTo(object o)
        {
            if (o is BE_Race)
                return Name.CompareTo((o as BE_Race).Name);

            throw new ArgumentException("Object is not a Race");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
