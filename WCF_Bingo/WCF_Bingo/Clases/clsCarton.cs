using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    public class clsCarton //: clsCartonModelo
    {
        //----------------------------------------------------------------------------------

        #region Variables

        private int cantidadNumerosAJugar;
        private int numeroAReducirParaGanar;
        private List<List<clsCelda>> columnas;

        #endregion

        //----------------------------------------------------------------------------------

        #region Constructor

        public clsCarton() { }

        public clsCarton(int cantidadNumerosAJugar, int numeroAReducirParaGanar, List<List<clsCelda>> columnas)
        {
            this.CantidadNumerosAJugar = cantidadNumerosAJugar;
            this.numeroAReducirParaGanar = numeroAReducirParaGanar;
            this.Columnas = columnas;
        }

        public clsCarton(int cantidadNumerosAJugar, int modalidad)
        {
            this.columnas = new List<List<clsCelda>>();
            this.CantidadNumerosAJugar = cantidadNumerosAJugar;
            llenarCarton(elegirModalidad(modalidad));
            numeroAReducirParaGanar = definirNumeroAReducir();
        }

        #endregion

        //----------------------------------------------------------------------------------

        #region Metodos

        public void llenarCarton(List<List<clsCelda>> cartonModalidad)
        {
            List<int> numerosYaSorteados = new List<int>();
            int segmentos = CantidadNumerosAJugar / 5;
            for (int x = 1; x <= 5; x++)
            {
                int suelo = segmentos * (x - 1);
                int techo = segmentos * x;
                Columnas.Add(new List<clsCelda>());
                for (int p = 1; p <= 5; p++)
                {
                    
                    int nuevoNumero;
                    bool aJugarEnCelda;
                    Random rnd = new Random();

                    do
                    {
                        nuevoNumero = rnd.Next(suelo+1, techo+1);
                    }
                    while (numerosYaSorteados.Contains(nuevoNumero));
                    numerosYaSorteados.Add(nuevoNumero);

                    //x-1 ya que el for empieza en 1 y la lista en 0
                    aJugarEnCelda = cartonModalidad[x-1][p-1].AJugar;

                    Columnas[x-1].Add((new clsCelda(nuevoNumero, aJugarEnCelda)));

                }
            }
        }

        private int definirNumeroAReducir()
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int p = 0; p < 5; p++)
                {
                    if (Columnas[i][p].AJugar)
                    {
                        count++;
                    }
                }
            }
            return count;
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

        public new List<List<clsCelda>> Columnas
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

        #endregion

        //----------------------------------------------------------------------------------

        #region Modalidades
        private List<List<clsCelda>> elegirModalidad(int modalidad)
        {
            List<List<clsCelda>> cartonModalidad = new List<List<clsCelda>>();
            //this.columnas = new List<List<clsCelda>>();
            for (int x = 1; x <= 5; x++)
            {
                cartonModalidad.Add(new List<clsCelda>());
                for (int p = 1; p <= 5; p++)
                {
                    cartonModalidad[x - 1].Add(new clsCelda());
                }
            }

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
                            cartonModalidad[i][p].AJugar = true;
                        }
                    }
                    break;

                //    CUATRO_ESQUINAS = 2,
                case 2:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = false;
                    cartonModalidad[0][2].AJugar = false;
                    cartonModalidad[0][3].AJugar = false;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = false;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = false;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = false;
                    //N
                    cartonModalidad[2][0].AJugar = false;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = false;
                    //G
                    cartonModalidad[3][0].AJugar = false;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = false;
                    cartonModalidad[3][3].AJugar = false;
                    cartonModalidad[3][4].AJugar = false;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = false;
                    cartonModalidad[4][2].AJugar = false;
                    cartonModalidad[4][3].AJugar = false;
                    cartonModalidad[4][4].AJugar = true;
                    break;

                //    LETRA_H         = 3,
                case 3:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = true;
                    cartonModalidad[0][2].AJugar = true;
                    cartonModalidad[0][3].AJugar = true;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = false;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = true;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = false;
                    //N
                    cartonModalidad[2][0].AJugar = false;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = false;
                    //G
                    cartonModalidad[3][0].AJugar = false;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = true;
                    cartonModalidad[3][3].AJugar = false;
                    cartonModalidad[3][4].AJugar = false;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = true;
                    cartonModalidad[4][2].AJugar = true;
                    cartonModalidad[4][3].AJugar = true;
                    cartonModalidad[4][4].AJugar = true;
                    break;

                //    LETRA_X         = 4,
                case 4:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = false;
                    cartonModalidad[0][2].AJugar = false;
                    cartonModalidad[0][3].AJugar = false;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = false;
                    cartonModalidad[1][1].AJugar = true;
                    cartonModalidad[1][2].AJugar = false;
                    cartonModalidad[1][3].AJugar = true;
                    cartonModalidad[1][4].AJugar = false;
                    //N
                    cartonModalidad[2][0].AJugar = false;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = false;
                    //G
                    cartonModalidad[3][0].AJugar = false;
                    cartonModalidad[3][1].AJugar = true;
                    cartonModalidad[3][2].AJugar = false;
                    cartonModalidad[3][3].AJugar = true;
                    cartonModalidad[3][4].AJugar = false;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = false;
                    cartonModalidad[4][2].AJugar = false;
                    cartonModalidad[4][3].AJugar = false;
                    cartonModalidad[4][4].AJugar = true;
                    break;

                //    LETRA_O         = 5,
                case 5:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = true;
                    cartonModalidad[0][2].AJugar = true;
                    cartonModalidad[0][3].AJugar = true;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = true;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = false;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = true;
                    //N
                    cartonModalidad[2][0].AJugar = true;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = true;
                    //G
                    cartonModalidad[3][0].AJugar = true;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = false;
                    cartonModalidad[3][3].AJugar = false;
                    cartonModalidad[3][4].AJugar = true;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = true;
                    cartonModalidad[4][2].AJugar = true;
                    cartonModalidad[4][3].AJugar = true;
                    cartonModalidad[4][4].AJugar = true;
                    break;

                //    LETRA_U         = 6,
                case 6:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = true;
                    cartonModalidad[0][2].AJugar = true;
                    cartonModalidad[0][3].AJugar = true;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = false;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = false;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = true;
                    //N
                    cartonModalidad[2][0].AJugar = false;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = true;
                    //G
                    cartonModalidad[3][0].AJugar = false;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = false;
                    cartonModalidad[3][3].AJugar = false;
                    cartonModalidad[3][4].AJugar = true;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = true;
                    cartonModalidad[4][2].AJugar = true;
                    cartonModalidad[4][3].AJugar = true;
                    cartonModalidad[4][4].AJugar = true;
                    break;

                //    LETRA_P         = 7,
                case 7:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = true;
                    cartonModalidad[0][2].AJugar = true;
                    cartonModalidad[0][3].AJugar = true;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = true;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = true;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = false;
                    //N
                    cartonModalidad[2][0].AJugar = true;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = false;
                    //G
                    cartonModalidad[3][0].AJugar = true;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = true;
                    cartonModalidad[3][3].AJugar = false;
                    cartonModalidad[3][4].AJugar = true;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = true;
                    cartonModalidad[4][2].AJugar = true;
                    cartonModalidad[4][3].AJugar = false;
                    cartonModalidad[4][4].AJugar = false;
                    break;

                //    LETRA_A         = 8,
                case 8:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = true;
                    cartonModalidad[0][2].AJugar = true;
                    cartonModalidad[0][3].AJugar = true;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = true;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = true;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = false;
                    //N
                    cartonModalidad[2][0].AJugar = true;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = false;
                    //G
                    cartonModalidad[3][0].AJugar = true;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = true;
                    cartonModalidad[3][3].AJugar = false;
                    cartonModalidad[3][4].AJugar = false;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = true;
                    cartonModalidad[4][2].AJugar = true;
                    cartonModalidad[4][3].AJugar = true;
                    cartonModalidad[4][4].AJugar = true;
                    break;

                //    LETRA_E         = 9
                case 9:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = true;
                    cartonModalidad[0][2].AJugar = true;
                    cartonModalidad[0][3].AJugar = true;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = true;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = true;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = true;
                    //N
                    cartonModalidad[2][0].AJugar = true;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = true;
                    //G
                    cartonModalidad[3][0].AJugar = true;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = true;
                    cartonModalidad[3][3].AJugar = false;
                    cartonModalidad[3][4].AJugar = true;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = false;
                    cartonModalidad[4][2].AJugar = true;
                    cartonModalidad[4][3].AJugar = false;
                    cartonModalidad[4][4].AJugar = true;
                    break;

                //    LETRA_W         = 10
                case 10:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = true;
                    cartonModalidad[0][2].AJugar = true;
                    cartonModalidad[0][3].AJugar = true;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = false;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = false;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = true;
                    //N
                    cartonModalidad[2][0].AJugar = true;
                    cartonModalidad[2][1].AJugar = true;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = true;
                    cartonModalidad[2][4].AJugar = true;
                    //G
                    cartonModalidad[3][0].AJugar = false;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = false;
                    cartonModalidad[3][3].AJugar = false;
                    cartonModalidad[3][4].AJugar = true;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = true;
                    cartonModalidad[4][2].AJugar = true;
                    cartonModalidad[4][3].AJugar = true;
                    cartonModalidad[4][4].AJugar = true;
                    break;
                //    LETRA_R         = 11
                case 11:
                    //B
                    cartonModalidad[0][0].AJugar = true;
                    cartonModalidad[0][1].AJugar = true;
                    cartonModalidad[0][2].AJugar = true;
                    cartonModalidad[0][3].AJugar = true;
                    cartonModalidad[0][4].AJugar = true;
                    //I
                    cartonModalidad[1][0].AJugar = true;
                    cartonModalidad[1][1].AJugar = false;
                    cartonModalidad[1][2].AJugar = true;
                    cartonModalidad[1][3].AJugar = false;
                    cartonModalidad[1][4].AJugar = false;
                    //N
                    cartonModalidad[2][0].AJugar = true;
                    cartonModalidad[2][1].AJugar = false;
                    cartonModalidad[2][2].AJugar = false;
                    cartonModalidad[2][3].AJugar = false;
                    cartonModalidad[2][4].AJugar = false;
                    //G
                    cartonModalidad[3][0].AJugar = true;
                    cartonModalidad[3][1].AJugar = false;
                    cartonModalidad[3][2].AJugar = true;
                    cartonModalidad[3][3].AJugar = true;
                    cartonModalidad[3][4].AJugar = false;
                    //O
                    cartonModalidad[4][0].AJugar = true;
                    cartonModalidad[4][1].AJugar = true;
                    cartonModalidad[4][2].AJugar = true;
                    cartonModalidad[4][3].AJugar = false;
                    cartonModalidad[4][4].AJugar = true;
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
