using System;

namespace TravisCITest
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var n = 0xFFF0;
            Console.WriteLine(n);
            var weight = SkolkoBitSensei(ref n);
            Console.WriteLine(n);

            Console.WriteLine(weight);
            //Console.WriteLine("Hello World!");
        }

        private static int SkolkoBit(int n)
        {
            var result = 0;
            var one = 1;
            for (int i = 0; i < sizeof(int) * 8; i++)
            {
                if ((n & (one << i)) > 0)
                {
                    result++;
                }
            }
            return result;
        }
        private static int SkolkoBitSensei(ref int n)
        {
            var t = n;
            var result = 0;
            while (t > 0)
            {
                result += (t & 1);
                t >>= 1;
            }
            return result;
        }
    }

}
