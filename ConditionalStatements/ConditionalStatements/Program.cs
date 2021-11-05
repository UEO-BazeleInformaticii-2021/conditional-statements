using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu - please type an option:");
            Console.WriteLine("1) File");
            Console.WriteLine("1) Edit");
            Console.WriteLine("1) View");
            Console.Write("Please type your option:");
            string optionLevel1 = Console.ReadLine();
            if (string.Equals(optionLevel1, "File", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Menu - please type an sub-option:");
                Console.WriteLine("1) New");
                Console.WriteLine("1) Open");
                Console.WriteLine("1) Clone");
                Console.Write("Please type your option:");
                string optionLevel2 = Console.ReadLine();
                if (string.Equals(optionLevel2, "New", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to create a new file");
                }
                else if (string.Equals(optionLevel2, "Open", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to open an existing file");
                }
                else if (string.Equals(optionLevel2, "Clone", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to clone a Github repository");
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
