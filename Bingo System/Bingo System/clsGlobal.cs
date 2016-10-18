using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bingo_System.LogicaNegocio;


namespace Bingo_System
{
    class clsGlobal
    {
        #region Variables Globales de Configuracion del Bingo

        // Se inicializa en 25 ya que es el numero minimo.
        public static Int32 iLimiteNumerosBingo = 25;   


        // Indica la Modalidad de Bingo a Jugar
        public static Logica.MODALIDAD_JUEGO mdModalidadJuego = Logica.MODALIDAD_JUEGO.INDEFINIDO;


        // Listado de Numeros Favorecidos (Son los numeros que ya han salido en el sorteo)
        public static List<Int32> ListaNumerosFavorecidos;


        public static List<Clases.clsJugador> ListaJugadores = new List<Clases.clsJugador>();


        #endregion

        //Recorre lista de cartones y busca ID carton
        public List<clsCarton> buscarJugador(int idJugador)
        {
            throw new System.NotImplementedException();
        }
    }
}
