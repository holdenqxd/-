using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int min = array.Min();

            int Average = (int)array.Average();

            int max = array.Max();
          
            int sum = array.Sum();

            
            Console.WriteLine(min);

            Console.WriteLine(Average);

            Console.WriteLine(max);
            
            Console.WriteLine(sum);

         

            


            
        }
    }
}
