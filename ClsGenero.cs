using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Negocio;
using Utilerias;

namespace Negocio
{
    public class  ClsGenero
    {
        #region PROPIEDADES
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
       
        #endregion

        #region MÉTODOS, ACCIONES, OPERACIONES
        public static bool CrearGenero(string nombre, string descripcion, )
        {
            bool valorRetorno = false;
            try
            {
                // CREAR OBJETO DATA CONTEXT Y ABRIR CONEXIÓN EN LA BASE DE DATOS 
                string strConnection = "Server=database-server-cine.c8hbnhjrqbcv.us-east-2.rds.amazonaws.com;Database=BD_CursoCSharpNet;User Id=admin;Password=s1I8lTCuyPxnXdkCGOV5;";
                dcCineDataContext dcDataContext = new dcCineDataContext(strConnection);
                dcDataContext.Connection.Open();

                // INSTRUCCIONES DE MANIPULACIÓN DE LOS DATOS
                Genero objGenero = new Genero ();
                objGenero.Nombre = nombre;
                objGenero.Descripción = descripcion;
             

                dcDataContext.Genero.InsertOnSubmit(objGenero);

                // ENVIAR CAMBIOS Y CERRAR CONEXIÓN
                dcDataContext.SubmitChanges();
                dcDataContext.Connection.Close();

                valorRetorno = true;
            }
            catch (Exception ex)
            {
                clsULogExceptions.WriteException(ex.Message);
                throw new ApplicationException("Ocurrió un error al actualizar el genero.");
            }
            return valorRetorno;
        }
        public static List<Genero> ObtenerLista()
        {
            string strConnection = "Server=database-server-cine.c8hbnhjrqbcv.us-east-2.rds.amazonaws.com;Database=BD_CursoCSharpNet;User Id=admin;Password=s1I8lTCuyPxnXdkCGOV5;";
            dcCineDataContext dcDataContext = new dcCineDataContext(strConnection);
            dcDataContext.Connection.Open();

            //  select * from Usuario
            var sqlConsulta = from u in dcDataContext.Genero
                              select u;

            dcDataContext.SubmitChanges();
            dcDataContext.Connection.Close();

            return sqlConsulta.ToList();
        }
        public static bool Actualizar(ClsGenero Genero)
        {
            bool valorRetorno = false;
            try
            {
                // CREAR OBJETO DATA CONTEXT Y ABRIR CONEXIÓN EN LA BASE DE DATOS DE LA NUBE
                string strConnection = "Server=database-server-cine.c8hbnhjrqbcv.us-east-2.rds.amazonaws.com;Database=BD_CursoCSharpNet;User Id=admin;Password=s1I8lTCuyPxnXdkCGOV5;";
                dcCineDataContext dcDataContext = new dcCineDataContext(strConnection);
                dcDataContext.Connection.Open();

                // INSTRUCCIONES DE MANIPULACIÓN DE LOS DATOS
                Genero objGenero = dcDataContext.Genero.First(u => u.ID == Genero.ID);
                objGenero.Nombre = Genero.Nombre;
                objGenero.Descripcion = Genero.Descripcion;
                

                // ENVIAR CAMBIOS Y CERRAR CONEXIÓN
                dcDataContext.SubmitChanges();
                dcDataContext.Connection.Close();

                valorRetorno = true;
            }
            catch (Exception ex)
            {
                clsULogExceptions.WriteException(ex.Message);
                throw new ApplicationException("Ocurrió un error al actualizar el genero.");
            }
            return valorRetorno;
        }
        public static bool Eliminar(int ID)
        {

            bool valorRetorno = false;
            try
            {
                // CREAR OBJETO DATA CONTEXT Y ABRIR CONEXIÓN
                string strConnection = "Server=database-server-cine.c8hbnhjrqbcv.us-east-2.rds.amazonaws.com;Database=BD_CursoCSharpNet;User Id=admin;Password=s1I8lTCuyPxnXdkCGOV5;";
                dcCineDataContext dcDataContext = new dcCineDataContext(strConnection);
                dcDataContext.Connection.Open();

                // INSTRUCCIONES DE MANIPULACIÓN DE LOS DATOS
                Usuario usuario = dcDataContext.Genero.First(u => u.ID == ID);

                dcDataContext.Genero.DeleteOnSubmit(usuario);

                // ENVIAR CAMBIOS Y CERRAR CONEXIÓN
                dcDataContext.SubmitChanges();
                dcDataContext.Connection.Close();

                valorRetorno = true;
            }
            catch (Exception ex)
            {
                clsULogExceptions.WriteException(ex.Message);
                throw new ApplicationException("Ocurrió un error al actualizar el genero.");
            }
            return valorRetorno;
        }
        public static ClsGenero  GetOne(int ID)
        {
            Usuario valorRetorno = null;
            try
            {
                // CREAR OBJETO DATA CONTEXT Y ABRIR CONEXIÓN EN LA BASE DE DATOS EN LA NUBE
                string strConnection = "Server=database-server-cine.c8hbnhjrqbcv.us-east-2.rds.amazonaws.com;Database=BD_CursoCSharpNet;User Id=admin;Password=s1I8lTCuyPxnXdkCGOV5;";
                dcCineDataContext dcDataContext = new dcCineDataContext(strConnection);
                dcDataContext.Connection.Open();

                // INSTRUCCIONES DE MANIPULACIÓN DE LOS DATOS
                valorRetorno = dcDataContext.Genero.First(u => u.ID == ID);

                // ENVIAR CAMBIOS Y CERRAR CONEXIÓN
                dcDataContext.SubmitChanges();
                dcDataContext.Connection.Close();
            }
            catch (Exception ex)
            {
                clsULogExceptions.WriteException(ex.Message);
                throw new ApplicationException("Ocurrió un error al obtener el genero con ID igual a " + ID);
            }
            return valorRetorno;
        }

    }
}


 
