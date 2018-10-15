using System;

namespace primeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno();

            Console.Write("-|--------------------------|- \n" +
                          " |       Dados do Aluno     | \n" +
                          "-|--------------------------|-\n" +
                          " | Nome: ");

            a.setNome(Console.ReadLine());

            Console.Write(" | Nota1: ");

            a.setN1(float.Parse(Console.ReadLine()));

            Console.Write(" | Nota2: ");

            a.setN2(float.Parse(Console.ReadLine()));

            Console.Write("\n" +
                          "-|--------------------------|- \n" +
                          " | Nome: {0} \n" +
                          " | Nota1: {1} \n" +
                          " | Nota2: {2} \n" +
                          " | Média: {3} \n" +
                          "-|--------------------------|- \n" +
                          " | Conceito: {4} \n" +
                          "-|--------------------------|-", 
                          a.getNome(), a.getN1(), 
                          a.getN2(), a.calcularMedia(a.getN1(), 
                          a.getN2()), a.calcularConceito(a.getMedia()));

            Console.ReadLine();

        }
    }
}
