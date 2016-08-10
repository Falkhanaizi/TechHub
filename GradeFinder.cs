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
            // Write a program to print grade of a student (input needed) (100-90: A, 89-80: B, 79-70: C, 69-60: D, 59-:F)

            Console.WriteLine("Enter your marks");
            int x;
            x = Convert.ToInt16(Console.ReadLine());
            

            if (x >= 90 && x<=100)
                Console.WriteLine("Grade is : A");
            else if (x >= 80 && x <= 89)
                Console.WriteLine("Grade is : B");
            else if (x >= 70 && x <= 79)
                Console.WriteLine("Grade is : C");
            else if (x >= 60 && x <= 69)
                Console.WriteLine("Grade is : D");
            else if (x >= 0 && x <= 59)
                Console.WriteLine("Grade is : F  :( ");

            Console.ReadKey();
        }
    }
}
