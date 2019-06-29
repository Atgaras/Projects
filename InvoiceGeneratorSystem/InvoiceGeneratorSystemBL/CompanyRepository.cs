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
                CompanyAddress = "Virtuvė",
                AccountNumber = "LT5566"
            });
            company.Add(new Company()
            {
                CompanyId = 2,
                CompanyName = "UAB Spintos ir lovos",
                CompanyAddress = "Kitur",
                AccountNumber = "LT6677"
            });
            company.Add(new Company()
            {
                CompanyId = 3,
                CompanyName = "UAB UAB",
                CompanyAddress = "Toli",
                AccountNumber = "LT3333"
            });
            company.Add(new Company()
            {
                CompanyId = 4,
                CompanyName = "AB Įmonė",
                CompanyAddress = "Prie ežero",
                AccountNumber = "LT1234"
            });
            company.Add(new Company()
            {
                CompanyId = 5,
                CompanyName = "UAB Kava",
                CompanyAddress = "Mėnulis",
                AccountNumber = "LT4321"
            });
            company.Add(new Company()
            {
                CompanyId = 6,
                CompanyName = "UAB OnePlus",
                CompanyAddress = "Kinija",
                AccountNumber = "CN6587"
            });
            company.Add(new Company()
            {
                CompanyId = 7,
                CompanyName = "UAB Antakalnis",
                CompanyAddress = "Antakalnis",
                AccountNumber = "LT4713"
            });
            company.Add(new Company()
            {
                CompanyId = 8,
                CompanyName = "UAB Dviratis",
                CompanyAddress = "Namai",
                AccountNumber = "LT9871"
            });
        }
    }
}