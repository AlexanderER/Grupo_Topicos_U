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


        #region Resultados
        private void verCartonesconNumero(List<WCF_Bingo.Clases.clsJugador> listaJugadores, Int32 iNumero)
        {
            DataSet dsData = new DataSet();

            //////////////////////////////////////////////////////////////////////////////////
            // Construyo el dataSet y la Tabla con las columnas
            DataTable dtTablaDif = dsData.Tables.Add("dtFavo");                             // requeridas para mostrar el reporte con las 
            dtTablaDif.Columns.Add("JUGADOR");                                               // diferencias en caso de que sea necesario
            dtTablaDif.Columns.Add("CARTON");                                               //
            //////////////////////////////////////////////////////////////////////////////////

            //recorre jugadores
            for (int i = 0; i < listaJugadores.Count; i++)
            {
                //recorre cartones
                for (int p = 0; p < listaJugadores[i].ListaCartones.Count; p++)
                {
                    //recorre celdas
                    for (int m = 0; m < 5; m++)
                    {
                        for (int n = 0; n < 5; n++)
                        {
                            if (iNumero == listaJugadores[i].ListaCartones[p].Columnas[m][n].Numero)
                            {

                                //////////////////////////////////////////////////////
                                DataRow myRow = dsData.Tables[0].NewRow();          //
                                myRow["JUGADOR"] = (i + 1).ToString();                //
                                myRow["CARTON"] = (p + 1).ToString();                 //
                                dsData.Tables[0].Rows.Add(myRow);                   //
                                //////////////////////////////////////////////////////

                                // MessageBox.Show("El Jugador " + (i + 1).ToString() + " carton " + (p + 1).ToString());
                            }
                        }
                    }
                }
            }

            this.mostrarFormatoDatagridSorteados(dsData);
        }

        private void mostrarFormatoDatagridSorteados(DataSet p_dsDatos)
        {
            this.dgvResultados.Columns.Clear();
            this.aplicarFormatoDataGrid(this.dgvResultados);
            this.crearColumnaGrid("JUGADOR", "Jugador", 65, this.dgvResultados);
            this.crearColumnaGrid("CARTON", "Carton", 279, this.dgvResultados);

            this.dgvResultados.DataSource = p_dsDatos;
            this.dgvResultados.DataMember = p_dsDatos.Tables[0].TableName;
        }




        #endregion




        #region Eventos

        private void btnJugar_Click(object sender, EventArgs e)
        {
            List<WCF_Bingo.Clases.clsJugador> ListaJugadorTemporal = clsGlobal.ListaJugador; // En caso de error o excepcion se recupera el ultimo listado

            try
            {

                if (clsGlobal.ListaNumerosFavorecidos.Count == clsGlobal.iLimiteNumerosBingo)
                {
                    MessageBox.Show("Ya no quedan números por jugar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //----------------------------------------------------------------------------------------   Obtengo el Numero 
                    // Traslado la lista a un arreglo ya que el metodo solicita un arreglo
                    //Int32[] arrayDeNumeros = new Int32[clsGlobal.ListaNumerosFavorecidos.Count];
                    //clsGlobal.ListaNumerosFavorecidos.CopyTo(arrayDeNumeros);

                    // Instancio el WCF y ejecuto el proceso de obtener numero
                    miServicio.Service1Client WCF_Service = new miServicio.Service1Client();
                    Int32 iNumeroObtenido = WCF_Service.GenerarNumero(clsGlobal.iLimiteNumerosBingo, clsGlobal.ListaNumerosFavorecidos);

                    // Agrego el numero a la Lista de Numero Favorecidos
                    clsGlobal.ListaNumerosFavorecidos.Add(iNumeroObtenido);

                    // Muestro en pantalla el numero que salio
                    MessageBox.Show("Con la letra de la: " + this.obtenerLetraNumeroFavorecido(iNumeroObtenido) +
                                    Environment.NewLine +
                                    Environment.NewLine +
                                    "El Número: " + iNumeroObtenido.ToString());

                    // Actualizo DataGridView
                    this.RefrescarDataGridNumFavorecidos();




                    this.verCartonesconNumero(clsGlobal.ListaJugador, iNumeroObtenido);

                    //----------------------------------------------------------------------------------------   Hacer Validaciones en Cartones
                    //////////////////////////////////////////
                    // Aqui hacer el llamado para hacer     //
                    // las validaciones en los cartones     //
                    //////////////////////////////////////////

                    // Paso 1.  Actualizo el estado de los cartones
                    clsGlobal.ListaJugador = WCF_Service.actualizarEstados(clsGlobal.ListaJugador, iNumeroObtenido);

                    // Paso 2.  Obtengo los cartones que contienen el numero
                    List<WCF_Bingo.Clases.clsJugador> Lganadores = WCF_Service.jugadoresGanadores(clsGlobal.ListaJugador);

                    if (Lganadores.Count > 0)
                    {
                        MessageBox.Show("//////////////////////////////////////////////////////" + Environment.NewLine +
                                        "//                                                                                   //" + Environment.NewLine +
                                        "//   *** *** ***   HAY GANADORES    *** *** ***       //" + Environment.NewLine +
                                        "//                                                                                  //" + Environment.NewLine +
                                        "////////////////////////////////////////////////////",
                                        "Carton Ganador", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        RefrescarDataGridGanadores(Lganadores);
                    }
                    else
                    {
                        MessageBox.Show("Aún no hay ganadores.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    // Paso 3.  Validar dentro de los Afortunados si era el ultimo numero que ocupaba




                }

            }
            catch (Exception ex) {

                clsGlobal.ListaJugador = ListaJugadorTemporal;

                String mensaje;
                String titulo;
                mensaje = "No se logró obtener el número de forma correcta";
                titulo = "Atención";

                MessageBox.Show(mensaje,titulo,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
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
            this.crearColumnaGrid("Numero", "Numero Ordenado", 60, this.dgvNumerosFavorecidos);

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
                    for (int i = 0; i <= clsGlobal.ListaNumerosFavorecidos.Count; i++)
                    {
                        clsGlobal.ListaNumerosFavorecidos.Sort();

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


        #region Pintar Jugadores

        private void RefrescarDataGridGanadores(List<WCF_Bingo.Clases.clsJugador> p_lista)
        {
            // Aplico Formato
            this.dgvJugadores.Columns.Clear();
            this.aplicarFormatoDataGridGanadores(this.dgvJugadores);

            // Agrego Columnas
            this.crearColumnaGrid("NOMBRE", "Nombre #", 110, this.dgvJugadores);
            this.crearColumnaGrid("CANT_CARTONES", "Cantidad de Cartones", 110, this.dgvJugadores);

            // Agregar Valores
            if (p_lista != null)   // Si es diferente de nulo
            {
                if (p_lista.Count >= 1)    // Si tiene elementos
                {
                    foreach (WCF_Bingo.Clases.clsJugador clsJugTemp in p_lista)  // Obtengo cada elemento de la Lista de Jugadores
                    {
                        String sTempNombreJugador = clsJugTemp.NombreJugador.ToString();  // Obtengo el nombre del Jugador
                        string[] row = { sTempNombreJugador, clsJugTemp.ListaCartones.Count.ToString() };
                        this.dgvJugadores.Rows.Add(row);
                    }
                }
            }

            this.dgvJugadores.CurrentCell = null;
        }

        private void aplicarFormatoDataGridGanadores(DataGridView dgView, Boolean bReadOnly = true)
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

        private void crearColumnaGridGanadores(String nombreBD, String nombreMostrar, Int32 tamanio, DataGridView dataGrid, Boolean visible = true, Boolean bAlignmentRight = false, Boolean bAlignmentCenter = false)
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




        //private void verCartonesconNumero(List<WCF_Bingo.Clases.clsJugador> listaJugadores, Int32 iNumero)
        //{
        //    foreach (WCF_Bingo.Clases.clsJugador miJugador in listaJugadores)
        //    {
        //        foreach (WCF_Bingo.Clases.clsCarton miCarton in miJugador.ListaCartones)
        //        {
        //            int iNumCarton = 1;

        //            for (int i = 0; i < 5; i++)
        //            {
        //                List<WCF_Bingo.Clases.clsCelda> miColumna;
        //                miColumna = miCarton.Columnas[i];

        //                if (miColumna[0].Numero == iNumero)
        //                {
        //                    // Agrego Jugador
        //                    MessageBox.Show("Jugador " + miJugador.NombreJugador.ToString() + " tiene el numero en el Carton " + iNumCarton.ToString());
        //                }

        //                if (miColumna[1].Numero == iNumero)
        //                {
        //                    // Agrego Jugador
        //                    MessageBox.Show("Jugador " + miJugador.NombreJugador.ToString() + " tiene el numero en el Carton " + iNumCarton.ToString());
        //                }

        //                if (miColumna[2].Numero == iNumero)
        //                {
        //                    // Agrego Jugador
        //                    MessageBox.Show("Jugador " + miJugador.NombreJugador.ToString() + " tiene el numero en el Carton " + iNumCarton.ToString());
        //                }

        //                if (miColumna[4].Numero == iNumero)
        //                {
        //                    // Agrego Jugador
        //                    MessageBox.Show("Jugador " + miJugador.NombreJugador.ToString() + " tiene el numero en el Carton " + iNumCarton.ToString());
        //                }
        //            }
        //            iNumCarton++;
        //        }
        //    }


        //}









        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
