using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoHenrique
{
    internal class Cards
    {
        private int _id;
        private string _frente;
        private string _verso;
        private DateTime _criacao;
        private DateTime _proxrevisao;
        private int _acerto;
        private int _erro;
        private int _adddias;
        private int _fkcr;

        public Cards(string frente, string verso, DateTime criacao, DateTime proxrevisao, int acerto, int erro, int adddias, int fkcr)
        {
            Frente = frente;
            Verso = verso;
            Criacao = criacao;
            ProxRevisao = proxrevisao;
            Acerto = acerto;
            Erro = erro;
            AddDias = adddias;
            FKCR = fkcr;
        }

        public Cards(int id,string frente, string verso, DateTime criacao, DateTime proxrevisao, int acerto, int erro, int adddias, int fkcr)
        {
            _id = id;
            Frente = frente;
            Verso = verso;
            Criacao = criacao;
            ProxRevisao = proxrevisao;
            Acerto = acerto;
            Erro = erro;
            AddDias = adddias;
            FKCR = fkcr;
        }

        public Cards(string frente, string verso,int fkcr)
        {
            Frente = frente;
            Verso = verso;
            FKCR = fkcr;
            Criacao = DateTime.Now;
            ProxRevisao = DateTime.Now;
            Acerto = 0;
            Erro = 0;
            AddDias = 1;
        }

        public int Id
        {
            get { return _id; }
        }
        public string Frente
        {
            get { return _frente; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A frente informada não é um texto válido");
                _frente = value;
            }
        }
        public string Verso
        {
            get { return _verso; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O verso informado não é um texto válido");
                _verso = value;
            }
        }

        public DateTime Criacao
        {
            get { return _criacao; }
            set
            {
                if (value == null)
                    throw new Exception("O nome informado não é um texto válido");
                _criacao = value;
            }
        }

        public DateTime ProxRevisao
        {
            get { return _proxrevisao; }
            set
            {
                if (value == null)
                    throw new Exception("O nome informado não é um texto válido");
                _proxrevisao = value;
            }
        }
        public int Acerto
        {
            get { return _acerto; }
            set { _acerto = value; }
        }

        public int Erro
        {
            get { return _erro; }
            set { _erro = value; }
        }

        public int AddDias
        {
            get { return _adddias; }
            set { _adddias = value; }
        }

        public int FKCR
        {
            get { return _fkcr; }
            set 
            {
                if (value <= 0)
                    throw new Exception("O conjunto não está previamente cadastrado.");
                _fkcr = value; 
            }
        }
    }
}
