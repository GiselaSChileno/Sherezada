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
    public partial class Mensual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Us = (int)Session["userI"];
            UsuarioNegocio negocio = new UsuarioNegocio();
            negocio.modPrem(Us);
            string memb = "mensual";
            UsuarioNegocio negocio1 = new UsuarioNegocio();
            negocio1.modRev(Us, memb);
            int prem = 3;
            Session.Add("userT", prem);
        }
    }
}