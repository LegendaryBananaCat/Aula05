using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Counts to 10 twice
        /// </summary>
        /// <return></return>
        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(i);
                CountToN(10);
            }
        }

        /// <summary>
        /// Counts from 1 to Max
        /// </summary>
        /// <param name="n"> Nº MAX to of count </param>
        /// <return> Int count from 1 to n </return>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }

        /// <summary>
        /// Calls fuctions.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i < 3; i++)
            {
                CountToN(8);
                CountToN(2);
                CountToN(2,4);
                CountTo10();
            }
        }

        /// <summary>
        /// Shows nº between n1 & n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>

        static void CountToN(int n1, int n2)
        {
            for (int i = 1; i <= n1; i++)
                Console.WriteLine(i);

            for (int j = 1; j <= n2; j++)
                Console.WriteLine(j);
        }

        
    }
}
