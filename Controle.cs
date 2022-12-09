using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            cmd.CommandText = "select * from usuario where usuario = @usuario and senha=@senha";
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    acesso = true;
                }
                con.Desconectar();
            }
            catch (SqlException)
            {
                Console.WriteLine("Erro com o banco de dados");
            }
            return acesso;
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

