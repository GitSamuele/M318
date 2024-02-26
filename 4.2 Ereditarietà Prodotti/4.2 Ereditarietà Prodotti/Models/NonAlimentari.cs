using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Ereditarietà_Prodotti.Models
{
    internal class NonAlimentari : Prodotto
    {

        #region =01=== costanti & statici ======================



        #endregion
        #region =02=== membri & proprietà ============propfull==

        private string _materiale;

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        #endregion
        #region =03=== costruttori =======================ctor==

        public NonAlimentari(string materiale, int codiceBarre, string descrizione, int prezzo) : base(codiceBarre, descrizione, prezzo)
        {

            Materiale = materiale;

        }

        #endregion
        #region =04=== metodi private e aiuto ==================



        #endregion
        #region =05=== metodi public ===========================

        public override void applicaSconto()
        {
            if (Materiale == "carta" || Materiale = "vetro" | Materiale = "plastica")
            {
                Prezzo = Prezzo * 0.9;
            }
            else
            {
                Prezzo = Prezzo * 0.95;
            }
        }

        #endregion

    }
}
