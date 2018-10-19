using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoHeranca.model
{
    class Pessoa
    {
        private string rg;
        private string nome;
        private byte idade;

        public Pessoa()
        {

        }

        public string getRg()
        {
            return this.rg;
        }

        public void setRg(string rg)
        {
            this.rg = rg;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public byte getIdade()
        {
            return this.idade;
        }

        public void setIdade(byte idade)
        {
            this.idade = idade;
        }

    }
}
