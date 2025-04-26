using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_OrnekProjeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden doğum yılı girilen bir kişinin yaşını hesaplayarak ekrana yazdıran program kodlarını yazınız.
            //int nowYear = 2025;
            //int newAge;
            //Console.Write("Doğum tarihinizi giriniz: ");
            //newAge = int.Parse(Console.ReadLine());
            //int age;
            //age = nowYear - newAge;
            //Console.WriteLine("Yaşınız: " + age);

            //********************************************************************************************************

            //Klavyeden girilen sayının karesini hesaplayarak sonucu ekrana yazdıran program kodlarını yazınız.
            //int x, kare;
            //Console.Write("Bir sayı giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //kare = x * x;
            //Console.WriteLine("Girdiğiniz sayının karesi: " + kare);

            //********************************************************************************************************

            //Klavyeden girilen 3 sayıyının ortalmasını bulan programı yazınız
            //double x, y, z, ortalama;
            //Console.Write("1.sayıyı giriniz: ");
            //x = double.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //y = double.Parse(Console.ReadLine());
            //Console.Write("3.sayıyı giriniz: ");
            //z = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine();
            //ortalama = (x + y + z) / 3;
            //Console.WriteLine("Girdiğiniz sayıların ortalaması: " + ortalama);

            //********************************************************************************************************

            //İki kenar uzunluğu girilen dikdörtgenin alanını ve çevresini hesaplayarak sonuçları ekrana yazdıran C# konsol uygulamasını yapınız.
            //int kenar1, kenar2, alan, cevre;
            //Console.Write("1.kenarı giriniz: ");
            //kenar1 = int.Parse(Console.ReadLine());
            //Console.Write("2.kenarı giriniz: ");
            //kenar2 = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //alan = kenar1 * kenar2;
            //Console.WriteLine("Alan: " + alan);
            //cevre = (kenar1 + kenar2)*2;
            //Console.WriteLine("Çevre uzunluğu: " + cevre);

            //********************************************************************************************************

            //Klavyeden girilen yarıçap değerine göre bir dairenin alanını ve çevresini hesaplayarak sonucu yazdıran c# konsol uygulamasını yazınız. (pi sayısını sabit tanımlayarak 3 değerini hesaplayınız)
            //int pi, yarıCap, alan, cevre;
            //pi = 3;
            //Console.Write("Yarıçapı giriniz: ");
            //yarıCap = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //alan = pi * (yarıCap * yarıCap);
            //Console.WriteLine("Daire Alanı: " + alan);
            //cevre = (pi * yarıCap) * 2;
            //Console.WriteLine("Dairenin Çevresi: " +  cevre);

            //********************************************************************************************************

            //Dik kenar uzunlukları klavyeden girilen bir üçgenin hipotenüs uzunluğunu bularak sonucu ekrana yazdıran c# konsol uygulamasını yapınız.
            //int a, b, hipotenus;
            //Console.Write("1.kenar uzunluğu: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("2.kenar uzunluğu: ");
            //b = int.Parse(Console.ReadLine());
            //hipotenus = (a*a) + (b*b);
            //Console.WriteLine("Hipotenüs uzunluk: " +  hipotenus);

            //********************************************************************************************************

            //Klavyeden girilen x ve y değerleri için 5x + 3y2 denkleminin sonucunu bularak ekrana yazdıran program kodlarını yazınız.
            //int x, y, denklem;
            //Console.Write("X değerini giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Y değerini giriniz: ");
            //y = int.Parse(Console.ReadLine());
            //denklem = 5 * x + 3*(y * y);
            //Console.WriteLine("Denklem sonucu: " + denklem);

            //********************************************************************************************************

            //Bir ürüne ait girilen alış fiyatı, kdv oranı ve kar oranına göre ürünün satış fiyatını bularak sonucu ekrana yazan program kodlarını yazınız.
            //double alisFiyati, kdvOrani, karOrani, satisFiyati;
            //Console.Write("Alış fiyatını giriniz: ");
            //alisFiyati = double.Parse(Console.ReadLine());
            //Console.Write("KDV Oranını giriniz: ");
            //kdvOrani = double.Parse(Console.ReadLine());
            //Console.Write("Kar oranını giriniz:");
            //karOrani = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //kdvOrani = (alisFiyati*kdvOrani)/ 100;
            //satisFiyati = alisFiyati + kdvOrani + karOrani;
            //Console.WriteLine(satisFiyati);

            //********************************************************************************************************

            //1 den başlayarak klavyeden girilen sayıya kadar olan tüm sayıları toplayarak sonucu yazdıran c# konsol uygulamasını yazınız.  (Birden n e kadar olan sayıların toplamı  1 +2 +3 + ... +n = ( n * (n+1 ) ) / 2 )
            //double n, toplam;
            //Console.Write("Bir sayı giriniz: ");
            //n = double.Parse(Console.ReadLine());
            //toplam = (n * (n + 1)) / 2;
            //Console.WriteLine("Girilen sayıya kadar olan toplam: " + toplam);

            //********************************************************************************************************

            //Vize notlarının ortalamasının %40 ı ve final sınavının %60 ının geçerili olduğu bir sınav sisteminde 2 vize ve 1 final notu girilen bir kişinin başarı notunu bulan c# konsol uygulamasını yazınız.
            //double exam1, exam2, final, agno;
            //Console.Write("1.sınav notu: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2.sınav notu: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Final notu: ");
            //final = double.Parse(Console.ReadLine());
            //agno = ((exam1 + exam2) * 40) / 100 + ((final)*60)/100;
            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız: " + agno);


            //*******************************************************************************************************

            //Klavyeden öğrencinin 2 adet not bilgisi girildikten sonra, ortalama 50 ve üzerinde ise ekrana “Geçti” değilse “Kaldı” yazdıran programın Console uygulamasını yapalım.

            //Console.Write("Lütfen ortalamanızı giriniz: ");
            //int ortalama = int.Parse(Console.ReadLine());
            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("Geçti");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Kaldı");
            //}

            //*******************************************************************************************************

            // Bir mağazada alınan ürünün fiyatı 100 Tl ve üzerinde ise 5 Tl olan kargo ücreti alınmamaktadır. Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren programı yazalım.


            //int urunPrice, kargoPrice, toplamTutar;
            //Console.Write("Lütfen ürün fiyatını giriniz: ");
            //urunPrice = int.Parse(Console.ReadLine());
            //kargoPrice = 5;
            //toplamTutar = urunPrice + kargoPrice;

            //if (urunPrice >= 100)
            //{
            //    Console.WriteLine("Toplam tutar: " + urunPrice);
            //}
            //else
            //{
            //    Console.WriteLine("Toplam tutar: " + toplamTutar);
            //}

            //*******************************************************************************************************

            //Klavyeden girilen sayının negatif, pozitif veya sıfır olduğunu gösteren programın C# kodlarını yazalım.
            //int number;
            //number = 0;
            //Console.Write("Lütfen sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine("Sayı Pozitif.");
            //}
            //if (number == 0)
            //{
            //    Console.WriteLine("SIFIR");
            //}
            //if (number < 0)
            //{
            //    Console.WriteLine("Sayı Negatif.");
            //}


            //Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü (toplama, çıkarma, çarpma, bölme) seçildiğinde, sonucu hesaplayarak ekranda gösteren programı yazalım.

            //Console.Write("1.sayıyı giriniz: ");
            //double sayi1 = double.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //double sayi2 = double.Parse(Console.ReadLine());
            //char ıslem;
            //double result=0;
            //Console.Write("Yapılacak işlemi giriniz:  ");
            //ıslem = char.Parse(Console.ReadLine());

            //if (ıslem == 't' | ıslem == 'T')
            //{
            //    result = sayi1 + sayi2;
            //}
            //if (ıslem == 'ç' | ıslem == 'Ç')
            //{
            //    result = sayi1 - sayi2;
            //}
            //if (ıslem == 'c' | ıslem == 'C')
            //{
            //    result = sayi1 * sayi2;
            //}
            //if (ıslem == 'b' | ıslem == 'B')
            //{
            //    result = sayi1 / sayi2;
            //}

            //Console.Write(result);


            //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise, 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.

            //double urun1, urun2, toplam;
            //Console.Write("1.ürünün fiuatını giriniz: ");
            //urun1 = double.Parse(Console.ReadLine());
            //Console.Write("2.ürünün fiyatını giriniz: ");
            //urun2 = double.Parse(Console.ReadLine());
            //toplam = urun1 + urun2;
            //if (toplam > 200)
            //{
            //    toplam = urun1 + (urun2 * 75) / 100;
            //}
            //if (toplam < 200)
            //{
            //    toplam = urun1 + urun2;
            //}

            //Console.Write("toplam ürün fiyatı: " + toplam);


            //------------------------------------------------------------------------------------------------

            // O ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren programı yapalım.

            //int sayi = 0;
            //int toplam = 0;

            //while (sayi<=100)
            //{
            //    if (sayi % 2 == 1)
            //    {
            //        toplam += sayi;
            //        //Console.WriteLine(sayi);
            //    }
            //    sayi++;
            //}

            //Console.WriteLine("0 ile 100 arasındaki tek sayıların toplamı: " + toplam);

            //------------------------------------------------------------------------------------------------
            




            Console.Read();
        }
    }
}
