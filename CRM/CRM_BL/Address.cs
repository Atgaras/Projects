using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_BL
{
    class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get; set; }
        public int AddresType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(PostalCode))
            {
                isValid = false;
            }
           
            return isValid;
        }
    }
}
