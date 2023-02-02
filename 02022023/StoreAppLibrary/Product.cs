using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    public class Product
    {
        static int _totalCount;
        public Product()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No;
        public string Name;
        public string Category;
        public double Price;

        public void ShowInfo()
        {
            Console.WriteLine($"No:{No} - Name: {Name} - Category: {Category} - Price: {Price}");
        }
    }
}
