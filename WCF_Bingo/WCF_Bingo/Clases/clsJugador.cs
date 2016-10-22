using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    public class clsJugador
    {
        //----------------------------------------------------------------------------------

        #region Variables

        private int nombreJugador;
        private List<clsCarton> listaCartones;

        #endregion

        //----------------------------------------------------------------------------------

        #region Constructor

        public clsJugador() {

        }

        public clsJugador(int nombreJugador, int cantidadCartones, int cantidadNumerosAJugar, int modalidad)
        {
            this.NombreJugador = nombreJugador;
            listaCartones = new List<clsCarton>();
            agregarCartones(cantidadCartones,cantidadNumerosAJugar,modalidad);
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

        #region Metodos

        public void agregarCartones(int cantidadCartones, int cantidadNumerosAJugar, int modalidad)
        {
            for (int i = 0; i < cantidadCartones; i++)
            {
                agregarCarton(cantidadNumerosAJugar, modalidad);   
            }
        }

        public void agregarCarton(int cantidadNumerosAJugar, int modalidad)
        {
            clsCarton carton = new clsCarton(cantidadNumerosAJugar, modalidad);

            //valida si el carton ya existe
            //recorre cada carton
            for (int i = 0; i < listaCartones.Count; i++)
            {
                bool similar = compararCartones(carton, ListaCartones[i]);

                if (similar) {
                    carton = new clsCarton(cantidadNumerosAJugar, modalidad);
                    i = -1;
                }                
            }
            this.listaCartones.Add(carton);
        }

        public bool compararCartones(clsCarton carton1, clsCarton carton2)
        {
            for (int m = 0; m < 5; m++)
            {
                for (int n = 0; n < 5; n++)
                {
                    //ignorar 3,3 (numero del centro)
                    if (!(m == 2 && n == 2))
                    {
                        //valida si encuentra una diferencia
                        if (carton1.Columnas[m][n].AJugar != carton2.Columnas[m][n].AJugar)
                        {
                            return true;
                        }
                    }
                    
                }
            }
            return false;
        }

        #endregion

        //----------------------------------------------------------------------------------

    }
}
