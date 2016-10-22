using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Prueba
{
    [TestClass]
    public class SuccessGenerarNumero
    {
        [TestMethod]
        public void GenerarNumeroSuccess()
        {
            Int32 numeroTecho = 5;

            List<int> lista = new List<int> { 1, 2, 3 };

            Int32 numeroEsperado = 4;


            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            Int32 resultado = servicio.GenerarNumero(numeroTecho, lista);

            Assert.AreEqual(resultado, numeroEsperado);

        }

        // metodo independiente de validación secundaria

        [TestMethod]
        public void GenerarNumeroSuccess2()
        {
            Int32 numeroTecho = 7;

            List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

            Int32 numeroEsperado = 6;


            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            Int32 resultado = servicio.GenerarNumero(numeroTecho, lista);

            Assert.AreEqual(resultado, numeroEsperado);

        }
    }
}
