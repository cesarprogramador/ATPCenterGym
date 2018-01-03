using ATPCenter.tiposdeclases;
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
    public partial class ABMClases : Form
    {
        ClassTiposDeClases _clases;
        DataSet _claseselect;
        string bandera;

        public ABMClases()
        {
            InitializeComponent();
        }

        private void ABMClases_Load(object sender, EventArgs e)
        {
            this._clases = new ClassTiposDeClases();

            this._clases.idclase = "0";
            this._clases.idtipodeclase = "0";
            this._clases.nombreclase = "";
          
            DataTable _todasclases = this._clases.BuscarTiposDeClases(this._clases);

            this.cbBusTipoClases.DataSource = _todasclases;
            this.cbBusTipoClases.ValueMember = "idtipodeclase";
            this.cbBusTipoClases.DisplayMember = "tipodeclase";
            this.cbBusTipoClases.SelectedValue = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._clases.idclase = "0";
            this._clases.idtipodeclase = this.cbBusTipoClases.SelectedValue.ToString();
            this._clases.nombreclase = this.txtBusClase.Text;

            this.dgvClases.DataSource = this._clases.BuscarTiposDeClases(this._clases, "Clases");
            this.dgvClases.DataMember = "Clases";

            if (this.dgvClases.Rows.Count > 0)
            {
                this.dgvClases.Columns[0].Visible = false;
                this.dgvClases.Columns[2].Visible = false;
            }
        }

        private void dgvClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClases.Rows.Count > 0)
            {
                this._clases.idclase = this.dgvClases[2, this.dgvClases.CurrentCell.RowIndex].Value.ToString();
                this._clases.idtipodeclase = "0";
                this._clases.nombreclase = "";

                this._claseselect = this._clases.BuscarTiposDeClases(this._clases, "Clases");

                if (this._claseselect.Tables["Clases"].Rows.Count > 0)
                {
               //     this.cbTipoClases.SelectedValue = this._claseselect.Tables["Clases"].Rows[0][0].ToString();
                    this.cbTipoClases.Text = this._claseselect.Tables["Clases"].Rows[0][1].ToString();
                    this.txtClase.Text = this._claseselect.Tables["Clases"].Rows[0][3].ToString();
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this._clases = new ClassTiposDeClases();

            this._clases.idclase = "0";
            this._clases.idtipodeclase = "1";
            this._clases.nombreclase = "";

            DataTable _todasclases = this._clases.BuscarTiposDeClases(this._clases);

            //Agrupar o borrar las filas repetidas de la lista que se recupera de la consulta
            _todasclases = this._clases.EliminarFilasDuplicadas(_todasclases, "tipodeclase");

            //Muestra datos en el combo
            this.cbTipoClases.DataSource = _todasclases;
            this.cbTipoClases.ValueMember = "idtipodeclase";
            this.cbTipoClases.DisplayMember = "tipodeclase";
            this.cbTipoClases.Visible = true;
          
            this.bandera = "N";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cbBusTipoClases.Text = "";
            this.txtBusClase.Text = "";

            this.dgvClases.DataSource = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.bandera = "M";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;

            this._clases.idclase = this.dgvClases[2, this.dgvClases.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.bandera = "B";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;

            this._clases.idclase = this.dgvClases[2, this.dgvClases.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bandera = "";
            this._clases.idclase = "0";
          
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si existe el tipo de clase
                this._clases.idtipodeclase = this.cbTipoClases.SelectedValue.ToString();
                if (this.bandera == "N") this.bandera = "A"; //se agrega una clase más al tipo de clase existente
            }
            catch
            {
                //No existe el tipo de clase
                this._clases.idtipodeclase = "0";
            }

            this._clases.tipodeclase = this.cbTipoClases.Text;
            this._clases.nombreclase = this.txtClase.Text;

            this._clases.accion = this.bandera;
            this._clases.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._clases.idempleadoaccion = 1; //Viene del login
            this._clases.idpuntoaccion = 1; //Viene del login

            this.dgvClases.DataSource = this._clases.ABMTipoDeClase(this._clases, "accion");
            this.dgvClases.DataMember = "accion";

            if (this.dgvClases.Rows.Count > 0)
            {
                  this.dgvClases.Columns[0].Visible = false;
                    this.dgvClases.Columns[2].Visible = false;
               
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this._clases.accion == "B")
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
