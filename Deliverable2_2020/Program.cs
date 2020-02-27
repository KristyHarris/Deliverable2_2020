using System;

namespace Deliverable2_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine();
            string upperInput = input.ToUpper();
            string message = "";
            int checksum = 0;
            foreach (char c in upperInput)
            {
                int value = (System.Convert.ToInt32(c) - 64);
                message += value.ToString() + "-";
                checksum += (System.Convert.ToInt32(c));
                }
                Console.WriteLine("Your encoded message is " + message);
                Console.WriteLine("Message checksum is " + checksum);
            }
            }
        }
    
