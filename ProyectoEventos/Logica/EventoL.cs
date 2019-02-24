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
    public class EventoL
    {
        public static void Nuevo(Evento evento, string accion)
        {
            try
            {
                EventoD.Insertar(evento, accion);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static void Modificar(Evento evento, string accion)
        {
            try
            {
                EventoD.Modificar(evento, accion);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
        public static List<Evento> ObtenerTodos()
        {
            try
            {
                List<Evento> lista = new List<Evento>();
                DataSet ds = EventoD.SeleccionarEventos();

                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    Evento evento = new Evento();
                    evento.id = fila["id"].ToString();
                    evento.Nombre = fila["Nombre"].ToString();
                    evento.Fecha =  Convert.ToDateTime(fila["Fecha"]);
                    evento.Estado = Convert.ToChar(fila["Estado"]);

                    lista.Add(evento);
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
