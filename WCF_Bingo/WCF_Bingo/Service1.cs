using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Bingo.Clases;

namespace WCF_Bingo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        #region Jugador

        public clsJugador getJugador(string p_sNombreUsuario, int p_iCantidadCartones, List<clsCarton> p_ListaCartones)
        {
            clsJugador miJugador = new clsJugador();

            miJugador.sNombreUsuario = p_sNombreUsuario;
            miJugador.iCantidadCartones = p_iCantidadCartones;
            miJugador.listaCartones = p_ListaCartones;

            return miJugador;
        }

        #endregion

    }
}
