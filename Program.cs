using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            int pw = 0;

            //requesting user input
            Console.WriteLine("Enter a five digit password: ");

            //printing user input as a string
            var input = Console.ReadLine();
            //making user input string a int
            //declaring a boolean expression for true/false for user to input numbers only
            bool successfulConversion = int.TryParse(input, out pw);

            //checking length of password
            if (pw.ToString().Length > 5) 
            {
                //if WriteLine message prints/print in red
                //display this error message if user input length is greater than 5
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a five digit number only");
                Console.ReadLine();
            }
            else if (!successfulConversion)
            {
                //if WriteLine message prints/print in red
                Console.ForegroundColor = ConsoleColor.Red;
                //display this message if input was something other than numbers
                Console.WriteLine("Please enter numbers only");
                Console.ReadLine();
            }

            if (pw.ToString().Length < 5)
            {
                //if WriteLine message prints/print in red
                Console.ForegroundColor = ConsoleColor.Red;
                //display this message if user input length is less than 5 numbers
                Console.WriteLine("Enter a five digit number only");
                Console.ReadLine();
            }
            else
            {
                //if WriteLine message prints/print in green
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                //if the user enters all numbers and the it is only 5 digits display this message
                Console.WriteLine("Access Granted");
                Console.ReadLine();

            }




                

            
        }

    }
}

