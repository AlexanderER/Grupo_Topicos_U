using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bingo_System
{
    public class clsCarton
    {
        private int cantidadNumerosAJugar;
        private int numeroAReducirParaGanar;
        private List<List<clsCelda>> columnas;

        public clsCarton()
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();
            llenarCarton();
        }
        public clsCarton(int cantidadNumerosAJugar)
        {
            List<List<clsCelda>> columnas = new List<List<clsCelda>>();
            this.CantidadNumerosAJugar = clsGlobal.iLimiteNumerosBingo;
            llenarCarton();
        }

        public void llenarCarton()
        {
            List<int> numerosYaSorteados = new List<int>();
            int segmentos = CantidadNumerosAJugar / 5;
            for (int x = 1; x <=5; x++)
            {
                columnas.Add(new List<clsCelda>());
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

                    //Aqui tener carton modelo
                    if (clsCartonModelo.Columnas[x][p])
                    {
                        celda.AJugar = true;
                    }
                    else
                    {
                        celda.AJugar = false;
                    }
                    columnas[x].Add(celda);

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