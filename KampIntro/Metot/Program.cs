using System;
using System.Linq;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplanıcak sayıları giriniz : ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            var number2 = Convert.ToInt32(Console.ReadLine());
            Add();
            Console.WriteLine("Toplamın sonucu : "+Add2(number1,number2));

            Console.WriteLine("Değer verilmesse 2+3'ü toplar.Toplamın sonucu : " + Add2());

            number1 = 20;
            number2 = 30;
            var result = Add3(ref number1, number2);
            //ref keywordu için number1 e değer verip yollaman gerekirdi ama onun yerine out keywordu kullansaydın böyle bir zorunluluğumuz olmaz.
            Console.WriteLine(result);
            Console.WriteLine(number1);

            Console.WriteLine("Params keywordüyle toplama:"+Add4(2,5,1,23,42,12));
        }
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int number1=2,int number2=3)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(ref int number1,int number2)
        {
            //ref keywordüyle yolladığımız için number1'i yazdırınca 30 yazdırıyor yoksa 20 yazdırırdı.
            number1 = 30;
            return number1 + number2;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
    
}
