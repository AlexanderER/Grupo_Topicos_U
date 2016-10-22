using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class TestActualizarEstados
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Creo el jugador
            WCF_Bingo.Clases.clsJugador jugador = new WCF_Bingo.Clases.clsJugador();
            jugador.NombreJugador = 1;
            jugador.ListaCartones = null;

            //Creo lista de jugador
            List<WCF_Bingo.Clases.clsJugador> listaJugadores = new List<WCF_Bingo.Clases.clsJugador>();
            int numeroAleatorio = new int();

            listaJugadores.Add(jugador);


            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            List<WCF_Bingo.Clases.clsJugador> resultado = servicio.actualizarEstados(listaJugadores, numeroAleatorio);

            Assert.IsNotNull(resultado);
        }
    }
}
