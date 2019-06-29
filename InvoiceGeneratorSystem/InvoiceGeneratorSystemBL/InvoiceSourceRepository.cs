using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGeneratorSystemBL
{
   
    public class InvoiceSourceRepository
    {
        private List<InvoiceSourceItem> sourceItems = new List<InvoiceSourceItem>();

        public InvoiceSourceRepository()
        {
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "001",
                Date = new DateTime(2019, 06, 29),
                ItemName = "Stalas",
                InvoicePrice = 100,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 1,
                RecipientCompanyId=2
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "001",
                Date = new DateTime(2019, 06, 29),
                ItemName = "Kėdės",
                InvoicePrice = 50,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 1,
                RecipientCompanyId = 2
            }); sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "001",
                Date = new DateTime(2019, 06, 29),
                ItemName = "Puodai",
                InvoicePrice = 30,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 1,
                RecipientCompanyId = 2
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "003",
                Date = new DateTime(2019, 04, 05),
                ItemName = "Trinkelių klojimas",
                InvoicePrice = 1000,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 4,
                RecipientCompanyId = 6
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "001",
                Date = new DateTime(2019, 06, 29),
                ItemName = "Šaukštas",
                InvoicePrice = 3000,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 1,
                RecipientCompanyId = 2
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "002",
                Date = new DateTime(2019, 04, 22),
                ItemName = "Dviratis",
                InvoicePrice = 500,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 7,
                RecipientCompanyId = 3
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "002",
                Date = new DateTime(2019, 04, 22),
                ItemName = "Pedalai",
                InvoicePrice = 25,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 7,
                RecipientCompanyId = 3
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "003",
                Date = new DateTime(2019, 04, 05),
                ItemName = "Tinkavimas",
                InvoicePrice = 600,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 4,
                RecipientCompanyId = 6
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "001",
                Date = new DateTime(2019, 06, 29),
                ItemName = "Samtis",
                InvoicePrice = 55,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 1,
                RecipientCompanyId = 2
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "002",
                Date = new DateTime(2019, 04, 22),
                ItemName = "Bagažinė",
                InvoicePrice = 20,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 7,
                RecipientCompanyId = 3
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "002",
                Date = new DateTime(2019, 04, 22),
                ItemName = "Šalmas",
                InvoicePrice = 50,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 7,
                RecipientCompanyId = 3
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "004",
                Date = new DateTime(2019, 05, 10),
                ItemName = "Fotoaparatas",
                InvoicePrice = 1100,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 5,
                RecipientCompanyId = 6
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "004",
                Date = new DateTime(2019, 05, 10),
                ItemName = "Objektyvas",
                InvoicePrice = 400,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 5,
                RecipientCompanyId = 6
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "004",
                Date = new DateTime(2019, 05, 10),
                ItemName = "Blykstė",
                InvoicePrice = 70,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 5,
                RecipientCompanyId = 6
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "001",
                Date = new DateTime(2019, 06, 29),
                ItemName = "Paveikslas",
                InvoicePrice = 100,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 1,
                RecipientCompanyId = 2
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "005",
                Date = new DateTime(2019, 03, 15),
                ItemName = "Batai",
                InvoicePrice = 50,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 2,
                RecipientCompanyId = 8
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "005",
                Date = new DateTime(2019, 03, 15),
                ItemName = "Kuprinė",
                InvoicePrice = 25,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 2,
                RecipientCompanyId = 8
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "005",
                Date = new DateTime(2019, 03, 15),
                ItemName = "Kepurė",
                InvoicePrice = 15,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 2,
                RecipientCompanyId = 8
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "002",
                Date = new DateTime(2019, 04, 22),
                ItemName = "Lempos",
                InvoicePrice = 15,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 7,
                RecipientCompanyId = 3
            });
            sourceItems.Add(new InvoiceSourceItem()
            {
                InvoiceNumber = "005",
                Date = new DateTime(2019, 03, 15),
                ItemName = "Laikrodis",
                InvoicePrice = 300,
                InvoiceCurrency = "EUR",
                ProviderCompanyId = 2,
                RecipientCompanyId = 8
            });
        }
        public List<InvoiceSourceItem> Retrieve()
        {
            return sourceItems;
        }
    }
}