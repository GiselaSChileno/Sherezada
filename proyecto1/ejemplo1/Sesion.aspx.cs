using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace ejemplo1
{
    public partial class Sesion : System.Web.UI.Page
    {
        public string user { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if ((string)Session["mensaje"] == "Ups, Error de dedo. Prueba de nuevo")
                {
                    string Ingreso = "Progreso";
                    Session.Add("Usuario", Ingreso);
                    Session.Add("userN", null);
                    Session.Add("userI", null);
                    Session.Add("userT", null);
                }
                else
                {

                    user = Request.QueryString["ing"].ToString();
                    if (user != "" )
                    {
                        string Ingreso = "Progreso";
                        Session.Add("Usuario", Ingreso);
                        Session.Add("userN", null);
                        Session.Add("userI", null);
                        Session.Add("userT", null);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        protected void BtnAcptClick(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();                           
                UsuarioNegocio negocio = new UsuarioNegocio();
                string Login;
                usuario.Nombre = txtNombre.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.Contrasena = txtContrasena.Text;

                if ((string)Session["Usuario"] != "Progreso")
                {
                    if (negocio.Nuevo(usuario))
                    {
                        Login = "Tu Usuario o Contraseña ya están en uso, por favor elige otro";
                    }
                    else
                    {
                        negocio.AgregarSp(usuario);
                        Login = "Te registraste exitosamente. Bienvenid@ a este club de lectura :)";

                    }
                }
                else
                {
                    if(negocio.Loguear(usuario))
                    {
                        Login = "¡Bienvenid@!";
                        
                        if (usuario.FechaCompra == null || usuario.FechaCompra >= usuario.FechaNormal)
                        {
                            usuario.Tipo = 1;
                        }
                        Session.Add("user", usuario);
                        Session.Add("userN", usuario.Nombre);
                        Session.Add("userI", usuario.Id);
                        Session.Add("userT", usuario.Tipo);


                    }
                    else
                    {
                        Login = "Ups, Error de dedo. Prueba de nuevo";
 
                    }
                }

                Session.Add("mensaje", Login);

                Response.Redirect("SesIniciada.aspx", false);

            }
            catch (Exception ex)
            {

                throw ex;

            }


        }
    }
}