using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // for(x;y;z)
            // x: Başlangıç değeri
            // y: Bitiş değeri(Koşul)
            // z: Artış - Azalış değeri


            // Ekrana 5 defa C# eğitim kampı yazdırma
            //int i;
            //for (i=1; i<=5;i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}


            // 1'den 20'ye kadar olan sayıları yazdırma
            //for(int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 1'den 50'ye kadar olan sayıları 3er 3 er yazdırma

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            // Başlangıç ve bitiş değerinin kullanıcıdan alınması

            //Console.Write("Başlangıç değerini giriniz: ");
            //int baslangıc = int.Parse(Console.ReadLine());
            //Console.Write("Bitiş değerini giriniz: ");
            //int bitis = int.Parse(Console.ReadLine());

            //for (int i = baslangıc; i <= bitis; i += 5)
            //{
            //    Console.WriteLine(i);
            //}


            // Bitiş değerini bizim belirlediğimiz ve ekrana kaç kere "Yaşasın Cumhuriyet " yazdıracağımızı belirlemek

            //Console.Write("Kaç defa yazdırmak istersiniz: ");
            //int finishValue = int.Parse(Console.ReadLine());
            //int i;
            //for (i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            // 1 ile 100 arasında 5 e tam bölünebien sayıları yazdırma

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //******************************************************************************************************************************


            // 1 ile 100 arasında 5 e ve 3 e tam bölünebilen sayıları yazdırma

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%3==0 & i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //******************************************************************************************************************************


            // 1'den 10'a kadar olan ayıların toplamını bulma

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);


            //******************************************************************************************************************************


            // 1 ve 20 sayıları arasındaki çift sayıların toplamını bulma

            //int toplam = 0;
            //int i;
            //for (i=0; i<20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(toplam);


            //******************************************************************************************************************************



            // 1 ile 50 arasında 7'ye tam bölünebilen sayıları yazdırma

            //int count = 0;
            //int i;
            //for (i = 1; i <= 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count ++;
            //    }
            //}
            //Console.WriteLine(count);

            //******************************************************************************************************************************


            // Bir bakteri türü her saat sonunda kendini 2 ye bölerek çoğalmaktadır.Yeni oluşan bakterilerde aynı şekilde çoğalmaktadır.24 saat sonunda bakteri sayısını hesaplayınız.

            //int bacterium = 1;
            //for (int i = 1; i <=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + " Saat sonunda bakteri sayısı: " + bacterium);
            //}


            //******************************************************************************************************************************



            #endregion

            #region While Döngüsü

            // while(şart)
            // {
            //   İŞLEMLER
            // }
            //------------------------------------------------------------------------------------------------------
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            #endregion

            #region While Döngüsü ile Karar Yapıları

            // 1 ile 10 arasında 3'e tam bölünebilen sayıları bulalım

            //int i = 1;
            //while (i <= 10)
            //{               
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);                    
            //    }
            //    i++;
            //}

            // 1 ile 10 arasındaki sayıların toplamı

            //int i = 1;
            //int toplam = 0;
            //while (i <= 10)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine(toplam);
            #endregion

            #region ÖRNEK PROJE

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);


            #endregion


            Console.Read();
        }
    }
}
