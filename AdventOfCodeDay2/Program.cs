using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCodeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "input.txt";
            List<string> opcodes = new List<string>();

            using (var reader = new StreamReader(file))
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                for (int i = 0;  i < values.Length; i++)
                {
                    opcodes.Add(values[i]);
                }
            }

            foreach (string i in opcodes)
            {
                Console.WriteLine(i);
            }
        }
    }
}

