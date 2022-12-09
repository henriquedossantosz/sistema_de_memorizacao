using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    class Idioma
    {
        private int _id;
        private string _nome;

        public Idioma(string nome)
        {
            Nome = nome;
        }

        public Idioma(int id, string nome)
        {
            _id = id;
            Nome = nome;
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
    }
}
