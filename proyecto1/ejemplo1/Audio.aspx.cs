using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class Audio : System.Web.UI.Page
    {
        public List<Novelas> Elegida { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Session.Add("Id", id);


            NovelaNegocio negocio = new NovelaNegocio();
            UsuarioNegocio nuevo = new UsuarioNegocio();
            Elegida = negocio.listAu((int)Session["Id"]);

            if (Session["userI"] != null & !IsPostBack)
            {
                int Us = (int)Session["userI"];
                int Cap = (int)Session["Id"];
                if (nuevo.Like(Cap, Us))
                {
                    RaBu1.Checked = true;
                }
                
            }

        }
        protected void RadioButton1(object sender, EventArgs e)
        {
            UsuarioNegocio nuevo = new UsuarioNegocio();
            if (RaBu1.Checked == true)
            {
                int Us = (int)Session["userI"];
                int Cap = (int)Session["Id"];
                nuevo.NewLike(Cap, Us);
            }
        }
    }
}