using System;

namespace TimeAfterXHours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type  'exit'  to quit the program.\n");
            System.Threading.Thread.Sleep(1500);
            Console.Write($"The current date and time is:  {DateTime.Now}\n");
            System.Threading.Thread.Sleep(1000);

            bool invalidAnswer = true;
            while (invalidAnswer)
            {
                Console.Write("Enter a random number of hours: ");
                string answer = Console.ReadLine().ToLower();

                // If the user types exit, the program ends.
                if (answer == "exit") break;
                else
                {
                    try
                    {
                        int hours = Convert.ToInt32(answer);
                        Console.WriteLine(
                            $"\t==================================\n" +
                            $"\t               in\n" +
                            $"\t            {hours} hours\n" +
                            $"\t The exact date and time will be\n" +
                            $"\t       {DateTime.Now.AddHours(hours)}\n" +
                            $"\t     The exact time will be\n" +
                            $"\t        {DateTime.Now.AddHours(hours).TimeOfDay}\n" +
                            $"\t==================================\n");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You need to enter a number...");
                        System.Threading.Thread.Sleep(500);
                    }
                }
            }

            Console.Write("\n\nSee ya later!");
            Console.ReadLine();
        }
    }
}
