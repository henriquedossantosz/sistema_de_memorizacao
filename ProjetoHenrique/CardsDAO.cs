using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    internal class CardsDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public CardsDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public void AtualizarCards(Cards carta)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = $"update FlashCard set poxrevisao = '" + carta.ProxRevisao.ToString("yyyy-MM-dd") + "', " +
                "acerto = " + carta.Acerto + ", erro = " + carta.Erro + ", adddias = " + carta.AddDias + " where id = " + carta.Id;

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                throw new Exception("Erro: Não foi possível atualizar carta no banco de dados.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Inserir(Cards carta)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO FlashCard VALUES (@frente, @verso, @criacao, @poxrevisao, @acerto, @erro, @adddias, @fkcr)";
            Cmd.Parameters.AddWithValue("@frente", carta.Frente);
            Cmd.Parameters.AddWithValue("@verso", carta.Verso);
            Cmd.Parameters.AddWithValue("@criacao", carta.Criacao);
            Cmd.Parameters.AddWithValue("@poxrevisao", carta.ProxRevisao.ToString("yyyy-MM-dd"));
            Cmd.Parameters.AddWithValue("@acerto", carta.Acerto);
            Cmd.Parameters.AddWithValue("@erro", carta.Erro);
            Cmd.Parameters.AddWithValue("@adddias", carta.AddDias);
            Cmd.Parameters.AddWithValue("@fkcr", carta.FKCR);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir flash card no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Atualizar(Cards carta)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE FlashCard SET frente = @frente, verso = @verso, FK_Codido_CR = @fkcr WHERE id = @id";
            Cmd.Parameters.AddWithValue("@frente", carta.Frente);
            Cmd.Parameters.AddWithValue("@verso", carta.Verso);
            Cmd.Parameters.AddWithValue("@fkcr", carta.FKCR);
            Cmd.Parameters.AddWithValue("@id", carta.Id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar o flash card no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM FlashCard where id = @id";
            Cmd.Parameters.AddWithValue("@id", id);

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

        public List<Cards> ListarTodasCards(int cod)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = $"SELECT * FROM FlashCard where FK_Codido_CR = " + cod.ToString() + " and  poxrevisao = '"
                + DateTime.Now.ToString("yyyy-MM-dd")+"'";

            List<Cards> listaDeCartas = new List<Cards>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Cards carta = new Cards((int)rd["Id"], (string)rd["frente"],
                    (string)rd["verso"], (DateTime)rd["criacao"], (DateTime)rd["poxrevisao"], (int)rd["acerto"], (int)rd["erro"], (int)rd["adddias"], (int)rd["FK_Codido_CR"]);
                    listaDeCartas.Add(carta);
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

            return listaDeCartas;
        }
        public List<Cards> ListarCards(int cod)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = $"SELECT * FROM FlashCard where FK_Codido_CR = " + cod.ToString();

            List<Cards> listaDeCartas = new List<Cards>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Cards carta = new Cards((int)rd["Id"], (string)rd["frente"],
                    (string)rd["verso"], (DateTime)rd["criacao"], (DateTime)rd["poxrevisao"], (int)rd["acerto"], (int)rd["erro"], (int)rd["adddias"], (int)rd["FK_Codido_CR"]);
                    listaDeCartas.Add(carta);
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

            return listaDeCartas;
        }
    }
}
