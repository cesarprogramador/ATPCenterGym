using ATPCenter.conexion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATPCenter.tiposdeclases
{
    class ClassTiposDeClases
    {
        public string bandera { get; set; }
        public string idclase { get; set; }
        public string idtipodeclase { get; set; }
        public string vtipodeclase { get; set; }
        public string tipodeclase { get; set; }
        public string nombreclase { get; set; }
       
        public string accion { get; set; }
        public string fechaaccion { get; set; }
        public int idempleadoaccion { get; set; }
        public int idpuntoaccion { get; set; }
        public string sql { get; set; }

        public DataSet ABMTipoDeClase(ClassTiposDeClases _tipoclase, string _tabla)
        {
            sql = "CALL sp_abmtiposdeclases(" + _tipoclase.idclase + ",'" + _tipoclase.tipodeclase + "','" + _tipoclase.nombreclase + "','" + _tipoclase.accion + "','" + _tipoclase.fechaaccion + "','" + _tipoclase.idempleadoaccion + "','" + _tipoclase.idpuntoaccion + "');";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataSet RealizarAccion(string _sql, string _tabla)
        {
            ClassConexion _cnx = new ClassConexion();

            DataSet _resp = new DataSet();

            _resp = _cnx.AcccionSobreBaseDatos(sql, _tabla);

            return _resp;
        }

        public DataTable BuscarTiposDeClases(ClassTiposDeClases _tipoclase)
        {
            sql = "CALL sp_buscadortiposdeclases(" + _tipoclase.idclase + "," + _tipoclase.idtipodeclase + ",'" + _tipoclase.nombreclase + "',0,100);";

            return this.RealizarAccion(sql);
        }

        public DataSet BuscarTiposDeClases(ClassTiposDeClases _tipoclase, string _tabla)
        {
            sql = "CALL sp_buscadortiposdeclases(" + _tipoclase.idclase + "," + _tipoclase.idtipodeclase + ",'" + _tipoclase.nombreclase + "',0,100);";

            return this.RealizarAccion(sql, _tabla);
        }

        private DataTable RealizarAccion(string _sql)
        {
            ClassConexion _cnx = new ClassConexion();

            DataTable _resp = new DataTable();

            _resp = _cnx.AcccionSobreBaseDatos(sql);

            return _resp;
        }

        public DataTable EliminarFilasDuplicadas(DataTable table, string DistinctColumn)
        {
            try
            {
                ArrayList UniqueRecords = new ArrayList();
                ArrayList DuplicateRecords = new ArrayList();

                // Check if records is already added to UniqueRecords otherwise,
                // Add the records to DuplicateRecords
                foreach (DataRow dRow in table.Rows)
                {
                    if (UniqueRecords.Contains(dRow[DistinctColumn]))
                        DuplicateRecords.Add(dRow);
                    else
                        UniqueRecords.Add(dRow[DistinctColumn]);
                }

                // Remove duplicate rows from DataTable added to DuplicateRecords
                foreach (DataRow dRow in DuplicateRecords)
                {
                    table.Rows.Remove(dRow);
                }

                // Return the clean DataTable which contains unique records.
                return table;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
