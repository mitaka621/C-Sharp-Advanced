using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class ListyIterator<T>: IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
