using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ejemplo1
{
    public partial class Busqueda : System.Web.UI.Page
    {
        public List<Novelas> Todo { get; set; }
        public List<Novelas> Alternativa { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NovelaNegocio negocio = new NovelaNegocio();
            NovelaNegocio neg = new NovelaNegocio();
            Todo = negocio.listar("Capitulos");
            Alternativa = neg.listar("Populares");
            
            string busqueda = (string)Session["Buscar"];
            List<Novelas> filtro = Todo.FindAll(X => X.Titulo.ToUpper().Contains(busqueda.ToUpper()));
            if (filtro.Count() > 0)
            {
                Repeater1.DataSource = filtro;
                Repeater1.DataBind();   
            }else
            {

                Repeater1.DataSource = Alternativa;
                Repeater1.DataBind();

            }

            

        }
    }
}