namespace ATPCenterGym
{
    partial class ABMClases
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.cbTipoClases = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            this.gbxConfirmarAccion = new System.Windows.Forms.GroupBox();
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.cbBusTipoClases = new System.Windows.Forms.ComboBox();
            this.txtBusClase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            this.gbxAcciones.SuspendLayout();
            this.gbxConfirmarAccion.SuspendLayout();
            this.gbxBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Location = new System.Drawing.Point(53, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de clase:";
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.txtClase);
            this.gbxDetalle.Controls.Add(this.cbTipoClases);
            this.gbxDetalle.Controls.Add(this.label16);
            this.gbxDetalle.Controls.Add(this.label11);
            this.gbxDetalle.Location = new System.Drawing.Point(315, 87);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(306, 181);
            this.gbxDetalle.TabIndex = 17;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle Clase Seleccionado";
            // 
            // txtClase
            // 
            this.txtClase.Location = new System.Drawing.Point(102, 102);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(185, 20);
            this.txtClase.TabIndex = 50;
            // 
            // cbTipoClases
            // 
            this.cbTipoClases.FormattingEnabled = true;
            this.cbTipoClases.Location = new System.Drawing.Point(102, 51);
            this.cbTipoClases.Name = "cbTipoClases";
            this.cbTipoClases.Size = new System.Drawing.Size(185, 21);
            this.cbTipoClases.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Nombre clase:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tipo de clase:";
            // 
            // dgvClases
            // 
            this.dgvClases.AllowUserToAddRows = false;
            this.dgvClases.AllowUserToDeleteRows = false;
            this.dgvClases.AllowUserToOrderColumns = true;
            this.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClases.Location = new System.Drawing.Point(14, 126);
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.ReadOnly = true;
            this.dgvClases.Size = new System.Drawing.Size(267, 311);
            this.dgvClases.TabIndex = 12;
            this.dgvClases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClases_CellClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Refresh;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Location = new System.Drawing.Point(171, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 42);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Undo;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(177, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 41);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Floppy;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Location = new System.Drawing.Point(35, 25);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 41);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::ATPCenterGym.Properties.Resources.Home;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVolver.Location = new System.Drawing.Point(22, 393);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 41);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Delete;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Location = new System.Drawing.Point(22, 177);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 39);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::ATPCenterGym.Properties.Resources.Add;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.Location = new System.Drawing.Point(22, 33);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 41);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Edit;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Location = new System.Drawing.Point(22, 104);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 39);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.Controls.Add(this.btnVolver);
            this.gbxAcciones.Controls.Add(this.btnEliminar);
            this.gbxAcciones.Controls.Add(this.btnNuevo);
            this.gbxAcciones.Controls.Add(this.btnModificar);
            this.gbxAcciones.Location = new System.Drawing.Point(627, 12);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(128, 451);
            this.gbxAcciones.TabIndex = 18;
            this.gbxAcciones.TabStop = false;
            this.gbxAcciones.Text = "Acciones";
            // 
            // gbxConfirmarAccion
            // 
            this.gbxConfirmarAccion.Controls.Add(this.btnCancelar);
            this.gbxConfirmarAccion.Controls.Add(this.btnAceptar);
            this.gbxConfirmarAccion.Location = new System.Drawing.Point(315, 380);
            this.gbxConfirmarAccion.Name = "gbxConfirmarAccion";
            this.gbxConfirmarAccion.Size = new System.Drawing.Size(306, 83);
            this.gbxConfirmarAccion.TabIndex = 19;
            this.gbxConfirmarAccion.TabStop = false;
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Controls.Add(this.cbBusTipoClases);
            this.gbxBuscador.Controls.Add(this.txtBusClase);
            this.gbxBuscador.Controls.Add(this.label1);
            this.gbxBuscador.Controls.Add(this.dgvClases);
            this.gbxBuscador.Controls.Add(this.btnLimpiar);
            this.gbxBuscador.Controls.Add(this.btnBuscar);
            this.gbxBuscador.Controls.Add(this.label3);
            this.gbxBuscador.Location = new System.Drawing.Point(12, 12);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Size = new System.Drawing.Size(297, 451);
            this.gbxBuscador.TabIndex = 16;
            this.gbxBuscador.TabStop = false;
            this.gbxBuscador.Text = "Buscador";
            // 
            // cbBusTipoClases
            // 
            this.cbBusTipoClases.FormattingEnabled = true;
            this.cbBusTipoClases.Location = new System.Drawing.Point(104, 19);
            this.cbBusTipoClases.Name = "cbBusTipoClases";
            this.cbBusTipoClases.Size = new System.Drawing.Size(177, 21);
            this.cbBusTipoClases.TabIndex = 50;
            // 
            // txtBusClase
            // 
            this.txtBusClase.Location = new System.Drawing.Point(104, 45);
            this.txtBusClase.Name = "txtBusClase";
            this.txtBusClase.Size = new System.Drawing.Size(177, 20);
            this.txtBusClase.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de clase:";
            // 
            // ABMClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 475);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.gbxAcciones);
            this.Controls.Add(this.gbxConfirmarAccion);
            this.Controls.Add(this.gbxBuscador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMClases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases";
            this.Load += new System.EventHandler(this.ABMClases_Load);
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            this.gbxAcciones.ResumeLayout(false);
            this.gbxConfirmarAccion.ResumeLayout(false);
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbxAcciones;
        private System.Windows.Forms.GroupBox gbxConfirmarAccion;
        private System.Windows.Forms.GroupBox gbxBuscador;
        private System.Windows.Forms.TextBox txtBusClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoClases;
        private System.Windows.Forms.ComboBox cbBusTipoClases;
        private System.Windows.Forms.TextBox txtClase;
    }
}