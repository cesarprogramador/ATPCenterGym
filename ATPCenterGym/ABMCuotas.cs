using ATPCenter.tiposdeclase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATPCenterGym
{
    public partial class ABMCuotas : Form
    {
        public string _idcurso = "";
        ClassCursos _inscrialu;
        DataSet _cuotas;
        decimal _deuda = 0;
        StreamWriter arch;
        string ruta = "";

        public ABMCuotas()
        {
            InitializeComponent();
        }

        private void ABMCuotas_Load(object sender, EventArgs e)
        {
            this._inscrialu = new ClassCursos();

            this._cuotas = this._inscrialu.BuscarDatosSocioInscripto(this._idcurso, "S", "Socio");

            if (this._cuotas.Tables["Socio"].Rows.Count > 0)
            {
                this.txtApellido.Text = this._cuotas.Tables["Socio"].Rows[0][0].ToString();
                this.txtNombre.Text = this._cuotas.Tables["Socio"].Rows[0][1].ToString();
                this.txtDni.Text = this._cuotas.Tables["Socio"].Rows[0][2].ToString();
                this.txtEmail.Text = this._cuotas.Tables["Socio"].Rows[0][3].ToString();
                this.txtPunto.Text = this._cuotas.Tables["Socio"].Rows[0][4].ToString();
                this.txtTipoClase.Text = this._cuotas.Tables["Socio"].Rows[0][5].ToString();
                this.txtNombreClase.Text = this._cuotas.Tables["Socio"].Rows[0][6].ToString();
                this.txtMontoCuotaTotal.Text = this._cuotas.Tables["Socio"].Rows[0][7].ToString();

                this.dgvHistorialCuotas.DataSource = this._inscrialu.BuscarDatosSocioInscripto(this._idcurso, "C", "CuotasSocio");
                this.dgvHistorialCuotas.DataMember = "CuotasSocio";

                if (this.dgvHistorialCuotas.Rows.Count > 0)
                {
                    //Idcurso
                    this.dgvHistorialCuotas.Columns[0].Visible = false;
                    //Fecha real pago
                    this.dgvHistorialCuotas.Columns[2].Visible = false;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._inscrialu.idcuota = this.dgvHistorialCuotas[0, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
            this._inscrialu.numcuota = int.Parse(this.dgvHistorialCuotas[1, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString()) + 1;
            this._inscrialu.idcurso = this._idcurso;
            this._inscrialu.fecharealpago = DateTime.Now.ToString();
            this._inscrialu.fechaproximopago = DateTime.Parse(this.txtFechaPago.Text).AddMonths(1).ToString("yyyy/MM/dd");
            this._inscrialu.montocuota = Decimal.Parse(this.txtMontoCuota.Text);
            this._inscrialu.montopagado = Decimal.Parse(this.txtAlumnoPaga.Text);
            this._inscrialu.montosaldo = Decimal.Parse(this.txtMontoDeuda.Text);

            this._inscrialu.accion = "N";
            this._inscrialu.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._inscrialu.idempleadoaccion = 1; //Viene del login
            this._inscrialu.idpuntoaccion = 1; //Viene del login

            this.dgvHistorialCuotas.DataSource = this._inscrialu.ABMCuotasSocios(this._inscrialu, "CuotasSocio");
            this.dgvHistorialCuotas.DataMember = "CuotasSocio";

            if (this.dgvHistorialCuotas.Rows.Count > 0)
            {
                //Idcurso
                this.dgvHistorialCuotas.Columns[0].Visible = false;
                //Fecha real pago
                this.dgvHistorialCuotas.Columns[2].Visible = false;
            }
        }

        private void txtAlumnoPaga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this._deuda = decimal.Parse(this.txtDebePagar.Text) - decimal.Parse(this.txtAlumnoPaga.Text);
                this.txtMontoDeuda.Text = this._deuda.ToString();
                this.btnAceptar.Enabled = true;
                this.btnAceptar.Focus();
            }
        }

        private void dgvHistorialCuotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvHistorialCuotas.Rows.Count > 0)
            {
                this.txtNumCuota.Text = "Cuota Nº" + this.dgvHistorialCuotas[1, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
                this.txtFechaPago.Text = DateTime.Parse(this.dgvHistorialCuotas[2, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString()).ToString("dd/MM/yyyy");
                this.txtFechaRealPago.Text = this.dgvHistorialCuotas[3, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
                this.txtMontoCuota.Text = this.dgvHistorialCuotas[4, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
                this.txtAlumnoPaga.Text = this.dgvHistorialCuotas[5, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();
                this.txtMontoSaldo.Text = this.dgvHistorialCuotas[6, this.dgvHistorialCuotas.CurrentCell.RowIndex].Value.ToString();

                if (this.txtAlumnoPaga.Text.Length <= 0) this.txtAlumnoPaga.Text = "0.00";

                this._deuda = decimal.Parse(this.txtMontoCuota.Text) + decimal.Parse(this.txtMontoSaldo.Text);
                this.txtDebePagar.Text = this._deuda.ToString();

                this._deuda = decimal.Parse(this.txtDebePagar.Text) - decimal.Parse(this.txtAlumnoPaga.Text);
                this.txtMontoDeuda.Text = this._deuda.ToString();

                this.btnAceptar.Enabled = true;
            }
        }

        private void txtMontoCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this._deuda = decimal.Parse(this.txtMontoCuota.Text) + decimal.Parse(this.txtMontoSaldo.Text);
                this.txtDebePagar.Text = this._deuda.ToString();
                this.txtAlumnoPaga.Focus();
            }
        }
    }
}
