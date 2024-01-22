using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà.Models
{

        #region =01=== costanti & statici ======================
        #endregion
        #region =02=== membri & proprietà ============propfull==

    internal class Mammifero
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        #endregion
        #region =03=== costruttori =======================ctor==

        public Mammifero(string nome)
        {
            _nome = nome; //mancano i controlli
        }

        #endregion
        #region =04=== metodi private e aiuto ==================
        #endregion
        #region =05=== metodi public ===========================

        public void Dormire()
        {
            Console.WriteLine("Ronf Ronf Dormo");
        }

        public virtual string EmettiVerso() //virtual serve ad indicare questo metodo sovrascrivibile dalla sottoclasse
        {
            return "EBBECCATI STO TTRAPEZZIO PEFAVVORE";
        }

        #endregion

    }
}
