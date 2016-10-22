using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class SuccessEstado
    {
        [TestMethod]
        public void estadoSuccess()
        {
            //Creo lista
            List<WCF_Bingo.Clases.clsJugador> listaJugadores = new List<WCF_Bingo.Clases.clsJugador>();

            int nombreUsuario = new int();
            int cantidadCartones = new int();
            int cantidadNumerosAJugar = new int();
            int modalidad = new int();

            // listaJugadores.Add(jugador);

            nombreUsuario = 1;
            cantidadCartones = 1;
            cantidadNumerosAJugar = 25;
            modalidad = 1;

            int numeroSalido = new int();
            numeroSalido = 3;
            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            List<WCF_Bingo.Clases.clsJugador> resultado = servicio.crearJugador(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);

            int res = resultado[0].ListaCartones[0].NumeroAReducirParaGanar;

            List<WCF_Bingo.Clases.clsJugador> re = servicio.actualizarEstados(resultado, numeroSalido);

            Assert.AreEqual(re[0].ListaCartones[0].NumeroAReducirParaGanar, 24);

        }
    }
}
