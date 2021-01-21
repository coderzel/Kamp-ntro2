using System;

namespace Kampİntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kedndini tekrarlama
            // Değer tutucu, alias
            // int - sayı
            // double - ondalıklı sayı


            string kategoriEtiketi = "Kategoriler";
            int ogrenciSyisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }

            Console.WriteLine(kategoriEtiketi);


        }


    }
}
