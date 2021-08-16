using System;
using System.Collections;


namespace laboratorio07
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] lista = { "Julio", "Lucia", "Daniel", "Joao"};

           /*Console.WriteLine("Array antes da ordenacao");
           for(int i = 0; i < lista.Length; i++)
           {
               Console.Write(lista[i] + " ");
            } 

            Console.WriteLine();
            
            Array.Sort(lista);
            Console.WriteLine("Array depois da ordenacao");
            for(int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            } */
            
            Console.WriteLine();
            Pessoa[] lista2 = { 
                new Pessoa("Jose", 25, false),
                new Pessoa("Ana", 28, false),
                new Pessoa("Paulo", 20, false)
            };

            Array.Sort(lista2);

            Console.WriteLine("Array depois da ordenacao");
            for(int i = 0; i < lista2.Length; i++)
            {
                Console.Write(lista2[i].Nome + " ");
                Console.Write(lista2[i].Idade + " ");
            }
        }
    }
}
