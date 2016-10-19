using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Bingo.Clases
{
    class clsCarton : clsCartonModelo
    {
        private int cantidadNumerosAJugar;
        private int numeroAReducirParaGanar;


        public clsCarton()
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();
            llenarCarton();
        }
        public clsCarton(int cantidadNumerosAJugar)
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();
            //this.CantidadNumerosAJugar = clsGlobal.iLimiteNumerosBingo;
            llenarCarton();
        }

        public void llenarCarton()
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


                    Columnas[x].Add(celda);

                }
            }
        }

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
    }
}
