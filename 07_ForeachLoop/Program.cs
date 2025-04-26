using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //foreach(1;2;3;4)

            // 1 --> Değişken Türü
            // 2 --> Değişken Adı
            // 3 --> In (içerisinde-içinde)
            // 4 --> Liste, Koleksiyon, Dizi Adları

            //string[] cities = { "milano", "bükreş", "kiev", "ankara", "istanbul" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            // dizideki çif sayıların bulunması

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            // Dizideki sayıların toplamı

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);



            // listelerle çalışma

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            // buradan çıkaracağımız foreach döngüsü sadece dizilerle çalışmaz bunun yanında liste elemanları ile de çalışır. Liste elemanları bir koleksiyon öğesi olarak bizi karşılar.

            // Bir kelimeyiş harflerine ayıran program

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            //***********************************************************************************************************************************************************

            #region Sınav sistemi uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrencilerin sayısını kullanıcıdan alma

            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler.

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double vlaue = double.Parse(Console.ReadLine());
                    totalExamResult += vlaue;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            // Öğrencilerin sınav ortalamalrı

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin not ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin geçip kalma durumlarını yapma

                if (studentExamAvg[i] <= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
            }




























            #endregion

            //***********************************************************************************************************************************************************

            Console.Read();

        }
    }
}
