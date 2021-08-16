using System;
using System.Collections.Generic;
using System.Linq;

namespace laboratorio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa{Nome="Ana",DataNascimento=new DateTime(1980,3,14), Casada=true},
                new Pessoa{Nome="Paulo",DataNascimento=new DateTime(1978,10,23), Casada=true},
                new Pessoa{Nome="Maria",DataNascimento=new DateTime(2000,1,10), Casada=false},
                new Pessoa{Nome="Carlos",DataNascimento=new DateTime(1999,12,12), Casada=false}
            };

            //query
            /*var linq1 = from p in pessoas
                        where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
                        select p;

            foreach(var pessoa in linq1)
            {
                Console.WriteLine(pessoa);
            }*/
            //método
            /*var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));
            foreach (var pessoa in linq2)
            {
                Console.WriteLine(pessoa);
            }*/

            //GroupBy - retorna uma lista com mais duas lista true e false. Neste caso.
            var grupoCasadosSolteiros = pessoas.GroupBy(p => p.Casada);
            //Percorre a lista de true e false.
            foreach (var grupo in grupoCasadosSolteiros)
            {
                //lista a Key que é o valor do Casada e conta os elementos da lista true e false
                Console.WriteLine("Casada? " + grupo.Key + "\nQuantidade: " + grupo.Count());
                //percorre cada pessoa da lista true e false.
               foreach (var pessoa in grupo)
               {
                   //acessa cada elemento e retrona as infos
                    Console.WriteLine(pessoa.ToString());
               }
            }

            var maisVelho = pessoas.OrderBy(p => p.DataNascimento).First();
            Console.WriteLine("Pessoa mais velha: " + maisVelho.Nome);

            var solteiraMaisNova = pessoas.Where(p => p.Casada == false).OrderBy(p => p.DataNascimento).Last();
            Console.WriteLine("Pessoa solteira mais nova: " + solteiraMaisNova.Nome);

        }
    }
}