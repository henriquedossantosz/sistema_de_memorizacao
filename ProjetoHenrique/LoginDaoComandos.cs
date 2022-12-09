using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoHenrique
{
    class LoginDaoComandos
    {
        private bool acesso = false;
        private string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool VerificarLogin(string usuario, string senha)
        {
            cmd.CommandText = @"select * from Usuarios where NomeUsuario = @usuario and Senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.ReturnConnection();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    acesso = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }
            return acesso;
        }

        public void Cadastrar(string usuario, string senha)
        {
            cmd.CommandText = "insert into Usuarios (usuario, senha) values (@nome, @senha)";
            cmd.Parameters.AddWithValue("nome", usuario);
            cmd.Parameters.AddWithValue("senha", senha);
            try
            {
                cmd.Connection = con.ReturnConnection();
                cmd.ExecuteReader();
                this.mensagem = "Cadastrado com sucesso!!!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar conectar com o banco de dados!!!";
            }
        }

        public string Mensagem
        {
            set { mensagem = value; }
            get { return mensagem; }
        }
        public bool Acesso
        {
            set { acesso = value; }
            get { return acesso; }
        }
    }
}
