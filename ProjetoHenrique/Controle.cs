using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoHenrique
{
    class Controle
    {
        private string mensagem;

        public Controle()
        {
            this.mensagem = "";
        }
        public string Mensagem
        {
            set { mensagem = value; }
            get { return mensagem; }
        }
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        private bool acesso = false;
        public bool Acessar(string usuario, string senha)
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
                con.CloseConnection();
            }
            catch (SqlException)
            {
                Console.WriteLine("Erro com o banco de dados");
            }
            return acesso;
        }

        public int RetornaId(string usuario, string senha)
        {
            cmd.Connection = con.ReturnConnection();
            cmd.CommandText = @"select id from Usuarios where NomeUsuario = @usuario and Senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            int id = 0;

            try
            { 
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    id = (int)rd["id"];
                }
            }
            catch(Exception err)
            {
                throw new Exception("Erro\n" + err);
            }
            return id;
        }

        public bool Acesso
        {
            set { acesso = value; }
            get { return acesso; }
        }
        public string Cadastrar(string usuario, string senha)
        {

            LoginDaoComandos loginDao = new LoginDaoComandos();
            loginDao.Cadastrar(usuario, senha);
            return loginDao.Mensagem;
        }
    }
}
