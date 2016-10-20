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


        public Int32 GenerarNumero(Int32 p_iNumeroTecho, List<Int32> p_lista)
        {
            Int32 iNumeroAleatorio = 0;
            Boolean bExiste = true;
            Random aleatorio = new Random();

            // Se comprueba si el número ya salió, 
            // es decir si esta contenido en la lista
            // Sino vuelvo a generar otro numero

            do
            {
                iNumeroAleatorio = aleatorio.Next(1, p_iNumeroTecho);

                if (p_lista != null) {

                    if (p_lista.Count >= 1) {

                        if (p_lista.Contains(iNumeroAleatorio)){

                            bExiste = true;

                        }else{

                            bExiste = false;
                        }

                    } else{

                        bExiste = false;
                    }

                } else{

                    bExiste = false;

                }

            } while (bExiste == true);


            //p_lista.Add(iNumero);
            return iNumeroAleatorio;
        }

        #endregion

    }
}
