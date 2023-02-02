using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkProduct drink1 = new DrinkProduct
            {
                AlcoholPercent = 10,
                Name = "Coca Cola 1L",
                Price = 13
            };
            DrinkProduct drink2 = new DrinkProduct
            {
                AlcoholPercent = 4,
                Name = "Pepsi Cola 1L",
                Price = 14
            };

            DairyProduct dairy1 = new DairyProduct
            {
                FatPercent = 8,
                Name = "Atena ayran 1L",
                Price = 4
            };
            DairyProduct dairy2 = new DairyProduct
            {
                FatPercent = 18,
                Name = "Milla ayran 1L",
                Price = 30
            };
            DairyProduct dairy3 = new DairyProduct
            {
                FatPercent = 0,
                Name = "Pal ayran 1L",
                Price = 10
            };

            Product[] products = { drink1, drink2, dairy1, dairy2, dairy3 };

            int count = 0;
            double sum = 0;
            foreach (var item in products)
            {
                if(item is DairyProduct)
                {
                    DairyProduct dp = item as DairyProduct;
                    sum += dp.FatPercent;

                    count++;
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(sum);
            Console.WriteLine(sum/count);

        }
    }
}
