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
            // Print sum of number from 1 to 10

            
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                \\ or sum += i;
                sum = sum + i;
            }
            Console.WriteLine("The sum of numbers from 1 to 10 is : " + sum);


            Console.ReadKey();
        }
    }
}
