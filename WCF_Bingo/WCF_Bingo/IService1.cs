using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Bingo.Clases;

namespace WCF_Bingo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        #region Jugador

        //[OperationContract]
        //clsJugador getJugador(String p_sNombreUsuario, Int32 p_iCantidadCartones, List<clsCarton> p_ListaCartones);

        //[OperationContract]
        //Boolean YaExisteElJugador(String p_sNombreJugador, List<clsJugador> p_ListaJugadores);

        #endregion


        #region Generacion de Numero Aleatorio

        [OperationContract]
        Int32 GenerarNumero(Int32 p_iNumeroTecho, List<Int32> p_lista);

        #endregion

        #region Crear Jugador

        [OperationContract]
        List<clsJugador> crearJugador(List<clsJugador> listaJugadores, int nombreUsuario, int cantidadCartones, int cantidadNumerosAJugar, int modalidad);

        #endregion

        #region Actualizar Estado

        [OperationContract]
        List<clsJugador> actualizarEstados(List<clsJugador> listaJugadores, int numeroAleatorio);

        #endregion

        #region regresar jugadores ganadores

        [OperationContract]
        List<clsJugador> jugadoresGanadores(List<clsJugador> listaJugadores);

        #endregion

        #region consultar carton
        [OperationContract]
        clsCarton consultarCarton(List<clsJugador> listaJugadores, int numeroJugador, int indiceCarton);
        #endregion

        #region consultar cantidad jugadores
        [OperationContract]
        int cantidadJugadores(List<clsJugador> listaJugadores);
        #endregion

    }
}
