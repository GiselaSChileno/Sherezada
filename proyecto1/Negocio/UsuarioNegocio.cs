using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Microsoft.SqlServer.Server;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public void modRev(int us, string mem)
        {
            Accesodatos datos = new Accesodatos();
            try
            {


                datos.setearConsulta("insert into Revisar values(@Id, @mem, GETDATE())");

                datos.setearParametro("@Id", us);
                datos.setearParametro("@mem", mem);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void modPrem(int us)
        {
            Accesodatos datos = new Accesodatos();
            try
            {


                datos.setearConsulta("Update Usuarios set Tipo = 3, FechaCompra = GETDATE() Where Id = @Id");

                datos.setearParametro("@Id", us);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public List<Comentarios> Coment(int cap)
        {

            Accesodatos datos = new Accesodatos();
            List<Comentarios> lista = new List<Comentarios>();

            try
            {
                datos.setearConsulta("Select * from Comentarios where IdCap = @Cap");
                datos.setearParametro("@Cap", cap);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Comentarios com = new Comentarios();
                    com.IdCom = (int)datos.Lector["IdCom"];
                    com.IdUs = (int)datos.Lector["IdUs"];
                    com.IdCap = (int)datos.Lector["IdCap"];
                    com.Comentario = (string)datos.Lector["Comentario"];
                    com.UsNombre = (string)datos.Lector["UsNombre"];
                    com.Likes = (int)datos.Lector["Likes"];
                    lista.Add(com);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public bool AgInt(int cap, int Interac)
        {

            Accesodatos datos = new Accesodatos();

            try
            {
                datos.setearConsulta("Update Usuarios set Interacciones = @Interac where Id = @Cap");
                datos.setearParametro("@Cap", cap);
                datos.setearParametro("@Like", Interac);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modiTipo(Usuario usuario)
        {
            Accesodatos datos = new Accesodatos();
            try
            {


                datos.setearConsulta("Update Usuarios set Tipo = 1 Where Id = @Id");
              
                datos.setearParametro("@Id", usuario.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void modificar(Usuario usuario)
        {
            Accesodatos datos = new Accesodatos();
            try
            {
                

                datos.setearConsulta("Update Usuarios set Nombre = @Nombre, Correo = @Correo, Contrasena = @Contrasena Where Id = @Id");
                datos.setearParametro("@Nombre", usuario.Nombre);
                datos.setearParametro("@Contrasena", usuario.Contrasena);
                datos.setearParametro("@Correo", usuario.Correo);
                datos.setearParametro("@Id", usuario.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        
        }
        public void AgregarSp(Usuario usuario)
        {
            Accesodatos datos = new Accesodatos();

            try
            {
                datos.setearProcedimiento("NuevoUsuario");
                datos.setearParametro("@Correo", usuario.Correo);
                datos.setearParametro("@Nombre", usuario.Nombre);
                datos.setearParametro("@Contrasena", usuario.Contrasena);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void AgregarCom(Comentarios comentario)
        {
            Accesodatos datos = new Accesodatos();

            try
            {
                datos.setearProcedimiento("altaComentario");
                datos.setearParametro("@IdUs", comentario.IdUs);
                datos.setearParametro("@IdCap", comentario.IdCap);
                datos.setearParametro("@Comentario", comentario.Comentario);
                datos.setearParametro("@UsNombre", comentario.UsNombre);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public bool Loguear(Usuario usuario)
        {

            Accesodatos datos = new Accesodatos();
            try
            {
                datos.setearConsulta("Select Id, Tipo, Nombre, Contrasena, Correo, FechaCompra, FechaNormal, Interacciones from Usuarios Where Correo = @correo AND Contrasena = @contrasena");
                datos.setearParametro("@correo", usuario.Correo);
                datos.setearParametro("@contrasena", usuario.Contrasena);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.Tipo = (int)datos.Lector["Tipo"];
                    usuario.Contrasena = (string)datos.Lector["Contrasena"];
                    usuario.Correo = (string)datos.Lector["Correo"];
                    usuario.Nombre = (string)datos.Lector["Nombre"];
                    usuario.FechaCompra = (DateTime)datos.Lector["FechaCompra"];
                    usuario.FechaNormal = (DateTime)datos.Lector["FechaNormal"];
                    usuario.Interacciones = (int)datos.Lector["Interacciones"];

                    return true;
                }
                return false;
            }
            catch ( Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool Nuevo(Usuario usuario)
        {

            Accesodatos datos = new Accesodatos();
            try
            {
                datos.setearConsulta("Select Id from Usuarios Where Nombre = @Nombre or Correo = @Correo");
                datos.setearParametro("@Correo", usuario.Correo);
                datos.setearParametro("@Nombre", usuario.Nombre);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public bool Like(int cap, int us )
        {

            Accesodatos datos = new Accesodatos();
            
            try
            {
                datos.setearConsulta("Select CapId from Favoritos Where CapId = @Cap and UsId = @Us");
                datos.setearParametro("@Cap", cap);
                datos.setearParametro("@Us", us);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Respuestas> ResCom()
        {

            Accesodatos datos = new Accesodatos();
            List<Respuestas> lista = new List<Respuestas>();

            try
            {
                datos.setearConsulta("Select Respuesta, UsNombre, IdComent from Respuestas");

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {

                    Respuestas com = new Respuestas();
                    com.Respuesta = (string)datos.Lector["Respuesta"];
                    com.UsNombre = (string)datos.Lector["UsNombre"];
                    com.IdComent = (int)datos.Lector["IdComent"];
                    lista.Add(com);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool NewLike(int cap, int us)
        {

            Accesodatos datos = new Accesodatos();

            try
            {
                datos.setearConsulta("Insert into Favoritos Values (@Cap, @Us)");
                datos.setearParametro("@Cap", cap);
                datos.setearParametro("@Us", us);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
