﻿namespace Bingo_System.Ventanas
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
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.nudTechoNumBingo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxModalidad = new System.Windows.Forms.ComboBox();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTechoNumBingo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.shapeContainer1.Size = new System.Drawing.Size(825, 443);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
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
            this.nudTechoNumBingo.TabIndex = 59;
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
            this.cbxModalidad.TabIndex = 61;
            this.cbxModalidad.SelectedIndexChanged += new System.EventHandler(this.cbxModalidad_SelectedIndexChanged);
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
            this.rectangleShape3.Size = new System.Drawing.Size(795, 287);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Jugadores";
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
            this.btnIniciarJuego.TabIndex = 64;
            this.btnIniciarJuego.Text = "Iniciar";
            this.btnIniciarJuego.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarJuego.UseVisualStyleBackColor = false;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarJugador.Enabled = false;
            this.btnAgregarJugador.FlatAppearance.BorderSize = 0;
            this.btnAgregarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarJugador.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarJugador.Image = global::Bingo_System.Properties.Resources.Apps_Dialog_Add_icon24p;
            this.btnAgregarJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarJugador.Location = new System.Drawing.Point(117, 146);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(84, 36);
            this.btnAgregarJugador.TabIndex = 63;
            this.btnAgregarJugador.Text = "Agregar\r\nJugador";
            this.btnAgregarJugador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarJugador.UseVisualStyleBackColor = false;
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
            this.btnCerrar.TabIndex = 3;
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
            this.btnGuardarConfig.TabIndex = 65;
            this.btnGuardarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarConfig.UseVisualStyleBackColor = false;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // frmInicioBingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 443);
            this.Controls.Add(this.btnGuardarConfig);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.btnAgregarJugador);
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
    }
}