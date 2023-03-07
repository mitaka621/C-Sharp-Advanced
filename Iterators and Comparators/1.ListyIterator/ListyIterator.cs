using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIteratorNS
{
    public class ListyIterator<T>
    {
        List<T> list;
        int index = 0;
        public ListyIterator(List<T> list)
        {
            this.list = list;
        }
        public bool Move()
        {
            if (index<list.Count-1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (!list.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            Console.WriteLine(list[index]);
        }

        public bool HasNext()
        {
            return index < list.Count-1;
        }
    }
}
