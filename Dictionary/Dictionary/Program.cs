using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int, string> hatlar = new Dictionary<int, string>(); //kütüphane oluşturmak için...

            hatlar.Add(1,"KM-35"); //kütüphaneye eleman eklemek için 
            hatlar.Add(2,"16-U");
            hatlar.Add(3,"17-S");

            string value = ""; 
            hatlar.TryGetValue(3,out value); //kütüphanenin 3.elemanını çağırmak için 
            Console.WriteLine(value);

            Console.WriteLine(hatlar[2]); //kütüphanenin 2.elemanını çağırmak için 
            hatlar[2] = hatlar[2] + "UĞURMUMCU-ÜSKÜDAR OTOBÜSÜ"; //bu şekilde üstüne ekleme yapılabilir
            Console.WriteLine(hatlar[2]);

            if (!hatlar.ContainsKey(4)) //eğer 4  nolu bir hat yoksa
            {
                hatlar.Add(4,"E-10"); //bu şekilde eklebiliriz
            }
            Console.WriteLine("yeni hattın adı : {0} " + hatlar[4]);

            bool varMı=hatlar.ContainsKey(5); //hatlarda 5 nolu otobüs var mı diye kontrol ediyor (true-false)
            Console.WriteLine(varMı);
            bool varMı2 =hatlar.ContainsValue("KM-35");
            Console.WriteLine(varMı2);

            int toplamHat = hatlar.Count(); //kaç tane hat olduğunu yazdırır
            Console.WriteLine(toplamHat);

            bool sil = hatlar.Remove(4); //4 nolu hattı siler

            foreach (var item in hatlar)
            {
                Console.WriteLine(item); //4 nolu hat yok çünkü sildik
            }
            Console.ReadKey();

        }
    }
}
