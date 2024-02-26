using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Ereditarietà_Prodotti.Models
{
    internal class Prodotto
    {

        #region =01=== costanti & statici ======================



        #endregion
        #region =02=== membri & proprietà ============propfull==

        private int _codiceBarre;
        private string _descrizione;
        private int _prezzo;

        public int CodiceBarre
        {
            get { return _codiceBarre; }
            set { _codiceBarre = value; }
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public int Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        #endregion
        #region =03=== costruttori =======================ctor==

        //su c# si possono usare i getter/setter nel costruttore

        public Prodotto(int codiceBarre, string descrizione, int prezzo)
        {
            CodiceBarre = codiceBarre;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }

        #endregion
        #region =04=== metodi private e aiuto ==================



        #endregion
        #region =05=== metodi public ===========================

        public virtual int applicaSconto()
        {
            return Prezzo = Prezzo * 95; //usando getter e setter
        }

        public override string ToString()
        {
            return " | " + CodiceBarre + " | " + Prezzo + " | " + Descrizione + " | ";
        }



        #endregion

    }
}
