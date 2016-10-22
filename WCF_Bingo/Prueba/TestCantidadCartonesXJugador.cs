using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class TestCantidadCartonesXJugador
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

            //(List<clsJugador> listaJugadores, int numeroJugador)

        }
    }
}
