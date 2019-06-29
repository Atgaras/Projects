using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceGeneratorSystemBL;

namespace InvoiceGeneratorSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator generator = new InvoiceGenerator(new InvoiceSourceRepository());
            generator.GenerateInvoices();
            foreach (var invoice in generator.Invoices)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", invoice.Number, invoice.Date, invoice.ProviderCompanyId, invoice.RecipientCompanyId, invoice.TotalPrice);
                Console.WriteLine("Details of invoice:");
                foreach (var item in invoice.InvoiceItems)
                {
                    Console.WriteLine("{0}, {1}, {2}", item.ItemName, item.ItemPrice, item.PriceCurrency);
                }
                
            }
            Console.ReadLine();
        }
    }
}