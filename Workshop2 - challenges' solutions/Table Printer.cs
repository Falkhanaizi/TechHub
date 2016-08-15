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
            // Print multiplication table of any number (till the 10th multiple)

            Console.WriteLine("Enter a number to print table");
            int x;
            x = Convert.ToInt16(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x + " x " + i + " = " + x * i);
            }



            Console.ReadKey();
        }
    }
}
