using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    class clsCelda
    {
        //----------------------------------------------------------------------------------

        #region Variables

        private bool aJugar;
        private int numero;

        #endregion

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
