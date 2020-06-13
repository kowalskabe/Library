using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Katalog romance = new Katalog("Romanse");
            Katalog horror = new Katalog("Horrory");
            Katalog children = new Katalog("Dla dzieci");

            Ksiazka book1 = new Ksiazka("Pucio mówi dzień dobry", 0, "Nasza Księgarnia", 2020, 28);
            Ksiazka book2 = new Ksiazka("Kicia Kocia na rowerze", 1, "Media Rodzina", 2019, 24);
            Ksiazka book3 = new Ksiazka("Niesamowite przygody dziesięciu skarpetek", 2, "Poradnia K.", 2015, 160);
            Ksiazka book4 = new Ksiazka("Skandal", 3, "Burda Media Polska", 2020, 282);
            Ksiazka book5 = new Ksiazka("Zapomnij, że istniałem", 4, "Jaguar", 2020, 376);
            Ksiazka book6 = new Ksiazka("Maybe Now. Maybe Not.", 5, "Otwarte", 2020, 464);
            Ksiazka book7 = new Ksiazka("This girl", 6, "YA!", 2018, 342);
            Ksiazka book8 = new Ksiazka("Jest krew", 7, "Prószyński Media", 2020, 512);
            Ksiazka book9 = new Ksiazka("Outsider", 8, "Prószyński Media", 2020, 640);
            Ksiazka book10 = new Ksiazka("Zew Cthulhu", 9, "Vesper", 2019, 272);
            Ksiazka book11 = new Ksiazka("Lore. Niegodziwi śmiertelnicy.", 10, "Zyski i S-ka", 2019, 400);
            Czasopismo magazine1 = new Czasopismo("Świat Lego Ninjago Legacy", 11, "Świat LEGO", 2020, 1020);
            Czasopismo magazine2 = new Czasopismo("Moviestar Planet", 12, "Domalala", 2020, 22020);
            Czasopismo magazine3 = new Czasopismo("Kosmos dla dziewczynek", 13, "Kosmos", 2020, 162020);

            Autor author1 = new Autor("Marta", "Galewska-Kustra", "polska");
            Autor author2 = new Autor("Anita", "Głowińska", "polska");
            Autor author3 = new Autor("Katarzyna", "Nowakowska", "polska");
            Autor author4 = new Autor("Beata", "Majewska", "polska");
            Autor author5 = new Autor("Colleen", "Hoover", "amerykańska");
            Autor author6 = new Autor("Stephen", "King", "amerykańska");
            Autor author7 = new Autor("Howard Philips", "Lovecraft", "amerykańska");
            Autor author8 = new Autor("Aaron", "Mahnke", "amerykańska");

            book1.DodajAutora(author1);
            book2.DodajAutora(author2);
            
            book4.DodajAutora(author3);
            book5.DodajAutora(author4);
            book6.DodajAutora(author5);
            book7.DodajAutora(author5);
            book8.DodajAutora(author6);
            book9.DodajAutora(author6);
            book10.DodajAutora(author7);
            book11.DodajAutora(author8);


            Biblioteka library1 = new Biblioteka("ul. Tadeusza Kościuszki 14, 81-704 Sopot");
            Biblioteka library2 = new Biblioteka("ul. Obrońców Westerplatte 16, 81-706 Sopot");

            Bibliotekarz employee1 = new Bibliotekarz("Ewa", "Kowalska", "2019-09-01", 4500);
            Bibliotekarz employee2 = new Bibliotekarz("Grzegorz", "Brzęczyszczykiewicz", "2013-05-01", 3500);
            Bibliotekarz employee3 = new Bibliotekarz("Michał", "Kułaczkowski", "2010-01-01", 2500);

            library1.DodajBibliotekarza(employee1);
            library1.DodajBibliotekarza(employee2);
            library2.DodajBibliotekarza(employee3);

            library1.WypiszWszystkiePozycje(); //pusta lista
            Console.WriteLine("\n\n");


            library1.DodajPozycje(book1, "Dla dzieci");
            library1.DodajPozycje(book2, "Dla dzieci");
            library1.DodajPozycje(book3, "Dla dzieci");
            library1.DodajKatalog(children);
            library1.DodajKatalog(romance);
            library1.DodajPozycje(book4, "Romanse");
            library1.DodajPozycje(book5, "Romanse");
            library1.DodajPozycje(book6, "Romanse");
            library1.DodajPozycje(book7, "Romanse");
            library1.DodajPozycje(book8, "Horrory");
            library1.DodajPozycje(book9, "Horrory");
            library1.DodajPozycje(book10, "Horrory");
            library1.DodajPozycje(book11, "Horrory");
            library1.DodajPozycje(magazine1, "Dla dzieci");

            library1.WypiszWszystkiePozycje();
            Console.WriteLine("\n\n");

            library1.WypiszBibliotekarzy();
            Console.WriteLine("\n\n");

            library1.ZnajdzPozycjePoId(0);
            library1.ZnajdzPozycjePoId(10);
            library1.ZnajdzPozycjePoId(110);

            Console.WriteLine("\n\n");

            library1.ZnajdzPozycjePoTytule("Maybe Now. Maybe Not.");
            Console.WriteLine("\n\n");




            library2.WypiszBibliotekarzy();
            Console.WriteLine("\n\n");

            library2.DodajPozycje(book1, "Dla dzieci");
            library2.DodajPozycje(magazine2, "Dla dzieci");
            library2.DodajPozycje(magazine3, "Dla dzieci");
            
            library2.ZnajdzPozycjePoId(0);
            library2.ZnajdzPozycjePoId(10);
            library2.ZnajdzPozycjePoId(110);

            Console.WriteLine("\n\n");
            
            library2.WypiszWszystkiePozycje();
            Console.WriteLine("\n\n");

            library2.ZnajdzPozycjePoTytule("Maybe Now. Maybe Not.");
            Console.WriteLine("\n\n");
            Console.ReadLine();
        }
    }
}
