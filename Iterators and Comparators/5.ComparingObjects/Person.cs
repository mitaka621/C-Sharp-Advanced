using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Person: IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            if (Name.CompareTo(other.Name) == 0 && Age.CompareTo(other.Age) == 0 && Town.CompareTo(other.Town) == 0)
            {
                return 0;
            }
            else return -1;
        }
    }
}
