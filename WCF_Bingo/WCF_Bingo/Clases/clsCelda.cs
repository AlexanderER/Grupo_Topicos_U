using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    public class clsCelda
    {
        //----------------------------------------------------------------------------------

        #region Variables

        private bool aJugar;
        private int numero;

        #endregion

        public clsCelda() { }

        public clsCelda(bool aJugar)
        {
            this.AJugar = aJugar;
        }

        public clsCelda(int numero, bool aJugar)
        {
            this.numero = numero;
            this.AJugar = aJugar;
        }

        //----------------------------------------------------------------------------------

        #region Sets y Gets

        public bool AJugar
        {
            get
            {
                return aJugar;
            }

            set
            {
                aJugar = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        #endregion

        //----------------------------------------------------------------------------------
    }
}
