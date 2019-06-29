using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGeneratorSystemBL
{
    public class InvoiceItem
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string PriceCurrency { get; set; }
    }
}