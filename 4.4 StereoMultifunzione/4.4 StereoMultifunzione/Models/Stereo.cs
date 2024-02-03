using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_StereoMultifunzione.Models
{
    internal class Stereo
    {

		private string _modello;

		public string Modello
		{
			get { return _modello; }
			set { _modello = value; }
		}

        public Stereo(string modello)
        {
            Modello = modello;
        }

        public void inserisciSupporto()
        {
            //codice
        }

        public void play()
        {
            //codice
        }

        public void stop()
        {
            //codice
        }

        public void estraiSupporto()
        {
            //codice
        }

    }
}
