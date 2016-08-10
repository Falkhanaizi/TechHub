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
            // Write a program that adds or subtracts two number depending on input ("+" = addition, "-" = subtraction)

            Console.WriteLine("Enter operator");
            char x;
            x = Convert.ToChar(Console.ReadLine());
            int y, z,result;
            y = Convert.ToInt16(Console.ReadLine());
            z= Convert.ToInt16(Console.ReadLine());


            if (x == '+')
            {
                result = y + z;
                Console.WriteLine("Sum is : " +result);

            }

            else if (x == '-')
            {
                result = y - z;
                Console.WriteLine("Subtraction is : " + result);

            }

            Console.ReadKey();
        }
    }
}
