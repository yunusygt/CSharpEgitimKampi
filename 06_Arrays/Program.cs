using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Temel Dizi Örnekleri

            //Aynı türden birden fazla veri tipini bir arada tutmak için kullanılır.
            //çift sayılar dizisi -->  2,4,6,8,......
            //renk dizisi  -->  mavi,sarı,yeşil,.....
            //şehir dizisi  -->  Aydın,İzmir,Ankara,....

            // DEğişkenTürü [] DiziAdi = new DeğişkenTürü[Eleman Sayısı]
            //----------------------------------------------------------------------

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "beyaz";
            //colors[2] = "sarı";
            //colors[3] = "lacivert";
            //Console.WriteLine(colors[2]);

            //------------------------------------------------

            //string[] cities = new string[5];
            //cities[0] = "Budapeşte";
            //cities[1] = "Roma";
            //cities[2] = "Kahire";
            //cities[3] = "Üsküp";
            //cities[4] = "Lyon";
            //Console.WriteLine(cities[4]);

            //--------------------------------------------------

            //int[] numbers = new int[10];
            //numbers[0] = 8;
            //numbers[1] = 456;
            //numbers[2] = 748;
            //numbers[3] = 54;
            //numbers[7] = 18;
            ////Console.WriteLine(numbers[7]);
            //Console.WriteLine(numbers[8]);
            ////Tam sayı formatındaki bir dizinin index değerini atamazsak o index değerinin çıktısı default olarak 0 (sıfır) çıkar.

            //----------------------------------------------------------------------------------

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Mavi", "Yeşil", "Sarı", "Turuncu", "Pembe", "Mor", "Lila" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //------------------------------------------------------------

            // Dizideki elamnların 3'e tam bölünebilenleri bulma.

            //int[] numbers = { 4, 85, 75, 99, 522, 1190, 2237, 3783 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //-------------------------------------------------------------------------

            //char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //------------------------------------------------------------------------------------------

            //Dizideki en büyük elemanı bulma.

            //int[] myArray = { 17, 33, 37, 45, 15, 67, 27, 98, 378, 110, 911, 1112, 1573, 104, 158 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i<myArray.Length;i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //------------------------------------------------------------------------------------------























            #endregion

            #region Dizi Metodları


            // index numarasını bulma
            //string[] customers = { "Eren", "Büşra", "Çınar", "Ahmet", "Kerem", "Işıl" };
            //int index = Array.IndexOf(customers, "Kerem");
            //Console.WriteLine(index);

            // Dizideki maksimum ve minmum sayıyı bulma

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            ////int maxNumber = numbers.Max();
            ////int minNumber = numbers.Min();
            //Console.WriteLine("Dizinin en büyük değeri: " + numbers.Max() + " ---- Dizinin en küçük değeri: " + numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine("----------------------------");

            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            #endregion

            #region Tam sayı dizisi oluşturup dizinin eleman sayılarının toplamını yapma

            //int[] numbers = {10,20,30,40,50};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Sayıların tek ve çift olarak yazdırılması

            //int[] numbers = { 21, 42, 33, 54,55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Array.Sort(numbers);
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Array.Sort(numbers);
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion


            Console.Read();








        }
    }
}
