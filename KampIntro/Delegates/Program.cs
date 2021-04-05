using System;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //DelegatesizYazilim(customerManager);
            //ParametresizDelegate(customerManager);
            //ParametreAlanDelegate(customerManager, myDelegate);
            //ParametreDondurenDelegate();

        }

        private static void DelegatesizYazilim(CustomerManager customerManager)
        {
            customerManager.SendMessage();
            customerManager.ShowAlert();
        }

        private static void ParametresizDelegate(CustomerManager customerManager)
        {
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            myDelegate();
        }

        private static void ParametreAlanDelegate(CustomerManager customerManager, MyDelegate myDelegate)
        {
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2("Hello Delegate");
            myDelegate();
        }

        private static void ParametreDondurenDelegate()
        {
            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            var sonuc = myDelegate3(3, 5);
            Console.WriteLine("Toplam=" + sonuc);
            myDelegate3 += matematik.Carp;
            sonuc = myDelegate3(3, 5);
            Console.WriteLine("Çarpım=" + sonuc);
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Carefull!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
