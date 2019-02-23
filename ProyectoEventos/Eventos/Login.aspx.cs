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

                if(miUsuario == null)
                {

                }else
                {
                    Response.Redirect("");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}