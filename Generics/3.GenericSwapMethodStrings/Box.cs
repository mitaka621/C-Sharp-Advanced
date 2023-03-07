using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box<T>
    {
        List<T> list;
        public void Swap(List<T>listR, int index1, int index2)
        {
            list=listR;
            T temp=list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
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
