using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    internal class Usuarios
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _telefone;
        private string _cpf;
        private DateTime _nascimento;
        private string _user;
        private string _senha;

        public Usuarios(string nome, string email, string telefone, string cpf,string user, DateTime nascimento, string senha)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Nascimento = nascimento;
            User = user;
            CPF = cpf;
            Senha = senha;
        }
        public Usuarios(int id,string nome, string email, string telefone, string cpf, string user, DateTime nascimento, string senha)
        {
            _id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Nascimento = nascimento;
            User = user;
            CPF = cpf;
            Senha = senha;
        }

        public Usuarios()
        {

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

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O e-mail informado não é um texto válido");
                _email = value;
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _telefone = value;
            }
        }

        public string CPF
        {
            get { return _cpf; }
            set
            {
                _cpf = value;
            }
        }
        public string User
        {
            get { return _user; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O usuário informado não é um texto válido");
                _user = value;
            }
        }
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A senha informado não é um texto válido");
                _senha = value;
            }
        }

        public DateTime Nascimento
        {
            get { return _nascimento; }
            set
            {
                _nascimento = value;
            }
        }
    }
}
