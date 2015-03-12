using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxEleman
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine( "dizinin elamanlarını gir: "     );
            
            int[] dizi =new int[5]; // dizinin tanımlanması
            for (int j = 0; j < dizi.Length;j++ ) // for döngüsüyle elemanları alma
            {
                
                dizi[j]=Convert.ToInt32(Console.ReadLine());
            }
            int sayi = maxElemanBulma(dizi);           

            Console.WriteLine("Dizinin en büyük elemanı: " +sayi);
            Console.ReadLine();

        }

        public static int maxElemanBulma(int[] dizi) { 
           int maxEleman=dizi[0];
           for (int i = 1; i < dizi.Length;i++ ) { //dizinin en büyük elemanını bulma
                if (dizi[i] > maxEleman) {
                    maxEleman = dizi[i];
                }
            }
           return maxEleman;
        }
    }
}
