using System;

namespace Deliverable_1
{
    class Program
    {
        private static double fidspin;
        private static double inches;
        private static double feet;
        private static string userInput;

        public static double memes { get; private set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Let's compare Imperial and MilHip! ");
            while (userInput != "yes")
            {
                
                Console.WriteLine("Would you like to convert inches, feet, fidget spinners or memes? ");
                string userInput2 = Console.ReadLine();
              
                if (userInput2 == "inches")
                {
                    Console.WriteLine("How many inches? ");
                    double inc = Convert.ToDouble(Console.ReadLine());
                    fidspin = inc * 3.5;
                    Console.WriteLine("{0} inches equals {1} fidget spinners", inc, fidspin);
                }
                else if (userInput2 == "feet")
                {
                    Console.WriteLine("How many feet? ");

                    double feet = Convert.ToDouble(Console.ReadLine());
                    memes = feet * 5;
                    Console.WriteLine("{0} feet equals {1} memes", feet, memes);
                }
                else if (userInput2 == "fidget spinners")
                {
                    Console.WriteLine("How many fidget spinners? ");

                    double fidspin = Convert.ToDouble(Console.ReadLine());
                    inches = fidspin / 3.5;
                    Console.WriteLine("{0} fidget spinners equals {1} inches", fidspin, inches);
                }
                else if (userInput2 == "memes")
                {
                    Console.WriteLine("How many memes? ");
                    double memes = Convert.ToDouble(Console.ReadLine());
                    feet = memes / 5;
                    Console.WriteLine("{0} memes equals {1} feet", memes, feet);
                }                
                else
                {
                    Console.WriteLine("That's not an option. Please choose inches, feet, fidget spinners or memes. ");
                }
                
                Console.WriteLine("Would you like to convert another unit? (yes/no) ");
                string query = Console.ReadLine();
                if (query == "no")
                {
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
