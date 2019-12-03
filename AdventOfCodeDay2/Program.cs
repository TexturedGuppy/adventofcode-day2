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
            List<int> opcodes = new List<int>();
            int currentPosInList = 0;
            int temporaryPosInList = 0;
            int positionToChange;

            using (var reader = new StreamReader(file))
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                for (int i = 0;  i < values.Length; i++)
                {
                    opcodes.Add(Convert.ToInt32(values[i]));
                }
            }

            foreach(int i in opcodes)
            {

            }

            foreach (int i in opcodes)
            {
                Console.WriteLine(i);
            }
        }
        public int OpCodeCalculation(int addOrMult, int val1, int val2)
        {
            if (addOrMult == 1)
            {
                return val1 + val2;
            }
            else if (addOrMult == 2)
            {
                return val1 * val2;
            }

            else
                throw new System.InvalidOperationException("Opcode sequence possibly broken, can only accept 1, 2, or 99");
        }
    }

}

