using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eventos
{
    public partial class Padron : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlEvento.DataSource = EventoL.ObtenerTodos();
                ddlEvento.DataTextField = "Nombre";
                ddlEvento.DataValueField = "id";
                ddlEvento.DataBind();


                gvPadron.DataSource = PadronL.ObtenerTodos();
                gvPadron.DataBind();
                
            }
        }

        protected void gvPadron_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void gvPadron_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gvPadron.PageIndex = e.NewPageIndex;
                gvPadron.DataSource = PadronL.ObtenerTodos();
                gvPadron.DataBind();
                gvPadron.SelectedIndex = -1;
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
                string archivo = Session["archivo"].ToString();
                PadronL.Nuevo("I", archivo,ddlEvento.SelectedValue);
                Session.Remove("archivo");
                Response.Redirect("index.aspx");
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        protected void afuExcel_UploadComplete(object sender, AjaxControlToolkit.AjaxFileUploadEventArgs e)
        {
            
                string ext = e.ContentType;
                if (ext == ".xls" || ext == ".xlsx")
                {
                    string rutaServer = Server.MapPath("Archivos/");
                    afuExcel.SaveAs(rutaServer + e.FileName);
                    Session["archivo"] = rutaServer + e.FileName;
                }
           
        }
    }
}