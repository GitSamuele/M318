using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà.Models
{
    internal class cane : Mammifero
    {

        private bool _isSegugio;

        public bool IsSegugio{
            get { return _isSegugio; } 
            set { _isSegugio = value; }
        }

        public cane(bool isSegugio, string nome):base(nome) //viene richiesto nel costruttore "cane" (stesso nome del file) nome del costruttore di mammifero
        {
            _isSegugio = isSegugio;
        }

        public override string EmettiVerso() //inserito override per identificare la classe sovrascritta / ricordarsi di immettere lo stesso tipo di ritorno
        {
            return "Bau Bau Bau";
        }

    }
}
