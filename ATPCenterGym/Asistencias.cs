using ATPCenter.personas;
using ATPCenterGym.asistencias;
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
    public partial class Asistencias : Form
    {
        ClassAsistencias _asistencia;
        DataSet _emp;
        public string _punto = "";
 
        public Asistencias()
        {
            InitializeComponent();
        }

        private void Asistencias_Load(object sender, EventArgs e)
        {
            this._asistencia = new ClassAsistencias();
            this.reloj.Start();
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            this.lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.reloj.Stop();
            Application.Exit();
        }

        private void pbxFotoSocio_Click(object sender, EventArgs e)
        {
            //Solicitar ingreso de dni
            string numdni = Microsoft.VisualBasic.Interaction.InputBox(
        "Ingrese su nuúmero de DNI",
        "Validación de acceso",
        "Ingrese DNI");

            //Busco persona en base de datos
            if (numdni.Length > 0)
            {
                this._asistencia = new ClassAsistencias();

                this._emp = new DataSet();

                this._emp = this._asistencia.BuscarPersonaAsistencia(numdni, "Login");

                if (this._emp.Tables["Login"].Rows.Count > 0)
                {
                    //Informo de la persona ingresada mostrando su foto, fecha y hora de ingreso, apellido y nombre por un tiempo de 1 minuto
                    this._asistencia.idpersona = this._emp.Tables["Login"].Rows[0][0].ToString();
                    this._asistencia.punto = this._punto;
                    
                    this.lblApeNomb.Text = this._emp.Tables["Login"].Rows[0][1].ToString();

                    this.lblTipoPerPunto.Text = this._emp.Tables["Login"].Rows[0][2].ToString() + " - " + this._punto;

                    this.lblAptoMedico.Text = VencidoActoMedico(this._emp.Tables["Login"].Rows[0][3].ToString());

                    this.lblFechaHoraAcceso.Text = this.lblFechaHora.Text;

                    this._asistencia.ingreso = this.lblFechaHoraAcceso.Text;
                    //Registro asistencia en base de datos


                    //Reestablecer pantalla para siguiente validación
                }
                else
                {
                    MessageBox.Show("Los datos no se corresponde con ningún socio!!!");
                }
            }
        }

        private string VencidoActoMedico(string fechavence)
        {
            DateTime fecha;

            try
            {
                if (fechavence.Length > 0)
                {
                    fecha = DateTime.Parse(fechavence);

                    if (fecha <= DateTime.Now)
                    {
                        return "Vencio su aptitud medica";
                    }
                    else
                    {
                        return "Aptitud medica al día";
                    }
                }
                else
                {
                    return "No presento nunca aptitud medica.";
                }
            }
            catch (Exception err)
            {
                return "No presento nunca aptitud medica.";
            }
        }

        private void AltaDeAsistencia()
        {/*
            this._login.idpersona=this.idpersona;
            this._login.accion = "N";
            this._login.fechaaccion = this.lblFechaHoraAcceso.Text;
            this._login.idempleadoaccion = 1; //Viene del login
            this._login.idpuntoaccion = 1; //Viene del login

            this.dgvSocios.DataSource = this._login.ABMPersona(this._socios, "accion");
            this.dgvSocios.DataMember = "accion";

            if (this.dgvSocios.Rows.Count > 0)
            {
                this.dgvSocios.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito. Indicar ahora a los cursos en los que se inscribira!!!", "Atención!!!");

                this.gbxDetalleCursos.Enabled = true;

                this.btnModificarInsc.Enabled = false;
                this.btnEliminarInsc.Enabled = false;

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this.dgvSocios.Rows.Count == 0 && (this.bandera == "B"))
                {
                    this.dgvSocios.Columns[0].Visible = false;
                    MessageBox.Show("Acción realizada con exito!!!", "Atención!!!");

                    this.gbxDetalleCursos.Enabled = true;

                    this.btnModificarInsc.Enabled = false;
                    this.btnEliminarInsc.Enabled = false;

                    this.btnCancelar_Click(sender, e);
                }
                else
                {

                    MessageBox.Show("Error en la ejecución de la acción en curso. Controle datos!!!", "Error!!!");
                }
            }
          */
        }
    }
}
