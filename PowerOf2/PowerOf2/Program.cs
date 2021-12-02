using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 8;

            Program p = new Program();
            bool flag = false;
            flag = p.isPowerOf2(num);

            if (flag == true)
            {
                Console.WriteLine("{0} is a number that is the power of 2.", num);
            }
            else
            {
                Console.WriteLine("{0} is not the power of 2.", num);
            }
        }
        Boolean isPowerOf2(int number)
        {
            while (number != 1)
            {
                if (number % 2 != 0)
                    return false;
                number = number / 2;
            }
            return true;
        }
    }
}
