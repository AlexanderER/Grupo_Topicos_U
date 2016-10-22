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
            List<WCF_Bingo.Clases.clsJugador> listaRespaldo = clsGlobal.ListaJugador;   // Lista de respaldo por si da alguna excepcion restaurar la ultima version

            try
            {
                if (txtNumeroCartones.Text.Equals("") | (cmbNumeroJugadores.SelectedIndex.Equals(null))) { MessageBox.Show("No ha ingresado valores válidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); }
                else
                {
                    //-------------------------------------------------------------------------------------------   Defino los parametros del Juego 
                    clsGlobal.iLimiteNumerosBingo = Convert.ToInt32(txtNumMax.Text);    // Cantidad Maxima de Numeros
                    clsGlobal.iModalidadJuego = cmbTiposJuego.SelectedIndex + 1;    // Defino la Modalidad de Juego



                    //-------------------------------------------------------------------------------------------   Agregar Jugador
                    miServicio.Service1Client WCF_Service = new miServicio.Service1Client();    // Instancio el Sevicio

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
                    cmbTiposJuego.Enabled = false;
                    txtNumeroCartones.Text = "";
                    txtNumMax.Enabled = false;
                    cmbNumeroJugadores.Items.RemoveAt(cmbNumeroJugadores.SelectedIndex);

                    // Refresco el Grid

                    this.RefrescarDataGrid();

                }
                if (cmbNumeroJugadores.Items.Count == 0)
                {
                    cmbNumeroJugadores.Enabled = false;
                    txtNumeroCartones.Enabled = false;
                    btnAdd.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                clsGlobal.ListaJugador = listaRespaldo;
                MessageBox.Show("No fue posible agregar al jugador.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.RefrescarDataGrid();
            }        
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




        #region Pintar Jugadores

        private void RefrescarDataGrid()
        {
            // Aplico Formato
            this.dgvJugadores.Columns.Clear();
            this.aplicarFormatoDataGrid(this.dgvJugadores);

            // Agrego Columnas
            this.crearColumnaGrid("NOMBRE", "Nombre #", 200, this.dgvJugadores);
            this.crearColumnaGrid("CANT_CARTONES", "Cantidad de Cartones", 187, this.dgvJugadores);

            // Agregar Valores
            if (clsGlobal.ListaJugador != null)   // Si es diferente de nulo
            {
                if (clsGlobal.ListaJugador.Count >= 1)    // Si tiene elementos
                {
                    foreach (WCF_Bingo.Clases.clsJugador clsJugTemp in clsGlobal.ListaJugador)  // Obtengo cada elemento de la Lista de Jugadores
                    {
                        String sTempNombreJugador = clsJugTemp.NombreJugador.ToString();  // Obtengo el nombre del Jugador
                        string[] row = { sTempNombreJugador, clsJugTemp.ListaCartones.Count.ToString() };
                        this.dgvJugadores.Rows.Add(row);
                    }
                }
            }

            this.dgvJugadores.CurrentCell = null;
        }

        private void aplicarFormatoDataGrid(DataGridView dgView, Boolean bReadOnly = true)
        {
            dgView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgView.ScrollBars = ScrollBars.Both;
            dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.DarkSeaGreen);
            dgView.AllowUserToResizeRows = false;
            dgView.MultiSelect = false;
            dgView.ReadOnly = bReadOnly;
            dgView.RowHeadersVisible = false;
        }

        private void crearColumnaGrid(String nombreBD, String nombreMostrar, Int32 tamanio, DataGridView dataGrid, Boolean visible = true, Boolean bAlignmentRight = false, Boolean bAlignmentCenter = false)
        {
            DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn();
            Columna.DataPropertyName = nombreBD;
            Columna.Name = nombreBD;
            Columna.HeaderText = nombreMostrar;

            dataGrid.Columns.Add(Columna);
            dataGrid.Columns[nombreBD].Width = tamanio;
            dataGrid.Columns[nombreBD].Visible = visible;

            if (bAlignmentRight)
            {
                dataGrid.Columns[nombreBD].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGrid.Columns[nombreBD].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (bAlignmentCenter)
            {
                dataGrid.Columns[nombreBD].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[nombreBD].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            Columna.ReadOnly = false;
            dataGrid.Columns[nombreBD].ReadOnly = false;
        }

        #endregion




    }


}
