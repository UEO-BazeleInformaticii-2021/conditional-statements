using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementationWithSwitch();

            Console.WriteLine();
        }

        static void ImplementationWithIf()
        {
            Console.WriteLine("Menu - please type an option:");
            Console.WriteLine("1) File");
            Console.WriteLine("2) Edit");
            Console.WriteLine("3) View");
            Console.Write("Please type your option:");
            string optionLevel1 = Console.ReadLine();
            if (string.Equals(optionLevel1, "File", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Menu - please type an sub-option:");
                Console.WriteLine("1.1) New");
                Console.WriteLine("1.2) Open");
                Console.WriteLine("1.3) Clone");
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
            else if (string.Equals(optionLevel1, "Edit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Menu - please type an sub-option:");
                Console.WriteLine("2.1) Cut");
                Console.WriteLine("2.2) Copy");
                Console.WriteLine("2.3) Paste");
                Console.Write("Please type your option:");
                string optionLevel2 = Console.ReadLine();

                if (string.Equals(optionLevel2, "Cut", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to Cut some text");
                }
                else if (string.Equals(optionLevel2, "Copy", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to Copy some text");
                }
                else if (string.Equals(optionLevel2, "Paste", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to Paste some text");
                }
            }
            else if (string.Equals(optionLevel1, "View", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Menu - please type an sub-option:");
                Console.WriteLine("3.1) Solution Explorer");
                Console.WriteLine("3.2) Git Changes");
                Console.WriteLine("3.3) Cloud Explorer");
                Console.Write("Please type your option:");
                string optionLevel2 = Console.ReadLine();

                if (string.Equals(optionLevel2, "Solution Explorer", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to view 'Solution Explorer' window");
                }
                else if (string.Equals(optionLevel2, "Git Changes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to view 'Git Changes' window");
                }
                else if (string.Equals(optionLevel2, "Cloud Explorer", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You choosed to view 'Cloud Explorer' window");
                }
            }

        }

        static void ImplementationWithSwitch()
        {
            Console.WriteLine("Menu - please type an option:");
            Console.WriteLine("1) File");
            Console.WriteLine("2) Edit");
            Console.WriteLine("3) View");
            Console.Write("Please type your option:");
            string optionLevel1 = Console.ReadLine();

            switch (optionLevel1)
            {
                case "File":
                    Console.WriteLine("Menu - please type an sub-option:");
                    Console.WriteLine("1.1) New");
                    Console.WriteLine("1.2) Open");
                    Console.WriteLine("1.3) Clone");
                    Console.Write("Please type your option:");
                    string optionLevel2For1 = Console.ReadLine();

                    switch (optionLevel2For1)
                    {
                        case "New":
                            Console.Write("You choosed to create a new file");
                            break;

                        case "Open":
                            Console.Write("You choosed to open an existing file");
                            break;

                        case "Clone":
                            Console.Write("You choosed to clone a Github repository");
                            break;
                    }
                    break;

                case "Edit":
                    Console.WriteLine("Menu - please type an sub-option:");
                    Console.WriteLine("2.1) Cut");
                    Console.WriteLine("2.2) Copy");
                    Console.WriteLine("2.3) Paste");
                    Console.Write("Please type your option:");
                    string optionLevel2For2 = Console.ReadLine();

                    switch (optionLevel2For2)
                    {
                        case "Cut":
                            Console.Write("You choosed to Cut some text");
                            break;

                        case "Copy":
                            Console.Write("You choosed to Copy some text");
                            break;

                        case "Paste":
                            Console.Write("You choosed to Paste some text");
                            break;
                    }
                    break;

                case "View":
                    Console.WriteLine("Menu - please type an sub-option:");
                    Console.WriteLine("3.1) Solution Explorer");
                    Console.WriteLine("3.2) Git Changes");
                    Console.WriteLine("3.3) Cloud Explorer");
                    Console.Write("Please type your option:");
                    string optionLevel2For3 = Console.ReadLine();

                    switch (optionLevel2For3)
                    {
                        case "Solution Explorer":
                            Console.Write("You choosed to view 'Solution Explorer' window");
                            break;

                        case "Git Changes":
                            Console.Write("You choosed to view 'Git Changes' window");
                            break;

                        case "Cloud Explorer":
                            Console.Write("You choosed to view 'Cloud Explorer' window");
                            break;
                    }
                    break;
            }
        }
    }
}
