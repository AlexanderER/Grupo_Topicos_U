using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Bingo.Clases
{
    class clsJugador
    {
        //----------------------------------------------------------------------------------

        #region Variables

        private int nombreJugador;
        private List<clsCarton> listaCartones;

        #endregion

        //----------------------------------------------------------------------------------

        #region Constructor

        public clsJugador()
        {

        }

        public clsJugador(int nombreJugador, int cantidadCartones, int cantidadNumerosAJugar, int modalidad)
        {
            this.NombreJugador = nombreJugador;
            listaCartones = new List<clsCarton>();
            agregarCartones(cantidadCartones, cantidadNumerosAJugar, modalidad);
        }

        #endregion

        //----------------------------------------------------------------------------------

        #region Sets y Gets

        public int NombreJugador
        {
            get
            {
                return nombreJugador;
            }

            set
            {
                nombreJugador = value;
            }
        }

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

        #endregion

        //----------------------------------------------------------------------------------

    }
}
