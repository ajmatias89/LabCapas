using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Conexion
    {
        public static string cadenaConexion = "Server=localhost; Database=productos; Uid=labCapas; Pwd=HPA3Capas";
    }

    public class D_Usuario : D_Conexion
    {
        public static E_Usuario Login(string strUsuario, string strPassword)
        {
            try
            {
                using(MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand("sp_ValidarLoginHash", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_dsUsuario", strUsuario);
                        cmd.Parameters.AddWithValue("_dsPassword", strPassword);

                        using (MySqlDataReader fReader = cmd.ExecuteReader())
                        {
                            E_Usuario usuario;
                            List<E_Usuario> lstUsuario = new List<E_Usuario>();

                            while (fReader.Read())
                            {
                                usuario = new E_Usuario();
                                usuario.id = fReader.GetInt32("id");
                                usuario.dsUsuario = fReader.GetString("dsUsuario");
                                lstUsuario.Add(usuario);
                            }
                            return lstUsuario.FirstOrDefault() ;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error al validar el login: " + ex.Message);
            }

        }
    }

}
