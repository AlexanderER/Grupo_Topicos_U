using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Bingo.Clases
{
    class clsCelda
    {
        //----------------------------------------------------------------------------------

        #region Variables

        private bool aJugar;
        private int numero;
        private bool numerojugado;

        #endregion

        //----------------------------------------------------------------------------------

        #region Constructor

        public clsCelda() { }

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

        public bool Numerojugado
        {
            get
            {
                return numerojugado;
            }

            set
            {
                numerojugado = value;
            }
        }

        #endregion

        //----------------------------------------------------------------------------------
    }
}
