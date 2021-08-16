using System;
using System.Collections.Generic;
using System.Linq;

namespace laboratorio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //fonte de dados
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa{Nome = "Ana", DataNascimento = new DateTime(1980, 3, 14), Casada = true},
                new Pessoa{Nome = "Paulo", DataNascimento = new DateTime(1978, 10, 23), Casada = true},
                new Pessoa{Nome = "Maria", DataNascimento = new DateTime(2000, 1, 10), Casada = false},
                new Pessoa{Nome = "Carlos", DataNascimento = new DateTime(1999, 12, 12), Casada = false},
            };
            //só defini a consulta, ainda não executei
            var linq1 = from p in pessoas//tipo1
                        where p.Casada
                        select p;
            //executei aqui
            foreach (var p in linq1)
            {
                Console.WriteLine(p);
            }

            //p é um parametro => bool é o retorno
            //só defini a consulta, ainda não executei
            var linq2 = pessoas.Where(p => p.Casada);//tipo2
            foreach (var p in linq2)
            {
                //executei aqui
                Console.WriteLine(p);
            }

            var linq3 = from p in pessoas
                        where p.Casada && p.DataNascimento > new DateTime(2020, 1, 1)
                        select p.Nome;
            //converte o linq3 em list  //Action é um delegate
            linq3.ToList().ForEach(Console.WriteLine);

            //execução imediata - usaremos só métodos como esse de baixo
            var linq4 = pessoas.Where(p => p.Casada).Count();
            Console.WriteLine(linq4);

           /*var linq5 = from p in pessoas
                        group p by p.Casada;*/

            var linq5 = pessoas.GroupBy(p => p.Casada);
            foreach (var g in linq5)
            {
                Console.WriteLine(g.Key);
                foreach (var p in g)
                {
                    Console.WriteLine(p);
                }
            }

        }
    }
}
