using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    class ConjuntoRevisao
    {
        private int _id;
        private string _nome;
        private string _descricao;
        private string _idioma;
        private int _codidioma; 

        public ConjuntoRevisao(string nome, string descricao, string idioma, int codioma)
        {
            Nome = nome;
            Descricao = descricao;
            Idioma = idioma;
            Codioma = codioma;
        }

        public ConjuntoRevisao(int id,string nome, string descricao, string idioma, int codioma)
        {
            _id = id;
            Nome = nome;
            Descricao = descricao;
            Idioma = idioma;
            Codioma = codioma;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _nome = value;
            }
        }

        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A descrição informada não é um texto válido");
                _descricao = value;
            }
        }

        public string Idioma
        {
            get { return _idioma; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _idioma = value;
            }
        }

        public int Codioma
        {
            get { return _codidioma; }

            set
            {
                if (value <= 0)
                    throw new Exception("O idioma informado não foi cadastrado previamente no sistema.");
                _codidioma = value;
            }
        }
    }
}
