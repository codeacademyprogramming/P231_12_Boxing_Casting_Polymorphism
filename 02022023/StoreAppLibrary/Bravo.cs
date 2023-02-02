using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    public class Bravo : IStore
    {
        private Product[] _products = new Product[0];

        private int AcoholPerrcentLimit = 40;
        public Product[] Products { get => _products; }

        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        


        public Product GetProductByNo(int no)
        {

            foreach (var item in _products)
            {
                if (item.No == no)
                    return item;
            }
          
            throw new Exception();
        }

        public bool HasProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                    return true;
            }

            return false;
        }
    }
}
