using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print numbers from 1 to n (n is the input)

            Console.WriteLine("Enter a number to print until");
            int x;
            x = Convert.ToInt16(Console.ReadLine());
            

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }
            


            Console.ReadKey();
        }
    }
}
