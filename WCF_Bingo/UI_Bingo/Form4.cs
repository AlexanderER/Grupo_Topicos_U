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
            carton=  WCF_Service.consultarCarton(clsGlobal.ListaJugador, Convert.ToInt32(cmbNumJugador.Text), Convert.ToInt32(cmbNumCarton.Text)-1);
            temp = carton.Columnas[0];
            lbl00.Text = Convert.ToString(temp[0].Numero);
            lbl01.Text = Convert.ToString(temp[1].Numero);
            lbl02.Text = Convert.ToString(temp[2].Numero);
            lbl03.Text = Convert.ToString(temp[3].Numero);
            lbl04.Text = Convert.ToString(temp[4].Numero);

            temp = carton.Columnas[1];
            lbl10.Text = Convert.ToString(temp[0].Numero);
            lbl11.Text = Convert.ToString(temp[1].Numero);
            lbl12.Text = Convert.ToString(temp[2].Numero);
            lbl13.Text = Convert.ToString(temp[3].Numero);
            lbl14.Text = Convert.ToString(temp[4].Numero);

            temp = carton.Columnas[2];
            lbl20.Text = Convert.ToString(temp[0].Numero);
            lbl21.Text = Convert.ToString(temp[1].Numero);
            //lbl22.Text = Convert.ToString(temp[2].Numero);
            lbl23.Text = Convert.ToString(temp[3].Numero);
            lbl24.Text = Convert.ToString(temp[4].Numero);

            temp = carton.Columnas[3];
            lbl30.Text = Convert.ToString(temp[0].Numero);
            lbl31.Text = Convert.ToString(temp[1].Numero);
            lbl32.Text = Convert.ToString(temp[2].Numero);
            lbl33.Text = Convert.ToString(temp[3].Numero);
            lbl34.Text = Convert.ToString(temp[4].Numero);

            temp = carton.Columnas[4];
            lbl40.Text = Convert.ToString(temp[0].Numero);
            lbl41.Text = Convert.ToString(temp[1].Numero);
            lbl42.Text = Convert.ToString(temp[2].Numero);
            lbl43.Text = Convert.ToString(temp[3].Numero);
            lbl44.Text = Convert.ToString(temp[4].Numero);

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
