using ATPCenter.conexion;
using ATPCenter.personas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATPCenterGym.asistencias
{
    class ClassAsistencias
    {
        public string bandera { get; set; }
        public string idasistencia { get; set; }
        public string idpersona { get; set; }
        public string ingreso { get; set; }
        public string salida { get; set; }
        public string punto { get; set; }
       
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public int idempleadoaccion { get; set; }
        public int idpuntoaccion { get; set; }
        public string sql { get; set; }
        
        public DataSet BuscarPersonaAsistencia(string _dato, string _tabla)
        {
            sql = "CALL sp_buscadorpersonas('" + _dato + "');";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        private DataTable RealizarAccion(string _sql)
        {
            ClassConexion _cnx = new ClassConexion();

            DataTable _resp = new DataTable();

            _resp = _cnx.AcccionSobreBaseDatos(sql);

            return _resp;
        }

        public DataSet ABMAsistencia(ClassPersonas _empleado, string _tabla)
        {
            sql = "CALL sp_abmasistencia(" + _empleado.idpersona + ",'" + _empleado.apellido + "','" + _empleado.nombre + "','" + _empleado.fechanac + "','" + _empleado.dni + "','" + _empleado.cuil + "','" + _empleado.cel + "','" + _empleado.tel + "','" + _empleado.correo + "','" + _empleado.calle + "','" + _empleado.numero + "','" + _empleado.piso + "','" + _empleado.dpto + "','" + _empleado.punto + "','" + _empleado.tipopersona + "','" + _empleado.urlfoto + "','" + _empleado.apellidocotacto + "','" + _empleado.nombrecontacto + "','" + _empleado.celcontacto + "','" + _empleado.telcontacto + "','" + _empleado.emailcontacto + "','" + _empleado.cuit + "','" + _empleado.idespecialidad + "','" + _empleado.aptomedico + "','" + _empleado.fechainicertificado + "','" + _empleado.fechafincertificado + "','" + _empleado.accion + "','" + _empleado.fechaaccion + "','" + _empleado.idempleadoaccion + "','" + _empleado.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }

    }
}