using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box<T> where T : IComparable<T>
    {
        List<T> list;
        public int Compare(List<T>listR, T element)
        {
            int count = 0;
            list = listR;
            foreach (var item in list)
            {
                if (item.CompareTo(element)>0)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            foreach (var item in list)
            {
                sb.Append($"{typeof(T)}: {item}\n");
            }
            return sb.ToString();
        }
    }
}
