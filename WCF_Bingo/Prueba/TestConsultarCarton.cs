﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class TestConsultarCarton
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Creo el carton
            
            WCF_Bingo.Clases.clsCarton carton = new WCF_Bingo.Clases.clsCarton();
            for (int x = 1; x <= 5; x++)
            {
                carton.Columnas.Add(new List<WCF_Bingo.Clases.clsCelda>());
                for (int p = 1; p <= 5; p++)
                {
                    carton.Columnas[x - 1].Add(new WCF_Bingo.Clases.clsCelda());
                    carton.Columnas[x - 1][p - 1].Numero = 1;
                }
            }


            //Creo el objeto jugador     
            WCF_Bingo.Clases.clsJugador jugador = new WCF_Bingo.Clases.clsJugador();
            jugador.NombreJugador = 1;
            jugador.ListaCartones.Add(carton);

            //Creo la lista de jugadores y demas parametros
            List<WCF_Bingo.Clases.clsJugador> listaJugador = new List<WCF_Bingo.Clases.clsJugador>();
            int numeroJugador = new int();
            int indiceCarton = new int();

            // Agrego jugador a la lista y tambien las demas variables
            listaJugador.Add(jugador);
            numeroJugador = 1;
            indiceCarton = 1;

            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            WCF_Bingo.Clases.clsCarton resultado = servicio.consultarCarton(listaJugador,numeroJugador,indiceCarton);

            Assert.IsNotNull(resultado);


            //(List<clsJugador> listaJugadores, int numeroJugador, int indiceCarton)
        }
    }
}
