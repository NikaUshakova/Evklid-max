using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skoka elementov?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int [n];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(3, 33);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nMAX ELEMENT = "+MaxElem.Max(array, 0));



        }
    }
}
