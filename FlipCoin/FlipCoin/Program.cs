using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's flip a coin 10000 times");
            Coinflip();
        }

        private static int Coinflip()
        {
            Random Rand = new Random();
            int heads = 0;
            int tails = 0;
            int lastResult = 0;
            int numOfTriples = 0;
            int currenStreak = 0;
            int result = 0;


            for (int i = 0; i < 10000; i++)
            {
                result = Rand.Next(0, 2);

                if (result == 1)
                {
                    lastResult = result;
                    heads++;
                }
                else
                {
                    lastResult = 0;
                    tails++;
                }

                if (lastResult == result)
                {
                    currenStreak++;

                    if (currenStreak == 3)
                    {
                        numOfTriples++;
                        currenStreak = 0;
                    }
                    else
                    {
                        currenStreak = 0;
                    }
                }
            }
            Console.WriteLine("heads was flipped {0} times", heads);
            Console.WriteLine("tails was flipped {0} times", tails);
            return result;
        }
    }
}
