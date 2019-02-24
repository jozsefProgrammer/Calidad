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
    public partial class Eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvEventos.DataSource = EventoL.ObtenerTodos();
                gvEventos.DataBind();
            }
        }

        protected void gvEventos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvEventos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                int index = e.NewSelectedIndex;
                Session.Remove("IdEvento");
                Session["IdEvento"] = gvEventos.DataKeys[index].Values[0].ToString();
                txtNombreEvento.Text = gvEventos.DataKeys[index].Values[1].ToString();
                txtFecha.Text = gvEventos.DataKeys[index].Values[2].ToString();
                ddlEstado.SelectedValue = gvEventos.DataKeys[index].Values[3].ToString();

                btnGuardar.Visible = false;
                btnEditar.Visible = true;
                btnLimpiar.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Evento miEvento = new Evento()
                {
                    id = "",
                    Nombre = txtNombreEvento.Text,
                    Fecha = Convert.ToDateTime(txtFecha.Text),
                    Estado = ddlEstado.SelectedValue.ToCharArray()[0]
                };
                EventoL.Nuevo(miEvento, "I");
                Response.Redirect("Eventos.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Evento miEvento = new Evento()
                {
                    id = Session["IdEvento"].ToString(),
                    Nombre = txtNombreEvento.Text,
                    Fecha = Convert.ToDateTime(txtFecha.Text),
                    Estado = ddlEstado.SelectedValue.ToCharArray()[0]
                };

                EventoL.Modificar(miEvento, "U");
                Response.Redirect("Eventos.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreEvento.Text = String.Empty;
                txtFecha.Text = String.Empty;
                ddlEstado.SelectedValue = "A";
                btnGuardar.Visible = true;
                btnEditar.Visible = false;
                btnLimpiar.Visible = false;
                gvEventos.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}