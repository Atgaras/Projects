using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_BL
{
    class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 1)
            {
                order.ShippingAddress = "fbaggins@hobbiton.me";
                order.Customer = "Frodo";
            }
            return order;
        }
        public bool Save()
        {
            return true;
        }
    }
}
