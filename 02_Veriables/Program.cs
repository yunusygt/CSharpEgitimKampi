using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);            

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double tomatoPrice;
            //double pepperPrice;
            //double carrotPrice;
            //double orangePrice;
            //double strawberryPrice;

            //tomatoPrice = 17.85;
            //pepperPrice = 14.37;
            //carrotPrice = 15.99;
            //orangePrice = 19.03;
            //strawberryPrice = 18.59;

            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("---- Biber Birim Fiyatı: " + pepperPrice + " TL");
            //Console.WriteLine("---- Havuç Birim Fiyatı: " + carrotPrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");

            //double tomatoGram, pepperGram, carrotGram, orangeGram, strawberryGram;

            //tomatoGram = 1.245;
            //pepperGram = 2.659;
            //carrotGram = 2.437;
            //orangeGram = 0.750;
            //strawberryGram = 3.745;

            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double pepperTotalPrice = pepperGram * pepperPrice;
            //double carrotTotalPrice = carrotGram * carrotPrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fiyat:" + tomatoPrice + " -Gramaj: " + tomatoGram + " -Toplam Tutar: " + tomatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Biber -" + "Birim Fiyat:" + pepperPrice + " -Gramaj: " + pepperGram + " -Toplam Tutar: " + pepperTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Havuç -" + "Birim Fiyat:" + carrotPrice + " -Gramaj: " + carrotGram + " -Toplam Tutar: " + carrotTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fiyat:" + orangePrice + " -Gramaj: " + orangeGram + " -Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek -" + "Birim Fiyat:" + strawberryPrice + " -Gramaj: " + strawberryGram + " -Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine() ;
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine();
            //double shoppingtotalPrice = tomatoTotalPrice + pepperTotalPrice + carrotTotalPrice + orangeTotalPrice + strawberryTotalPrice;
            //Console.WriteLine("Toplam Ödenecek Tutar: " + shoppingtotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //çift tırnak ile gösterilir.
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler


            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;


            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("ID Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");

            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("İlçe/Şehir: " + passengerDistrict + " / " + passengerCity);
            //Console.WriteLine("Yaş: " + passengerAge);
            //Console.WriteLine("TC NO: " + passengerIdentityNumber);


            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int tablePrice, chairPrice, computerPrice, tvPrice;

            //tablePrice = 3000;
            //chairPrice = 1500;
            //computerPrice = 7500;
            //tvPrice = 4500;

            //int tableCount, chairCount, computerCount, tvCount;

            //Console.Write("Lütfen masa sayısını giriniz: ");
            //tableCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen sandelye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = tablePrice*tableCount + chairPrice*chairCount + computerPrice*computerCount + tvPrice*tvCount;

            //Console.Write("Toplam ödenecek tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, resault;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //resault = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + resault);


            #endregion

            #region Klavyeden Char Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyetinizi Giriniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz: " + gender);

            #endregion




            Console.Read();
        }
    }
}
