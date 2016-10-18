using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bingo_System.LogicaNegocio;


namespace Bingo_System.Ventanas
{
    public partial class frmInicioBingo : Form
    {
        //---------------------------------------------------------------------------

        #region Variables
        #endregion

        //---------------------------------------------------------------------------

        #region Constructor

        public frmInicioBingo()
        {
            InitializeComponent();
        }

        #endregion

        //---------------------------------------------------------------------------

        #region Eventos

        private void frmInicioBingo_Load(object sender, EventArgs e)
        {
            //carga las modalidades configuradas
            foreach (Logica.MODALIDAD_JUEGO val in Enum.GetValues(typeof(Logica.MODALIDAD_JUEGO)))
            {
                if(val != Logica.MODALIDAD_JUEGO.INDEFINIDO)
                    this.cbxModalidad.Items.Add(val.ToString());
            }
        }

        private void nudTechoNumBingo_ValueChanged(object sender, EventArgs e)
        {
            this.valGuardarConfig();
        }

        private void cbxModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.valGuardarConfig();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            this.valAgregarJugador();
        }

        private void nudCantidadCartones_ValueChanged(object sender, EventArgs e)
        {
            this.valAgregarJugador();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarConfig_Click(object sender, EventArgs e)
        {
            // Apago las opciones
            this.nudTechoNumBingo.Enabled = false;
            this.cbxModalidad.Enabled     = false;
            this.btnGuardarConfig.Enabled = false;

            // Defino el techo de los numero del Bingo 
            clsGlobal.iLimiteNumerosBingo = Convert.ToInt32(this.nudTechoNumBingo.Value);

            // Defino la modalidad de juego del Bingo
            String sModalidad          = this.cbxModalidad.SelectedItem.ToString();
            clsGlobal.mdModalidadJuego = (Logica.MODALIDAD_JUEGO)Enum.Parse(typeof(Logica.MODALIDAD_JUEGO), Convert.ToString(sModalidad));

            MessageBox.Show("Configuración del Juego Guardada de manera correcta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.pnlAgregarJugador.Enabled = true;
            this.ActiveControl             = this.txtNombreUsuario;
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            String sNombre = this.txtNombreUsuario.Text;
            Int32 iCantidadCartones = Convert.ToInt32(this.nudCantidadCartones.Value);


            // Paso 1.  Valido que el Usuario no exista
            if (this.YaExisteElJugador(sNombre))
            {
                MessageBox.Show("El Nombre del Jugador ya existe.  Favor verificar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //////////////////////////////////////////////////////////
                //  Hacer ciclo con la cantidad de cartones y crearlos  //
                //////////////////////////////////////////////////////////

                // Paso 3.  Crear Jugador Nuevo
                Clases.clsJugador nuevoJugador = new Clases.clsJugador(sNombre, iCantidadCartones, null);

                // Paso 4.  Agregar Jugador a la Lista de Jugadores
                clsGlobal.ListaJugadores.Add(nuevoJugador);

                // Paso 5.  Refrescar DataGridView
                this.RefrescarDataGrid();
            }
        }

        #endregion

        //---------------------------------------------------------------------------

        #region Metodos

        public void valGuardarConfig()
        {
            Boolean bEstado = true;

            if (this.cbxModalidad.SelectedIndex == -1)
            {
                bEstado = false;
            }

            this.btnGuardarConfig.Enabled = bEstado;
        }

        public void valAgregarJugador()
        {
            Boolean bEstado = true;

            if (this.txtNombreUsuario.Text.Trim() == "")
            {
                bEstado = false;
            }

            if (Convert.ToInt32(this.nudCantidadCartones.Value) <= 0)
            {
                bEstado = false;
            }

            this.btnAgregarJugador.Enabled = bEstado;
        }

        private Boolean YaExisteElJugador(String p_sNombreJugador)
        {
            Boolean bExiste = false;

            if (clsGlobal.ListaJugadores != null)   // Si es diferente de nulo
            {
                if (clsGlobal.ListaJugadores.Count >= 1)    // Si tiene elementos
                {
                    foreach (Clases.clsJugador clsJugTemp in clsGlobal.ListaJugadores)  // Obtengo cada elemento de la Lista de Jugadores
                    {
                        String sTempNombreJugador = clsJugTemp.SNombreUsuario;  // Obtengo el nombre del Jugador

                        if (sTempNombreJugador == p_sNombreJugador) // Valido que no sean iguales
                        {
                            bExiste = true;
                        }
                    }
                }
            }

            return bExiste;
        }

        private void RefrescarDataGrid()
        {
            // Aplico Formato
            this.dgvJugadores.Columns.Clear();
            this.aplicarFormatoDataGrid(this.dgvJugadores);

            // Agrego Columnas
            this.crearColumnaGrid("NOMBRE", "Nombre", 200, this.dgvJugadores);
            this.crearColumnaGrid("CANT_CARTONES", "Cantidad de Cartones", 150, this.dgvJugadores);

            // Agregar Valores
            if (clsGlobal.ListaJugadores != null)   // Si es diferente de nulo
            {
                if (clsGlobal.ListaJugadores.Count >= 1)    // Si tiene elementos
                {
                    foreach (Clases.clsJugador clsJugTemp in clsGlobal.ListaJugadores)  // Obtengo cada elemento de la Lista de Jugadores
                    {
                        String sTempNombreJugador = clsJugTemp.SNombreUsuario;  // Obtengo el nombre del Jugador
                        string[] row = { clsJugTemp.SNombreUsuario, clsJugTemp.ICantidadCartones.ToString() };
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

        //---------------------------------------------------------------------------

    }
}
