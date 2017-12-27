namespace ATPCenterGym
{
    partial class Asistencias
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
            this.components = new System.ComponentModel.Container();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApeNomb = new System.Windows.Forms.Label();
            this.lblTipoPerPunto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaHoraAcceso = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.pbxFotoSocio = new System.Windows.Forms.PictureBox();
            this.lblAptoMedico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.Color.White;
            this.lblFechaHora.Location = new System.Drawing.Point(283, 24);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(275, 31);
            this.lblFechaHora.TabIndex = 1;
            this.lblFechaHora.Text = "27/12/2017 hh:mm:ss";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datos persona";
            // 
            // lblApeNomb
            // 
            this.lblApeNomb.AutoSize = true;
            this.lblApeNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeNomb.ForeColor = System.Drawing.Color.White;
            this.lblApeNomb.Location = new System.Drawing.Point(284, 97);
            this.lblApeNomb.Name = "lblApeNomb";
            this.lblApeNomb.Size = new System.Drawing.Size(30, 25);
            this.lblApeNomb.TabIndex = 3;
            this.lblApeNomb.Text = "...";
            // 
            // lblTipoPerPunto
            // 
            this.lblTipoPerPunto.AutoSize = true;
            this.lblTipoPerPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPerPunto.ForeColor = System.Drawing.Color.White;
            this.lblTipoPerPunto.Location = new System.Drawing.Point(284, 131);
            this.lblTipoPerPunto.Name = "lblTipoPerPunto";
            this.lblTipoPerPunto.Size = new System.Drawing.Size(30, 25);
            this.lblTipoPerPunto.TabIndex = 4;
            this.lblTipoPerPunto.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(284, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha y hora de ingreso";
            // 
            // lblFechaHoraAcceso
            // 
            this.lblFechaHoraAcceso.AutoSize = true;
            this.lblFechaHoraAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraAcceso.ForeColor = System.Drawing.Color.White;
            this.lblFechaHoraAcceso.Location = new System.Drawing.Point(408, 221);
            this.lblFechaHoraAcceso.Name = "lblFechaHoraAcceso";
            this.lblFechaHoraAcceso.Size = new System.Drawing.Size(30, 25);
            this.lblFechaHoraAcceso.TabIndex = 6;
            this.lblFechaHoraAcceso.Text = "...";
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(619, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 16);
            this.lblClose.TabIndex = 28;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pbxFotoSocio
            // 
            this.pbxFotoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFotoSocio.Image = global::ATPCenterGym.Properties.Resources.black;
            this.pbxFotoSocio.Location = new System.Drawing.Point(25, 17);
            this.pbxFotoSocio.Name = "pbxFotoSocio";
            this.pbxFotoSocio.Size = new System.Drawing.Size(211, 226);
            this.pbxFotoSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFotoSocio.TabIndex = 0;
            this.pbxFotoSocio.TabStop = false;
            this.pbxFotoSocio.Click += new System.EventHandler(this.pbxFotoSocio_Click);
            // 
            // lblAptoMedico
            // 
            this.lblAptoMedico.AutoSize = true;
            this.lblAptoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAptoMedico.ForeColor = System.Drawing.Color.White;
            this.lblAptoMedico.Location = new System.Drawing.Point(284, 165);
            this.lblAptoMedico.Name = "lblAptoMedico";
            this.lblAptoMedico.Size = new System.Drawing.Size(30, 25);
            this.lblAptoMedico.TabIndex = 29;
            this.lblAptoMedico.Text = "...";
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(638, 262);
            this.Controls.Add(this.lblAptoMedico);
            this.Controls.Add(this.lblFechaHoraAcceso);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTipoPerPunto);
            this.Controls.Add(this.lblApeNomb);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxFotoSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Asistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencias";
            this.Load += new System.EventHandler(this.Asistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFotoSocio;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApeNomb;
        private System.Windows.Forms.Label lblTipoPerPunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechaHoraAcceso;
        private System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblAptoMedico;
    }
}