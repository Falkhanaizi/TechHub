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
            // program to find the largest between two numbers

            Console.WriteLine("Enter two numbers");
            int x, y;
            x = Convert.ToInt16(Console.ReadLine());
            y = Convert.ToInt16(Console.ReadLine());

            if (x > y)
                Console.WriteLine("The largest value is : " + x);
            else
                Console.WriteLine("The largest value is : " + y);

            Console.ReadKey();
        }
    }
}
