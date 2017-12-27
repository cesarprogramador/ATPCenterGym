using ATPCenter.puntos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATPCenterGym
{
    public partial class ABMPuntos : Form
    {
        ClassPuntos _puntos;
        DataSet _puntoselec;
        string bandera;

        public ABMPuntos()
        {
            InitializeComponent();
        }

        private void ABMPuntos_Load(object sender, EventArgs e)
        {
            this._puntos = new ClassPuntos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._puntos.idpunto = "0";
            this._puntos.nombrepunto = this.txtBusNombres.Text;
            this._puntos.calle = this.txtBusCalle.Text;

            this.dgvPuntos.DataSource = this._puntos.BuscarPuntos(this._puntos, "Puntos");
            this.dgvPuntos.DataMember = "Puntos";

            if (this.dgvPuntos.Rows.Count > 0) this.dgvPuntos.Columns[0].Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBusNombres.Text = "";
            this.txtBusCalle.Text = "";

            this.dgvPuntos.DataSource = null;
        }

        private void dgvPuntos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPuntos.Rows.Count > 0)
            {
                this._puntos.idpunto = this.dgvPuntos[0, this.dgvPuntos.CurrentCell.RowIndex].Value.ToString();

                this._puntoselec = this._puntos.BuscarPuntos(this._puntos, "Punto");

                if (this._puntoselec.Tables["Punto"].Rows.Count > 0)
                {
                    this.txtNombre.Text = this._puntoselec.Tables["Punto"].Rows[0][0].ToString();
                    this.txtCel.Text = this._puntoselec.Tables["Punto"].Rows[0][2].ToString();
                    this.txtTel.Text = this._puntoselec.Tables["Punto"].Rows[0][3].ToString();
                    this.txtCalle.Text = this._puntoselec.Tables["Punto"].Rows[0][4].ToString();
                    this.txtNumero.Text = this._puntoselec.Tables["Punto"].Rows[0][5].ToString();
                    this.txtPiso.Text = this._puntoselec.Tables["Punto"].Rows[0][6].ToString();
                    this.txtDpto.Text = this._puntoselec.Tables["Punto"].Rows[0][7].ToString();
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.bandera = "N";
            this._puntos.idpunto = "0";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.bandera = "M";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.bandera = "B";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bandera = "";
            this._puntos.idpunto = "0";
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._puntos.nombrepunto = this.txtNombre.Text;
            this._puntos.cel = this.txtCel.Text;
            this._puntos.tel = this.txtTel.Text;
            this._puntos.calle = this.txtCalle.Text;
            this._puntos.numero = this.txtNumero.Text;
            this._puntos.piso = this.txtPiso.Text;
            this._puntos.dpto = this.txtDpto.Text;

            this._puntos.accion = this.bandera;
            this._puntos.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._puntos.idempleadoaccion = 1; //Viene del login
            this._puntos.idpuntoaccion = 1; //Viene del login

            this.dgvPuntos.DataSource = this._puntos.ABMPunto(this._puntos, "accion");
            this.dgvPuntos.DataMember = "accion";

            if (this.dgvPuntos.Rows.Count > 0)
            {
                this.dgvPuntos.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this._puntos.accion == "B")
                {
                    MessageBox.Show("Acción realizada con exito", "Atención!!!");

                    this.btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error en la ejecución de la acción en curso. Controle datos!!!", "Error!!!");
                }
            }
        }
    }
}
