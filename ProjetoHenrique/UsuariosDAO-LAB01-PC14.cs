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
            Cmd.CommandText = @"INSERT INTO Usuarios VALUES (@nome, @email, @tel, @usuario, @senha)";

            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@email", usuario.Email);
            Cmd.Parameters.AddWithValue("@tel", usuario.Telefone);
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
                throw new Exception("Erro ao excluir usuário.");
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Alterar(Usuarios usuarios)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuarios SET Nome = @nome, Email = @email, Telefone = @telefone, NomeUsuario = @usuario, Senha = @senha WHERE id = @id";
            Cmd.Parameters.AddWithValue("@id", usuarios.Id);
            Cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
            Cmd.Parameters.AddWithValue("@email", usuarios.Email);
            Cmd.Parameters.AddWithValue("@telefone", usuarios.Telefone);
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
                        (string)rd["Email"], (string)rd["Telefone"], (string)rd["NomeUsuario"], (string)rd["Senha"]);
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
