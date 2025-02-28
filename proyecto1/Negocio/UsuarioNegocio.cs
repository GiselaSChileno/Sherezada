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
        public bool Loguear(Usuario usuario)
        {

            Accesodatos datos = new Accesodatos();
            try
            {
                datos.setearConsulta("Select Id, Tipo, Nombre, Contrasena, Correo, FechaCompra, FechaNormal from Usuarios Where Correo = @correo AND Contrasena = @contrasena");
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
