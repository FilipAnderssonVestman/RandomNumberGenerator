using System;
using System.Collections.Generic;
using System.IO;

namespace RandomNumberGenerator
{
    public class Generator
    {
        private static Random _random = new Random();

        public static void GenerateIntList(int amount)
        {
            var numberList = new List<int>();

            for (int i = 0; i < amount; i++)
                numberList.Add(_random.Next(10000));

            using (TextWriter tw = new StreamWriter("RandomIntegers" + amount + ".txt"))
                tw.Write(string.Join(",", numberList));
        }
    }
}
