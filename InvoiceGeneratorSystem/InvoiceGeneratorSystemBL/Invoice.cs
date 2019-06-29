using System;
using System.Collections.Generic;

namespace InvoiceGeneratorSystemBL
{
    public class Invoice
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
        public int RecipientCompanyId { get; set; }
        public int ProviderCompanyId { get; set; }
        public double TotalPrice
        {
            get
            {
                double sum = 0;
                foreach (var item in InvoiceItems)
                {
                    sum = sum + item.ItemPrice;
                }
                return sum;
            }
        }

    }
}