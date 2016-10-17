using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_System.LogicaNegocio
{
    public class Logica
    {
        #region Variables

        /// <summary>
        /// ENUM que contiene las modalidades de Juego del Bingo
        /// </summary>
        public enum MODALIDAD_JUEGO
        {
            INDEFINIDO      = 0,
            CARTON_LLENO    = 1,
            CUATRO_ESQUINAS = 2,
            LETRA_H         = 3,
            LETRA_X         = 4,
            LETRA_O         = 5,
            LETRA_U         = 6,
            LETRA_P         = 7,
            LETRA_A         = 8,
            LETRA_E         = 9,
            LETRA_W         = 10,
            LETRA_R         = 11
        }

        #endregion
    }
}
