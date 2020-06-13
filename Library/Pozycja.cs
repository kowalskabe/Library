using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Pozycja
    {
		internal protected string tytul;
		internal protected int id;
		protected string wydawnictwo;
		protected int rokWydania;


		public Pozycja()
		{ 
		}
		public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
		{
			this.tytul = tytul;
			this.id = id;
			this.wydawnictwo = wydawnictwo;
			this.rokWydania = rokWydania;
		}

		public abstract void WypiszInfo();
	
	}
}
