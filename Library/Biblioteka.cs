using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library 
{
    class Biblioteka : IZarzadzaniePozycjami
    {
        private string adres;
        public List<Katalog> listaKatalogow = new List<Katalog>();
        public List<Bibliotekarz> listaBibliotekarzy = new List<Bibliotekarz>();

        public Biblioteka()
        { 
        
        }

        public Biblioteka(string adres)
        {
            this.adres = adres;
        }


        public void DodajBibliotekarza(Bibliotekarz bibliotekarz)
        {
            if (listaBibliotekarzy == null)
            {
                listaBibliotekarzy[0] = bibliotekarz;
            }
            else
            {
                listaBibliotekarzy.Add(bibliotekarz);
            }
        }
        
        public void WypiszBibliotekarzy()
        {
            Console.WriteLine($"\n_____________________Zatrudnieni w bibliotece o adresie:{this.adres}");
            foreach (Bibliotekarz bibliotekarz in listaBibliotekarzy)
            {
                bibliotekarz.WypiszInfo();
            }
        }

        public void DodajKatalog(Katalog nazwaKatalogu)
        {
            if (listaKatalogow == null)
            {
                listaKatalogow[0] = nazwaKatalogu;
            }
            else
            { 
                if(listaKatalogow.Find(x => x.dzialTematyczny == nazwaKatalogu.dzialTematyczny) == null)
                {
                    listaKatalogow.Add(nazwaKatalogu);
                }
            }
        }

        public void DodajPozycje(Pozycja pozycja, string dzialTematyczny)
        {
            var i = listaKatalogow.FindIndex(x => x.dzialTematyczny == dzialTematyczny);
            if (i == -1)
            {
                Katalog katalog = new Katalog(dzialTematyczny);
                DodajKatalog(katalog);
                listaKatalogow.Last().DodajPozycje(pozycja);
            }
            else
            {
                listaKatalogow[i].DodajPozycje(pozycja);
            }
        }

        public void WypiszWszystkiePozycje()
        {
            Console.WriteLine($"____________Wszystkie pozycje dostępne w filii pod adresem {this.adres}");
            foreach (Katalog katalog in listaKatalogow)
            {
                katalog.WypiszWszystkiePozycje();
            }
        }

        public void ZnajdzPozycjePoId(int i)
        {
            foreach (Katalog katalog in listaKatalogow)
            {
                katalog.ZnajdzPozycjePoId(i);
            }
        }

        public void ZnajdzPozycjePoTytule(string t)
        {
            foreach (Katalog katalog in listaKatalogow)
            {
                katalog.ZnajdzPozycjePoTytule(t);
            }
        }
    }
}
