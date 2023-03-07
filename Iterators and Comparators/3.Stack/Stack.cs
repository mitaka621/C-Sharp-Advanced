using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNS
{
    public class Stack<T>:IEnumerable<T>
    {
        List<T> stck;
        public Stack()
        {
            stck=new List<T>();
        }
        public void Push(T[] array)
        {
            stck.AddRange(array);
        }
        public void Pop()
        {
            if (!stck.Any())
            {
                Console.WriteLine("No elements");
            }
            else
            {
                stck.RemoveAt(stck.Count - 1);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stck.Count-1;i>=0; i--)
            {
                yield return stck[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }

        
    }
}
