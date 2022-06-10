using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        //mantığı last in - first out
        //mantığı first in - last out
        static void Main(string[] args)
        {
            Stack<int> sayılar = new Stack<int>();
            //Push = Stack' e veri ekleme

            sayılar.Push(10);
            sayılar.Push(20);
            sayılar.Push(30);
            sayılar.Push(40);
            sayılar.Push(50);
            sayılar.Push(60);

            int[] stackekleme = { 100, 200, 300, 400, 500 }; //push demek yerine bu şekilde de stack içine eleman ekleyebilirz
            Stack<int> sayılar2 = new Stack<int>(stackekleme);

            try
            {
                //Pop =  Stack' den veri silme
                int a =sayılar.Pop();
                Console.WriteLine(a);
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }

            if (sayılar.Contains(30)) //sayılar stackinin içinde 30 var mı diye kontrol ediyor
            {
                Console.WriteLine("evet var");
            }
            else
            {
                Console.WriteLine("hayır yok");
            }

            if (sayılar2.Contains(2000)) //sayılar2 nin içinde 2000 var mı diye kontrol ediyor
            {
                Console.WriteLine("evet var");
            }
            else
            {
                Console.WriteLine("hayır yok");
            }
            Console.WriteLine(sayılar.Peek()); //50 değerini verecek çünkü en üstte o var
            
            

            Console.ReadKey();


        }
    }
}
