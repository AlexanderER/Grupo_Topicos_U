using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class SuccessCrearJugador
    {
        [TestMethod]
        public void CrearJugadorSuccess()
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
            cantidadNumerosAJugar = 50;
            modalidad = 4;


            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            List<WCF_Bingo.Clases.clsJugador> resultado = servicio.crearJugador(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);

            Assert.AreEqual(1,resultado.Count);
        
    }
    }
}
