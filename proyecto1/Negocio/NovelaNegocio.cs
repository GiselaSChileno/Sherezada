using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Dominio;
using static System.Collections.Specialized.BitVector32;

namespace Negocio
{
    
    public class NovelaNegocio
    {
        public List<Novelas> listAu(int id)
        {
            List<Novelas> list = new List<Novelas>();
            Accesodatos datos = new Accesodatos();
            try
            {
                datos.setearProcedimiento("StoredListar");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Novelas aux = new Novelas();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Categoria = (string)datos.Lector["Categoria"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Episodio = (int)datos.Lector["Episodio"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Benefactor = (DateTime)datos.Lector["Benefactor"];
                    aux.Likes = (int)datos.Lector["Likes"];
                    aux.Audio = (string)datos.Lector["Audio"];
                    aux.Texto = (string)datos.Lector["Texto"];
                    
                    if (aux.Id == id)
                    {

                        list.Add(aux);
                    }
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public List<Novelas> ListE(string titulo, int Tipo)
        {
            List<Novelas> list = new List<Novelas>();
            Accesodatos datos = new Accesodatos();
            
            try
            {
                datos.setearProcedimiento("StoredListar");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Novelas aux = new Novelas();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Categoria = (string)datos.Lector["Categoria"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Episodio = (int)datos.Lector["Episodio"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Benefactor = (DateTime)datos.Lector["Benefactor"];
                    aux.Likes = (int)datos.Lector["Likes"];
                    aux.Audio = (string)datos.Lector["Audio"];
                    aux.Texto = (string)datos.Lector["Texto"];
                    DateTime thisDay = DateTime.Today;
                    if (Tipo == 3)
                    {
                        if (aux.Titulo == titulo)
                        {

                            list.Add(aux);
                        }
                        
                    }
                    else
                    {
                        if (aux.Titulo == titulo & aux.Fecha < thisDay)
                        {

                            list.Add(aux);
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public List<Novelas> listar(string pro)
        {
            List<Novelas> lista = new List<Novelas>();
            Accesodatos datos = new Accesodatos();

            try
            {
                
                datos.setearProcedimiento(pro);
                datos.ejecutarLectura();

                if (pro == "Capitulos")
                {
                    while (datos.Lector.Read())
                    {
                        Novelas aux = new Novelas();
                        aux.Titulo = (string)datos.Lector["Titulo"];
                        aux.caps = (int)datos.Lector["caps"];
                        aux.Texto = (string)datos.Lector["Texto"];

                        lista.Add(aux);

                    }
                }
                else if(pro=="Populares")
                {
                    while (datos.Lector.Read())
                    {
                        Novelas aux = new Novelas();
                        aux.Titulo = (string)datos.Lector["Titulo"];
                        aux.Likes = (int)datos.Lector["Likes"];
                        aux.Texto = (string)datos.Lector["Texto"];

                        lista.Add(aux);

                    }
                }
                else if (pro == "Cats")
                {
                    while (datos.Lector.Read())
                    {
                        Novelas aux = new Novelas();
                        aux.Categoria = (string)datos.Lector["Categoria"];

                        lista.Add(aux);

                    }
                }
                else if (pro == "CateDisp")
                {
                    while (datos.Lector.Read())
                    {
                        Novelas aux = new Novelas();
                        aux.Titulo = (string)datos.Lector["Titulo"];
                        aux.Categoria = (string)datos.Lector["Categoria"];
                        
                        lista.Add(aux);

                    }
                }
                else
                {

                    while (datos.Lector.Read())
                    {
                        Novelas aux = new Novelas();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Categoria = (string)datos.Lector["Categoria"];
                        aux.Titulo = (string)datos.Lector["Titulo"];
                        aux.Episodio = (int)datos.Lector["Episodio"];
                        aux.Fecha = (DateTime)datos.Lector["Fecha"];
                        aux.Fecha.ToShortDateString();
                        aux.Benefactor = (DateTime)datos.Lector["Benefactor"];
                        aux.Benefactor.ToShortDateString();
                        aux.Likes = (int)datos.Lector["Likes"];
                        aux.Audio = (string)datos.Lector["Audio"];
                        aux.Texto = (string)datos.Lector["Texto"];
                        
                        lista.Add(aux); 
                    }

                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
