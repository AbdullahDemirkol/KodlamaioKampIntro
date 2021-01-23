using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKredi = new IhtiyacKrediManager();
            //ihtiyacKredi.Hesapla();

            //TasitKrediManager tasitKredi = new TasitKrediManager();
            //tasitKredi.Hesapla();

            //KonutKrediManager konutKredi = new KonutKrediManager();
            //konutKredi.Hesapla();

            IKrediManager ihtiyacKredi = new IhtiyacKrediManager();
            IKrediManager tasitKredi = new TasitKrediManager();
            IKrediManager konutKredi = new KonutKrediManager();
            IKrediManager esnafKredisi= new EsnafKredisiManager();

            ILoggerService dataTableLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { dataTableLoggerService, fileLoggerService, smsLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            Console.WriteLine("Almak İstediğiniz Kredi Türünü Seçiniz:");
            Console.WriteLine("1-Ihtiyaç Kredisi");
            Console.WriteLine("2-Taşıt Kredisi");
            Console.WriteLine("3-Konut Kredisi");
            Console.WriteLine("4-Esnaf Kredisi");

            int a =Convert.ToInt16(Console.ReadLine());
            if (a == 1)
            {
                basvuruManager.BasvuruYap(ihtiyacKredi, loggers);
            }
            else if (a == 2)
            {
                basvuruManager.BasvuruYap(tasitKredi, loggers);
            }
            else if (a == 3)
            {
                basvuruManager.BasvuruYap(konutKredi,loggers);
            }
            else if (a == 4)
            {
                basvuruManager.BasvuruYap(esnafKredisi, loggers);
            }

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKredi ,tasitKredi,konutKredi,esnafKredisi};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadLine();
        }
    }
}
