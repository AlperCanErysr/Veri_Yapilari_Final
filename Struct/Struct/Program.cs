using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        public struct kisibilgisi //kisi bilgileri olan bir sınıf gibi düşünebilirz struct yapısını
        {
            public string kisiAdı;
            public string kisiCinsiyeti; //kisinin bilgilerini içerecek 
            public int kisiYaşı;

            public kisibilgisi(string kisiAdı,string kisiCinsiyeti,int kisiYaşı) //burada kisi bilgililerini kodumuzda kullanacağımız şekilde şekillendiriyoruz bu sayede istediğimiz kadar kişi oluşturabiliriz 
            {
                this.kisiAdı = kisiAdı;
                this.kisiCinsiyeti = kisiCinsiyeti;
                this.kisiYaşı = kisiYaşı;
            }
        }
        struct kayit
            {
                public string ad;
                public int vize, final;
                public double ort;
            }
        static void Main(string[] args)
        {
            //class gibi bir şeyleri tanımlamak için kullanıyoruz
            kisibilgisi kisi1 = new kisibilgisi("Alper","Erkek",19); //yukarıda tanımladığımız gibi değerleri atıyoruz
            kisibilgisi kisi2 = new kisibilgisi("Cem","Erkek",14);
            kisibilgisi kisi3 = new kisibilgisi("Elif", "Kız", 25);
            Console.WriteLine(kisi1.kisiAdı);
            Console.WriteLine(kisi2.kisiCinsiyeti);
            Console.WriteLine(kisi3.kisiYaşı);
            Console.WriteLine();
            Console.WriteLine();

            //örnek
            int i;
            kayit ogrenci = new kayit();
            Console.WriteLine("Öğrencinin Adı");
            ogrenci.ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Öğrencinin Vize Notu");
            ogrenci.vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrencinin Final Notu");
            ogrenci.final = Convert.ToInt32(Console.ReadLine());
            ogrenci.ort = ogrenci.vize * 0.6 + ogrenci.final * 0.4;
            Console.WriteLine("Öğrencinin Adı= {0} Öğrencin Not Ortalaması {1}", ogrenci.ad, ogrenci.ort);
            Console.ReadKey();
        }
    }
}
