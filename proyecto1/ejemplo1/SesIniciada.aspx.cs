using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class SesIniciada : System.Web.UI.Page
    {
        
        string Ingreso;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        public void BLog(object sender,EventArgs e)
        {
            if ((string)Session["mensaje"] == "Te registraste exitosamente. Bienvenid@ a este club de lectura :)")
            {
                Ingreso = "Progreso";
                Session.Add("Usuario", Ingreso);
                Response.Redirect("Sesion.aspx", false);
            }
            else if((string)Session["mensaje"] == "¡Bienvenid@!")
            {

               Response.Redirect("Default.aspx", false );
            }
            else
            {
                
                Response.Redirect("Sesion.aspx", false);
            }
        }
        public void ModClik(object sender, EventArgs e)
        {
            Response.Redirect("Perfil.aspx", false);
        }
    }
}