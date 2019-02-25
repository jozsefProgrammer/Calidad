using Datos.Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PadronL
    {
        PadronD datos = new PadronD();
        public static void Nuevo( string accion, string archivo,string idEvento)
        {
            List<Padron> lstPadrones = new List<Padron>();
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            OleDbCommand cmdExcel = new OleDbCommand();

            string conStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;", archivo);
            string cadenaConexionArchivoExcel = conStr;

            try
            {
                //Get the name of First Sheet                                    
                DataTable dt = new DataTable();
                cmdExcel.Connection = conexion;

                conexion = new OleDbConnection(cadenaConexionArchivoExcel);
                conexion.Open();
                DataTable dtExcelSchema;
                dtExcelSchema = conexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                string Padron = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                string consultaHojaComisiones = "Select * from [" + Padron + "]";
                conexion.Close();

                conexion.Open();
                cmdExcel.CommandText = consultaHojaComisiones;
                dataAdapter = new OleDbDataAdapter(consultaHojaComisiones, conexion);
                //dataAdapter.SelectCommand = cmdExcel;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, Padron);
                conexion.Close();
                List<Padron> carga = new List<Padron>();

                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Padron p = new Padron();
                    p.id = dataSet.Tables[0].Rows[i]["id"].ToString();
                    p.Nombre = dataSet.Tables[0].Rows[i]["Nombre"].ToString();
                    p.Cedula = dataSet.Tables[0].Rows[i]["Número Cédula"].ToString();
                    p.Estatus1 = dataSet.Tables[0].Rows[i]["Estatus 1"].ToString();
                    p.Estado2 = dataSet.Tables[0].Rows[i]["Estado 2 "].ToString();
                    p.Correo = dataSet.Tables[0].Rows[i]["Correo"].ToString();
                    p.Telefono = dataSet.Tables[0].Rows[i]["Telefono"].ToString();
                    p.idEvento = Convert.ToInt32(idEvento);

                    lstPadrones.Add(p);
                }
                foreach (Padron p in lstPadrones)
                {
                    PadronD.Insertar(p, accion);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                conexion.Close();
            }

        }
        public static List<Padron> ObtenerTodos()
        {
            try
            {
                List<Padron> lista = new List<Padron>();
                DataSet ds = PadronD.SeleccionarPadrones();

                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Padron padron = new Padron();
                    padron.id = fila["id"].ToString();
                    padron.Nombre = fila["Nombre"].ToString();
                    padron.Cedula = fila["Cedula"].ToString();
                    padron.Estatus1 = fila["Estatus1"].ToString();
                    padron.Estado2 = fila["Estado2"].ToString();
                    padron.Correo = fila["Correo"].ToString();
                    padron.Telefono = fila["Telefono"].ToString();
                    padron.idEvento = Convert.ToInt16(fila["idEvento"]);


                    lista.Add(padron);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }

        public Padron SeleccionarPadron(Padron padron)
        {
            try
            {
                DataSet ds = PadronD.SeleccionarPadron(padron);
                Padron p = new Padron();
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    p.id = fila["id"].ToString();
                    p.Nombre = fila["Nombre"].ToString();
                    p.Cedula = fila["Cedula"].ToString();
                    p.Estatus1 = fila["Estatus1"].ToString();
                    p.Estado2 = fila["Estado2"].ToString();
                    p.Correo = fila["Correo"].ToString();
                    p.Telefono = fila["Telefono"].ToString();
                    p.idEvento = Convert.ToInt16(fila["idEvento"]);
                }

                return p;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
