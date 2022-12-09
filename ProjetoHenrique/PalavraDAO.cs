using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    class PalavraDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public PalavraDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        
        public void Inserir(Palavra palavra)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Palavra VALUES (@texto, @definicao, @pronuncia, @animo, @utilidade, @classificacao, @morfologia, @fonte, @tema, @observacao, @fkidm)";
            Cmd.Parameters.AddWithValue("@texto", palavra.Texto);
            Cmd.Parameters.AddWithValue("@definicao", palavra.Definicao);
            Cmd.Parameters.AddWithValue("@pronuncia", palavra.Pronuncia);
            Cmd.Parameters.AddWithValue("@animo", palavra.Animo);
            Cmd.Parameters.AddWithValue("@utilidade", palavra.Utilidade);
            Cmd.Parameters.AddWithValue("@classificacao", palavra.Classificacao);
            Cmd.Parameters.AddWithValue("@morfologia", palavra.Morfologia);
            Cmd.Parameters.AddWithValue("@fonte", palavra.Fonte);
            Cmd.Parameters.AddWithValue("@tema", palavra.Tema);
            Cmd.Parameters.AddWithValue("@observacao", palavra.Observacao);
            Cmd.Parameters.AddWithValue("@fkidm", palavra.FKidioma);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir palavra no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Atualizar(Palavra palavra)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Palavra SET Palavra_Texto = @texto, Definicao = @definicao, Palavra_Pronuncia = @pronuncia, Palavra_Animo = @animo, Palavra_Utilidade = @utilidade, Classificacao = @classificacao, Morfologia = @morfologia, Fonte = @fonte, Tema = @tema, Observacao = @observacao, FK_Codigo_Idioma = @fkidm WHERE Codigo_Palavra = @id";
            Cmd.Parameters.AddWithValue("@texto", palavra.Texto);
            Cmd.Parameters.AddWithValue("@definicao", palavra.Definicao);
            Cmd.Parameters.AddWithValue("@pronuncia", palavra.Pronuncia);
            Cmd.Parameters.AddWithValue("@animo", palavra.Animo);
            Cmd.Parameters.AddWithValue("@utilidade", palavra.Utilidade);
            Cmd.Parameters.AddWithValue("@classificacao", palavra.Classificacao);
            Cmd.Parameters.AddWithValue("@morfologia", palavra.Morfologia);
            Cmd.Parameters.AddWithValue("@fonte", palavra.Fonte);
            Cmd.Parameters.AddWithValue("@tema", palavra.Tema);
            Cmd.Parameters.AddWithValue("@observacao", palavra.Observacao);
            Cmd.Parameters.AddWithValue("@fkidm", palavra.FKidioma);
            Cmd.Parameters.AddWithValue("@id", palavra.Id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar palavra no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Palavra WHERE Codigo_Palavra = @id";
            Cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir palavra no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Palavra> GerarListaPalavra(string selecao)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = selecao;

            List<Palavra> listaPalavras = new List<Palavra>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Palavra plv = new Palavra((int)rd["Codigo_Palavra"], (string)rd["Nome_Idioma"], (string)rd["Palavra_Texto"], (string)rd["Definicao"],
                        (string)rd["Palavra_Pronuncia"], (int)rd["Palavra_Animo"], (int)rd["Palavra_Utilidade"], (int)rd["Relevancia"],
                        (string)rd["Classificacao"], (string)rd["Morfologia"], (string)rd["Fonte"], (string)rd["Tema"], (string)rd["Observacao"],
                        (int)rd["FK_Codigo_Idioma"]);
                    listaPalavras.Add(plv);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura das palavras no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaPalavras;
        }
    }
}
