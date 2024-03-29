﻿using System;

namespace ClassIntro
{
    using System;

    namespace ClassIntro
    {
        class Program
        {
            static void Main(string[] args)
            {
                Kurs kurs1 = new Kurs();
                kurs1.KursAdi = "C#";
                kurs1.Egitmen = "Engin Demiroğ";
                kurs1.IzlenmeOrani = 68;

                Kurs kurs2 = new Kurs();
                kurs2.KursAdi = "Java";
                kurs2.Egitmen = "Abdullah Demirkol";
                kurs2.IzlenmeOrani = 64;

                Kurs kurs3 = new Kurs();
                kurs3.KursAdi = "Python";
                kurs3.Egitmen = "Ecem Sarıca";
                kurs3.IzlenmeOrani = 80;

                Kurs kurs4 = new Kurs();
                kurs4.KursAdi = "C++";
                kurs4.Egitmen = "Murat Kurtboğan";
                kurs4.IzlenmeOrani = 100;


                Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

                foreach (var kurs in kurslar)
                {
                    Console.WriteLine("Kurs Adı: "+kurs.KursAdi);
                    Console.WriteLine("Kurs Eğitmeni: " + kurs.KursEgitmeni);
                    Console.WriteLine("İzlenme Oranı: " + kurs.IzlenmeOrani);
                    Console.WriteLine("-----------------------------------");
                }
            }
        }
    }
}
