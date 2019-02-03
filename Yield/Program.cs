using System;
using System.Collections;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Power(2, 8))
            {
                Console.WriteLine("a={0}  ", i.ToString());
            }

            Console.ReadLine();

        }


        public static IEnumerable Power(int number, int exponent)
        {
            int counter = 0;
            int result = 1;

            while (counter++ < exponent)
            {
                result = result * number;
                yield return result;
            }
        }

    }

}
