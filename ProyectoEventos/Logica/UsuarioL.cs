using Datos.Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioL
    {
        public void Nuevo(Usuario user, string accion)
        {
            try
            {
                UsuarioD.Insertar(user, accion);
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
                UsuarioD.Modificar(user, accion);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static List<Usuario> ObtenerTodos()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                DataSet ds = UsuarioD.SeleccionarUsuarios();

                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Usuario users = new Usuario();
                    users.id = fila["id"].ToString();
                    users.Nombre = fila["Nombre"].ToString();
                    users.idPerfil = (int)fila["Perfil"];
                    users.contrasenna = fila["Contraseña"].ToString();
                    users.Estado = Convert.ToInt16(fila["Estado"]);

                    lista.Add(users);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
    }
}
