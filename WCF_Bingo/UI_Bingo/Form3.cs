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
                                Environment.NewLine +
                                "El Número: " + iNumeroObtenido.ToString());

                // Actualizo DataGridView
                this.RefrescarDataGridNumFavorecidos();





                //----------------------------------------------------------------------------------------   Hacer Validaciones en Cartones
                //////////////////////////////////////////
                // Aqui hacer el llamado para hacer     //
                // las validaciones en los cartones     //
                //////////////////////////////////////////

            }




        }

        #endregion


        #region Metodos
        private String obtenerLetraNumeroFavorecido(Int32 p_sInumero)
        {
            String sLetra = "";

            Int32 iRango = (clsGlobal.iLimiteNumerosBingo / 5); // Divido entre cinco que son la cantidad de letras de "B I N G O"

            if (p_sInumero <= (iRango * 1))   // LETRA B
            {
                sLetra = "B";
            }
            else
            {
                if (p_sInumero <= (iRango * 2))   // LETRA I
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

        private void RefrescarDataGridNumFavorecidos()
        {
            // Aplico Formato
            this.dgvNumerosFavorecidos.Columns.Clear();
            this.aplicarFormatoDataGrid(this.dgvNumerosFavorecidos);

            // Agrego Columnas
            this.crearColumnaGrid("NUMERO", "Número", 60, this.dgvNumerosFavorecidos);

            // Agregar Valores
            if (clsGlobal.ListaNumerosFavorecidos != null)   // Si es diferente de nulo
            {
                if (clsGlobal.ListaNumerosFavorecidos.Count >= 1)    // Si tiene elementos
                {
                    foreach (Int32 iTemp in clsGlobal.ListaNumerosFavorecidos)  // Obtengo cada elemento de la Lista de Jugadores
                    {
                        String sNumero = iTemp.ToString();  // Obtengo el nombre del Jugador
                        string[] row = { sNumero };
                        this.dgvNumerosFavorecidos.Rows.Add(row);
                    }
                }
            }

            this.dgvNumerosFavorecidos.CurrentCell = null;
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
