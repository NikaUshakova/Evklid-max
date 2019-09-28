using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElement
{
    class MaxElem
    {
        public static int Max(int[] arr, int n)
        { 
            
            if (arr.Length > n)
            {
                int max = Max(arr, n + 1);
                if (arr[n] > max) return arr[n];
                else return max;
            }
            else
            {
                return arr[0];

            }
        }
    }
}
