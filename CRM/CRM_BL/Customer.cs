using System;
using System.Collections.Generic;

namespace CRM_BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
        }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName + ", " + FirstName;
                }
                else if (string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(FirstName))
                {
                    return FirstName;
                }
                else if (!string.IsNullOrWhiteSpace(LastName) && string.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName;
                }
                else
                {
                    return "";
                }
            }
        }
        public string EmailAdress { get; set; }
        public string HomeAdress { get; set; }
        public string WorkAdress { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            else if (string.IsNullOrWhiteSpace(EmailAdress))
            {
                isValid = false;
            }

            return isValid;
        }
        public bool Save()
        {
            return true;
        }
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retieve()
        {
            return new List<Customer>();
        }
    }
}
