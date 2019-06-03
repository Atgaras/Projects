using System;
using System.Collections.Generic;

namespace CRM_BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderItems { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ShippingAddress))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}

