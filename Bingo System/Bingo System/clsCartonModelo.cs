using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_System
{
    class clsCartonModelo
    {
        private List<List<bool>> columnas;
        private string nombre;

        public clsCartonModelo() { }


        public List<List<bool>> Columnas
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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}
