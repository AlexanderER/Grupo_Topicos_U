using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Bingo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 ventana = new Form4();
            ventana.Show();
         }






        #region Eventos

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (clsGlobal.ListaNumerosFavorecidos.Count == clsGlobal.iLimiteNumerosBingo)
            {
                MessageBox.Show("Ya no quedan numero por jugar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //----------------------------------------------------------------------------------------   Obtengo el Numero 
                // Traslado la lista a un arreglo ya que el metodo solicita un arreglo
                Int32[] arrayDeNumeros = new Int32[clsGlobal.ListaNumerosFavorecidos.Count];
                clsGlobal.ListaNumerosFavorecidos.CopyTo(arrayDeNumeros);

                // Instancio el WCF y ejecuto el proceso de obtener numero
                miServicio.Service1Client WCF_Service = new miServicio.Service1Client();
                Int32 iNumeroObtenido                 = WCF_Service.GenerarNumero(clsGlobal.iLimiteNumerosBingo, arrayDeNumeros);

                // Agrego el numero a la Lista de Numero Favorecidos
                clsGlobal.ListaNumerosFavorecidos.Add(iNumeroObtenido);

                // Muestro en pantalla el numero que salio
                MessageBox.Show("Con la letra de la: " + this.obtenerLetraNumeroFavorecido(iNumeroObtenido) + 
                                Environment.NewLine +
                                "El Número: " + iNumeroObtenido.ToString());





                //----------------------------------------------------------------------------------------   Hacer Validaciones en Cartones

            }




        }

        #endregion





        private String obtenerLetraNumeroFavorecido(Int32 p_sInumero)
        {
            String sLetra = "";

            Int32 iRango = (clsGlobal.iLimiteNumerosBingo / 5); // Divido entre cinco que son la cantidad de letras de "B I N G O"

            if (p_sInumero <= (iRango*1))   // LETRA B
            {
                sLetra = "B";
            }
            else
            {
                if (p_sInumero <= (iRango*2))   // LETRA I
                {
                    sLetra = "I";
                }
                else
                {
                    if (p_sInumero <= (iRango * 3)) // LETRA N
                    {
                        sLetra = "N";
                    }
                    else
                    {
                        if (p_sInumero <= (iRango * 4)) // LETRA G
                        {
                            sLetra = "G";
                        }
                        else
                        {
                            if (p_sInumero <= (iRango * 5)) // LETRA O
                            {
                                sLetra = "O";
                            }
                            else
                            {
                                sLetra = "";
                            }
                        }
                    }
                }
            }

            return sLetra;
        }



    }
}
