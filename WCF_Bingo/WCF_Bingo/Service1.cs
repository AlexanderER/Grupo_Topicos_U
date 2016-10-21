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

        #region Crear Jugador
        public List<clsJugador> crearJugador(List<clsJugador> listaJugadores, int nombreUsuario, int cantidadCartones, int cantidadNumerosAJugar, int modalidad)
        {
            clsJugador jugador = new clsJugador(nombreUsuario,cantidadCartones,cantidadNumerosAJugar,modalidad);

            if (!(listaJugadores.Count == 0))
            {

                #region validar cartones repetidos

                //Recorre Cada Jugador
                for (int x = 0; x < listaJugadores.Count; x++)
                {
                    bool similar = true;
                    //Recorre cada carton de jugador x
                    for (int i = 0; i < listaJugadores[x].ListaCartones.Count; i++)
                    {
                        //Recorre nuevo jugador
                        for (int z = 0; z < jugador.ListaCartones.Count; z++)
                        {
                            //recorre cada celda
                            for (int p = 0; p < 5; p++)
                            {
                                for (int q = 0; q < 5; q++)
                                {
                                    //valida si encuentra una diferencia
                                    if (!(listaJugadores[x].ListaCartones[i].Columnas[p][q].Numero == jugador.ListaCartones[z].Columnas[p][q].Numero))
                                    {
                                        similar = false;
                                    }
                                }
                            }
                            if (similar)
                            {
                                jugador = new clsJugador(nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);
                                x = 0;
                            }
                        }
                    }
                }
                #endregion

            }

            listaJugadores.Add(jugador);
            return listaJugadores;
        }
        #endregion

        #region Jugador

        //public clsJugador getJugador(string p_sNombreUsuario, int p_iCantidadCartones, List<clsCarton> p_ListaCartones)
        //{
        //    clsJugador miJugador = new clsJugador();

        //    miJugador.sNombreUsuario = p_sNombreUsuario;
        //    miJugador.iCantidadCartones = p_iCantidadCartones;
        //    miJugador.listaCartones = p_ListaCartones;

        //    return miJugador;
        //}


        //public bool YaExisteElJugador(string p_sNombreJugador, List<clsJugador> p_ListaJugadores)
        //{
        //    Boolean bExiste = false;

        //    if (p_ListaJugadores != null)   // Si es diferente de nulo
        //    {
        //        if (p_ListaJugadores.Count >= 1)    // Si tiene elementos
        //        {
        //            foreach (clsJugador clsJugTemp in p_ListaJugadores)  // Obtengo cada elemento de la Lista de Jugadores
        //            {
        //                String sTempNombreJugador = clsJugTemp.sNombreUsuario;  // Obtengo el nombre del Jugador

        //                if (sTempNombreJugador == p_sNombreJugador) // Valido que no sean iguales
        //                {
        //                    bExiste = true;
        //                }
        //            }
        //        }
        //    }

        //    return bExiste;
        //}

        #endregion



        #region Generacion de Numero Aleatorio


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
                iNumeroAleatorio = aleatorio.Next(1, (p_iNumeroTecho + 1));

                if (p_lista != null)
                {

                    if (p_lista.Count >= 1)
                    {

                        if (p_lista.Contains(iNumeroAleatorio))
                        {

                            bExiste = true;

                        }
                        else
                        {

                            bExiste = false;
                        }

                    }
                    else
                    {

                        bExiste = false;
                    }

                }
                else
                {

                    bExiste = false;

                }

            } while (bExiste == true);


            //p_lista.Add(iNumero);
            return iNumeroAleatorio;
        }

        #endregion

        #region Actualizar Estado de Cartones

        public List<clsJugador> actualizarEstados(List<clsJugador> listaJugadores, int numeroAleatorio)
        {
            //recorre jugadores
            for (int i = 0; i < listaJugadores.Count; i++)
            {
                //recorre cartones
                for (int p = 0; p < listaJugadores[i].ListaCartones.Count; p++)
                {
                    //recorre celdas
                    for (int m = 0; m < 5; m++)
                    {
                        for (int n = 0; n < 5; n++)
                        {
                            if (numeroAleatorio == listaJugadores[i].ListaCartones[p].Columnas[m][n].Numero) {
                                //NumeroAReducirParaGanar = NumeroAReducirParaGanar - 1
                                listaJugadores[i].ListaCartones[p].NumeroAReducirParaGanar = listaJugadores[i].ListaCartones[p].NumeroAReducirParaGanar - 1;
                            }
                        }
                    }
                }
            }
            return listaJugadores;
        }



        #endregion

        #region regresar jugadores ganadores
        public List<clsJugador> jugadoresGanadores(List<clsJugador> listaJugadores)
        {
            List<clsJugador> listaARetornar = new List<clsJugador>();

            for (int i = 0; i < listaJugadores.Count; i++)
            {
                
                List<clsCarton> listaCartones = new List<clsCarton>();

                for (int x = 0; x < listaJugadores[i].ListaCartones.Count; x++)
                {                    
                    if (listaJugadores[i].ListaCartones[x].NumeroAReducirParaGanar==0)
                    {
                        listaCartones.Add(listaJugadores[i].ListaCartones[x]);
                    }
                }

                if (listaCartones.Count > 0)
                {
                    clsJugador jugador = new clsJugador();
                    jugador.ListaCartones = listaCartones;
                    jugador.NombreJugador = listaJugadores[i].NombreJugador;
                    listaARetornar.Add(jugador); 
                }                
                
            }
            return listaARetornar;
        }
        #endregion

        #region consultar carton
        public clsCarton consultarCarton(List<clsJugador> listaJugadores, int numeroJugador, int indiceCarton)
        {
            for (int i = 0; i < listaJugadores.Count; i++)
            {
                if (listaJugadores[i].NombreJugador == numeroJugador)
                {
                    return listaJugadores[i].ListaCartones[indiceCarton];
                }
            }
            return null;
        }


        #endregion

        #region consultar cantidad jugadores
        public int cantidadJugadores(List<clsJugador> listaJugadores)
        {
            return listaJugadores.Count;
        }
        #endregion

        #region consultar cantidad cartones de jugador
        public int cantidadCartonesPorJugador(List<clsJugador> listaJugadores, int numeroJugador)
        {
            for (int i = 0; i < listaJugadores.Count; i++)
            {
                if (listaJugadores[i].NombreJugador == numeroJugador)
                {
                    return listaJugadores[i].ListaCartones.Count;
                }
            }
            return 0;
        }
        #endregion
    }
}
