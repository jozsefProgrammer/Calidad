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
    public class AsistenciaL
    {
        public static void Nuevo(Asistencia asis, string accion)
        {
            try
            {
                AsistenciaD.Insertar(asis, accion);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static List<Asistencia> ObtenerTodos()
        {
            try
            {
                List<Asistencia> lista = new List<Asistencia>();
                DataSet ds = PadronD.SeleccionarPadrones();

                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Asistencia a = new Asistencia();
                    a.id = Convert.ToInt16(fila["id"].ToString());
                    a.idEvento = Convert.ToInt16(fila["Nombre"].ToString());
                    a.idUsuario = fila["idUsuario"].ToString();
                    a.UsuarioRegistra = fila["UsuarioRegistra"].ToString();
                    a.FechaRegistra = Convert.ToDateTime(fila["FechaRegistra"].ToString());
                    a.Estado = fila["Estado"].ToString();


                    lista.Add(a);
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
