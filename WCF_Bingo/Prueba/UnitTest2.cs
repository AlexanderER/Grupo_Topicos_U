using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Int32 numeroTecho = 5;

            //Int32[] lista = new Int32[] { 1, 2, 3 };

            //Int32 numeroEsperado = 4;
            List<WCF_Bingo.Clases.clsJugador> listaJugadores = new List<WCF_Bingo.Clases.clsJugador>();

            int nombreUsuario = new int();
            int cantidadCartones = new int();
            int cantidadNumerosAJugar = new int();
            int modalidad = new int();

            nombreUsuario = 1;
            cantidadCartones = 1;
            cantidadNumerosAJugar = 50;
            modalidad = 4;



            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            Int32 resultado = servicio.crearJugador(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);

            Assert.IsNotNull(resultado);
        }

    }
}
