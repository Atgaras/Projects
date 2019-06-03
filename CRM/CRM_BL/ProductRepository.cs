using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_BL
{
    class ProductRepository
    {
        public Product Retrieve(string productName)
        {
            Product product = new Product(productName);
            //??? nežinau ar gerai
            if (string.IsNullOrEmpty(productName))
            {
                product.ProductName = "Table";
            }
            return product;
        }
        public bool Save()
        {
            return true;
        }
    }
}
