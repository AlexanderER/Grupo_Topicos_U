﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Bingo.Clases
{
    class clsCarton
    {
        //----------------------------------------------------------------------------------

        #region Variables

        private int cantidadNumerosAJugar;
        private int numeroAReducirParaGanar;
        private List<List<clsCelda>> columnas;

        #endregion

        //----------------------------------------------------------------------------------

        #region Constructor

        public clsCarton() { }

        #endregion

        //----------------------------------------------------------------------------------

        #region Sets y Gets

        public int CantidadNumerosAJugar
        {
            get
            {
                return cantidadNumerosAJugar;
            }

            set
            {
                cantidadNumerosAJugar = value;
            }
        }

        public int NumeroAReducirParaGanar
        {
            get
            {
                return numeroAReducirParaGanar;
            }

            set
            {
                numeroAReducirParaGanar = value;
            }
        }

        public new List<List<clsCelda>> Columnas
        {
            get
            {
                return columnas;
            }

            set
            {
                columnas = value;
            }
        }

        #endregion

        //----------------------------------------------------------------------------------

    }
}
