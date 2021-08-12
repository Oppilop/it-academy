using System;
using System.Collections.Generic;

namespace laboratorio07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] nomes = {"Julio", "Lucia", "Daniel", "João"};
            Console.WriteLine("Antes da ordenação, Nomes:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            //acessando o método Sort da classe Array
            //Icomparable - define um método de comparação de tipo específico
            Array.Sort(nomes);
            Console.WriteLine("Nomes ordenados: ");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }*/

            //lista de objetos
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa {Nome = "Julio", Idade = 30},
                new Pessoa {Nome = "Lucia", Idade = 25},
                new Pessoa {Nome = "Daniel", Idade = 20},
                new Pessoa {Nome = "Julio", Idade = 15}
            };

            Console.WriteLine("Antes da ordenação, Pessoas:");

            //percorrendo a lista
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Nome + " " + pessoa.Idade);
            }

            //ordenação por implementação
            //ordena somente pelo nome
            // 1 dos tipos de ordenação
            pessoas.Sort();

            //chamada do método que compara por idade
            // 1 dos tipos de ordenação
            pessoas.Sort(new PessoaComparadorIdade());

            //ordenação feita pelo nome com condição para a idade (verifique a linha 14 da classe Pessoa)
            // 1 dos tipos d ordenação
            pessoas.Sort((p1, p2) => p1.Nome.CompareTo(p2.Nome));

            Console.WriteLine("Pessoas ordenadas:");

            //percorrendo a lista que já está ordenada
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Nome + " " + pessoa.Idade);
            }

            //delegate Predicate - retorno bool
            //percorrendo a lista e verificando se possui algum Julio nela
            Console.WriteLine(pessoas.Exists(p => p.Nome == "Julio"));

            //delegate Predicate - retorno bool
            //percorrendo a lista e verificando se possui alguma idade 15 nela
            Console.WriteLine(pessoas.Exists(p => p.Idade == 15));

        }    
    }
}
