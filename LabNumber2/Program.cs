using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userChoice;
            int userNumber;
            bool Continue = true;

            Console.WriteLine("Hi! What's your name?");
            userName = Console.ReadLine();

            while (Continue == true)
            {

                Console.WriteLine(userName + " " + "please enter a number between 1 and 100");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber % 2 == 1)
                {
                    Console.WriteLine("Odd" + " " + userNumber);
                }
                else
                { 
                    if (userNumber <= 25)

                        Console.WriteLine("Even and less than 25");

                    else if (userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (userNumber > 60)
                    {
                        Console.WriteLine("Even" + " " + userNumber);
                    }
                }

                Console.WriteLine("Do you want to run the code again?");
                userChoice = Console.ReadLine();

                if (userChoice == "N" || userChoice == "No" || userChoice == "NO" || userChoice == "no")
                {
                    Continue = false;
                }
            }
        }
    }
}