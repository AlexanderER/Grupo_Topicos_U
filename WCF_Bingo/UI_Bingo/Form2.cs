﻿using System;
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
            //Console.WriteLine("Hola");
            //cmbTiposJuego.Items.Add("Cartón lleno");
            //cmbTiposJuego.Items.Add("Cuatro esquinas");
            //cmbTiposJuego.Items.Add("Letra H");
            //cmbTiposJuego.Items.Add("Letra X");
            //
            //
            //Letra O
            //Letra U
            //Letra P
            //Letra A
            //Letra E
            //Letra W
            //Letra R
            //")

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
            Console.WriteLine("Dentro del IF");
            for (int i = 0; i < int.Parse(txtNumeroJugadores.Text); i++)
            {
                Console.WriteLine("Dentro del for");
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
                txtNumeroJugadores.Enabled = false;
                txtNumeroCartones.Text = "";
                txtNumMax.Enabled = false;
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
            if (int.Parse(txtNumMax.Text) < 25) { MessageBox.Show("Digite unicamente números mayores a 24", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1); }
        }
    }


}
