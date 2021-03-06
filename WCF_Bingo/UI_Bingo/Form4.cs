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
            if (temp[0].Numerojugado == false) { lbl00.Text = Convert.ToString(temp[0].Numero);
                this.lbl00.BackColor = System.Drawing.Color.White;
                this.lbl00.ForeColor = System.Drawing.Color.Black;
            }
            else {
                this.lbl00.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl00.ForeColor = System.Drawing.Color.White;
                lbl00.Text = Convert.ToString(temp[0].Numero);}

            if (temp[1].Numerojugado == false) { lbl10.Text = Convert.ToString(temp[1].Numero);
                this.lbl10.BackColor = System.Drawing.Color.White;
                this.lbl10.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl10.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl10.ForeColor = System.Drawing.Color.White;
                lbl10.Text = Convert.ToString(temp[1].Numero);
            }

            if (temp[2].Numerojugado == false) { lbl20.Text = Convert.ToString(temp[2].Numero);
                this.lbl20.BackColor = System.Drawing.Color.White;
                this.lbl20.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl20.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl20.ForeColor = System.Drawing.Color.White;
                lbl20.Text = Convert.ToString(temp[2].Numero);
            }
            if (temp[3].Numerojugado == false) { lbl30.Text = Convert.ToString(temp[3].Numero);
                this.lbl30.BackColor = System.Drawing.Color.White;
                this.lbl30.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl30.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl30.ForeColor = System.Drawing.Color.White;
                lbl30.Text = Convert.ToString(temp[3].Numero);
            }
            if (temp[4].Numerojugado == false) { lbl40.Text = Convert.ToString(temp[4].Numero);
                this.lbl40.BackColor = System.Drawing.Color.White;
                this.lbl40.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl40.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl40.ForeColor = System.Drawing.Color.White;
                lbl40.Text = Convert.ToString(temp[4].Numero);
            }

            temp = carton.Columnas[1];
            if (temp[0].Numerojugado == false) { lbl01.Text = Convert.ToString(temp[0].Numero);
                this.lbl01.BackColor = System.Drawing.Color.White;
                this.lbl01.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl01.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl01.ForeColor = System.Drawing.Color.White;
                lbl01.Text = Convert.ToString(temp[0].Numero);
            }
            if (temp[1].Numerojugado == false) { lbl11.Text = Convert.ToString(temp[1].Numero);
                this.lbl11.BackColor = System.Drawing.Color.White;
                this.lbl11.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl11.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl11.ForeColor = System.Drawing.Color.White;
                lbl11.Text = Convert.ToString(temp[1].Numero);
            }
            if (temp[2].Numerojugado == false) { lbl21.Text = Convert.ToString(temp[2].Numero);
                this.lbl21.BackColor = System.Drawing.Color.White;
                this.lbl21.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl21.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl21.ForeColor = System.Drawing.Color.White;
                lbl21.Text = Convert.ToString(temp[2].Numero);
            }
            if (temp[3].Numerojugado == false) { lbl31.Text = Convert.ToString(temp[3].Numero);
                this.lbl31.BackColor = System.Drawing.Color.White;
                this.lbl31.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl31.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl31.ForeColor = System.Drawing.Color.White;
                lbl31.Text = Convert.ToString(temp[3].Numero);
            }
            if (temp[4].Numerojugado == false) { lbl41.Text = Convert.ToString(temp[4].Numero);
                this.lbl41.BackColor = System.Drawing.Color.White;
                this.lbl41.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl41.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl41.ForeColor = System.Drawing.Color.White;
                lbl41.Text = Convert.ToString(temp[4].Numero);
            }

            temp = carton.Columnas[2];
            if (temp[0].Numerojugado == false) { lbl02.Text = Convert.ToString(temp[0].Numero);
                this.lbl02.BackColor = System.Drawing.Color.White;
                this.lbl02.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl02.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl02.ForeColor = System.Drawing.Color.White;
                lbl02.Text = Convert.ToString(temp[0].Numero);
            }
            if (temp[1].Numerojugado == false) { lbl12.Text = Convert.ToString(temp[1].Numero);
                this.lbl12.BackColor = System.Drawing.Color.White;
                this.lbl12.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl12.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl12.ForeColor = System.Drawing.Color.White;
                lbl12.Text = Convert.ToString(temp[1].Numero);
            }
            //lbl22.Text = Convert.ToString(temp[2].Numero);
            if (temp[3].Numerojugado == false) { lbl32.Text = Convert.ToString(temp[3].Numero);
                this.lbl32.BackColor = System.Drawing.Color.White;
                this.lbl32.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl32.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl32.ForeColor = System.Drawing.Color.White;
                lbl32.Text = Convert.ToString(temp[3].Numero);
            }
            if (temp[4].Numerojugado == false) { lbl42.Text = Convert.ToString(temp[4].Numero);
                this.lbl42.BackColor = System.Drawing.Color.White;
                this.lbl42.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl42.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl42.ForeColor = System.Drawing.Color.White;
                lbl42.Text = Convert.ToString(temp[4].Numero);
            }

            temp = carton.Columnas[3];
            if (temp[0].Numerojugado == false) { lbl03.Text = Convert.ToString(temp[0].Numero);
                this.lbl03.BackColor = System.Drawing.Color.White;
                this.lbl03.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl03.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl03.ForeColor = System.Drawing.Color.White;
                lbl03.Text = Convert.ToString(temp[0].Numero);
            }
            if (temp[1].Numerojugado == false) { lbl13.Text = Convert.ToString(temp[1].Numero);
                this.lbl13.BackColor = System.Drawing.Color.White;
                this.lbl13.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl13.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl13.ForeColor = System.Drawing.Color.White;
                lbl13.Text = Convert.ToString(temp[1].Numero);
            }
            if (temp[2].Numerojugado == false) { lbl23.Text = Convert.ToString(temp[2].Numero);
                this.lbl23.BackColor = System.Drawing.Color.White;
                this.lbl23.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl23.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl23.ForeColor = System.Drawing.Color.White;
                lbl23.Text = Convert.ToString(temp[2].Numero);
            }
            if (temp[3].Numerojugado == false) { lbl33.Text = Convert.ToString(temp[3].Numero);
                this.lbl33.BackColor = System.Drawing.Color.White;
                this.lbl33.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl33.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl33.ForeColor = System.Drawing.Color.White;
                lbl33.Text = Convert.ToString(temp[3].Numero);
            }
            if (temp[4].Numerojugado == false) { lbl43.Text = Convert.ToString(temp[4].Numero);
                this.lbl43.BackColor = System.Drawing.Color.White;
                this.lbl43.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl43.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl43.ForeColor = System.Drawing.Color.White;
                lbl43.Text = Convert.ToString(temp[4].Numero);
            }

            temp = carton.Columnas[4];
            if (temp[0].Numerojugado == false) { lbl04.Text = Convert.ToString(temp[0].Numero);
                this.lbl04.BackColor = System.Drawing.Color.White;
                this.lbl04.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl04.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl04.ForeColor = System.Drawing.Color.White;
                lbl04.Text = Convert.ToString(temp[0].Numero);
            }
            if (temp[1].Numerojugado == false) { lbl14.Text = Convert.ToString(temp[1].Numero);
                this.lbl14.BackColor = System.Drawing.Color.White;
                this.lbl14.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl14.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl14.ForeColor = System.Drawing.Color.White;
                lbl14.Text = Convert.ToString(temp[1].Numero);
            }
            if (temp[2].Numerojugado == false) { lbl24.Text = Convert.ToString(temp[2].Numero);
                this.lbl24.BackColor = System.Drawing.Color.White;
                this.lbl24.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl24.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl24.ForeColor = System.Drawing.Color.White;
                lbl24.Text = Convert.ToString(temp[2].Numero);
            }
            if (temp[3].Numerojugado == false) { lbl34.Text = Convert.ToString(temp[3].Numero);
                this.lbl34.BackColor = System.Drawing.Color.White;
                this.lbl34.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl34.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl34.ForeColor = System.Drawing.Color.White;
                lbl34.Text = Convert.ToString(temp[3].Numero);
            }
            if (temp[4].Numerojugado == false) { lbl44.Text = Convert.ToString(temp[4].Numero);
                this.lbl44.BackColor = System.Drawing.Color.White;
                this.lbl44.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.lbl44.BackColor = System.Drawing.Color.MidnightBlue;
                this.lbl44.ForeColor = System.Drawing.Color.White;
                lbl44.Text = Convert.ToString(temp[4].Numero);
            }

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
