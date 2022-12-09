using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    class IdiomaDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public IdiomaDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public List<Idioma> ListarIdiomas(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "select * from Idioma";

            List<Idioma> listaIdioma = new List<Idioma>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Idioma idm = new Idioma((int)rd["Codigo_Idioma"], (string)rd["Nome_Idioma"]);
                    listaIdioma.Add(idm);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de idiomas no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaIdioma;
        }

        public void Inserir(string nome, int us)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "insert into Idioma values (@nome, @us)";
            Cmd.Parameters.AddWithValue("@us", us);
            Cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                throw new Exception("Problemas ao inserir idioma!\n", err);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Alterar(Idioma idm)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"update Idioma set Nome_Idioma = @nome where Codigo_Idioma = @id";
            Cmd.Parameters.AddWithValue("@nome", idm.Nome);
            Cmd.Parameters.AddWithValue("@id", idm.Id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Problemas ao inserir idioma!\n", err);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"delete from Idioma where Codigo_Idioma = @id";
            Cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Problemas ao excluir idioma!\n", err);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
    }
}
