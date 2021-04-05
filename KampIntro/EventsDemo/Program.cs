using System;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            hardDisk.ProductName = "Hard Disk";
            
            Product gsm = new Product(50);
            gsm.ProductName = "Telefon";

            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(6);
                gsm.Sell(6);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Telefon bitmeye yakın."); ;
        }
    }
}
