using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Java Kursu";
            string kurs3 = "Pyhton Kursu ";

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Java Kursu", "Pyhton Kursu ","C++" ,"C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)   //foreach dizi temelli yapıları tek tek dönmeye yarıyor. 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer ");
        }
    }
}
