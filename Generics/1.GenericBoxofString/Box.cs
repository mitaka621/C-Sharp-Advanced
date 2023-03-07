using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box<T>
    {
        public Box(T storage)
        {
            this.storage = storage;
        }
       public T storage { get; set; }
        public override string ToString()
        {
            return $"{storage.GetType()}: {storage}";
        }
    }
}
