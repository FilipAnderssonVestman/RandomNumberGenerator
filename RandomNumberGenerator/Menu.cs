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
                Console.WriteLine("Welcome to Random Number Generator\n" +
                    "1: Generate random list of integers");

                switch (Console.ReadLine())
                {
                    case "1":
                        var num = Input.GetInteger();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
