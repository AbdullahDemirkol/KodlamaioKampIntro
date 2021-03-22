using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            Console.WriteLine(sehirler.Count);
            foreach (var item in sehirler.Gonder)
            {
                Console.WriteLine(item);
            }
        }
    }
}
