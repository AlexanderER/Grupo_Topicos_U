using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    class clsCarton : clsCartonModelo
    {
        //----------------------------------------------------------------------------------

        #region Variables

        private int cantidadNumerosAJugar;
        private int numeroAReducirParaGanar;

        #endregion

        //----------------------------------------------------------------------------------

        #region Constructor

        public clsCarton()
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();            
        }

        public clsCarton(int cantidadNumerosAJugar, clsCartonModelo cartonModalidad)
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();
            this.CantidadNumerosAJugar = cantidadNumerosAJugar;
            llenarCarton(cartonModalidad);
        }

        #endregion

        //----------------------------------------------------------------------------------

        #region Metodos

        public void llenarCarton(clsCartonModelo cartonModalidad)
        {
            List<int> numerosYaSorteados = new List<int>();
            int segmentos = CantidadNumerosAJugar / 5;
            for (int x = 1; x <= 5; x++)
            {
                Columnas.Add(new List<clsCelda>());
                for (int p = 1; p <= 5; p++)
                {
                    int suelo = segmentos * (p - 1);
                    int techo = segmentos * p;
                    int nuevoNumero;
                    clsCelda celda = new clsCelda();
                    Random rnd = new Random();

                    do
                    {
                        nuevoNumero = rnd.Next(suelo, techo);
                    }
                    while (numerosYaSorteados.Contains(nuevoNumero));
                    numerosYaSorteados.Add(nuevoNumero);

                    celda.Numero = nuevoNumero;

                    //x-1 ya que el for empieza en 1 y la lista en 0
                    celda.AJugar = cartonModalidad.Columnas[x-1][p-1].AJugar;

                    Columnas[x].Add(celda);

                }
            }
        }

        #endregion

        //----------------------------------------------------------------------------------

        #region Sets y Gets

        public int CantidadNumerosAJugar
        {
            get
            {
                return cantidadNumerosAJugar;
            }

            set
            {
                cantidadNumerosAJugar = value;
            }
        }

        public int NumeroAReducirParaGanar
        {
            get
            {
                return numeroAReducirParaGanar;
            }

            set
            {
                numeroAReducirParaGanar = value;
            }
        }

        #endregion
    }
}
