using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //*******************************************************************************************

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Bilgiler Doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Bilgiler hatalı.");
            //}

            //*******************************************************************************************

            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı yanlış.");
            //}

            //*******************************************************************************************

            //double exam1, exam2, exam3, average;

            //Console.Write("1.sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("2.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());            

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınav ortalamanız: " + average);
            //if (average > 0 & average < 45)
            //{
            //    Console.WriteLine(" / Başarısız oldunuz.");
            //}
            //if (45 <= average & average < 55)
            //{
            //    Console.WriteLine(" / Sorumlu ders geçişi.");
            //}
            //if (55 <= average & average < 70)
            //{
            //    Console.WriteLine(" / Ortalama geçiş");
            //}
            //if (70 <= average & average < 85)
            //{
            //    Console.WriteLine(" / İyi");
            //}
            //if (85 <= average & average <= 100)
            //{
            //    Console.WriteLine(" / Pekiyi");
            //}
            //else
            //{
            //    if (average <= 0)
            //    {
            //        Console.WriteLine(" / Sınava Girilmedi.");
            //    }                
            //}

            //*******************************************************************************************

            //string city;
            //Console.Write("Lütfen Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "aydın" | city == "bursa" | city == "istanbul")
            //{
            //    Console.WriteLine("Şehir Mevcut.");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}


            //*******************************************************************************************


            //string userName;
            //Console.Write("Kullanıcı adı giriniz: ");
            //userName = Console.ReadLine();
            //if (userName != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else 
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}

            //*******************************************************************************************


            #endregion

            #region MOD İŞLEMLERİ -- Aritmetik işlemlerde iki sayının bir birine bölümünden kalanı verir.

            //Console.Write("Lütfen sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int result = number % 5;
            //Console.WriteLine("Sayının 5'e bölümünden kalan: " + result);


            //---------------------------------------------------------------------------------------------


            // Sayının tek mi çift mi olma durumu

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları

            //*********************************************************************************

            //char team;
            //string result = "takım mevcut değil.";
            //Console.Write("lütfen takımınızı giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'f' | team == 'f')
            //{
            //    Console.WriteLine("fenerbahçe");
            //}
            //if (team == 'g' | team == 'g')
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //if (team == 'b' | team == 'b')
            //{
            //    Console.WriteLine("beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("hata!");
            //}


            //***********************************************************************************


            #endregion

            #region Örnek proje uygulaması

            //Console.WriteLine("C# yemek menüsüne hoş geldiniz.");
            //Console.WriteLine();
            //Console.WriteLine("********Yemek Menüsü********");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Salatalar");
            //Console.WriteLine("3-Çorbalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("istediğiniz yemek kodunu seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*****Ana Yemekler*****");
            //    Console.WriteLine("1-Köfte");
            //    Console.WriteLine("2-Izgara tavuk");
            //    Console.WriteLine("3-Tavuk pilav");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*****Salatalar*****");
            //    Console.WriteLine("1-Akdeniz");
            //    Console.WriteLine("2-Ton balık");
            //    Console.WriteLine("3-Cevizli");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*****Çorbalar*****");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Kellepaça");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*****Tatlılar*****");
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Güllaç");
            //    Console.WriteLine("3-Kemalpaşa");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*****İçecekler*****");
            //    Console.WriteLine("1-Cola");
            //    Console.WriteLine("2-Sprite");
            //    Console.WriteLine("3-Su");
            //}



            #endregion

            #region Switch Case Karar Yapıları

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber) 
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Giriş Yapıldı."); break;
            //}

            #endregion

            #region Switch Case Karar Yapıları - Örnek Proje Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}

            //*******************************************************************************************

            //Console.Write("bir sayı giriniz: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("1- küp   2-kare    3-kök\n");
            //Console.Write("Seçim:  ");
            //int secim = int.Parse(Console.ReadLine());
            //switch (secim)
            //{
            //    case 1:
            //        int kup = x * x * x;
            //        Console.Write("girilen sayının kübü= " + kup);
            //        break;
            //    case 2:
            //        int kare = x * x;
            //        Console.Write("girilen sayının karesi= " + kare);
            //        break;
            //    case 3:
            //        double kok = Math.Sqrt(x);
            //        Console.Write("girilen sayının kökü= " + kok);
            //        break;
            //    default:
            //        Console.Write("1,2,3 tuşlarından birin basmalısınız!");
            //        break;
            //}

            #endregion


            // Random sayı çıktısı alma *****************************************

            //Random random = new Random();
            //int number = random.Next(20, 50);
            //Console.WriteLine("Rastgele Sayı = " + number);


            //******************************************************************


            #region




            #endregion

            Console.ReadLine();
        }
    }
}
