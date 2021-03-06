﻿namespace ATPCenterGym
{
    partial class ABMEmpleados
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
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbBusPuntos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBusEmpleadoTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.gbxDetalleOperaciones = new System.Windows.Forms.GroupBox();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPunto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbxConfirmarAccion = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gbxDetalle.SuspendLayout();
            this.gbxDetalleOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.gbxAcciones.SuspendLayout();
            this.gbxConfirmarAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Controls.Add(this.dgvEmpleados);
            this.gbxBuscador.Controls.Add(this.btnLimpiar);
            this.gbxBuscador.Controls.Add(this.btnBuscar);
            this.gbxBuscador.Controls.Add(this.cbBusPuntos);
            this.gbxBuscador.Controls.Add(this.label5);
            this.gbxBuscador.Controls.Add(this.cbBusEmpleadoTipo);
            this.gbxBuscador.Controls.Add(this.label4);
            this.gbxBuscador.Controls.Add(this.txtBusDni);
            this.gbxBuscador.Controls.Add(this.label3);
            this.gbxBuscador.Controls.Add(this.txtBusNombres);
            this.gbxBuscador.Controls.Add(this.label2);
            this.gbxBuscador.Controls.Add(this.txtBusApellidos);
            this.gbxBuscador.Controls.Add(this.label1);
            this.gbxBuscador.Location = new System.Drawing.Point(12, 12);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Size = new System.Drawing.Size(297, 614);
            this.gbxBuscador.TabIndex = 0;
            this.gbxBuscador.TabStop = false;
            this.gbxBuscador.Text = "Buscador";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(14, 210);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(267, 388);
            this.dgvEmpleados.TabIndex = 12;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Refresh;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Location = new System.Drawing.Point(169, 155);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 42);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Location = new System.Drawing.Point(51, 155);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbBusPuntos
            // 
            this.cbBusPuntos.FormattingEnabled = true;
            this.cbBusPuntos.Location = new System.Drawing.Point(90, 121);
            this.cbBusPuntos.Name = "cbBusPuntos";
            this.cbBusPuntos.Size = new System.Drawing.Size(191, 21);
            this.cbBusPuntos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Punto:";
            // 
            // cbBusEmpleadoTipo
            // 
            this.cbBusEmpleadoTipo.FormattingEnabled = true;
            this.cbBusEmpleadoTipo.Location = new System.Drawing.Point(90, 94);
            this.cbBusEmpleadoTipo.Name = "cbBusEmpleadoTipo";
            this.cbBusEmpleadoTipo.Size = new System.Drawing.Size(191, 21);
            this.cbBusEmpleadoTipo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Empleado tipo:";
            // 
            // txtBusDni
            // 
            this.txtBusDni.Location = new System.Drawing.Point(90, 68);
            this.txtBusDni.Name = "txtBusDni";
            this.txtBusDni.Size = new System.Drawing.Size(191, 20);
            this.txtBusDni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dni:";
            // 
            // txtBusNombres
            // 
            this.txtBusNombres.Location = new System.Drawing.Point(90, 42);
            this.txtBusNombres.Name = "txtBusNombres";
            this.txtBusNombres.Size = new System.Drawing.Size(191, 20);
            this.txtBusNombres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // txtBusApellidos
            // 
            this.txtBusApellidos.Location = new System.Drawing.Point(90, 16);
            this.txtBusApellidos.Name = "txtBusApellidos";
            this.txtBusApellidos.Size = new System.Drawing.Size(191, 20);
            this.txtBusApellidos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido:";
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.gbxDetalleOperaciones);
            this.gbxDetalle.Controls.Add(this.pbxFoto);
            this.gbxDetalle.Controls.Add(this.txtDpto);
            this.gbxDetalle.Controls.Add(this.label18);
            this.gbxDetalle.Controls.Add(this.txtPiso);
            this.gbxDetalle.Controls.Add(this.label19);
            this.gbxDetalle.Controls.Add(this.txtNumero);
            this.gbxDetalle.Controls.Add(this.label17);
            this.gbxDetalle.Controls.Add(this.txtCalle);
            this.gbxDetalle.Controls.Add(this.label14);
            this.gbxDetalle.Controls.Add(this.txtEmail);
            this.gbxDetalle.Controls.Add(this.label15);
            this.gbxDetalle.Controls.Add(this.txtTel);
            this.gbxDetalle.Controls.Add(this.label16);
            this.gbxDetalle.Controls.Add(this.txtCel);
            this.gbxDetalle.Controls.Add(this.label11);
            this.gbxDetalle.Controls.Add(this.txtCuil);
            this.gbxDetalle.Controls.Add(this.label12);
            this.gbxDetalle.Controls.Add(this.txtDni);
            this.gbxDetalle.Controls.Add(this.label13);
            this.gbxDetalle.Controls.Add(this.cbPunto);
            this.gbxDetalle.Controls.Add(this.label6);
            this.gbxDetalle.Controls.Add(this.cbTipoEmpleado);
            this.gbxDetalle.Controls.Add(this.label7);
            this.gbxDetalle.Controls.Add(this.txtFechaNac);
            this.gbxDetalle.Controls.Add(this.label8);
            this.gbxDetalle.Controls.Add(this.txtNombre);
            this.gbxDetalle.Controls.Add(this.label9);
            this.gbxDetalle.Controls.Add(this.txtApellido);
            this.gbxDetalle.Controls.Add(this.label10);
            this.gbxDetalle.Location = new System.Drawing.Point(315, 12);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(627, 525);
            this.gbxDetalle.TabIndex = 1;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle Empleado Seleccionado";
            // 
            // gbxDetalleOperaciones
            // 
            this.gbxDetalleOperaciones.Controls.Add(this.dgvOperaciones);
            this.gbxDetalleOperaciones.Location = new System.Drawing.Point(31, 290);
            this.gbxDetalleOperaciones.Name = "gbxDetalleOperaciones";
            this.gbxDetalleOperaciones.Size = new System.Drawing.Size(559, 215);
            this.gbxDetalleOperaciones.TabIndex = 30;
            this.gbxDetalleOperaciones.TabStop = false;
            this.gbxDetalleOperaciones.Text = "Operaciones que puede hacer";
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.AllowUserToOrderColumns = true;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(21, 28);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.Size = new System.Drawing.Size(524, 160);
            this.dgvOperaciones.TabIndex = 13;
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Image = global::ATPCenterGym.Properties.Resources.check_user_icon;
            this.pbxFoto.Location = new System.Drawing.Point(412, 19);
            this.pbxFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(164, 157);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 29;
            this.pbxFoto.TabStop = false;
            // 
            // txtDpto
            // 
            this.txtDpto.Location = new System.Drawing.Point(399, 207);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(191, 20);
            this.txtDpto.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(349, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Nº Dpto:";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(399, 181);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(191, 20);
            this.txtPiso.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(367, 185);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Piso:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(90, 260);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(191, 20);
            this.txtNumero.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Número:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(90, 234);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(191, 20);
            this.txtCalle.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Calle:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Email:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(90, 182);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 20);
            this.txtTel.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Télefono:";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(90, 156);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(191, 20);
            this.txtCel.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Célular:";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(90, 130);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(191, 20);
            this.txtCuil.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cuil:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(90, 104);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(191, 20);
            this.txtDni.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Dni:";
            // 
            // cbPunto
            // 
            this.cbPunto.FormattingEnabled = true;
            this.cbPunto.Location = new System.Drawing.Point(399, 263);
            this.cbPunto.Name = "cbPunto";
            this.cbPunto.Size = new System.Drawing.Size(191, 21);
            this.cbPunto.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Punto:";
            // 
            // cbTipoEmpleado
            // 
            this.cbTipoEmpleado.FormattingEnabled = true;
            this.cbTipoEmpleado.Location = new System.Drawing.Point(399, 236);
            this.cbTipoEmpleado.Name = "cbTipoEmpleado";
            this.cbTipoEmpleado.Size = new System.Drawing.Size(191, 21);
            this.cbTipoEmpleado.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Empleado:";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(90, 78);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(191, 20);
            this.txtFechaNac.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fecha Nac.:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombres:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(90, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(191, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Apellido:";
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.Controls.Add(this.btnVolver);
            this.gbxAcciones.Controls.Add(this.btnEliminar);
            this.gbxAcciones.Controls.Add(this.btnNuevo);
            this.gbxAcciones.Controls.Add(this.btnModificar);
            this.gbxAcciones.Location = new System.Drawing.Point(948, 12);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(158, 614);
            this.gbxAcciones.TabIndex = 2;
            this.gbxAcciones.TabStop = false;
            this.gbxAcciones.Text = "Acciones";
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::ATPCenterGym.Properties.Resources.Home;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVolver.Location = new System.Drawing.Point(36, 552);
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
            this.btnEliminar.Location = new System.Drawing.Point(36, 318);
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
            this.btnNuevo.Location = new System.Drawing.Point(36, 44);
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
            this.btnModificar.Location = new System.Drawing.Point(36, 185);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 39);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbxConfirmarAccion
            // 
            this.gbxConfirmarAccion.Controls.Add(this.btnCancelar);
            this.gbxConfirmarAccion.Controls.Add(this.btnAceptar);
            this.gbxConfirmarAccion.Location = new System.Drawing.Point(315, 543);
            this.gbxConfirmarAccion.Name = "gbxConfirmarAccion";
            this.gbxConfirmarAccion.Size = new System.Drawing.Size(627, 83);
            this.gbxConfirmarAccion.TabIndex = 3;
            this.gbxConfirmarAccion.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ATPCenterGym.Properties.Resources.Undo;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(370, 21);
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
            this.btnAceptar.Location = new System.Drawing.Point(143, 21);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 41);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ABMEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 638);
            this.Controls.Add(this.gbxConfirmarAccion);
            this.Controls.Add(this.gbxAcciones);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.gbxBuscador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Empleados";
            this.Load += new System.EventHandler(this.ABMEmpleados_Load);
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            this.gbxDetalleOperaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.gbxAcciones.ResumeLayout(false);
            this.gbxConfirmarAccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBuscador;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbBusPuntos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBusEmpleadoTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.GroupBox gbxDetalleOperaciones;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPunto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbxAcciones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxConfirmarAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}