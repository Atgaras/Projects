using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGeneratorSystemBL
{
    class ReportGenerator
    {
        private readonly List<Invoice> _invoices;
        public ReportGenerator(List<Invoice> invoices)
        {
            _invoices = invoices;
        }
    }
}