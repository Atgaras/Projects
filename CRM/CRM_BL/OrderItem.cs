using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(string orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public string OrderItemId { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(OrderItemId))
            {
                isValid = false;
            }
           
            return isValid;
        }
    }
}
