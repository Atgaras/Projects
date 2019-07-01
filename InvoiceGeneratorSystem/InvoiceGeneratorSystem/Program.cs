using System;
using System.Collections.Generic;
using System.IO;
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
            bool iseiti = false;
            bool reportsGenerated = false;
            while(!iseiti)
            {
                Console.Clear();
                Console.WriteLine("Koki veiksma norite atlikti: [1] - Generuoti saskaitas, [2] - Rodyti ataskaita, [3] - Iseiti");
                int userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1)
                {
                    generator.GenerateInvoices();
                    Console.WriteLine("Sugeneruota, spauskite ENTER");
                    Console.ReadLine();
                    reportsGenerated = true;
                }
                else if (userChoice == 2)
                {
                    if (reportsGenerated == true)
                    {
                        string temp = "";

                        foreach (var invoice in generator.Invoices)
                        {
                            temp=temp+string.Format("{0}, {1}, {2}, {3}, {4}", invoice.Number, invoice.Date, invoice.ProviderCompanyId, invoice.RecipientCompanyId, invoice.TotalPrice)+Environment.NewLine;
                            temp = temp + string.Format("Details of invoice:")+Environment.NewLine;
                            foreach (var item in invoice.InvoiceItems)
                            {
                                temp = temp + string.Format("{0}, {1}, {2}", item.ItemName, item.ItemPrice, item.PriceCurrency)+Environment.NewLine;
                            }
                        }
                        Console.WriteLine(temp);

                        Console.WriteLine("Ar norite issaugoti i byla? [1] - Taip, [2] - Ne");
                        int arIssaugoti = int.Parse(Console.ReadLine());
                        if (arIssaugoti == 1)
                        {
                            Console.WriteLine("Iveskite failo varda:");
                            string failoVardas = Console.ReadLine();
                            failoVardas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), failoVardas);
                            string fileExtension = Path.GetExtension(failoVardas);
                            if (fileExtension != ".txt")
                            {
                                failoVardas = Path.ChangeExtension(failoVardas, ".txt");
                            }
                            if (!string.IsNullOrEmpty(failoVardas))
                            {
                                File.WriteAllText(Path.Combine(failoVardas, failoVardas), temp);
                                Console.WriteLine("Issaugota, spauskite ENTER");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Netinkamas failo vardas");
                            }
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saskaitos dar nesugeneruotos.");
                    }
                }
                else
                {
                    iseiti = true;
                }
               
            }
        }
    }
}