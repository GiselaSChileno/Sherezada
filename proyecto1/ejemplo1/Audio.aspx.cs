using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public List<Comentarios> Comentarios { get; set; }
        public List<Respuestas> Respuestas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Session.Add("Id", id);


            NovelaNegocio negocio = new NovelaNegocio();
            UsuarioNegocio nuevo = new UsuarioNegocio();
            UsuarioNegocio coment = new UsuarioNegocio(); 
            UsuarioNegocio comneg = new UsuarioNegocio();
            Elegida = negocio.listAu((int)Session["Id"]);
            Comentarios = coment.Coment((int)Session["Id"]);
            Respuestas = comneg.ResCom();



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
            NovelaNegocio nov = new NovelaNegocio();
            UsuarioNegocio negocio1 = new UsuarioNegocio();
            if (RaBu1.Checked == true)
            {
                int Us = (int)Session["userI"];
                int Cap = (int)Session["Id"];
                int like = (int)Elegida[0].Likes;
                like ++;
                int Interac = (int)Session["userInt"];
                Interac++;
                nuevo.NewLike(Cap, Us);
                nov.AgLike(Cap, like);
                negocio1.AgInt(Cap, Interac);   

            }
        }
       protected void btn1_Click(object sender, EventArgs e)
        {
            Comentarios nuevo = new Comentarios();
            UsuarioNegocio negocio = new UsuarioNegocio();

            nuevo.IdUs = (int)Session["userI"];
            nuevo.IdCap = (int)Session["Id"];
            nuevo.Comentario = txtComent.Text;
            nuevo.UsNombre = (string)Session["userN"];

            negocio.AgregarCom(nuevo);
            Response.Redirect("Elegida.aspx", false);



        }
    }
}