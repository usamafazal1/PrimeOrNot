using System;

namespace QuestionNo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            // take input and store it in variable called 'number'
            Console.WriteLine("Input your number to check if it is prime or not: ");
            int number = Convert.ToInt32(Console.ReadLine());

     

            //test for positive number
            int a = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number%i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine();
                Console.WriteLine("{0} is a prime number", number);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Not a prime");
            }
        }
    }
}
