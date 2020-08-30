using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Punto.Venta.BE;

namespace Sistema.Punto.Venta.BC
{
    
    public class Autenticacion
    {
        
        
        public List<Usuario> ObtenerUsuarioAutenticado(string conexion,string contrasena,string appProcedimiento)
        {
            List<Usuario> ListaUsuario = new List<Usuario>();
            Usuario usuario = new Usuario();
            try
            {
                SqlConnection sql = new SqlConnection(conexion);
                sql.Open();
                SqlCommand cmd = new SqlCommand(appProcedimiento, sql);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param;
                param = cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar, 50);
                param.Value = contrasena;
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    return ListaUsuario;
                    sql.Close();
                }
                else
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        usuario.Nombre = dataTable.Rows[i]["Nombre"].ToString();
                        usuario.ApellidoPaterno = dataTable.Rows[i]["Apellido_Paterno"].ToString();
                        usuario.RolId = Convert.ToInt16(dataTable.Rows[i]["Rol"].ToString());
                    }
                    ListaUsuario.Add(usuario);
                    sql.Close();
                }
            }
            catch (Exception ex)
            {
                
            }
            return ListaUsuario;
        }
    }
}
