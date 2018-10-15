using System;

namespace primeiroProjeto
{
    internal class Aluno
    {
        public string nome;
        private float n1;
        private float n2;
        private float media;

        public Aluno()
        {

        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setN1(float n1)
        {
            this.n1 = n1;
        }

        public void setN2(float n2)
        {
            this.n2 = n2;
        }

        public void setMedia(float media)
        {
            this.media = media;
        }

        public string getNome()
        {
            return this.nome;
        }

        public float getN1()
        {
            return this.n1;
        }

        public float getN2()
        {
            return this.n2;
        }

        public float getMedia()
        {
            return this.media;
        }

        public float calcularMedia(float n1, float n2)
        {
            this.media= (n1 + n2) / 2;

            return this.media; 
        }

        public string calcularConceito(float media)
        {
            if (media >= 7.0)
            {
                return "Aluno aprovado";

            } else if (media > 5)
            {

                return "Aluno em recuperação";

            }

            return "Aluno reprovado";
        }
    }
}