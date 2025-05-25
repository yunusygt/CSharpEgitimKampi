using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar
            // () - Bir yapının metot olup olmadığını açılır kapanır parantezin olduğundan anlarız.
            // void methods
            //Geriye değer döndürmeyen metotlar - void metotlar diye adlandırılır
            // customer --> listeler,ekle,sil,güncelle
            // Void

            //void customerList()
            //{
            //    Console.WriteLine("Yunus Yiğit");
            //    Console.WriteLine("Kenan Yiğit");
            //    Console.WriteLine("Nuray Yiğit");
            //}
            //customerList();

            // Alt alta bir kaç defa çıktı almak istersek yazdırılmasını istediğimiz değerin alt altra bir kaç defa daha çıktısının almasına neden olur. bunun faydası tekrardan kurtarmaya yarar.
            //customerList();
            //customerList();


            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();
            #endregion

            #region Geriye değer döndürmeyen STRİNG parametreli metotlar

            //void WriteMthod(string customerName)
            //{
            //    Console.WriteLine(customerName); 
            //}
            //WriteMthod("Yunus Yiğit");

            //void customerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //customerCard("Yunus","Yiğit");
            //customerCard("Kenan","Çınar");

            // istediğim kadar müşteri çağırabilirim.

            #endregion

            #region Geriye değer döndürmeyen INT parametreli metotlar

            // kullanıcıdan alınan 3 tane sayının toplamı

            //void sum(int number1, int number2, int number3)
            //{

            //    Console.Write("1.sayıyı giriniz: ");
            //    number1 = int.Parse(Console.ReadLine());
            //    Console.Write("2.sayıyı giriniz: ");
            //    number2 = int.Parse(Console.ReadLine());
            //    Console.Write("3.sayıyı giriniz: ");
            //    number3 = int.Parse(Console.ReadLine());



            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(0, 0, 0);


            #endregion

            #region Geriye değer döndüren metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}
            //customerName();

            //string studentCard()
            //{
            //    string name = "Yunus";
            //    string surName = "Yiğit";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye değer döndüren STRİNG parametreli metotlar

            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke adı: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //// Bir değişkeni sadece bir yerde kullanabiliriz.

            //string x, y, z;

            //Console.Write("Ülke: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengi: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));
            //Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));


            // Burada Kullanıcıdan alınan bilgileri kullanıcıya tekrardan mesaj yollamak için kullanabiliriz.Örneğin "Merhaba Yunus Yiğit C# eiğitim kampını tamamlamak için devam edinmiz" tarzında kullanıcı online olurken gösterebiliriz.

            #endregion

            #region#region Geriye değer döndüren INT parametreli metotlar

            //int Sum(int number1,int number2)
            //{
            //    int toplam = number1 + number2;
            //    return toplam;
            //}
            //Console.WriteLine(Sum(55,40));
            //Console.WriteLine(Sum(47,7));
            //Console.WriteLine(Sum(13,19));
            //Console.WriteLine(Sum(15,23));
            //Console.WriteLine(Sum(91,56));            

            #endregion

            #region ÖRNEK UYGULAMA

            //string examResult(string studentName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return studentName + " Sınavı Geçti." + " Ortalaması: " + result;
            //    }
            //    else
            //    {
            //        return studentName + " Başarısız Oldu." + " Ortalaması: " + result;
            //    }
            //}
            //string k;
            //int x, y, z;
            //Console.Write("Öğrenci Adı: ");
            //k = Console.ReadLine();
            //Console.Write("1.sınav notu: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("2.sınav notu: ");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("3.sınav notu: ");
            //z = int.Parse(Console.ReadLine());

            //Console.WriteLine(examResult(k,x,y,z));

            //Console.WriteLine(examResult("Ali",100,80,60));
            //Console.WriteLine(examResult("Gamze",50,30,40));


            //----------------------------------------------------------------------------------------


            //double dikdortgenAlanı(double kisa, double uzun)
            // {
            //     double alan = kisa * uzun;
            //     return alan;
            // }

            // double x, y;

            // Console.Write("1.sayıyı giriniz: ");
            // x = double.Parse(Console.ReadLine());
            // Console.Write("2.sayıyı giriniz: ");
            // y = double.Parse(Console.ReadLine());
            // Console.WriteLine($"Dikdörtgenin alanı: {dikdortgenAlanı(x, y)}");


            //int TekMiCiftMi(int sayi)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine($"{sayi} sayısı: Çift");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{sayi} sayısı: Tek");
            //    }
            //    return sayi;
            //}

            //int x;
            //Console.Write("Bir sayı giriniz: ");
            //x = int.Parse( Console.ReadLine() );

            //TekMiCiftMi(x);

            #endregion




            Console.Read();
        }
    }
}
