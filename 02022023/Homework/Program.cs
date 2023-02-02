using StoreAppLibrary;
using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bravo market1 = new Bravo();


            string opt;
            do
            {
                Console.WriteLine("\n=======================  MENU  ======================");
                Console.WriteLine("\n1. Product elave et");
                Console.WriteLine("2. Productlara bax");
                Console.WriteLine("3. Secilmis nomreli producta bax");
                Console.WriteLine("0. Cix");

                Console.WriteLine("\nSeciminizi edin:");
                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        var pr = CreateProduct();
                        market1.AddProduct(pr);
                        break;
                    case "2":
                        foreach (Product item in market1.Products)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "3":
                        Console.WriteLine("No: ");
                        string noStr = Console.ReadLine();
                        int no = Convert.ToInt32(noStr);

                        try
                        {
                            var wantedProduct = market1.GetProductByNo(no);
                            wantedProduct.ShowInfo();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"{no} nomreli mehsul yoxdur!");
                        }

                        break;
                    case "0":
                        Console.WriteLine("Program bitdi!");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim, yeniden cehd edin!");
                        break;
                }

            } while (opt!="0");
           

        }

        static Product CreateProduct()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            string priceStr;
            double price;
            do
            {
                Console.Write("Price: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr,out price));


            Product product = new Product
            {
                Name = name,
                Category = category,
                Price = price
            };

            return product;
        }
    }
}
