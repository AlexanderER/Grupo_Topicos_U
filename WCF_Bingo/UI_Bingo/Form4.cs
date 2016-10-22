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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Instancio el WCF y ejecuto el proceso de obtener numero
            miServicio.Service1Client WCF_Service = new miServicio.Service1Client();
      
            for (int i = 0; i < WCF_Service.cantidadJugadores(clsGlobal.ListaJugador); i++)
            {

                this.cmbNumJugador.Items.Add(i + 1);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
