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
            listaCartones = new List<clsCarton>();
            agregarCartones(cantidadCartones,cantidadNumerosAJugar,modalidad);
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
                bool similar = true;

                //recorre cada celda
                for (int p = 0; p < 5; p++)
                {
                    for (int q = 0; q < 5; q++)
                    {
                        //valida si encuentra una diferencia
                        if (!(listaCartones[i].Columnas[p][q].Numero == carton.Columnas[p][q].Numero)) {
                            similar = false;
                        }
                    }
                }
                if (similar) {
                    carton = new clsCarton(cantidadNumerosAJugar, modalidad);
                    i = 0;
                }                
            }
            this.listaCartones.Add(carton);
        }

        #endregion

        //----------------------------------------------------------------------------------

    }
}
