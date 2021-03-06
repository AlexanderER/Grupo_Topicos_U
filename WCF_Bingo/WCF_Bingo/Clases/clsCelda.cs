﻿using System;
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
        private bool numerojugado;
        private int numero;

        #endregion

        //----------------------------------------------------------------------------------

        #region Constructor

        public clsCelda()
        {
            this.numerojugado = false;
        }

        public clsCelda(bool aJugar)
        {
            this.AJugar = aJugar;
            this.numerojugado = false;
        }

        public clsCelda(int numero, bool aJugar)
        {
            this.numero = numero;
            this.AJugar = aJugar;
            this.numerojugado = false;
        }

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
