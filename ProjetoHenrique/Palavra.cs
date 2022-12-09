using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHenrique
{
    class Palavra
    {
        private int _id;
        private string _idioma;
        private string _texto;
        private string _definicao;
        private string _pronuncia;
        private int _animo;
        private int _utilidade;
        private int _relevancia;
        private string _classificacao;
        private string _morfologia;
        private string _fonte;
        private string _tema;
        private string _observacao;
        private int _fkidioma;

        public Palavra(string idioma, string texto, string definicao, string pronuncia, int animo, int utilidade, int relevancia,
            string classificacao, string morfologia, string fonte, string tema, string observacao, int fkidioma)
        {
            Idioma = idioma;
            Texto = texto;
            Definicao = definicao;
            Pronuncia = pronuncia;
            Animo = animo;
            Utilidade = utilidade;
            Relevancia = relevancia;
            Classificacao = classificacao;
            Morfologia = morfologia;
            Fonte = fonte;
            Tema = tema;
            Observacao = observacao;
            FKidioma = fkidioma;
        }

        public Palavra(int id,string idioma, string texto, string definicao, string pronuncia, int animo, int utilidade, int relevancia,
    string classificacao, string morfologia, string fonte, string tema, string observacao, int fkidioma)
        {
            _id = id;
            Idioma = idioma;
            Texto = texto;
            Definicao = definicao;
            Pronuncia = pronuncia;
            Animo = animo;
            Utilidade = utilidade;
            Relevancia = relevancia;
            Classificacao = classificacao;
            Morfologia = morfologia;
            Fonte = fonte;
            Tema = tema;
            Observacao = observacao;
            FKidioma = fkidioma;
        }
        public int Id
        {
            get { return _id; }
        }
        public string Idioma
        {
            get { return _idioma; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O idioma informado não está previamente cadastrado!");
                _idioma = value;
            }
        }
        public string Texto
        {
            get { return _texto; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A palavra informada não é válida, pois está vazia!");
                _texto = value;
            }
        }
        public string Definicao
        {
            get { return _definicao; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A definição informada não é válida!");
                _definicao = value;
            }
        }
        public string Pronuncia
        {
            get { return _pronuncia; }
            set
            {
                _pronuncia = value;
            }
        }
        public int Animo
        {
            get { return _animo; }
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Insira valor de 0 a 10!");
                _animo = value;
            }
        }
        public int Utilidade
        {
            get { return _utilidade; }
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Insira valor de 0 a 10!");
                _utilidade = value;
            }
        }
        public int Relevancia
        {
            get { return _relevancia; }
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Insira valor de 0 a 10!");
                _relevancia = value;
            }
        }
        public string Classificacao
        {
            get { return _classificacao; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Selecione uma classificacao!");
                _classificacao = value;
            }
        }
        public string Morfologia
        {
            get { return _morfologia; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Selecione uma classe morfológica!");
                _morfologia = value;
            }
        }
        public string Fonte
        {
            get { return _fonte; }
            set
            {
                _fonte = value;
            }
        }
        public string Tema
        {
            get { return _tema; }
            set
            {
                _tema = value;
            }
        }
        public string Observacao
        {
            get { return _observacao; }
            set
            {
                _observacao = value;
            }
        }
        public int FKidioma
        {
            get { return _fkidioma; }
            set
            {
                if (value <= 0)
                    throw new Exception("Idioma inválido, pois não está previamente cadastrado!");
                _fkidioma = value;
            }
        }
    }
}
