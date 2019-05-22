using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07_02.book
{
    class Program
    {
        struct Book
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
            public bool ar_isduota;
        };

        static void Main(string[] args)
        {
            Book knyga;
            Book knyga2;

            knyga.title = "Karas ir taika";
            knyga.author = "Tolstojus";
            knyga.subject = "Romanas";
            knyga.book_id = 1;
            knyga.ar_isduota = false;

            knyga2.title = "Karas ir taika II";
            knyga2.author = "Tolstojus";
            knyga2.subject = "Romanas";
            knyga2.book_id = 1;

            Console.WriteLine(knyga.title);
            Console.WriteLine(knyga2.title);
            Console.WriteLine(knyga.book_id);
            Console.WriteLine(knyga2.book_id);

            Book[] knygos = new Book[2];
            knygos[0].title = "Pavadinimas";
            knygos[0].author = "Autorius";
            knygos[0].subject = "kazkoks";
            knygos[0].book_id = 3;

            knygos[1].title = "Pavadinimas";
            knygos[1].author = "Autorius";
            knygos[1].subject = "kazkoks";
            knygos[1].book_id = 4;

            for (int i = 0; i < knygos.Length; i++)
            {
                Console.WriteLine(knygos[i].title);
            }

 
            List<Book> knyguSarasas = new List<Book>();
            Book knygaSarasui;
            knygaSarasui.title = "Knyga sasasui";
            knygaSarasui.author = "Autorius";
            knygaSarasui.subject = "Kazkas";
            knygaSarasui.book_id = 5;
            knygaSarasui.ar_isduota = false;

            knyguSarasas.Add(knygaSarasui);
            knyguSarasas.Add(knygaSarasui);
            knyguSarasas.Add(knygaSarasui);
            knyguSarasas.Add(knygaSarasui);
            knyguSarasas.Add(knygaSarasui);

            for (int i = 0; i < knyguSarasas.Count; i++)
            {
                Console.WriteLine(knyguSarasas[i].title);
            }


            Console.ReadLine();
        }
    }
}
