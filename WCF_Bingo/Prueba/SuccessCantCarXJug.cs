using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class SuccessCantCarXJug
    {
        [TestMethod]
        public void CantidadCartonesXJugadorSuccess()
        {
            List<WCF_Bingo.Clases.clsJugador> listaJugadores = new List<WCF_Bingo.Clases.clsJugador>();

            int nombreUsuario = new int();
            int cantidadCartones = new int();
            int cantidadNumerosAJugar = new int();
            int modalidad = new int();

            // listaJugadores.Add(jugador);

            nombreUsuario = 1;
            cantidadCartones = 2;
            cantidadNumerosAJugar = 25;
            modalidad = 1;


            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            listaJugadores = servicio.crearJugador(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);
            int cantCarXJugador = servicio.cantidadCartonesPorJugador(listaJugadores, 1);

            Assert.AreEqual(cantCarXJugador, cantidadCartones);

        }
    }
}
