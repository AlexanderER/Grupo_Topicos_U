using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    class clsJugador
    { //----------------------------------------------------------------------------------

        #region Variables

        private String sNombreUsuario;
        private Int32 iCantidadCartones;
        private List<clsCarton> listaCartones;

        #endregion

        //----------------------------------------------------------------------------------

        #region Sets y Gets

        public string SNombreUsuario
        {
            get
            {
                return sNombreUsuario;
            }

            set
            {
                sNombreUsuario = value;
            }
        }

        public int ICantidadCartones
        {
            get
            {
                return iCantidadCartones;
            }

            set
            {
                iCantidadCartones = value;
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

        public clsJugador(String p_sNombreUsuario, Int32 p_iCantidadCartones, List<clsCarton> p_ListaCartones)
        {
            sNombreUsuario = p_sNombreUsuario;
            iCantidadCartones = p_iCantidadCartones;
            listaCartones = p_ListaCartones;
        }

        #endregion

        //----------------------------------------------------------------------------------

    }
}
