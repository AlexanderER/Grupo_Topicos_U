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
                this.cbxModalidad.Items.Add(val.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        //---------------------------------------------------------------------------

        #region Metodos
        #endregion

        //---------------------------------------------------------------------------

    }
}
