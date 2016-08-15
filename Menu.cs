using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a variable to hold the selected option value
            int option;
            //start do while loop
            do
            {
                //print the menu
                Console.WriteLine("Please select one option:");
                Console.WriteLine("1: Say my name");
                Console.WriteLine("2: Say my age");
                Console.WriteLine("3: Add to numbers together");
                Console.WriteLine("4: Exit");
                //store the option value 
                option = Convert.ToInt32(Console.ReadLine());

                //start a switch 
                switch (option)
                {
                    //case 1 ask the user for his/her name and print it
                    case 1:
                        Console.WriteLine("Please write your name...");
                        //store the name in a string variable
                        string name = Console.ReadLine();
                        Console.WriteLine("Your name is: " + name);
                        Console.WriteLine("*******************************");
                        break;

                    //case 2 ask the user for his/her age and print it
                    case 2:
                        Console.WriteLine("Please write your age...");
                        //store the age in a string variable
                        string age = Console.ReadLine();
                        Console.WriteLine("Your age is: " + age);
                        Console.WriteLine("*******************************");
                        break;
                    
                    //case 3 ask the user to enter 2 numbers and print the sum
                    case 3:
                        Console.WriteLine("Please write number 1..");
                        //store number 1 in an integer variable
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please write number 2..");
                        //store number 2 in an integer variable
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The sum of two number is: " + (num1+num2));
                        Console.WriteLine("*******************************");
                        break;

                    //case 4 exit the application
                    case 4:
                        Console.WriteLine("Exit the app....");
                        break;
                    
                    //show the user error message if they enter wrong option number
                    default:
                        Console.WriteLine("Choose an option from the menu.. Try again!");
                        Console.WriteLine("*******************************");
                        break;
                }
            }
            while (option != 4);
        }
    }
}