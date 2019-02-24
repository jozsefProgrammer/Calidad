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
    public class UsuarioD
    {

        public DataSet SeleccionarUsuario(Usuario usuario)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");
                SqlCommand comando = new SqlCommand("SP_SEG_SELECCIONAR_USUARIO");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", usuario.id);
                comando.Parameters.AddWithValue("@contrasenna", usuario.contrasenna);
                DataSet ds = db.ExecuteReader(comando, "Usuario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }

        public static DataSet SeleccionarUsuarios()
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");
                SqlCommand comando = new SqlCommand("SP_SEG_SELECCIONAR_USUARIOS");
                comando.CommandType = CommandType.StoredProcedure;
                DataSet ds = db.ExecuteReader(comando, "Usuario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static void Insertar(Usuario user, string accion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");

                SqlCommand comando = new SqlCommand("SP_SEG_TRANS_USUARIO");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", user.id);
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                comando.Parameters.AddWithValue("@Perfil", user.idPerfil);
                comando.Parameters.AddWithValue("@Estado", user.Estado);
                comando.Parameters.AddWithValue("@Contrasenna", user.contrasenna);
                comando.Parameters.AddWithValue("@accion", accion);
                db.ExecuteNonQuery(comando);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static void Modificar(Usuario user, string accion)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Default");
                SqlCommand comando = new SqlCommand("SP_SEG_TRANS_USUARIO");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", user.id);
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                comando.Parameters.AddWithValue("@Perfil", user.idPerfil);
                comando.Parameters.AddWithValue("@Estado", user.Estado);
                comando.Parameters.AddWithValue("@Contrasenna", user.contrasenna);
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
