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
    public class EventoD
    {
        public static DataSet SeleccionarEventos()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");
                SqlCommand comando = new SqlCommand("SP_SEG_SELECCIONAR_EVENTOS");
                comando.CommandType = CommandType.StoredProcedure;
                DataSet ds = db.ExecuteReader(comando, "Evento");
                return ds;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static void Insertar(Evento even, string accion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");

                SqlCommand comando = new SqlCommand("SP_SEG_TRANS_EVENTO");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", even.id);
                comando.Parameters.AddWithValue("@nombre", even.Nombre);
                comando.Parameters.AddWithValue("@fecha", even.Fecha);
                comando.Parameters.AddWithValue("@estado", even.Estado);
                comando.Parameters.AddWithValue("@accion", accion);

                db.ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static void Modificar(Evento even, string accion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");
                SqlCommand comando = new SqlCommand("SP_SEG_TRANS_EVENTO");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id", even.id);
                comando.Parameters.AddWithValue("@nombre", even.Nombre);
                comando.Parameters.AddWithValue("@fecha", even.Fecha);
                comando.Parameters.AddWithValue("@estado", even.Estado);
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
