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
    public class AsistenciaD
    {
        public static void Insertar(Asistencia asis, string accion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");

                SqlCommand comando = new SqlCommand("SP_SEG_TRANS_ASISTENCIA");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", asis.id);
                comando.Parameters.AddWithValue("@idEvento", asis.idEvento);
                comando.Parameters.AddWithValue("@idUsuario", asis.idUsuario);
                comando.Parameters.AddWithValue("@usuarioRegistra", asis.UsuarioRegistra);
                comando.Parameters.AddWithValue("@fechaRegistra", asis.FechaRegistra);

                comando.Parameters.AddWithValue("@accion", accion);

                db.ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static DataSet SeleccionarAsistencias()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");
                SqlCommand comando = new SqlCommand("SP_SEG_SELECCIONAR_ASISTENCIAS");
                comando.CommandType = CommandType.StoredProcedure;
                DataSet ds = db.ExecuteReader(comando, "Asistencia");
                return ds;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
    }
}
