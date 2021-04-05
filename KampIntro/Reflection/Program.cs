using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(8,14);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(15, 21));
            
            
            var type = typeof(DortIslem);
            
            
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,13,8);
            //Console.WriteLine(dortIslem.Topla(6,7)); 
            //Console.WriteLine(dortIslem.Topla2());


            //var instance=Activator.CreateInstance(type,15,46);
            //MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            //Console.WriteLine(methodInfo.Invoke(instance, null));


            var methods = type.GetMethods();
            Console.WriteLine("Method İsimleri:");
            foreach (var item in methods)
            {
                Console.Write(item.Name+" Parametreleri : ");
                foreach (var parameter in item.GetParameters())
                {
                    Console.Write(parameter.Name + " ");
                }
                Console.Write(" , Attribute : ");
                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.Write(attribute.GetType().Name + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class DortIslem
    {
        int _sayi1;

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        int _sayi2;
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
