using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    internal class UsuariosDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public UsuariosDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Usuarios usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Usuarios VALUES (@nome, @email, @tel, @cpf, @nasc, @usuario, @senha)";

            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@email", usuario.Email);
            Cmd.Parameters.AddWithValue("@tel", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
            Cmd.Parameters.AddWithValue("@nasc", usuario.Nascimento);
            Cmd.Parameters.AddWithValue("@usuario", usuario.User);
            Cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE from Usuarios WHERE id = @id";
            Cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao excluir usuário." + err);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Alterar(Usuarios usuarios)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuarios SET Nome = @nome, Email = @email, Celular = @telefone, CPF = @cpf, Nascimento = @nasc, NomeUsuario = @usuario, Senha = @senha WHERE id = @id";
            Cmd.Parameters.AddWithValue("@id", usuarios.Id);
            Cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
            Cmd.Parameters.AddWithValue("@email", usuarios.Email);
            Cmd.Parameters.AddWithValue("@telefone", usuarios.Telefone);
            Cmd.Parameters.AddWithValue("@cpf", usuarios.CPF);
            Cmd.Parameters.AddWithValue("@nasc", usuarios.Nascimento);
            Cmd.Parameters.AddWithValue("@usuario", usuarios.User);
            Cmd.Parameters.AddWithValue("@senha", usuarios.Senha);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao alterar usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Usuarios> GerarListaUsuarios(string selecao)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = selecao;

            List<Usuarios> listaDeUsuarios = new List<Usuarios>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Usuarios usuario = new Usuarios((int)rd["Id"], (string)rd["Nome"],
                        (string)rd["Email"], (string)rd["Celular"], (string)rd["CPF"], (string)rd["NomeUsuario"], (DateTime)rd["Nascimento"], (string)rd["Senha"]);
                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeUsuarios;
        }

        public Usuarios RetornaUsuario(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"select * from Usuarios where id = " + id;

            //Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Usuarios usuario = new Usuarios();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    usuario = new Usuarios((int)rd["id"], (string)rd["Nome"],
                        (string)rd["Email"], (string)rd["Celular"], (string)rd["CPF"], (string)rd["NomeUsuario"], (DateTime)rd["Nascimento"], (string)rd["Senha"]);
                }
                rd.Close();
            }
            catch(Exception err)
            {
                throw new Exception("Problemas ao retornar usuário\n", err);
            }
            finally
            {
                Con.CloseConnection();
            }
            return usuario;
        }


        public void Logar(string nomeUsuario, string senha)
        {
            try 
            {
                Cmd.Connection = Con.ReturnConnection();
                Cmd.CommandText = "SELECT * FROM Usuarios where NomeUsuario = @NomeUsuario";
            }
            catch(Exception err)
            {
                throw new Exception("Usuário informado não existe!\n"+err.Message);
            }

        }
    }
}
