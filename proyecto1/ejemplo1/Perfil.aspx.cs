using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Usuario usuario = new Usuario();
                usuario = (Usuario)Session["user"];

                txtNombre.Text = usuario.Nombre;
                txtContrasena.Text = usuario.Contrasena;
                txtCorreo.Text = usuario.Correo;
            }

        }

        public void BtnAcptClick(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Correo = txtCorreo.Text;
            nuevo.Contrasena = txtContrasena.Text;
            nuevo.Id = (int)Session["userI"];   

            negocio.modificar(nuevo);
            Session.Add("user", nuevo);
            Session.Add("userN", nuevo.Nombre);
            Session.Add("userI", nuevo.Id);
            Session.Add("userT", nuevo.Tipo);

            Response.Redirect("SesIniciada.aspx", false);
        }
    }
}