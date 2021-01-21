using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            

            //array-dizi
            // foreach - dizileri tek tek gezmeye yarıyor

            string[] kurslar = new string[] { "Yazılım geliştirici kurs", "Programlamaya başlangıç kursu" , "Java" ,"python","C#"};


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu- footer");
        }  
        
    }
}
