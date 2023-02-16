using System;
using System.Security.Claims;

namespace KampIntroCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 3.45;
            double dolarBugun = 4.25;

            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }       
                        
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }                        
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}