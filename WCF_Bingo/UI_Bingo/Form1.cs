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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 ventana = new Form2();
            ventana.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (clsGlobal.ListaJugador.Count == 0)
            {
                MessageBox.Show("El juego no se ha creado, inicialícelo para habilitar esta opción.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
            Form3 ventana = new Form3();
            ventana.Show();
        }
        }
    }
}
