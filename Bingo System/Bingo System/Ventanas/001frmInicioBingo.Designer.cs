namespace Bingo_System.Ventanas
{
    partial class frmInicioBingo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.nudTechoNumBingo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxModalidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCantidadCartones = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAgregarJugador = new System.Windows.Forms.Panel();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudTechoNumBingo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCartones)).BeginInit();
            this.pnlAgregarJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(825, 412);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3.BorderColor = System.Drawing.Color.DarkGray;
            this.rectangleShape3.CornerRadius = 5;
            this.rectangleShape3.Enabled = false;
            this.rectangleShape3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape3.Location = new System.Drawing.Point(15, 139);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(795, 256);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.DarkGray;
            this.rectangleShape2.CornerRadius = 5;
            this.rectangleShape2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(14, 80);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(795, 42);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rectangleShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(840, 64);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(55, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bingo";
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumeros.Location = new System.Drawing.Point(23, 92);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(196, 18);
            this.lblNumeros.TabIndex = 58;
            this.lblNumeros.Text = "Cantidad Números Bingo";
            this.lblNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTechoNumBingo
            // 
            this.nudTechoNumBingo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTechoNumBingo.Location = new System.Drawing.Point(225, 92);
            this.nudTechoNumBingo.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudTechoNumBingo.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudTechoNumBingo.Name = "nudTechoNumBingo";
            this.nudTechoNumBingo.ReadOnly = true;
            this.nudTechoNumBingo.Size = new System.Drawing.Size(82, 20);
            this.nudTechoNumBingo.TabIndex = 1;
            this.nudTechoNumBingo.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudTechoNumBingo.ValueChanged += new System.EventHandler(this.nudTechoNumBingo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(378, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Modalidad del Juego";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxModalidad
            // 
            this.cbxModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModalidad.FormattingEnabled = true;
            this.cbxModalidad.Location = new System.Drawing.Point(547, 91);
            this.cbxModalidad.Name = "cbxModalidad";
            this.cbxModalidad.Size = new System.Drawing.Size(198, 21);
            this.cbxModalidad.TabIndex = 2;
            this.cbxModalidad.SelectedIndexChanged += new System.EventHandler(this.cbxModalidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Agregar Jugadores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIniciarJuego.FlatAppearance.BorderSize = 0;
            this.btnIniciarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarJuego.ForeColor = System.Drawing.Color.White;
            this.btnIniciarJuego.Image = global::Bingo_System.Properties.Resources.Apps_Run_icon;
            this.btnIniciarJuego.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarJuego.Location = new System.Drawing.Point(631, 9);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(83, 46);
            this.btnIniciarJuego.TabIndex = 9;
            this.btnIniciarJuego.Text = "Iniciar";
            this.btnIniciarJuego.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarJuego.UseVisualStyleBackColor = false;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarJugador.Enabled = false;
            this.btnAgregarJugador.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarJugador.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarJugador.Image = global::Bingo_System.Properties.Resources.Apps_Dialog_Add_icon24p;
            this.btnAgregarJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarJugador.Location = new System.Drawing.Point(216, 134);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(84, 36);
            this.btnAgregarJugador.TabIndex = 7;
            this.btnAgregarJugador.Text = "Agregar\r\nJugador";
            this.btnAgregarJugador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarJugador.UseVisualStyleBackColor = false;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::Bingo_System.Properties.Resources.Actions_window_close_icon;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(727, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(83, 46);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::Bingo_System.Properties.Resources.Cute_Ball_Reboot_icon;
            this.pictureBox1.Location = new System.Drawing.Point(14, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarConfig.Enabled = false;
            this.btnGuardarConfig.FlatAppearance.BorderSize = 0;
            this.btnGuardarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConfig.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarConfig.Image = global::Bingo_System.Properties.Resources.check_icon;
            this.btnGuardarConfig.Location = new System.Drawing.Point(757, 83);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(44, 36);
            this.btnGuardarConfig.TabIndex = 3;
            this.btnGuardarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarConfig.UseVisualStyleBackColor = false;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(81, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Nombre";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(131, 58);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(169, 20);
            this.txtNombreUsuario.TabIndex = 5;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Cantidad de Cartones";
            // 
            // nudCantidadCartones
            // 
            this.nudCantidadCartones.Location = new System.Drawing.Point(131, 94);
            this.nudCantidadCartones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadCartones.Name = "nudCantidadCartones";
            this.nudCantidadCartones.ReadOnly = true;
            this.nudCantidadCartones.Size = new System.Drawing.Size(169, 20);
            this.nudCantidadCartones.TabIndex = 6;
            this.nudCantidadCartones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadCartones.ValueChanged += new System.EventHandler(this.nudCantidadCartones_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(427, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Listado de Jugadores";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAgregarJugador
            // 
            this.pnlAgregarJugador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAgregarJugador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgregarJugador.Controls.Add(this.txtNombreUsuario);
            this.pnlAgregarJugador.Controls.Add(this.label3);
            this.pnlAgregarJugador.Controls.Add(this.label4);
            this.pnlAgregarJugador.Controls.Add(this.nudCantidadCartones);
            this.pnlAgregarJugador.Controls.Add(this.btnAgregarJugador);
            this.pnlAgregarJugador.Enabled = false;
            this.pnlAgregarJugador.Location = new System.Drawing.Point(26, 182);
            this.pnlAgregarJugador.Name = "pnlAgregarJugador";
            this.pnlAgregarJugador.Size = new System.Drawing.Size(323, 199);
            this.pnlAgregarJugador.TabIndex = 4;
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.AllowUserToResizeRows = false;
            this.dgvJugadores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(430, 182);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.Size = new System.Drawing.Size(370, 199);
            this.dgvJugadores.TabIndex = 73;
            // 
            // frmInicioBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 412);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.pnlAgregarJugador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarConfig);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxModalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTechoNumBingo);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicioBingo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo System .:. frm001";
            this.Load += new System.EventHandler(this.frmInicioBingo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTechoNumBingo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCartones)).EndInit();
            this.pnlAgregarJugador.ResumeLayout(false);
            this.pnlAgregarJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.NumericUpDown nudTechoNumBingo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxModalidad;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnIniciarJuego;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCantidadCartones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlAgregarJugador;
        private System.Windows.Forms.DataGridView dgvJugadores;
    }
}