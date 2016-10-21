namespace UI_Bingo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTiposJuego = new System.Windows.Forms.ComboBox();
            this.cmbNumeroJugadores = new System.Windows.Forms.ComboBox();
            this.txtNumeroJugadores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroCartones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumMax = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 310);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbTiposJuego);
            this.panel2.Controls.Add(this.cmbNumeroJugadores);
            this.panel2.Controls.Add(this.txtNumeroJugadores);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNumeroCartones);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNumMax);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 418);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(383, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(18, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(463, 2);
            this.label9.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(18, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(463, 2);
            this.label8.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(9, 156);
            this.label7.MaximumSize = new System.Drawing.Size(0, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 2);
            this.label7.TabIndex = 24;
            this.label7.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad de Cartones";
            // 
            // cmbTiposJuego
            // 
            this.cmbTiposJuego.FormattingEnabled = true;
            this.cmbTiposJuego.Items.AddRange(new object[] {
            "Cartón lleno",
            "Cuatro esquinas",
            "Letra H",
            "Letra X",
            "Letra O",
            "Letra U",
            "Letra P",
            "Letra A",
            "Letra E",
            "Letra W",
            "Letra R"});
            this.cmbTiposJuego.Location = new System.Drawing.Point(233, 140);
            this.cmbTiposJuego.Name = "cmbTiposJuego";
            this.cmbTiposJuego.Size = new System.Drawing.Size(91, 21);
            this.cmbTiposJuego.TabIndex = 18;
            // 
            // cmbNumeroJugadores
            // 
            this.cmbNumeroJugadores.FormattingEnabled = true;
            this.cmbNumeroJugadores.Location = new System.Drawing.Point(70, 281);
            this.cmbNumeroJugadores.Name = "cmbNumeroJugadores";
            this.cmbNumeroJugadores.Size = new System.Drawing.Size(91, 21);
            this.cmbNumeroJugadores.TabIndex = 17;
            // 
            // txtNumeroJugadores
            // 
            this.txtNumeroJugadores.Location = new System.Drawing.Point(270, 48);
            this.txtNumeroJugadores.Name = "txtNumeroJugadores";
            this.txtNumeroJugadores.Size = new System.Drawing.Size(53, 20);
            this.txtNumeroJugadores.TabIndex = 14;
            this.txtNumeroJugadores.Leave += new System.EventHandler(this.txtNumeroJugadores_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Digite la cantidad de cartones  que desea tener cada jugador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Bingo.Properties.Resources.icon128_2x;
            this.pictureBox1.Location = new System.Drawing.Point(341, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Digite el valor máximo del cartón";
            // 
            // txtNumeroCartones
            // 
            this.txtNumeroCartones.Location = new System.Drawing.Point(284, 282);
            this.txtNumeroCartones.Name = "txtNumeroCartones";
            this.txtNumeroCartones.Size = new System.Drawing.Size(53, 20);
            this.txtNumeroCartones.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seleccione el tipo de Juego";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Digite el Número de jugadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jugador";
            // 
            // txtNumMax
            // 
            this.txtNumMax.Location = new System.Drawing.Point(270, 93);
            this.txtNumMax.Name = "txtNumMax";
            this.txtNumMax.Size = new System.Drawing.Size(53, 20);
            this.txtNumMax.TabIndex = 22;
            this.txtNumMax.Leave += new System.EventHandler(this.txtNumMax_Leave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(287, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 58);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Iniciar Juego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Juego";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTiposJuego;
        private System.Windows.Forms.ComboBox cmbNumeroJugadores;
        private System.Windows.Forms.TextBox txtNumeroJugadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroCartones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}