using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    class ConjuntoRevisaoDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ConjuntoRevisaoDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public List<ConjuntoRevisao> ListarConjuntos(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "select Codigo_CR, Nome_CR, Descricao, Nome_Idioma, Codigo_Idioma from Conjunto_de_Revisao inner join Idioma on Codigo_Idioma = FK_Codigo_Idioma";

            List<ConjuntoRevisao> listaDeCR = new List<ConjuntoRevisao>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    ConjuntoRevisao cr = new ConjuntoRevisao((int)rd["Codigo_CR"], (string)rd["Nome_CR"],
                    (string)rd["Descricao"], (string)rd["Nome_Idioma"], (int)rd["Codigo_Idioma"]);
                    listaDeCR.Add(cr);
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

            return listaDeCR;
        }

        public List<ConjuntoRevisao> FiltrarConjuntos(int fkidm)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "select Codigo_CR, Nome_CR, Descricao, Nome_Idioma, Codigo_Idioma from Conjunto_de_Revisao inner join Idioma on Codigo_Idioma = FK_Codigo_Idioma where FK_Codigo_Idioma = @id";
            Cmd.Parameters.AddWithValue("@id", fkidm);

            List<ConjuntoRevisao> listaDeCR = new List<ConjuntoRevisao>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    ConjuntoRevisao cr = new ConjuntoRevisao((int)rd["Codigo_CR"], (string)rd["Nome_CR"],
                    (string)rd["Descricao"], (string)rd["Nome_Idioma"], (int)rd["Codigo_Idioma"]);
                    listaDeCR.Add(cr);
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

            return listaDeCR;
        }

        public void Inserir(ConjuntoRevisao conjuntoRevisao)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Conjunto_de_Revisao VALUES (@nome, @descricao, @codidm)";

            Cmd.Parameters.AddWithValue("@nome", conjuntoRevisao.Nome);
            Cmd.Parameters.AddWithValue("@descricao", conjuntoRevisao.Descricao);
            Cmd.Parameters.AddWithValue("@codidm", conjuntoRevisao.Codioma);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir conjunto de revisão no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int cr)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM FlashCard where FK_Codido_CR = @cr DELETE FROM Conjunto_de_Revisao WHERE Codigo_CR = @cr";
            Cmd.Parameters.AddWithValue("@cr", cr);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Problemas ao Excluir o Conjunto de Revisão.\n" + err);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Alterar(ConjuntoRevisao conjunto)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Conjunto_de_Revisao SET Nome_CR = @nome, Descricao = @descricao, FK_Codigo_Idioma = @codidm WHERE Codigo_CR = @id";

            Cmd.Parameters.AddWithValue("@nome", conjunto.Nome);
            Cmd.Parameters.AddWithValue("@descricao", conjunto.Descricao);
            Cmd.Parameters.AddWithValue("@codidm", conjunto.Codioma);
            Cmd.Parameters.AddWithValue("@id", conjunto.Id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir conjunto de revisão no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<CRAuxiliar> ContarCards(int fkidm)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "select Codigo_CR, Nome_CR, count(id) as 'contagem' from Conjunto_de_Revisao inner join FlashCard on Codigo_CR = FK_Codido_CR where FK_Codigo_Idioma = @fkidm group by Codigo_CR, Nome_CR order by 'contagem' desc";
            Cmd.Parameters.AddWithValue("@fkidm", fkidm);

            List<CRAuxiliar> listaDeCR = new List<CRAuxiliar>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    CRAuxiliar cr = new CRAuxiliar((int)rd["Codigo_CR"], (string)rd["Nome_CR"],
                    (int)rd["contagem"]);
                    listaDeCR.Add(cr);
                }
                rd.Close();
            }
            catch(Exception err)
            {
                throw new Exception("Erro ao consultar banco\n" + err);
            }
            {
                Con.CloseConnection();
            }
            return listaDeCR;
        }
    }
}
