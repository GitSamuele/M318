using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Ereditarietà_Prodotti.Models
{
    internal class Alimentari : Prodotto
    {

        #region =01=== costanti & statici ======================

        //aggiornamento repository: da cmd > nella directory > git add * > git commit -m "Esercizio negozio"

        #endregion
        #region =02=== membri & proprietà ============propfull==

        private int _dataScadenza;

        public int DataScadenza
        {
            get { return _dataScadenza; }
            set { _dataScadenza = value; }
        }

        #endregion
        #region =03=== costruttori =======================ctor==

        public Alimentari(int dataScadenza, int codiceBarre, string descrizione, int prezzo, int anno, int mese, int giorno) : base(codiceBarre, descrizione, prezzo)
        {

            DataScadenza = new DateTime(anno, mese, giorno);

        }

        #endregion
        #region =04=== metodi private e aiuto ==================



        #endregion
        #region =05=== metodi public ===========================

        public override void applicaSconto()
        {
            if (DataScadenza + 10 >= DateTime.Today)
            {
                Prezzo = Prezzo * 0.8;
            }
            else
            {
                Prezzo = Prezzo * 0.95;
            }
        }

        #endregion
    }
}
