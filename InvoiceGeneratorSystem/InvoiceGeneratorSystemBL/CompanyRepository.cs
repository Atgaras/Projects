using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGeneratorSystemBL
{
    class CompanyRepository
    {
        public List<Company> company = new List<Company>();
        public CompanyRepository()
        {
            company.Add(new Company()
            {
                CompanyId = 1,
                CompanyName = "UAB Stalai ir kėdės",
                CompanyAddress = "aaaa",
                AccountNumber = "LT5566"
            });
            company.Add(new Company()
            {
                CompanyId = 2,
                CompanyName = "UAB Stalai ir lovos",
                CompanyAddress = "sssss",
                AccountNumber = "LT6677"
            });
        }
    }
}
