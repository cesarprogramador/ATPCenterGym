using ATPCenter.cajadeldia;
using ATPCenter.personas;
using ATPCenter.tiposdeclase;
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
    public partial class Principal : Form
    {
        ClassPersonas _loginper;
        ClassCursos _cursos;
        ClassCajaDelDia _caja;

        public Principal()
        {
            InitializeComponent();
        }

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmpleados formempleado = new ABMEmpleados();
            formempleado.Show();
        }

        private void aBMProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProfesores formprofesor = new ABMProfesores();
            formprofesor.Show();
        }

        private void aBMSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSocios formsocio = new ABMSocios();
            formsocio.Show();
        }

        private void salirProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this._loginper = new ClassPersonas();

            Login formlogin = new Login();

            formlogin.ShowDialog();

            this._loginper.idpersona = formlogin.idpersona;
            this._loginper.apellido = formlogin.apellido;
            this._loginper.nombre = formlogin.nombre;
            this._loginper.tipopersona = formlogin.tipopersona;
            this._loginper.idpunto = "0";
            this._loginper.punto = formlogin.punto;

            this.lblTituloForm.Text = "Movimientos - Usuario: " + this._loginper.apellido + ", " + this._loginper.nombre + " - Cargo: " + this._loginper.tipopersona + " - Punto: " + this._loginper.punto;

            this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;

            DataTable _puntos = this._loginper.BuscarPuntos(this._loginper);

            this.cbBusPuntos.DataSource = _puntos;
            this.cbBusPuntos.ValueMember = "idpunto";
            this.cbBusPuntos.DisplayMember = "nombrepunto";
            this.cbBusPuntos.Text = "";

            this._cursos = new ClassCursos();
            this._cursos.idpunto = "0";
            this._cursos.tipodeclase = "";

            this.cbBusTipoClase.DataSource = this._cursos.BuscarTiposDeClases(this._cursos);
            this.cbBusTipoClase.ValueMember = "idtipodeclase";
            this.cbBusTipoClase.DisplayMember = "tipodeclase";
            this.cbBusTipoClase.Text = "";

            this.cbBusNombreClase.Enabled = false;
        }

        private void btnBusTipoClase_Click(object sender, EventArgs e)
        {
            this._cursos.idpunto = this.cbBusPuntos.SelectedValue.ToString();
            this._cursos.tipodeclase = "";
            this.cbBusTipoClase.Text = "";
            this.cbBusTipoClase.DataSource = this._cursos.BuscarTiposDeClases(this._cursos);
            this.cbBusTipoClase.ValueMember = "idtipodeclase";
            this.cbBusTipoClase.DisplayMember = "tipodeclase";
            this.cbBusTipoClase.Enabled = true;
        }

        private void btnBusNombreClase_Click(object sender, EventArgs e)
        {
            try
            {
                this.cbBusNombreClase.Enabled = true;

                this._cursos.idclase = "0";
                this._cursos.idtipodeclase = this.cbBusTipoClase.SelectedValue.ToString();
                this._cursos.tipodeclase = "";
                this.cbBusNombreClase.Text = "";
                this.cbBusNombreClase.DataSource = this._cursos.BuscarNombresDeClases(this._cursos);
                this.cbBusNombreClase.ValueMember = "idclase";
                this.cbBusNombreClase.DisplayMember = "nombreclase";
            }
            catch (Exception err)
            {
                this.cbBusNombreClase.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cbBusTipoPersona.Text = "Todos";
            this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
            this.txtBusApellido.Text = "";
            this.txtBusNombre.Text = "";
            this.txtBusDetalleMovimiento.Text = "";

            this.cbBusTipoOperaciones.Text = "Caja del día";
            this.cbBusPuntos.Text = "";

            this._cursos.idpunto = "0";
            this._cursos.tipodeclase = "";

            this.cbBusTipoClase.DataSource = this._cursos.BuscarTiposDeClases(this._cursos);
            this.cbBusTipoClase.ValueMember = "idtipodeclase";
            this.cbBusTipoClase.DisplayMember = "tipodeclase";
            this.cbBusTipoClase.Text = "";

            this.cbBusNombreClase.DataSource = null;
            this.cbBusNombreClase.Enabled = false;
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._loginper = new ClassPersonas();

            Login formlogin = new Login();

            formlogin.ShowDialog();

            this._loginper.idpersona = formlogin.idpersona;
            this._loginper.apellido = formlogin.apellido;
            this._loginper.nombre = formlogin.nombre;
            this._loginper.tipopersona = formlogin.tipopersona;
            this._loginper.idpunto = "0";
            this._loginper.punto = formlogin.punto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._caja = new ClassCajaDelDia();

            this._caja.tipooperacion = this.cbBusTipoOperaciones.Text;
            this._caja.fechainicio = this.txtBusFechaIni.Text;
            this._caja.fechafin = this.txtBusFechaFin.Text;

            switch (this.cbBusTipoOperaciones.Text)
            {
                case "Caja del día":
                    this._caja.tipopersona = "";
                    this._caja.apellidos = this.txtBusApellido.Text;
                    this._caja.nombres = this.txtBusNombre.Text;
                    this._caja.detallemovimiento = this.txtBusDetalleMovimiento.Text;
                    this._caja.punto = this.cbBusPuntos.Text;
                    this._caja.nombreclase = this.cbBusNombreClase.Text;
                    this._caja.tipoclase = this.cbBusTipoClase.Text;
                    break;
                case "Ingresos":
                    if (this.cbBusTipoPersona.Text == "Todos los ingresos")
                    {
                        this._caja.tipopersona = "";
                        this._caja.apellidos = "";
                        this._caja.nombres = "";
                    }
                    else
                    {//Empleado o Socios
                        this._caja.tipopersona = this.cbBusTipoPersona.Text;
                        this._caja.apellidos = this.txtBusApellido.Text;
                        this._caja.nombres = this.txtBusNombre.Text;
                    }

                    this._caja.detallemovimiento = this.txtBusDetalleMovimiento.Text;
                    this._caja.punto = this.cbBusPuntos.Text;
                    this._caja.tipoclase = this.cbBusTipoClase.Text;
                    this._caja.nombreclase = this.cbBusNombreClase.Text;
                    break;
                case "Egresos":
                    if (this.cbBusTipoPersona.Text == "Todos los egresos")
                    {
                        this._caja.tipopersona = "";
                        this._caja.apellidos = "";
                        this._caja.nombres = "";
                    }
                    else
                    {//Empleado, proveedores o profesores
                        this._caja.tipopersona = this.cbBusTipoPersona.Text;
                        this._caja.apellidos = this.txtBusApellido.Text;
                        this._caja.nombres = this.txtBusNombre.Text;
                    }

                    this._caja.detallemovimiento = this.txtBusDetalleMovimiento.Text;
                    this._caja.punto = this.cbBusPuntos.Text;
                    this._caja.tipoclase = "";
                    this._caja.nombreclase = "";
                    break;
            }

            this.dgvDetalleCaja.DataSource = this._caja.BuscarCajaDelDia(this._caja, "CajaDia");
            this.dgvDetalleCaja.DataMember = "CajaDia";

            if (this.dgvDetalleCaja.Rows.Count > 0)
            {
                this.dgvDetalleCaja.Columns[0].Visible = false;
                this.dgvDetalleCaja.Columns[8].Visible = false;
                this.dgvDetalleCaja.Columns[9].Visible = false;
            }
        }

        private void cbBusTipoOperaciones_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cbBusTipoPersona.Items.Clear();

            switch (this.cbBusTipoOperaciones.Text)
            {
                case "Caja del día":
                    this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    this.txtBusFechaIni.Enabled = false;
                    this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
                    this.txtBusFechaFin.Enabled = false;

                    this.txtBusApellido.Text = "";
                    this.txtBusApellido.Enabled = true;
                    
                    this.txtBusNombre.Text = "";
                    this.txtBusNombre.Enabled = true;
                    
                    this.txtBusDetalleMovimiento.Text = "";
                    this.txtBusDetalleMovimiento.Enabled = true;

                    this.cbBusTipoPersona.Text = "Todos";
                    this.cbBusTipoPersona.Enabled = false;

                    this.cbBusPuntos.Text = "";
                    this.cbBusPuntos.Enabled = true;
                    this._cursos.idpunto = "0";
                   
                    this.cbBusTipoClase.Text="";
                    this.cbBusTipoClase.Enabled = true;
                    this.btnBusTipoClase.Enabled = true;

                    this.cbBusNombreClase.Text = "";
                    this.cbBusNombreClase.DataSource = null;
                    this.cbBusNombreClase.Enabled = true;
                    this.btnBusNombreClase.Enabled = true;
                    break;
                case "Ingresos":
                    this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    this.txtBusFechaIni.Enabled = true;
                    this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
                    this.txtBusFechaFin.Enabled = true;
                    
                    this.txtBusApellido.Text = "";
                    this.txtBusApellido.Enabled = true;

                    this.txtBusNombre.Text = "";
                    this.txtBusNombre.Enabled = true;
                    
                    this.txtBusDetalleMovimiento.Text = "";
                    this.txtBusDetalleMovimiento.Enabled = true;

                    this.cbBusTipoPersona.Items.Add("Todos los ingresos");
                    this.cbBusTipoPersona.Items.Add("Empleados");
                    this.cbBusTipoPersona.Items.Add("Socios");
                    this.cbBusTipoPersona.Enabled = true;

                    this.cbBusPuntos.Text = "";
                    this._cursos.idpunto = "0";
                    this.cbBusPuntos.Enabled = true;

                    this.cbBusTipoClase.Text = "";
                    this.cbBusTipoClase.Enabled = false;

                    this.cbBusNombreClase.DataSource = null;
                    this.cbBusNombreClase.Enabled = false;
                    break;
                case "Egresos":
                    this.txtBusFechaIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    this.txtBusFechaIni.Enabled = true;
                    this.txtBusFechaFin.Text = this.txtBusFechaIni.Text;
                    this.txtBusFechaFin.Enabled = true;
                    
                    this.txtBusApellido.Text = "";
                    this.txtBusApellido.Enabled = true;

                    this.txtBusNombre.Text = "";
                    this.txtBusNombre.Enabled = true;
                    
                    this.txtBusDetalleMovimiento.Text = "";
                    this.txtBusDetalleMovimiento.Enabled = true;

                    this.cbBusTipoPersona.Items.Add("Todos los egresos");
                    this.cbBusTipoPersona.Items.Add("Empleados");
                    this.cbBusTipoPersona.Items.Add("Proveedores");
                    this.cbBusTipoPersona.Items.Add("Profesores");
                    this.cbBusTipoPersona.Enabled = true;

                    this.cbBusPuntos.Text = "";
                    this._cursos.idpunto = "0";
                    this.cbBusPuntos.Enabled = true;
                    
                    this.cbBusTipoClase.Text = "";
                    this.cbBusTipoClase.Enabled = false;
                    this.btnBusTipoClase.Enabled = false;

                    this.btnBusNombreClase.Enabled = false;
                    this.cbBusNombreClase.DataSource = null;
                    this.cbBusNombreClase.Enabled = false;
                    break;
            }
        }

        private void aBMProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProveedores formproveedor = new ABMProveedores();
            formproveedor.Show();
        }
    }
}