using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eventos
{
    public partial class Asistencia : System.Web.UI.Page
    {
        PadronL padL = new PadronL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    this.refrescarListar();
                }
            }
            catch (Exception ex)
            {

                return;
            }
        }

        protected void btnCrearAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                string estado = ddlEstado.SelectedValue;

                Entidades.Asistencia asis = new Entidades.Asistencia();

                asis.idUsuario = txtCedula.Text;
                asis.idEvento = Convert.ToInt16(txtidEvento.Text);
                asis.UsuarioRegistra = TxtUsuarioRegistra.Text;
                asis.FechaRegistra = Convert.ToDateTime(TxtFechaRegistra.Text);
                asis.Estado = ddlEstado.SelectedValue;

                AsistenciaL.Nuevo(asis, "I");
                Response.Redirect("Asistencia.aspx");
            }
            catch (Exception ex)
            {

                return;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txtidEvento.Text = "";
            TxtUsuarioRegistra.Text = "";
            TxtFechaRegistra.Text = "";
        }
        private void refrescarListar()
        {
            try
            {
                List<Entidades.Asistencia> lista = new List<Entidades.Asistencia>();
                lista = AsistenciaL.ObtenerTodos();
                gvAsistencias.DataSource = lista;
                gvAsistencias.DataBind();
            }
            catch (Exception ex)
            {


                return;
            }

        }

        protected void btnBuscarUsuarioPadron_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Padron miPadron = new Entidades.Padron();
                Entidades.Padron padron = new Entidades.Padron()
                {
                    Cedula = txtCedula.Text,
                };

                miPadron = padL.SeleccionarPadron(padron);

                if (String.IsNullOrEmpty(miPadron.id))
                {
                    lblMsj.Text = "El usuario no se encuentra en el padron";
                    error.Attributes.Remove("style");
                    error.Attributes.Add("style", "display:block");
                    return;
                }
                else
                {
                    TxtUsuarioRegistra.Text = (Session["login"] as Usuario).Nombre;
                    txtCedula.Text = miPadron.Cedula;
                    txtidEvento.Text = miPadron.idEvento.ToString();
                    TxtFechaRegistra.Text = DateTime.Now.ToString();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}