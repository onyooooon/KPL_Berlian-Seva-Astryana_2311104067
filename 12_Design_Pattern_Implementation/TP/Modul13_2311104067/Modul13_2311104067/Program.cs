using System.Numerics;
using singleton_dp;

namespace design_pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========Singleton==========");
            Rektor rektor1 = Rektor.GetRektor();
            Rektor rektor2 = Rektor.GetRektor();

            if (rektor1 == rektor2)
            {
                Console.WriteLine("Rektor sama");
            }
            else
            {
                Console.WriteLine("Rektor berbeda");
            }

            rektor1.Tandatangan();

        }
    }
}