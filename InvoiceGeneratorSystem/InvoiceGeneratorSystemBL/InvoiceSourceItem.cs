using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGeneratorSystemBL
{
    class InvoiceSourceItem
    {
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string ItemName { get; set; }
        public double InvoicePrice { get; set; }
        public string InvoiceCurrency { get; set; }
        public int RecipientCompanyId { get; set; }
        public int ProviderCompanyId { get; set; }
    }
}