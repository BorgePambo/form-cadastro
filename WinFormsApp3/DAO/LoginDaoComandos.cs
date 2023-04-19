using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.DAO
{
    internal class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand command = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader reader;

        public bool verificarLogin(String email, String senha)
        {
            command.CommandText = "SELECT * FROM logins WHERE email=@email and senha = @senha";
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", senha);

            try
            {
                command.Connection = con.conectar();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tem = true;
                }

                con.desconectar();
                reader.Close();
            
            }
            catch (SqlException) {
                this.mensagem = "Erro ao acessar banco de dados";
            }
            return tem;

        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            if (senha.Equals(confSenha))
            {
                command.CommandText = "INSERT INTO logins VALUES (@e, @s);";
                command.Parameters.AddWithValue("@e", email);
                command.Parameters.AddWithValue("@s", senha);

                try
                {
                    command.Connection = con.conectar();
                    command.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadatrado com sucesso";
                    tem = true;

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com banco de dados";
                }

            }
            else {
                this.mensagem = "Senha não correspondem!";
            }
            return mensagem;
        }

    }
}
