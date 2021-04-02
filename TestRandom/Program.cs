using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRandom
{
    using static Rand;
    static public class Rand
    {
        static Random rnd = new Random();
        public static int RandomInt(int a, int b)
        {
            return rnd.Next(a, b);
        }

        public static char RandomChar()
        {
            return (char)rnd.Next(0x0061, 0x007A);
        }

        public static string RandomString(int length = 6)
        {
            string name = "";
            for (int i = 0; i < length; i++)
            {
                name = name + RandomChar();
            }
            return name;
        }

        public static bool RandomBool()
        {
            int res = rnd.Next(0, 2);
            if (res == 1)
            {
                return true;
            }
            return false;
        }

        public static double RandomSign()
        {
            switch (RandomBool())
            {
                case true:
                    return 1;
                case false:
                    return -1;
                default:
                    return 1;
            }
        }

        public static double RandomDouble(int a, int b, double h = 0.01d)
        {
            return rnd.NextDouble() * (b - a) + a;
        }
           
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i =0; i< 10; i++)
            {
                Console.WriteLine("{0}: [{1}]",i, RandomDouble(-1,1));
            }
        }
    }
}
