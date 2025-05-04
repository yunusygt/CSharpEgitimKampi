using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud --> 4 temel veri tabanı işlemidir.
            // create - read - update - delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=YANNIS;initial catalog=EgitimKampiDb;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori Başarıyla Eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi

            string productName;
            decimal productPrice;

            Console.Write("Ürün adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=YANNIS;initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@productPrice",productPrice);
            command.Parameters.AddWithValue("@productStatus",true);
            command.ExecuteNonQuery();
            connection.Close();

            Console.Write("Ürün Başarılı Bir Şekilde Eklendi!");


            #endregion





            Console.Read();
        }
    }
}
