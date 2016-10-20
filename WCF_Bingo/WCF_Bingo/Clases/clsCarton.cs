using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    public class clsCarton : clsCartonModelo
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

        public clsCarton(int cantidadNumerosAJugar, int modalidad)
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();
            this.CantidadNumerosAJugar = cantidadNumerosAJugar;
            llenarCarton(elegirModalidad(modalidad));
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

        //----------------------------------------------------------------------------------

        #region Modalidades
        private clsCartonModelo elegirModalidad(int modalidad)
        {
            clsCartonModelo cartonModalidad = new clsCartonModelo();

            switch (modalidad)
            {
                case 0:
                    throw new System.ArgumentException("Modalidad no puede ser 0", "original");
                //break;

                // CARTON_LLENO
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        for (int p = 0; p < 5; p++)
                        {
                            cartonModalidad.Columnas[i][p].AJugar = true;
                        }
                    }
                    break;

                //    CUATRO_ESQUINAS = 2,
                case 2:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = false;
                    cartonModalidad.Columnas[0][2].AJugar = false;
                    cartonModalidad.Columnas[0][3].AJugar = false;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = false;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = false;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = false;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = false;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = false;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = false;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = false;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = false;
                    cartonModalidad.Columnas[3][3].AJugar = false;
                    cartonModalidad.Columnas[3][4].AJugar = false;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = false;
                    cartonModalidad.Columnas[4][2].AJugar = false;
                    cartonModalidad.Columnas[4][3].AJugar = false;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;

                //    LETRA_H         = 3,
                case 3:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = true;
                    cartonModalidad.Columnas[0][2].AJugar = true;
                    cartonModalidad.Columnas[0][3].AJugar = true;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = false;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = true;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = false;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = false;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = true;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = false;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = false;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = true;
                    cartonModalidad.Columnas[3][3].AJugar = false;
                    cartonModalidad.Columnas[3][4].AJugar = false;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = true;
                    cartonModalidad.Columnas[4][2].AJugar = true;
                    cartonModalidad.Columnas[4][3].AJugar = true;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;

                //    LETRA_X         = 4,
                case 4:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = false;
                    cartonModalidad.Columnas[0][2].AJugar = false;
                    cartonModalidad.Columnas[0][3].AJugar = false;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = false;
                    cartonModalidad.Columnas[1][1].AJugar = true;
                    cartonModalidad.Columnas[1][2].AJugar = false;
                    cartonModalidad.Columnas[1][3].AJugar = true;
                    cartonModalidad.Columnas[1][4].AJugar = false;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = false;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = true;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = false;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = false;
                    cartonModalidad.Columnas[3][1].AJugar = true;
                    cartonModalidad.Columnas[3][2].AJugar = false;
                    cartonModalidad.Columnas[3][3].AJugar = true;
                    cartonModalidad.Columnas[3][4].AJugar = false;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = false;
                    cartonModalidad.Columnas[4][2].AJugar = false;
                    cartonModalidad.Columnas[4][3].AJugar = false;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;

                //    LETRA_O         = 5,
                case 5:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = true;
                    cartonModalidad.Columnas[0][2].AJugar = true;
                    cartonModalidad.Columnas[0][3].AJugar = true;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = true;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = false;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = true;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = true;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = false;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = true;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = true;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = false;
                    cartonModalidad.Columnas[3][3].AJugar = false;
                    cartonModalidad.Columnas[3][4].AJugar = true;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = true;
                    cartonModalidad.Columnas[4][2].AJugar = true;
                    cartonModalidad.Columnas[4][3].AJugar = true;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;

                //    LETRA_U         = 6,
                case 6:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = true;
                    cartonModalidad.Columnas[0][2].AJugar = true;
                    cartonModalidad.Columnas[0][3].AJugar = true;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = false;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = false;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = true;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = false;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = false;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = true;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = false;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = false;
                    cartonModalidad.Columnas[3][3].AJugar = false;
                    cartonModalidad.Columnas[3][4].AJugar = true;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = true;
                    cartonModalidad.Columnas[4][2].AJugar = true;
                    cartonModalidad.Columnas[4][3].AJugar = true;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;

                //    LETRA_P         = 7,
                case 7:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = true;
                    cartonModalidad.Columnas[0][2].AJugar = true;
                    cartonModalidad.Columnas[0][3].AJugar = true;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = true;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = true;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = false;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = true;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = false;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = false;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = true;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = true;
                    cartonModalidad.Columnas[3][3].AJugar = false;
                    cartonModalidad.Columnas[3][4].AJugar = true;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = true;
                    cartonModalidad.Columnas[4][2].AJugar = true;
                    cartonModalidad.Columnas[4][3].AJugar = false;
                    cartonModalidad.Columnas[4][4].AJugar = false;
                    break;

                //    LETRA_A         = 8,
                case 8:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = true;
                    cartonModalidad.Columnas[0][2].AJugar = true;
                    cartonModalidad.Columnas[0][3].AJugar = true;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = true;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = true;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = false;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = true;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = false;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = false;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = true;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = true;
                    cartonModalidad.Columnas[3][3].AJugar = false;
                    cartonModalidad.Columnas[3][4].AJugar = false;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = true;
                    cartonModalidad.Columnas[4][2].AJugar = true;
                    cartonModalidad.Columnas[4][3].AJugar = true;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;

                //    LETRA_E         = 9
                case 9:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = true;
                    cartonModalidad.Columnas[0][2].AJugar = true;
                    cartonModalidad.Columnas[0][3].AJugar = true;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = true;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = true;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = true;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = true;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = false;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = true;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = true;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = true;
                    cartonModalidad.Columnas[3][3].AJugar = false;
                    cartonModalidad.Columnas[3][4].AJugar = true;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = false;
                    cartonModalidad.Columnas[4][2].AJugar = true;
                    cartonModalidad.Columnas[4][3].AJugar = false;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;

                //    LETRA_W         = 10
                case 10:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = true;
                    cartonModalidad.Columnas[0][2].AJugar = true;
                    cartonModalidad.Columnas[0][3].AJugar = true;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = false;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = false;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = true;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = true;
                    cartonModalidad.Columnas[2][1].AJugar = true;
                    cartonModalidad.Columnas[2][2].AJugar = false;
                    cartonModalidad.Columnas[2][3].AJugar = true;
                    cartonModalidad.Columnas[2][4].AJugar = true;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = false;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = false;
                    cartonModalidad.Columnas[3][3].AJugar = false;
                    cartonModalidad.Columnas[3][4].AJugar = true;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = true;
                    cartonModalidad.Columnas[4][2].AJugar = true;
                    cartonModalidad.Columnas[4][3].AJugar = true;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;
                //    LETRA_R         = 11
                case 11:
                    //B
                    cartonModalidad.Columnas[0][0].AJugar = true;
                    cartonModalidad.Columnas[0][1].AJugar = true;
                    cartonModalidad.Columnas[0][2].AJugar = true;
                    cartonModalidad.Columnas[0][3].AJugar = true;
                    cartonModalidad.Columnas[0][4].AJugar = true;
                    //I
                    cartonModalidad.Columnas[1][0].AJugar = true;
                    cartonModalidad.Columnas[1][1].AJugar = false;
                    cartonModalidad.Columnas[1][2].AJugar = true;
                    cartonModalidad.Columnas[1][3].AJugar = false;
                    cartonModalidad.Columnas[1][4].AJugar = false;
                    //N
                    cartonModalidad.Columnas[2][0].AJugar = true;
                    cartonModalidad.Columnas[2][1].AJugar = false;
                    cartonModalidad.Columnas[2][2].AJugar = false;
                    cartonModalidad.Columnas[2][3].AJugar = false;
                    cartonModalidad.Columnas[2][4].AJugar = false;
                    //G
                    cartonModalidad.Columnas[3][0].AJugar = true;
                    cartonModalidad.Columnas[3][1].AJugar = false;
                    cartonModalidad.Columnas[3][2].AJugar = true;
                    cartonModalidad.Columnas[3][3].AJugar = true;
                    cartonModalidad.Columnas[3][4].AJugar = false;
                    //O
                    cartonModalidad.Columnas[4][0].AJugar = true;
                    cartonModalidad.Columnas[4][1].AJugar = true;
                    cartonModalidad.Columnas[4][2].AJugar = true;
                    cartonModalidad.Columnas[4][3].AJugar = false;
                    cartonModalidad.Columnas[4][4].AJugar = true;
                    break;

                default:
                    Console.WriteLine("No se eligio modalidad");
                    break;
            }

            return cartonModalidad;
        }
        #endregion

    }
}
