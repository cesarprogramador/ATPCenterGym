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
        private bool bandera = false;
        private int contado = 0;
 
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
            
            if ((this.contado > 30)&&(this.bandera==true))
            {
                this.bandera = false;
                this.contado = 0;
                this.lblApeNomb.Text = "...";
                this.lblTipoPerPunto.Text = "...";
                this.lblAptoMedico.Text = "...";
                this.lblFechaHoraAcceso.Text = "...";
            //    this.pbxFotoSocio.Select;
            }
            else
            {
                this.contado++;
            }
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
                    //Se utiliza para el tiempo de duración del logín
                    this.bandera = true;
                    this.contado = 0;

                    //Informo de la persona ingresada mostrando su foto, fecha y hora de ingreso, apellido y nombre por un tiempo de 1 minuto
                    this._asistencia.idasistencia = "0";
                   
                    this._asistencia.idpersona = this._emp.Tables["Login"].Rows[0][0].ToString();
                    this._asistencia.punto = this._punto;
                    
                    this.lblApeNomb.Text = this._emp.Tables["Login"].Rows[0][1].ToString();

                    this.lblTipoPerPunto.Text = this._emp.Tables["Login"].Rows[0][2].ToString() + " - " + this._punto;

                    this.lblAptoMedico.Text = VencidoActoMedico(this._emp.Tables["Login"].Rows[0][3].ToString());

                    this.lblFechaHoraAcceso.Text = this.lblFechaHora.Text;

                    this._asistencia.ingreso = DateTime.Parse(this.lblFechaHoraAcceso.Text).ToString("yyyy/MM/dd hh:mm:ss");

                    this._asistencia.salida = DateTime.Parse(this.lblFechaHoraAcceso.Text).ToString("yyyy/MM/dd hh:mm:ss");

                    this._asistencia.accion = "I";
                    this._asistencia.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                    this._asistencia.idempleadoaccion = 1; //Viene del login
                    this._asistencia.idpuntoaccion = 1; //Viene del login
                    
                    //Registro asistencia en base de datos
                    this._asistencia.ABMAsistencia(this._asistencia, "ingreso");                    
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
  }
}
