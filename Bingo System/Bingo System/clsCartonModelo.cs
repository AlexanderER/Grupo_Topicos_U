using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_System
{
    public class clsCartonModelo
    {
        private string nombre;
        private List<List<clsCelda>> columnas;

        public clsCartonModelo()
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();
            for (int x = 1; x <= 5; x++)
            {
                Columnas.Add(new List<clsCelda>());
                for (int p = 1; p <= 5; p++)
                {
                    clsCelda celda = new clsCelda();
                    
                    //celda.AJugar = mdModalidadJuego.esquema[x][p];

                    Columnas[x].Add(celda);

                }
            }

        }

        public List<List<clsCelda>> Columnas
        {
            get
            {
                return columnas;
            }

            set
            {
                columnas = value;
            }
        }
    }
}
