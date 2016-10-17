﻿using System;
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

        public static Int32 iLimiteNumerosBingo = 25;   // Se inicializa en 25 ya que es el numero minimo.

        LogicaNegocio.Logica.MODALIDAD_JUEGO mdModalidadJuego = Logica.MODALIDAD_JUEGO.INDEFINIDO;

        #endregion
    }
}
