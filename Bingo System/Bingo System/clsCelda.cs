using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bingo_System
{
    public class clsCelda
    {
        private bool aJugar;
        private int numero;

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
    }
}