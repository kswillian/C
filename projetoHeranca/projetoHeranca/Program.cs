using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            model.Aluno a = new model.Aluno();

            Console.Write("-|--------------------------|- \n" +
                          " | RG: ");
            a.setRg(Console.ReadLine());
            Console.Write(" | Nome: ");
            a.setNome(Console.ReadLine());
            Console.Write(" | Idade: ");
            a.setIdade(byte.Parse(Console.ReadLine()));
            Console.Write("-|--------------------------|- \n" +
                          " | Serie: ");
            a.setSerie(Console.ReadLine());
            Console.Write(" | Nota 1: ");
            a.setNota1(float.Parse(Console.ReadLine()));
            Console.Write(" | Nota 2: ");
            a.setNota2(float.Parse(Console.ReadLine()));
            Console.Write("-|--------------------------|- ");

            Console.WriteLine("\n\n" +
                            "-|--------------------------|- \n" +
                            " |--------------------------|  \n" +
                            " |  Nome: {0}   \n" +
                            " | ------------------------ |  \n" +
                            " |  Serie: {1}  \n" +
                            " |  Nota 1: {2} \n" +
                            " |  Nota 2: {3} \n" +
                            " | ------------------------ |  \n" +
                            " |  Média : {4}   \n" +
                            " |  Conceito: {5} \n" +
                            " |--------------------------|  \n" +
                            "-|--------------------------|-", 
                            a.getNome(), a.getSerie(), a.getNota1(), a.getNota2(), a.calcularMedia(), a.calcularConceito());

            Console.Read();
        }
     }
}
