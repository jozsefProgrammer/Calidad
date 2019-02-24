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
    public partial class Index : System.Web.UI.Page
    {
        UsuarioL userl = new UsuarioL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario miUsuario = new Usuario();
                Usuario user = new Usuario()
                {
                    id = TxtCedula.Text,
                    contrasenna = TxtContrasenna.Text,
                };

                miUsuario = userl.SeleccionarUsuario(user);

                if(String.IsNullOrEmpty(miUsuario.id))
                {
                    lblMsj.Text = "El usuario no existe o se encuentra inactivo.";
                    error.Attributes.Remove("style");
                    error.Attributes.Add("style", "display:block");
                    return;
                }
                else
                {
                    Response.Redirect("index.aspx");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}