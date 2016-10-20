﻿using System;
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

        [OperationContract]
        clsJugador getJugador(String p_sNombreUsuario, Int32 p_iCantidadCartones, List<clsCarton> p_ListaCartones);

        
        [OperationContract]
        Int32 GenerarNumero(Int32 p_iNumeroTecho, List<Int32> p_lista);


        #endregion
    }
}
