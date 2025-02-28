using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace ejemplo1
{
    public partial class _default : System.Web.UI.Page
    {
        public List<Novelas> ListaNovelas {  get; set; }
        public List<Novelas> Populares { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            NovelaNegocio negocio = new NovelaNegocio();
            ListaNovelas = negocio.listar("Capitulos");

            NovelaNegocio negocio1 = new NovelaNegocio();
            Populares = negocio1.listar("Populares");
            if (!IsPostBack)
            {
                RepPop.DataSource = Populares;
                RepPop.DataBind();  

            }
            if (!IsPostBack)
            {
                RepN.DataSource = ListaNovelas;
                RepN.DataBind();

            }

            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
            Session.Add("Titulo", valor);
            Response.Redirect("Elegida.aspx");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
            Session.Add("Titulo", valor);
            Response.Redirect("Elegida.aspx");
        }

    }
}