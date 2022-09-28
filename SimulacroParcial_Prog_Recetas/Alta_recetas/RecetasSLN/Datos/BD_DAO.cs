using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RecetasSLN.dominio;

namespace RecetasSLN.Datos.Interfaz
{
    public class BD_DAO
    {
        private static BD_DAO instancia;
        private SqlConnection conexion;
        private SqlCommand command = new SqlCommand();
        public BD_DAO()
        {
            conexion = new SqlConnection(Properties.Resources.CnnString);
        }
        public static BD_DAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new BD_DAO();
            }
            return instancia;
        }
        public DataTable ConsultaSQL(string sp)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            command.Connection = conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            tabla.Load(command.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public int ConsultarProximo(string sp, string Parametro)
        {
            conexion.Open();
            command.Connection = conexion;
            command.CommandText = sp;
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = Parametro;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            command.Parameters.Add(pOut);
            command.ExecuteNonQuery();
            conexion.Close();
            return (int)pOut.Value;
        }
        public bool ConfirmarPresupuesto(Receta oReceta)
        {
            SqlTransaction transaction = null;
            bool retorno = true;
            try
            {
                conexion.Open();
                transaction = conexion.BeginTransaction();

                //Receta
                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_RECETA", conexion, transaction); // Preguntar en clase - ?
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@tipo_receta", oReceta.TipoReceta);
                cmdMaestro.Parameters.AddWithValue("@nombre", oReceta.Nombre);
                if (oReceta.Chef != null)
                    cmdMaestro.Parameters.AddWithValue("@cheff", oReceta.Chef);
                else
                    cmdMaestro.Parameters.AddWithValue("@cheff", DBNull.Value);

                //Parametro de salida:
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@receta_nro";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(pOut);
                cmdMaestro.ExecuteNonQuery();
                cmdMaestro.Parameters.Clear();
                int recetaNro = (int)pOut.Value;
               
                int count = 1;

                //Detalle
                foreach (DetalleReceta detalle in oReceta.DetallesRecetas)
                {
                    SqlCommand cmdDetalle = new SqlCommand("InsertarDetalle", conexion, transaction); // Preguntar en clase - ?
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@receta_nro", recetaNro);
                    cmdDetalle.Parameters.AddWithValue("@id_ingrediente", detalle.Ingrediente.IdIngrediente);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    count++;
                    cmdDetalle.ExecuteNonQuery();
                    cmdDetalle.Parameters.Clear();

                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                retorno = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;
        }


        


      
    }
}
