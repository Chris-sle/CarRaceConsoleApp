using System.Reflection.Metadata.Ecma335;

namespace CarRaceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Press 1 for warmup " +
                                  "\nPress 2 to start race");
                string input = Console.ReadLine();

                if (input == "1") new WarmUp().TestDrive();
                else if (input == "2") new Race().StartRace();
                else if (input != "1" && input != "2") continue;

                Console.WriteLine("Press 1 to continue, anything else to end app");
                if (Console.ReadLine() != "1") break;
            }
        }
    }
}
