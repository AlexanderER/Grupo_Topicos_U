using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    public class clsJugador
    { //----------------------------------------------------------------------------------

        #region Variables

        private int nombreJugador;
        private List<clsCarton> listaCartones;

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

        #region Constructor

        public clsJugador() {

        }

        public clsJugador(int nombreUsuario, int cantidadCartones, int cantidadNumerosAJugar, int modalidad)
        {
            this.NombreJugador = nombreJugador;
            agregarCartones(cantidadCartones,cantidadNumerosAJugar,modalidad);
        }

        #endregion

        //----------------------------------------------------------------------------------

        #region Metodos

        public void agregarCartones(int cantidadCartones, int cantidadNumerosAJugar, int modalidad)
        {
            for (int i = 0; i < cantidadCartones; i++)
            {
                agregarCarton(cantidadCartones, modalidad);   
            }
        }

        public void agregarCarton(int cantidadNumerosAJugar, int modalidad)
        {
            clsCarton carton = new clsCarton();
            this.ListaCartones.Add(carton);
        }

        #endregion

        //----------------------------------------------------------------------------------

    }
}
