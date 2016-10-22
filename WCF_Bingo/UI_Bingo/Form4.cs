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


        private void cmbNumJugador_Leave(object sender, EventArgs e)
        {
            this.cmbNumCarton.Items.Clear();
            miServicio.Service1Client WCF_Service = new miServicio.Service1Client();

            for (int i = 0; i < WCF_Service.cantidadCartonesPorJugador(clsGlobal.ListaJugador, Convert.ToInt32(this.cmbNumJugador.Text)); i++)
            {

                this.cmbNumCarton.Items.Add(i + 1);
            }
        }

        private void cmbNumJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbNumCarton.Items.Clear();
            //miServicio.Service1Client WCF_Service = new miServicio.Service1Client();

            //for (int i = 0; i < WCF_Service.cantidadCartonesPorJugador(clsGlobal.ListaJugador, Convert.ToInt32(this.cmbNumJugador.Text)); i++)
            //{

            //    this.cmbNumCarton.Items.Add(i + 1);
            //}
        }

        private void cmbNumCarton_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<WCF_Bingo.Clases.clsCelda> temp;
            miServicio.Service1Client WCF_Service = new miServicio.Service1Client();
            WCF_Bingo.Clases.clsCarton carton = new WCF_Bingo.Clases.clsCarton();
              carton=  WCF_Service.consultarCarton(clsGlobal.ListaJugador, Convert.ToInt32(cmbNumJugador.Text), Convert.ToInt32(cmbNumCarton.Text));
            for (int i = 0; i < 5; i++) {
               // for (int j = 0; j < 5; j++) {
                    temp = carton.Columnas[i];
                   // carton.[x].ListaCartones[i].Columnas[p][q].Numero == jugador.ListaCartones[z].Columnas[p][q].Numero))
                    lbl00.Text = Convert.ToString(temp[0].Numero);
                    //System.Diagnostics.Trace.WriteLine(Convert.ToString(temp[0].Numero));
               // }
            }


        }
    }
}
