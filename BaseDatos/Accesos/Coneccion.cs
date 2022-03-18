using BaseDatos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Accesos
{
    public class Coneccion
    {
        readonly string cadena = "Server = Localhost; Port=3306; Database= ejercicio3; Uid=root; pwd=1234;";

        MySqlConnection conn;
        MySqlCommand cmd;


        public Usuarios Login(string idusuario, string clave)
        {
            Usuarios user = null;

            try
            {
                string sql = "SELECT * FROM usuarios  WHERE IdUsuario= @IdUsuario AND Clave=@Clave ";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idusuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuarios();
                    user.IdUsuario = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Apellido = reader[2].ToString();
                    user.Edad = Convert.ToInt32((reader[3].ToString()));
                    user.Clave = reader[4].ToString();

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return user;
        }

        public DataTable MostrarUsuarios ()
        {
            DataTable MostrarUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuarios;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                MostrarUsuariosDT.Load(reader);



            }
            catch (Exception)
            {

                throw;
            }

            return MostrarUsuariosDT;

        }




    }
}
    
