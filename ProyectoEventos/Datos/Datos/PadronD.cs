using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Datos
{
    public class PadronD
    {
        public static DataSet SeleccionarPadrones()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");
                SqlCommand comando = new SqlCommand("SP_SEG_SELECCIONAR_PADRONES");
                comando.CommandType = CommandType.StoredProcedure;
                DataSet ds = db.ExecuteReader(comando, "Padron");
                return ds;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public DataSet SeleccionarPadron(Padron padron)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");
                SqlCommand comando = new SqlCommand("SP_SEG_SELECCIONAR_USUARIO_PADRON");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cedula", padron.Cedula);
                DataSet ds = db.ExecuteReader(comando, "Padron");
                return ds;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static void Insertar(Padron padron, string accion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");

                SqlCommand comando = new SqlCommand("SP_SEG_TRANS_PADRON");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", padron.id);
                comando.Parameters.AddWithValue("@nombre", padron.Nombre);
                comando.Parameters.AddWithValue("@cedula", padron.Cedula);
                comando.Parameters.AddWithValue("@estatus1", padron.Estatus1);
                comando.Parameters.AddWithValue("@estado2", padron.Estado2);
                comando.Parameters.AddWithValue("@correo", padron.Correo);
                comando.Parameters.AddWithValue("@telefono", padron.Telefono);
                comando.Parameters.AddWithValue("@idEvento", padron.idEvento);
                comando.Parameters.AddWithValue("@accion", accion);

                db.ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
    }
}
