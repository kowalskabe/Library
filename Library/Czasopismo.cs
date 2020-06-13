using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Czasopismo : Pozycja
    {
        private int numer;


        public Czasopismo()
        {
        }

        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer) : base( tytul, id,  wydawnictwo, rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.numer = numer;
        }
        public override void WypiszInfo()
        {
            //Console.WriteLine("\n");
            Console.WriteLine("=Czasopismo="); 
            Console.WriteLine($"\tTytuł: {this.tytul}");
            Console.WriteLine($"\tId: {this.id}");
            Console.WriteLine($"\tWydawnictwo: {this.wydawnictwo}");
            Console.WriteLine($"\tRok wydania: {this.rokWydania}");
            Console.WriteLine($"\tNumer: {this.numer}");
            //Console.WriteLine("__");
        }
    }
}
