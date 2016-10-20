using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    public class clsCartonModelo
    {
        //----------------------------------------------------------------------------------

        #region Variables
        private string nombre;
        private List<List<clsCelda>> columnas;

        #endregion

        //----------------------------------------------------------------------------------

        #region Constructor

        public clsCartonModelo()
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();
            for (int x = 1; x <= 5; x++)
            {
                Columnas.Add(new List<clsCelda>());
                for (int p = 1; p <= 5; p++)
                {
                    clsCelda celda = new clsCelda();
                    Columnas[x].Add(celda);
                }
            }

        }

        #endregion

        //----------------------------------------------------------------------------------

        #region Sets y Gets

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

        #endregion
    }
}
