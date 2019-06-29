using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorSystemBL
{
    public class InvoiceGenerator
    {
        private InvoiceSourceRepository _invoiceSourceRepository;
        public List<Invoice> Invoices { get; set; }

        public InvoiceGenerator(InvoiceSourceRepository invoiceSourceRepository)
        {
            _invoiceSourceRepository = invoiceSourceRepository;
        }

        public void GenerateInvoices()
        {
            List<string> invoiceNumbers = _invoiceSourceRepository.Retrieve().Select(x => x.InvoiceNumber).Distinct().ToList();
            foreach (var invoiceNumber in invoiceNumbers)
            {
                Invoice invoice = new Invoice();
                invoice.Number = invoiceNumber;
                List<InvoiceSourceItem> invoiceSourceItems = _invoiceSourceRepository.Retrieve().Where(x => x.InvoiceNumber == invoiceNumber).ToList();
                invoice.Date = invoiceSourceItems[0].Date;
                invoice.RecipientCompanyId = invoiceSourceItems[0].RecipientCompanyId;
                invoice.ProviderCompanyId = invoiceSourceItems[0].ProviderCompanyId;

                InvoiceItem invoiceItem = new InvoiceItem();
                foreach (var sourceItem in invoiceSourceItems)
                {
                    invoiceItem.ItemName = sourceItem.ItemName;
                    invoiceItem.ItemPrice = sourceItem.InvoicePrice;
                    invoiceItem.PriceCurrency = sourceItem.InvoiceCurrency;
                    invoice.InvoiceItems.Add(invoiceItem);
                }
                Invoices.Add(invoice);
            }
        }
    }
}