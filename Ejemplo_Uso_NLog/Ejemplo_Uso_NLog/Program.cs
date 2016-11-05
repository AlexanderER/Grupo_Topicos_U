using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Ejemplo_Uso_NLog
{
    class Program
    {
        //--------------------------------------------------------------------
        private static Logger logger = LogManager.GetCurrentClassLogger();  //
        //--------------------------------------------------------------------

        static void Main(string[] args)
        {
            //--------------------------------------------------------------------
            logger.Trace("Ejemplo log tipo 'Trace'");
            logger.Debug("Ejemplo log tipo 'Debug'");
            logger.Info("Ejemplo log tipo 'Info'");
            logger.Warn("Ejemplo log tipo 'Warning'");
            logger.Error("Ejemplo log tipo 'Error'");
            logger.Fatal("Ejemplo log tipo 'Fatal'");

            Console.ReadLine();
            //--------------------------------------------------------------------
        }
    }
}
