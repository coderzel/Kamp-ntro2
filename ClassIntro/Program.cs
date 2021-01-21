using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Zeliş";
            int yas = 19;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin ";
            kurs1.Izlenmeorani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "zeliş ";
            kurs2.Izlenmeorani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "kaçar ";
            kurs3.Izlenmeorani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen  { get; set; }
        public int Izlenmeorani { get; set; }

    }
}
