using System;

namespace SSiterasyon
{
    internal class Program
    {
        public static void ssHesabı(double[] dizi) {
            double adet = 0, toplam = 0, arit = 0,kToplam=0, ss = 0, varyans=0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = toplam + dizi[i];
                adet++;
            }
            arit = toplam / adet;
            //aritmatik ortalama bulundu
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = dizi[i] - arit;
            }
            //her veriden a.o. çıkarıldı
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = dizi[i] * dizi[i];
                kToplam = kToplam + dizi[i];
            }
            //verilerin kareleri alındı
            varyans = kToplam / (adet - 1);
            ss = Math.Sqrt(varyans);
            Console.WriteLine("Mean Değeri = " + arit);
            Console.WriteLine("Varyans Değeri = " + varyans);
            Console.WriteLine("Standart Sapma Değeri = " + ss);


        }
        public static double[] elemanalma(double[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write((i+1)+". Sayıyı Giriniz : ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            return dizi;
        }
        static void Main(string[] args)
        {
            int dEleman=0;
            //eleman sayısı ile kaç veri olduğunu alıyoruz buda dizinin boyutunu belirliyor
            Console.Write("Lütfen Eleman Sayısı Giriniz : ");
            dEleman = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double[] dizi=new double[dEleman];
            elemanalma(dizi);
            Console.WriteLine();
            ssHesabı(dizi);
        }
    }
}
