using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_StereoMultifunzione.Models
{
    internal class Vinile : Supporto
    {

		private string _giriMinuti;

		public string GiriMinuto
		{
			get { return _giriMinuti; }
			set { _giriMinuti = value; }
		}

        public Vinile(string giriMinuti):base(marca, modello, traccie)
        {
            GiriMinuto = giriMinuti;
        }
    }
}
