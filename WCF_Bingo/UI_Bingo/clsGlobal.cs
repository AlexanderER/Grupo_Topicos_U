using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Bingo
{
    class clsGlobal
    {

        #region Variables Globales de Configuracion del Bingo

        // Se inicializa en 25 ya que es el numero minimo.
        public static Int32 iLimiteNumerosBingo = 25;

        // Listado de Numeros Favorecidos (Son los numeros que ya han salido en el sorteo)
        public static List<Int32> ListaNumerosFavorecidos = new List<Int32>();

        public static List<Clases.clsJugador> ListaJugador = new List<Clases.clsJugador>();


        #endregion

    }
}
