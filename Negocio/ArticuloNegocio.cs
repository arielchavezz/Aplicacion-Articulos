using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl , Precio, A.IdMarca, A.IdCategoria from ARTICULOS A , MARCAS M,CATEGORIAS C where   M.Id = A.IdMarca and C.Id = A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.id = (int)lector["Id"];
                    aux.codigo = (string)lector["Codigo"];
                    aux.nombre = (string)lector["Nombre"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)lector["IdMarca"];   
                    aux.marca.descripcion = (string)lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)lector["IdCategoria"];
                    aux.categoria.descripcion = (string)lector["Categoria"];
                    
                    if (!(lector["ImagenUrl"] is DBNull)){
                            aux.imagen = (string)lector["ImagenUrl"];}
                    
                    aux.precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria) values ('" + nuevo.codigo + "','" + nuevo.nombre + "','" + nuevo.descripcion + "','" + nuevo.imagen + "','" + nuevo.precio + "',@idMarca,@idCategoria)");
                datos.setearParametro("@idMarca",nuevo.marca.id);
                datos.setearParametro("@idCategoria", nuevo.categoria.id);
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

        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagen, Precio = @precio where Id = @id ");
                datos.setearParametro("@codigo",modificar.codigo);
                datos.setearParametro("@nombre",modificar.nombre);
                datos.setearParametro("@descripcion",modificar.codigo);
                datos.setearParametro("@idMarca",modificar.marca.id);
                datos.setearParametro("@idCategoria",modificar.categoria.id);
                datos.setearParametro("@imagen", modificar.imagen);
                datos.setearParametro("@precio", modificar.precio);
                datos.setearParametro("@id",modificar.id);
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

        public void EliminarFisica(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @id ");
                datos.setearParametro("@id", id);
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

        public List<Articulo> filtrar(string filtrar, string forma, string clave)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl , Precio, A.IdMarca, A.IdCategoria from ARTICULOS A , MARCAS M,CATEGORIAS C where   M.Id = A.IdMarca and C.Id = A.IdCategoria and ";

                switch (filtrar)
                {
                    case "Codigo":
                        switch (forma)
                        {
                            case "Comienza con":
                                consulta += "Codigo like '" + clave + "%' ";
                                break;
                            case "Termina con":
                                consulta += "Codigo like '%" + clave + "'";
                                break;
                            default:
                                consulta += "Codigo like '%" + clave + "%'";
                                break;
                        }
                        break;
                    case "Precio":
                        switch (forma)
                        {
                            case "Mayor a":
                                consulta += "Precio > " + clave;
                                break;
                            case "Menor a":
                                consulta += "Precio < " + clave;
                                break;
                            default:
                                consulta += "Precio = " + clave;
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (forma)
                        {
                            case "Comienza con":
                                consulta += "Nombre like '" + clave + "%' ";
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + clave + "'";
                                break;
                            default:
                                consulta += "Nombre like '%" + clave + "%'";
                                break;
                        }
                        break;
                    default:
                        switch (forma)
                        {
                            case "Comienza con":
                                consulta += "M.Descripcion like '" + clave + "%' ";
                                break;
                            case "Termina con":
                                consulta += "M.Descripcion like '%" + clave + "'";
                                break;
                            default:
                                consulta += "M.Descripcion like '%" + clave + "%'";
                                break;
                                
                        }
                    break;

                }

                datos.setearConsulta(consulta);
                datos.ejecutarLector();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.Lector["IdMarca"];
                    aux.marca.descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.imagen = (string)datos.Lector["ImagenUrl"];
                    }

                    aux.precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
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
    }
}
