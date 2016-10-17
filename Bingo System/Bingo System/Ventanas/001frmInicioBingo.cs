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

            this.btnAgregarJugador.Enabled = true;
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

        #endregion

        //---------------------------------------------------------------------------



    }
}
