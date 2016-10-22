using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Prueba
{
    [TestClass]
    public class TestGenerarNumero
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int32 numeroTecho = 5;

            Int32[] lista =new Int32[] { 1, 2, 3 };
            
            Int32 numeroEsperado = 4;


            ServiceReference1.Service1Client servicio = new ServiceReference1.Service1Client();
            Int32 resultado = servicio.GenerarNumero(numeroTecho, lista);

            Assert.AreEqual(resultado, numeroEsperado);
            
        }
    }
}
