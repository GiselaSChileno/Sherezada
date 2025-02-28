using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class Episodios : System.Web.UI.Page
    {
        public List<Novelas> Obras { get; set; }
        public List<Novelas> Cats { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NovelaNegocio negocio = new NovelaNegocio();
            Obras = negocio.listar("CateDisp");

            NovelaNegocio nego = new NovelaNegocio();
            Cats = nego.listar("Cats");

          
        }
       
    
            
       
    }
}