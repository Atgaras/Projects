using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_BL
{
    class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAdress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
        public bool Save()
        {
            return true;
        }
    }
}
