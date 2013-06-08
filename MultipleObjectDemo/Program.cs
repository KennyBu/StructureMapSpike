using System;

namespace MultipleObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = Ioc.Initialize();
            container.AssertConfigurationIsValid();

            while (true) // Loop indefinitely
            {
                Console.WriteLine("Enter input:");
                var line = Console.ReadLine(); // Get string from user
                if (line == "exit") // Check string
                {
                    break;
                }

                var character = Ioc.CreatePerson(container, line);
                if (character == null)
                {
                    Console.WriteLine("No character was found!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Character found and he says: {0}", character.Gloat());
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
