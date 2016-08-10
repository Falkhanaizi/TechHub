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
            // program to find the largest between to numbers

            Console.WriteLine("Enter a number");
            int x;
            x = Convert.ToInt16(Console.ReadLine());
            

            if (x == 1)
                Console.WriteLine("The day is Sunday");
            else if (x == 2)
                Console.WriteLine("The day is Monday");
            else if (x == 3)
                Console.WriteLine("The day is Tuesday");
            else if (x == 4)
                Console.WriteLine("The day is Wednesday");
            else if (x == 5)
                Console.WriteLine("The day is Thursday");
            else if (x == 6)
                Console.WriteLine("The day is Friday");
            else if (x == 7)
                Console.WriteLine("The day is Saturday");




            Console.ReadKey();
        }
    }
}
