using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> isimler = new Queue<string>(); //queue yapısını bu şekilde oluşturuyoruz

            isimler.Enqueue("Alpercan Eryaşar"); //queue ye eleman eklemek için kullandığımız metot
            isimler.Enqueue("Berk Baypınar");
            isimler.Enqueue("Tamer Özvatan");
            isimler.Enqueue("Emir Açıkgöz");

            try
            {
                string silinenİsim = isimler.Dequeue(); //queue den eleman çıkarmak için kullandığımız metot 
                Console.WriteLine("silinen isim : " + silinenİsim); //ilk giren ilk çıkar o yüzden alpercan eryaşar kuyruktan çıkartılır
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("KUYRUK BOŞ");
                throw;
            }

            if (isimler.Contains("Alpercan Eryaşar")) //isimlerde böyle bir değer var mı diye kontrol eden metot
            {
                Console.WriteLine("MECVUT");
            }
            else
            {
                Console.WriteLine("MEVCUT DEĞİL");
            }

            Console.WriteLine(isimler.Count()); //isimlerde kaç tane eleman olduğunu yazdırır


            string[] tekrarYazdır = isimler.ToArray(); //ToArray sayeseinde kuyruğun bi kopyasını daha oluşturuyoruz
            for (int i = 0; i < tekrarYazdır.Length; i++)
            {
                Console.WriteLine(tekrarYazdır[i]);
            }
            Console.WriteLine(isimler.Count()); //isimlerde kaç tane eleman olduğunu yazdırır
            isimler.Clear(); ///isimlerde bulunan her şeyi siler
            Console.WriteLine(isimler.Count());
           
            Console.ReadKey();
        }
    }
}
