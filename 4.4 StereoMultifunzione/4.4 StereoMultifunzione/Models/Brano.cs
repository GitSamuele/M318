using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_StereoMultifunzione.Models
{
    internal class Brano
    {

		private string _artista;

		public string Artista
		{
			get { return _artista; }
			set { _artista = value; }
		}

        private int _durata;

        public int Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }

        private string _titolo;

        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        public Brano(string artista, int durata, string titolo)
        {
            Artista = artista;
            Durata = durata;
            Titolo = titolo;
        }

    }
}
