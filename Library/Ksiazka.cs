using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private List<Autor> listaAutorow = new List<Autor>();

        public Ksiazka()
        {
        }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron) : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
        }

        public void DodajAutora(Autor autor)
        {
            if (listaAutorow == null)
            {
                listaAutorow[0] = autor;
            }
            else
            {
                listaAutorow.Add(autor);
            }
        }

        public override void WypiszInfo()
        {
            //Console.WriteLine("\n");
            Console.WriteLine("=Książka=");
            Console.WriteLine($"\tTytuł: {this.tytul}");
            Console.WriteLine($"\tId: {this.id}");
            Console.WriteLine($"\tWydawnictwo: {this.wydawnictwo}");
            Console.WriteLine($"\tRok wydania: {this.rokWydania}");
            Console.WriteLine($"\tLiczba stron: {this.liczbaStron}");
            Console.WriteLine($"\tLiczba autorów: {listaAutorow.Count}");
            //Console.WriteLine("__");
        }
    }
}
