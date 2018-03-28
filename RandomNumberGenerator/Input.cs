using System;

namespace RandomNumberGenerator
{
    public class Input
    {
        public static int GetInteger()
        {
            var success = false;
            int number;

            do
            {
                success = int.TryParse(Console.ReadLine(), out number);
            } while (!success);

            return number;
        }
    }
}
