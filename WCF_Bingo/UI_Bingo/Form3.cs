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
            miServicio.Service1Client WCF_Service = new miServicio.Service1Client();

            Int32 iNumeroObtenido = WCF_Service.GenerarNumero(clsGlobal.iLimiteNumerosBingo, null);

            //clsGlobal.ListaNumerosFavorecidos.Add(iNumeroObtenido);

            MessageBox.Show("Salio el: " + iNumeroObtenido.ToString());
        }

        #endregion



    }
}
