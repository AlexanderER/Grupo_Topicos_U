using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Logica
    {
        #region Variables

        /// <summary>
        /// ENUM que contiene las modalidades de Juego del Bingo
        /// </summary>
        public enum MODALIDAD_JUEGO
        {
            CARTON_LLENO = 0,
            CUATRO_ESQUINAS = 1,
            LETRA_H = 2,
            LETRA_X = 3,
            LETRA_O = 4,
            LETRA_U = 5,
            LETRA_P = 6,
            LETRA_A = 7,
            LETRA_E = 8,
            LETRA_W = 9,
            LETRA_R = 10
        }

        #endregion
    }
}
