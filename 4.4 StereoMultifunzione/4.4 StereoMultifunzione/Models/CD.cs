using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_StereoMultifunzione.Models
{
    internal class CD : Supporto
    {

		private string _dimensione;

		public string Dimensione
		{
			get { return _dimensione; }
			set { _dimensione = value; }
		}

        public CD(string dimensione):base(marca, modello, traccie)
        {
            Dimensione = dimensione;
        }



    }
}
