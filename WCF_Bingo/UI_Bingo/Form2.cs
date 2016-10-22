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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void txtNumeroJugadores_Leave_1(object sender, EventArgs e)
        {
            if (txtNumeroJugadores.Text.Equals("")) { txtNumeroJugadores.Text = "0";}
            this.cmbNumeroJugadores.Items.Clear();
           
            for (int i = 0; i < int.Parse(txtNumeroJugadores.Text); i++)
            {
               
                this.cmbNumeroJugadores.Items.Add(i + 1);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNumeroCartones.Text.Equals("") | (cmbNumeroJugadores.SelectedIndex.Equals(null))) { MessageBox.Show("No ha ingresado valores válidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); }
            else
            {
                //-------------------------------------------------------------------------------------------   Defino los parametros del Juego 
                clsGlobal.iLimiteNumerosBingo = Convert.ToInt32(txtNumMax.Text);    // Cantidad Maxima de Numeros
                clsGlobal.iModalidadJuego     = cmbTiposJuego.SelectedIndex + 1;    // Defino la Modalidad de Juego



                //-------------------------------------------------------------------------------------------   Agregar Jugador
                miServicio.Service1Client WCF_Service = new miServicio.Service1Client();    // Instancio el Sevicio
                List<WCF_Bingo.Clases.clsJugador> listaRespaldo = clsGlobal.ListaJugador;   // Lista de respaldo por si da alguna excepcion restaurar la ultima version

                //clsGlobal.ListaJugador.Clear(); // Limpio la Lista Global (Omitir)

                String sTempJuga = this.cmbNumeroJugadores.Text;
                String sTempCart = this.txtNumeroCartones.Text;

                Int32 iNumeroUsuario = Convert.ToInt32(sTempJuga);                //this.cmbNumeroJugadores.SelectedIndex + 1;
                Int32 iNumCartonesJugador = Convert.ToInt32(sTempCart);  //Convert.ToInt32(this.txtNumeroCartones.Text);

                clsGlobal.ListaJugador = WCF_Service.crearJugador(clsGlobal.ListaJugador, iNumeroUsuario, iNumCartonesJugador, clsGlobal.iLimiteNumerosBingo, clsGlobal.iModalidadJuego);

                MessageBox.Show("El jugador " + iNumeroUsuario.ToString() + " se agrego exitosamente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //--------------------------------------------------------------------------------------------------
                // Actualizo la Ventana
                txtNumeroJugadores.Enabled = false;
                cmbTiposJuego.Enabled      = false;
                txtNumeroCartones.Text     = "";
                txtNumMax.Enabled          = false;
                cmbNumeroJugadores.Items.RemoveAt(cmbNumeroJugadores.SelectedIndex);

            }
            if (cmbNumeroJugadores.Items.Count == 0) {
                cmbNumeroJugadores.Enabled = false; }

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ventana = new Form3();
            ventana.Show();
            this.Hide();
        }

        private void txtNumMax_Leave(object sender, EventArgs e)
        {
            //clsGlobal.iLimiteNumerosBingo = Convert.ToInt32(txtNumMax.Text);


            if (int.Parse(txtNumMax.Text) < 25) { MessageBox.Show("Digite unicamente números mayores a 24", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1); }
        }
    }


}
