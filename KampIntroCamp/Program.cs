using System;
using System.ComponentModel;
using System.Security.Claims;

namespace KampIntroCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 320000000;
            //double faizOrani = 1.45;
            //bool sistemeGirisYapmisMi = false;
            //double dolarDun = 3.45;
            //double dolarBugun = 4.25;

            //if(dolarDun>dolarBugun)
            //{
            //    Console.WriteLine("Azalış Butonu");
            //}       
                        
            //else if (dolarBugun>dolarDun)
            //{
            //    Console.WriteLine("Artış Butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Değişmedi Butonu");
            //}




            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("Ayarlar Butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}                        
            
            //Console.WriteLine(kategoriEtiketi);

            Add();
            var result= Add2(20);
            
            Console.WriteLine(result);
            Console.WriteLine(Add3(1,2,4,6,7,7));
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
            
        }
        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}