using System;

namespace UnitOneDeliverableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string input;
            string message="";
            int checksum=0;

            //get user input
            Console.Write("What is your message? ");
            input = Console.ReadLine();
            //convert input to all caps
            input = input.ToUpper();
           
            //iterate through each letter  of string convert to UTF/Ascii and add to proper variable
            for (int c = 0;c<input.Length; c++)
            {           
             
                checksum += (int)input[c];
                if (c < input.Length - 1)
                {
                    message += ((int)input[c] - 64) + "-";
                }else
                {
                    message += (int)input[c] - 64;
                }
            }
            //outputs
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);

        }
    }
}