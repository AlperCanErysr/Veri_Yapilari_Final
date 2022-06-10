using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //liste tanımlama ve eleman ekleme
            List<string> isimler = new List<string>();
            isimler.Add("Alper");
            isimler.Add("Can");
            isimler.Add("Eryasar");
            List<int> sayılar = new List<int>();
            sayılar.Add(10);
            sayılar.Add(20);
            sayılar.Add(30);
            sayılar.Add(40);

            Console.WriteLine(isimler.Count()); //isimler listesinin içinde kaç tane eleman olduğunu yazdırır
            Console.WriteLine(sayılar.Count()); //sayılar listesinin içinde kaç tane eleman olduğunu yazdırır

            foreach (var isimoku in isimler) //listenin içindeki elemanları yazdırır
            {
                Console.WriteLine(isimoku);
            }

            foreach (var sayıoku in sayılar) //listenin içindeki elemanları yazdırır
            {
                Console.WriteLine(sayıoku);
            }

            isimler.Remove("Alper"); //isimler listesinde bulunan Alper'i listeden siler
            sayılar.Remove(10); //sayılar listesinde bulunan 10'u listeden siler

            isimler.RemoveAt(1); //isimler listesinde index numarası 1 olan elemanı siler
            sayılar.RemoveAt(0); //sayılar listesinde index numarası 0 olan elemanı siler yani ilk elemanını

            if (isimler.Contains("Can")) //isimler listesinde Can var mı diye kontrol eder
            {
                Console.WriteLine("Can isimler listesinin içinde mevcut");
            }
            else
            {
                Console.WriteLine("Can isimler listesinin içinde mevcut değil");
            }

            if (sayılar.Contains(40)) //sayılar listesinde 40 var mı diye kontrol eder
            {
                Console.WriteLine("40 sayısı sayılar listesinin içinde mevcut");
            }
            else
            {
                Console.WriteLine("40 sayısı sayılar listesinin içinde mevcut değil");
            }
            foreach (var isimoku in isimler) 
            {
                Console.WriteLine(isimoku);
            }

            foreach (var sayıoku in sayılar) 
            {
                Console.WriteLine(sayıoku);
            }

            int isimIndexbul = isimler.BinarySearch("Can"); //listemizdeki Can'ın index numarasını verecek 
            Console.WriteLine(isimIndexbul); //0 değerini verecek demek ki listemizin ilk elemanı Can, diğer verileri sildik sadece can kaldı

            int sayıIndexbul = sayılar.BinarySearch(40); //listemizdeki 40'ın index numarasını verecek
            Console.WriteLine(sayıIndexbul); //1 değerini verecek demek ki listemizin ikinci elemanı 40mış , diğer verileri sildik sadece 30 ve 40 kaldı
            Console.WriteLine("--------------------------------------------------------------------------");
            isimler.Clear(); //isimler listesinin elemanlarını siler
            sayılar.Clear(); //sayılar listesinin elemanlarını siler
            foreach (var isimoku in isimler)
            {
                Console.WriteLine(isimoku);
            }

            foreach (var sayıoku in sayılar)
            {
                Console.WriteLine(sayıoku);
            }
            Console.WriteLine("--------------------------------------------------------------------------");


            Console.ReadKey();
        }
    }
}
