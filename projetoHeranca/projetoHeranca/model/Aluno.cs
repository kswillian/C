using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoHeranca.model
{
    class Aluno : Pessoa
    {
        private string serie;
        private float nota1;
        private float nota2;
        private float media;

        public Aluno()
        {

        }

        public string getSerie()
        {
            return this.serie;
        }

        public void setSerie(string serie)
        {
            this.serie = serie;
        }

        public float getNota1()
        {
            return this.nota1;
        }

        public void setNota1(float nota)
        {
            this.nota1 = nota;
        }

        public float getNota2()
        {
            return this.nota2;
        }

        public void setNota2(float nota)
        {
            this.nota2 = nota;
        }

        public float getMedia()
        {
            return this.media;
        }

        public void setMedia(float media)
        {
            this.media = media;
        }

        public float calcularMedia()
        {
            return this.media = (this.nota1 + this.nota2) / 2;
        }

        public string calcularConceito()
        {
            if (this.media > 8.50)
            {
                return "A";

            } else if (this.media >= 7.0)
            {
                return "B";

            }else if (this.media >= 5.0)
            {
                return "C";

            } else if (this.media > 0.0)
            {
                return "D";
            }

            return "E";
        }
    }
}
