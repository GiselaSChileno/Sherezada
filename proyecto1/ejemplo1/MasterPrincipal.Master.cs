using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class MasterPrincipal : System.Web.UI.MasterPage
    {
        protected void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {

                }
                else
                {
                    string busqueda = txtBuscar.Text;
                    Session.Add("Buscar", busqueda);
                    Response.Redirect("Busqueda.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
       
    }
}