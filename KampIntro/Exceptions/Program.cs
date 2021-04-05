using System;
using System.Threading;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla(2,3));

            //Func<int, int, int> add = Topla;
            //Console.WriteLine(add(3,5));

            FuncKullanimSekilleri();
        }

        private static void FuncKullanimSekilleri()
        {
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(100);

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
            Thread.Sleep(100);

            Random random = new Random();
            Func<int, int, int> getRandomNumber3 = random.Next;
            Console.WriteLine(getRandomNumber3(1, 100));
        }

        static int Topla(int x,int y)
        {
            return x + y;
        }
    }
}
