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

        public DataSet ABMAsistencia(ClassAsistencias _asistencia, string _tabla)
        {
            sql = "CALL sp_abmasistencia(" + _asistencia.idasistencia + "," + _asistencia.idpersona + ",'" + _asistencia.ingreso + "','" + _asistencia.salida + "','" + _asistencia.punto + "','" + _asistencia.accion + "','" + _asistencia.fechaaccion + "','" + _asistencia.idempleadoaccion + "','" + _asistencia.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }

    }
}