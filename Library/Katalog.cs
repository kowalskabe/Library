using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Katalog : IZarzadzaniePozycjami
    {
        //private string dzialTematyczny;
        public List<Pozycja> listaPozycji = new List<Pozycja>();
        public string dzialTematyczny { get; private set; }
        public Katalog()
        {
        }

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }
        public void DodajPozycje(Pozycja pozycja)
        {
            if (listaPozycji == null)
            {
                listaPozycji[0] = pozycja;
            }
            else
            {
                listaPozycji.Add(pozycja);
            }
            
        }

        public void WypiszWszystkiePozycje()
        {
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~Kategoria : {dzialTematyczny}");
            foreach (Pozycja pozycja in listaPozycji)
            {
                pozycja.WypiszInfo();
            }
        }

        public void ZnajdzPozycjePoId(int i)
        {
            var tmp = listaPozycji.Find(x => x.id == i);
            if (tmp != null)
            {
                Console.WriteLine($"\nZnaleziono pozycję o id {i} w katalogu {this.dzialTematyczny}:");
                tmp.WypiszInfo();
            }
        }

        public void ZnajdzPozycjePoTytule(string title)
        {
            var tmp = listaPozycji.Find(x => x.tytul == title);
            if (tmp != null)
            {
                Console.WriteLine($"\nZnaleziono pozycję o tytule \"{title}\" w katalogu {this.dzialTematyczny}:");
                tmp.WypiszInfo();
            }
        }
    }
}