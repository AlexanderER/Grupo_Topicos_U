using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_System
{
    class clsJugador
    {
        private List<clsCarton> listaCartones;
        private int cantidadDeCartones;

        public clsJugador() { }
        public clsJugador(int cantidadDeCartones) { }

        public List<clsCarton> ListaCartones
        {
            get
            {
                return listaCartones;
            }

            set
            {
                listaCartones = value;
            }
        }
    }
}
