using ATPCenter.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATPCenterGym.gastos
{
    class ClassGastos
    {
        public string bandera { get; set; }
        public string idgasto { get; set; }
        public string numerofactura { get; set; }
        public string tipofactura { get; set; }
        public string idproveedor { get; set; }
        public string nombreproveedor { get; set; }
        public decimal montopagado { get; set; }
        public string fecharealcarga { get; set; }
        public string fechainigasto { get; set; }
        public string fechafingasto { get; set; }
        public string fechagasto { get; set; }
        public string observacion { get; set; }
        public string idpunto { get; set; }
        public string nombrepunto { get; set; }
       
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public int idempleadoaccion { get; set; }
        public int idpuntoaccion { get; set; }
        public string sql { get; set; }

        public DataSet BuscarGastos(ClassGastos _gasto, string _tabla)
        {
            
            sql = "CALL sp_buscadorgastos(" + _gasto.idgasto + ",'" + _gasto.fechafingasto + "','" + _gasto.fechafingasto + "','" + _gasto.nombreproveedor + "','" + _gasto.nombrepunto + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataSet ABMGasto(ClassGastos _gasto, string _tabla)
        {
            sql = "CALL sp_abmgasto(" + _gasto.idgasto + ",'" + _empleado.apellido + "','" + _empleado.nombre + "','" + _empleado.fechanac + "','" + _empleado.dni + "','" + _empleado.cuil + "','" + _empleado.cel + "','" + _empleado.tel + "','" + _empleado.correo + "','" + _empleado.calle + "','" + _empleado.numero + "','" + _empleado.piso + "','" + _empleado.dpto + "','" + _empleado.punto + "','" + _empleado.tipopersona + "','" + _empleado.urlfoto + "','" + _empleado.apellidocotacto + "','" + _empleado.nombrecontacto + "','" + _empleado.celcontacto + "','" + _empleado.telcontacto + "','" + _empleado.emailcontacto + "','" + _empleado.cuit + "','" + _empleado.accion + "','" + _empleado.fechaaccion + "','" + _empleado.idempleadoaccion + "','" + _empleado.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }
    }
}
