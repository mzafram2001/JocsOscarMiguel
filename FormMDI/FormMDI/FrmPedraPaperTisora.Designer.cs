namespace FormMDI
{
    partial class FrmPedraPaperTisora
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
            this.lbPuntsJugador = new System.Windows.Forms.Label();
            this.lbPuntsComp = new System.Windows.Forms.Label();
            this.lbTitol = new System.Windows.Forms.Label();
            this.btPedra = new System.Windows.Forms.Button();
            this.btPaper = new System.Windows.Forms.Button();
            this.btTisora = new System.Windows.Forms.Button();
            this.gbJugada = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbJugadaJugador = new System.Windows.Forms.Label();
            this.gbJugador = new System.Windows.Forms.GroupBox();
            this.gbComputadora = new System.Windows.Forms.GroupBox();
            this.lbJugadaComputador = new System.Windows.Forms.Label();
            this.lbTotalPartides = new System.Windows.Forms.Label();
            this.btJugarRonda = new System.Windows.Forms.Button();
            this.lbStatusAnteriorJug = new System.Windows.Forms.Label();
            this.lbStatusAnteriorComp = new System.Windows.Forms.Label();
            this.lbJugadaActual = new System.Windows.Forms.Label();
            this.gbJugada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbJugador.SuspendLayout();
            this.gbComputadora.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPuntsJugador
            // 
            this.lbPuntsJugador.AutoSize = true;
            this.lbPuntsJugador.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbPuntsJugador.Location = new System.Drawing.Point(6, 32);
            this.lbPuntsJugador.Name = "lbPuntsJugador";
            this.lbPuntsJugador.Size = new System.Drawing.Size(200, 17);
            this.lbPuntsJugador.TabIndex = 0;
            this.lbPuntsJugador.Text = "TOTAL PUNTS JUGADOR: 0";
            // 
            // lbPuntsComp
            // 
            this.lbPuntsComp.AutoSize = true;
            this.lbPuntsComp.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbPuntsComp.Location = new System.Drawing.Point(6, 32);
            this.lbPuntsComp.Name = "lbPuntsComp";
            this.lbPuntsComp.Size = new System.Drawing.Size(241, 17);
            this.lbPuntsComp.TabIndex = 1;
            this.lbPuntsComp.Text = "TOTAL PUNTS COMPUTADORA: 0";
            // 
            // lbTitol
            // 
            this.lbTitol.AutoSize = true;
            this.lbTitol.Font = new System.Drawing.Font("Verdana", 20F);
            this.lbTitol.Location = new System.Drawing.Point(74, 18);
            this.lbTitol.Name = "lbTitol";
            this.lbTitol.Size = new System.Drawing.Size(456, 32);
            this.lbTitol.TabIndex = 2;
            this.lbTitol.Text = "JOC DE PEDRA, PAPER I TISORA";
            // 
            // btPedra
            // 
            this.btPedra.Location = new System.Drawing.Point(27, 78);
            this.btPedra.Name = "btPedra";
            this.btPedra.Size = new System.Drawing.Size(142, 40);
            this.btPedra.TabIndex = 3;
            this.btPedra.Text = "PEDRA";
            this.btPedra.UseVisualStyleBackColor = true;
            this.btPedra.Click += new System.EventHandler(this.btPedra_Click);
            // 
            // btPaper
            // 
            this.btPaper.Location = new System.Drawing.Point(202, 78);
            this.btPaper.Name = "btPaper";
            this.btPaper.Size = new System.Drawing.Size(142, 40);
            this.btPaper.TabIndex = 4;
            this.btPaper.Text = "PAPER";
            this.btPaper.UseVisualStyleBackColor = true;
            this.btPaper.Click += new System.EventHandler(this.btPaper_Click);
            // 
            // btTisora
            // 
            this.btTisora.Location = new System.Drawing.Point(371, 78);
            this.btTisora.Name = "btTisora";
            this.btTisora.Size = new System.Drawing.Size(142, 40);
            this.btTisora.TabIndex = 5;
            this.btTisora.Text = "TISORA";
            this.btTisora.UseVisualStyleBackColor = true;
            this.btTisora.Click += new System.EventHandler(this.btTisora_Click);
            // 
            // gbJugada
            // 
            this.gbJugada.Controls.Add(this.pictureBox3);
            this.gbJugada.Controls.Add(this.pictureBox2);
            this.gbJugada.Controls.Add(this.pictureBox1);
            this.gbJugada.Controls.Add(this.btPedra);
            this.gbJugada.Controls.Add(this.btTisora);
            this.gbJugada.Controls.Add(this.btPaper);
            this.gbJugada.Font = new System.Drawing.Font("Verdana", 10F);
            this.gbJugada.Location = new System.Drawing.Point(28, 53);
            this.gbJugada.Name = "gbJugada";
            this.gbJugada.Size = new System.Drawing.Size(546, 124);
            this.gbJugada.TabIndex = 6;
            this.gbJugada.TabStop = false;
            this.gbJugada.Text = "JUGADA";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FormMDI.Properties.Resources.tijera2;
            this.pictureBox3.Location = new System.Drawing.Point(412, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormMDI.Properties.Resources.piedra2;
            this.pictureBox2.Location = new System.Drawing.Point(63, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormMDI.Properties.Resources.papel2;
            this.pictureBox1.Location = new System.Drawing.Point(239, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbJugadaJugador
            // 
            this.lbJugadaJugador.AutoSize = true;
            this.lbJugadaJugador.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbJugadaJugador.Location = new System.Drawing.Point(6, 72);
            this.lbJugadaJugador.Name = "lbJugadaJugador";
            this.lbJugadaJugador.Size = new System.Drawing.Size(163, 17);
            this.lbJugadaJugador.TabIndex = 7;
            this.lbJugadaJugador.Text = "JUGADA ANTERIOR: -";
            // 
            // gbJugador
            // 
            this.gbJugador.Controls.Add(this.lbStatusAnteriorJug);
            this.gbJugador.Controls.Add(this.lbPuntsJugador);
            this.gbJugador.Controls.Add(this.lbJugadaJugador);
            this.gbJugador.Font = new System.Drawing.Font("Verdana", 10F);
            this.gbJugador.Location = new System.Drawing.Point(28, 183);
            this.gbJugador.Name = "gbJugador";
            this.gbJugador.Size = new System.Drawing.Size(270, 142);
            this.gbJugador.TabIndex = 8;
            this.gbJugador.TabStop = false;
            this.gbJugador.Text = "JUGADOR";
            // 
            // gbComputadora
            // 
            this.gbComputadora.Controls.Add(this.lbStatusAnteriorComp);
            this.gbComputadora.Controls.Add(this.lbJugadaComputador);
            this.gbComputadora.Controls.Add(this.lbPuntsComp);
            this.gbComputadora.Font = new System.Drawing.Font("Verdana", 10F);
            this.gbComputadora.Location = new System.Drawing.Point(304, 183);
            this.gbComputadora.Name = "gbComputadora";
            this.gbComputadora.Size = new System.Drawing.Size(270, 142);
            this.gbComputadora.TabIndex = 9;
            this.gbComputadora.TabStop = false;
            this.gbComputadora.Text = "COMPUTADORA";
            // 
            // lbJugadaComputador
            // 
            this.lbJugadaComputador.AutoSize = true;
            this.lbJugadaComputador.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbJugadaComputador.Location = new System.Drawing.Point(6, 72);
            this.lbJugadaComputador.Name = "lbJugadaComputador";
            this.lbJugadaComputador.Size = new System.Drawing.Size(163, 17);
            this.lbJugadaComputador.TabIndex = 8;
            this.lbJugadaComputador.Text = "JUGADA ANTERIOR: -";
            // 
            // lbTotalPartides
            // 
            this.lbTotalPartides.AutoSize = true;
            this.lbTotalPartides.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbTotalPartides.Location = new System.Drawing.Point(25, 334);
            this.lbTotalPartides.Name = "lbTotalPartides";
            this.lbTotalPartides.Size = new System.Drawing.Size(80, 17);
            this.lbTotalPartides.TabIndex = 8;
            this.lbTotalPartides.Text = "RONDA: 0";
            // 
            // btJugarRonda
            // 
            this.btJugarRonda.Font = new System.Drawing.Font("Verdana", 10F);
            this.btJugarRonda.Location = new System.Drawing.Point(399, 331);
            this.btJugarRonda.Name = "btJugarRonda";
            this.btJugarRonda.Size = new System.Drawing.Size(175, 23);
            this.btJugarRonda.TabIndex = 10;
            this.btJugarRonda.Text = "JUGAR RONDA";
            this.btJugarRonda.UseVisualStyleBackColor = true;
            this.btJugarRonda.Click += new System.EventHandler(this.btJugarRonda_Click);
            // 
            // lbStatusAnteriorJug
            // 
            this.lbStatusAnteriorJug.AutoSize = true;
            this.lbStatusAnteriorJug.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lbStatusAnteriorJug.Location = new System.Drawing.Point(6, 105);
            this.lbStatusAnteriorJug.Name = "lbStatusAnteriorJug";
            this.lbStatusAnteriorJug.Size = new System.Drawing.Size(15, 17);
            this.lbStatusAnteriorJug.TabIndex = 8;
            this.lbStatusAnteriorJug.Text = "-";
            // 
            // lbStatusAnteriorComp
            // 
            this.lbStatusAnteriorComp.AutoSize = true;
            this.lbStatusAnteriorComp.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lbStatusAnteriorComp.Location = new System.Drawing.Point(6, 105);
            this.lbStatusAnteriorComp.Name = "lbStatusAnteriorComp";
            this.lbStatusAnteriorComp.Size = new System.Drawing.Size(15, 17);
            this.lbStatusAnteriorComp.TabIndex = 9;
            this.lbStatusAnteriorComp.Text = "-";
            // 
            // lbJugadaActual
            // 
            this.lbJugadaActual.AutoSize = true;
            this.lbJugadaActual.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbJugadaActual.Location = new System.Drawing.Point(139, 334);
            this.lbJugadaActual.Name = "lbJugadaActual";
            this.lbJugadaActual.Size = new System.Drawing.Size(146, 17);
            this.lbJugadaActual.TabIndex = 9;
            this.lbJugadaActual.Text = "JUGADA ACTUAL: -";
            // 
            // FrmPedraPaperTisora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbJugadaActual);
            this.Controls.Add(this.btJugarRonda);
            this.Controls.Add(this.lbTotalPartides);
            this.Controls.Add(this.gbComputadora);
            this.Controls.Add(this.gbJugador);
            this.Controls.Add(this.gbJugada);
            this.Controls.Add(this.lbTitol);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPedraPaperTisora";
            this.Text = "Pedra - Paper - Tisora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedraPaperTisora_FormClosing);
            this.gbJugada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbJugador.ResumeLayout(false);
            this.gbJugador.PerformLayout();
            this.gbComputadora.ResumeLayout(false);
            this.gbComputadora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPuntsJugador;
        private System.Windows.Forms.Label lbPuntsComp;
        private System.Windows.Forms.Label lbTitol;
        private System.Windows.Forms.Button btPedra;
        private System.Windows.Forms.Button btPaper;
        private System.Windows.Forms.Button btTisora;
        private System.Windows.Forms.GroupBox gbJugada;
        private System.Windows.Forms.Label lbJugadaJugador;
        private System.Windows.Forms.GroupBox gbJugador;
        private System.Windows.Forms.GroupBox gbComputadora;
        private System.Windows.Forms.Label lbJugadaComputador;
        private System.Windows.Forms.Label lbTotalPartides;
        private System.Windows.Forms.Button btJugarRonda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbStatusAnteriorJug;
        private System.Windows.Forms.Label lbStatusAnteriorComp;
        private System.Windows.Forms.Label lbJugadaActual;
    }
}