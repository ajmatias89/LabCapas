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
        public static string cadenaConexion = "Server=localhost; Database=productos; Uid=root; Pwd=prima1008";
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

                    using (MySqlCommand cmd = new MySqlCommand("sp_VAlidarLoginHash", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_dsUsuario", strUsuario);
                        cmd.Parameters.AddWithValue("_dsPassword", strPassword);

                        using (MySqlDataReader fReader = cmd.ExecuteReader())
                        {
                            E_Usuario usuario = new E_Usuario();

                            while (fReader.Read())
                            {
                                usuario.id = fReader.GetInt32("id");
                                usuario.dsUsuario = fReader.GetString("dsUsuario");

                            }
                            return usuario;
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
