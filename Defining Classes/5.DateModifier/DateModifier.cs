using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateM
{
    public class DateModifier
    {
        double diff;
        public DateModifier()
        {
            diff = -1;

        }


        public void CalcDiff(string date1, string date2)
        {
            int[] arr1 = date1.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = date2.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            DateTime dt1 = new DateTime(arr1[0], arr1[1], arr1[2]);
            DateTime dt2 = new DateTime(arr2[0], arr2[1], arr2[2]);
            diff= (dt1 - dt2).TotalDays;
        }

        public override string ToString()
        {
            return Math.Abs(diff).ToString();
        }

    }
}
