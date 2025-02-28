using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class Novela : System.Web.UI.Page
    {
        public List<Novelas> Elegida { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                string Title = Request.QueryString["id"].ToString();
                Session.Add("Titulo", Title);
            }

            int Tipo = 1;

            if (Session["userT"] != null)
            {
                Tipo = (int)Session["userT"];
            }
            
            NovelaNegocio negocio = new NovelaNegocio();
            Elegida = negocio.ListE((string)Session["Titulo"], Tipo);
            GridView1.DataSource = Elegida;
            GridView1.DataBind();

        }

        protected void dgvNovPage(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void dgvListNov(object sender, EventArgs e)
        {
            string id = GridView1.SelectedDataKey.Value.ToString();
            Response.Redirect("Audio.aspx?id=" + id);
        }

    }
}