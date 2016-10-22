using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Prueba
{
    [TestClass]
    public class SuccessGanadores
    {
        [TestMethod]
        public void Ganadores()
        {
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

           // int numeroSalido = new int();
            // numeroSalido = 1;
            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            List<WCF_Bingo.Clases.clsJugador> resultado = servicio.crearJugador(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);

            int res = resultado[0].ListaCartones[0].NumeroAReducirParaGanar;

            List<WCF_Bingo.Clases.clsJugador> ganadores = new List<WCF_Bingo.Clases.clsJugador>();

            List<WCF_Bingo.Clases.clsJugador> re = new List<WCF_Bingo.Clases.clsJugador>();
            for (int p=1; p <= 25; p++)
            {
                resultado = servicio.actualizarEstados(resultado, p);
                ganadores = servicio.jugadoresGanadores(resultado);
                if(ganadores.Count >= 1)
                {
                    break;
                }
            }

            Assert.AreEqual(ganadores.Count, 1);
        }

        //addicional


        [TestMethod]
        public void Ganadores2()
        {
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

            // int numeroSalido = new int();
            // numeroSalido = 1;
            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            List<WCF_Bingo.Clases.clsJugador> resultado = servicio.crearJugador(listaJugadores, nombreUsuario, cantidadCartones, cantidadNumerosAJugar, modalidad);

            int res = resultado[0].ListaCartones[0].NumeroAReducirParaGanar;

            List<WCF_Bingo.Clases.clsJugador> ganadores = new List<WCF_Bingo.Clases.clsJugador>();

            List<WCF_Bingo.Clases.clsJugador> re = new List<WCF_Bingo.Clases.clsJugador>();
            for (int p = 1; p <= 25; p++)
            {
                resultado = servicio.actualizarEstados(resultado, p);
                ganadores = servicio.jugadoresGanadores(resultado);
                if (ganadores.Count >= 1)
                {
                    break;
                }
            }

            Assert.AreEqual(ganadores.Count, 1);
        }



    }
}
