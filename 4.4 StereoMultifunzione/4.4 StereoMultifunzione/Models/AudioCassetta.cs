using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_StereoMultifunzione.Models
{
    internal class AudioCassetta : Supporto
    {

		private string _lunghezzaNastro;

		public string LunghezzaNastro
		{
			get { return _lunghezzaNastro; }
			set { _lunghezzaNastro = value; }
		}

        public AudioCassetta(string lunghezzaNastro):base(marca, modello, traccie)
        {
            LunghezzaNastro = lunghezzaNastro;
        }
    }
}
