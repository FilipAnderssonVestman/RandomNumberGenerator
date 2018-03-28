using System;

namespace RandomNumberGenerator
{
    public class Menu
    {
        public void Start()
        {
            WriteMenu();
        }

        private void WriteMenu()
        {
            while (true)
            {
                Console.Write("Welcome to Random Number Generator\n" +
                    "1: Generate random list of integers\n" +
                    "Exit: Exit\n" +
                    "Choice: ");

                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        Console.Write("Type amount: ");
                        Generator.GenerateIntList(Input.GetInteger());
                        Console.WriteLine("Success");
                        break;
                    case "exit":
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
