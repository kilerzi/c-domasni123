using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
      static void Main()
            {
            //ova e comandata za queue
                Queue<int> numberQueue = new Queue<int>();
                string userInput;
            //pravi se dodeka playerot kje stavi Y 
                do
                {
                //pisi brojte
                    Console.Write("Enter a number: ");
                    int number;
                //ako ne e brojce
                    while (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.Write("Invalid input. Please enter a valid number: ");
                    }
                    //da go stava ako e number vo nizata
                    numberQueue.Enqueue(number);
                //dali sakas nov number da enternes 
                    Console.Write("Do you want to enter another number? (Y/N): ");
                    userInput = Console.ReadLine().Trim().ToUpper();

                } while (userInput == "Y");
                 //
                Console.WriteLine("\nNumbers in the order you entered:");

                foreach (int num in numberQueue)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }

