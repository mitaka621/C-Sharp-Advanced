using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake:IEnumerable<int>
    {
        List<int> odd;
        Stack<int> even;
       
        public Lake()
        {
            odd=new List<int>();
            even=new Stack<int>();
        }
        public void Add(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {

            
                if (i % 2 != 0)
                {
                   even.Push(num[i]);
                  
                }
                else
                {
                    odd.Add(num[i]);
                }
            }
            
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in odd)
            {
                yield return item;
            }
            while(even.Count>0)
            { 
                yield return even.Pop();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
