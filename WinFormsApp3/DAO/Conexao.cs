using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.DAO
{
    internal class Conexao
    {

        public SqlConnection conn = new SqlConnection();

        public Conexao() {
            conn.ConnectionString = @"Data Source=DESKTOP-EO6D9UQ\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True";
        }

        public SqlConnection conectar() {
            if (conn.State == System.Data.ConnectionState.Closed) { 
                conn.Open();
            }

            return conn;
        }

        public void desconectar() {
            if (conn.State == System.Data.ConnectionState.Open) { 
                conn.Close();
            }
        }


    }
}
