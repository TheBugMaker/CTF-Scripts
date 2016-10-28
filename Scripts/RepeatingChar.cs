using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
namespace Scripts
{
    class RepeatingChar
    {
        public void Work()
        {
            var code = File.ReadAllText("MorseStegno.txt");

            int i = 1;
            Console.WriteLine(code.Length);
            for (; i < code.Length/2; i++)
            {
                bool repeat = true; 
                for (int j = i; j < code.Length; j+=i)
                {
                    for (int k = j; k < j+i; k++)
                    {
                        if (code[k] != code[j - i])
                        {
                            repeat = false;
                            break; 
                        }
                        if (!repeat) break; 
                    }
                }

                if (repeat)
                {
                    Console.WriteLine("repeats on "+i);
                }
                else
                {
                    Console.WriteLine("no repeats on "+i);
                }
            }
        }
    }
}
