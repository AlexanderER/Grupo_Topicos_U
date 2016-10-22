using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class TestCrearJugador
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            //Creo el objeto jugador     
            WCF_Bingo.Clases.clsJugador jugador = new WCF_Bingo.Clases.clsJugador();
            jugador.NombreJugador = 1;
            jugador.ListaCartones = null;

            //Creo lista
            List<WCF_Bingo.Clases.clsJugador> listaJugadores = new List<WCF_Bingo.Clases.clsJugador>();

            int nombreUsuario = new int();
            int cantidadCartones = new int();
            int cantidadNumerosAJugar = new int();
            int modalidad = new int();

            listaJugadores.Add(jugador);
            nombreUsuario = 1;
            cantidadCartones = 1;
            cantidadNumerosAJugar = 50;
            modalidad = 4;



            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            List<WCF_Bingo.Clases.clsJugador> resultado = servicio.crearJugador(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);

            Assert.IsNotNull(resultado);
        }

    }
}
