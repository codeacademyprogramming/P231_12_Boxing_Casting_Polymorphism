using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    public interface IStore
    {
        Product[] Products { get; }
        void AddProduct(Product product);
        bool HasProductByNo(int no);
        Product GetProductByNo(int no);
    }
}
