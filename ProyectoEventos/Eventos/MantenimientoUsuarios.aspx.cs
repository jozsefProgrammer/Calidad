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
    public partial class MantenimientoUsuarios : System.Web.UI.Page
    {
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

        protected void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int tipo = Convert.ToInt16(ddlTipoUsuario.SelectedValue);
                int estado = Convert.ToInt16(ddlEstado.SelectedValue);

                Usuario user = new Usuario();


                user.id = txtCedula.Text;
                user.Nombre = TxtNombre.Text;
                user.contrasenna = TxtContrasenna.Text;
                user.idPerfil = tipo;
                user.Estado = estado;

                UsuarioL.Nuevo(user, "I");
                Response.Redirect("MantenimientoUsuarios.aspx");
            }
            catch (Exception ex)
            {

                return;
            }
        }
        private void refrescarListar()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                lista = UsuarioL.ObtenerTodos();
                gvUsuarios.DataSource = lista;
                gvUsuarios.DataBind();
            }
            catch (Exception ex)
            {


                return;
            }

        }

        protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {


                return;
            }
        }

        protected void gvUsuarios_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the currently selected row using the SelectedRow property.
                GridViewRow row = gvUsuarios.SelectedRow;

                // Display the first name from the selected row.
                // In this example, the third column (index 2) contains
                // the first name.
                txtCedula.Text = row.Cells[0].Text;
                TxtNombre.Text = row.Cells[1].Text;
                btnActualizar.Visible = true;
                btnCrearUsuario.Visible = false;
                txtCedula.Enabled = false;
                TxtNombre.Enabled = false;
                TxtContrasenna.Enabled = false;
                ddlTipoUsuario.Enabled = false;
            }
            catch (Exception ex)
            {


                return;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipo = Convert.ToInt16(ddlTipoUsuario.SelectedValue);
                int estado = Convert.ToInt16(ddlEstado.SelectedValue);

                Usuario user = new Usuario();


                user.id = txtCedula.Text;
                user.Nombre = TxtNombre.Text;
                user.contrasenna = TxtContrasenna.Text;
                user.idPerfil = tipo;
                user.Estado = estado;

                UsuarioL.Nuevo(user, "U");
                Response.Redirect("MantenimientoUsuarios.aspx");
            }
            catch (Exception ex)
            {

                return;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            TxtNombre.Text = "";
            btnActualizar.Visible = false;
            btnCrearUsuario.Visible = true;
            txtCedula.Enabled = true;
            TxtNombre.Enabled = true;
            TxtContrasenna.Enabled = true;
            ddlTipoUsuario.Enabled = true;
            gvUsuarios.SelectedIndex = -1;
        }
    }
}