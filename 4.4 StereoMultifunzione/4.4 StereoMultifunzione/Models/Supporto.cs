using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_StereoMultifunzione.Models
{
    internal class Supporto
    {

		private string _marca;

		public string Marca
		{
			get { return _marca; }
			set { _marca = value; }
		}

		private string _modello;

		public string Modello
		{
			get { return _modello; }
			set { _modello = value; }
		}

        private string _traccie;
        public string Traccie
        {
            get { return _traccie; }
            set { _traccie = value; }
        }

        public Supporto(string marca, string modello, string traccie)
        {
            Marca = marca;
            Modello = modello;
            Traccie = traccie;
        }
    }
}
