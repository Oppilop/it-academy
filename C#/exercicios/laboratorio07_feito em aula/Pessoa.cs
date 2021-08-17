using System;
using System.Collections.Generic;

namespace laboratorio07
{
    //implementação da interface Icomparable para classificação generalizada
    //"O objeto a ser classificado implementará IComparable, enquanto a classe que irá ordenar os objetos implementará o IComparer."
    public class Pessoa : IComparable<Pessoa>
    {
        //declarando atributos e já adicionando as propriedades
        public string Nome {get; set;}
        public int Idade {get; set;}

        //método comparador com condição para a idade
        public int CompareTo(Pessoa outra)
        {
            if (Nome.CompareTo(outra.Nome) == 0)
            {
                return Idade.CompareTo(outra.Idade);
            }
            return Nome.CompareTo(outra.Nome);

        }
    }
    
    //"O objeto a ser classificado implementará IComparable, enquanto a classe que irá ordenar os objetos implementará o IComparer."
    public class PessoaComparadorIdade : IComparer<Pessoa>
    {
        public int Compare(Pessoa x, Pessoa y)
        {
        //compara por idade
        return x.Idade.CompareTo(y.Idade);
        }
    }
}