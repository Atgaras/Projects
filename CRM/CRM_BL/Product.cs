using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_BL
{
    class Product
    {
        public Product()
        {

        }
        public Product(string productName)
        {
            ProductName = productName;
        }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
           
            return isValid;
        }
    }
}
