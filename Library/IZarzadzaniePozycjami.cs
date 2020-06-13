using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IZarzadzaniePozycjami
    {
        void ZnajdzPozycjePoTytule(string t);
        void ZnajdzPozycjePoId(int i);
        void WypiszWszystkiePozycje();
    }
}
