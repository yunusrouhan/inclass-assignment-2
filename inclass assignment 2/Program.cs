using System;

namespace inclass_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your years of experience");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                for (int i = 0; i < value_of_input; i++)
                {
                    Console.WriteLine("Your experience is " + i.ToString());

                }
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please enter years of expereicne in integer");
                Console.ReadKey(true);
            }
        }
    }
}