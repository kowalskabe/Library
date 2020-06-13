using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;

        
        public Bibliotekarz()
        {

        }

        public Bibliotekarz(string imie, string nazwisko, string dataZatrudnienia, double wynagrodzenie) : base(imie, nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataZatrudnienia = dataZatrudnienia;
            this.wynagrodzenie = wynagrodzenie;
        }


        public void WypiszInfo()
        {
            Console.WriteLine("Bibliotekarz___________");
            Console.WriteLine($"\tImię: {this.imie}");
            Console.WriteLine($"\tNazwisko: {this.nazwisko}");
            Console.WriteLine($"\tData zatrudnienia: {this.dataZatrudnienia}");
            Console.WriteLine($"\tWynagrodzenie: {this.wynagrodzenie}");
            Console.WriteLine("_____________________");
        }
    }
}
