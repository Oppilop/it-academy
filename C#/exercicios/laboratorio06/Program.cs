using System;
using System.Collections.Generic;

namespace laboratorio06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IEstadoBinario[] lista = new IEstadoBinario[3]; 
            lista[0] = new Lampada(110, 60); 
            lista[0].Ligar(); 
            lista[1] = new TermometroEletrico();
            lista[1].Desligar();
            lista[2] = new CafeteiraEletrica();
            lista[2].Ligar();

            for (int i = 0; i < lista.Length; i++) 
            { 
                Console.WriteLine(lista[i].Estado); 
            }*/

            List<IEstadoBinario> lista2 = new List<IEstadoBinario>();
            lista2.Add(new Lampada(110, 60));
            lista2[0].Ligar();
            lista2.Add(new TermometroEletrico());
            lista2[1].Desligar();
            lista2.Add(new CafeteiraEletrica());
            lista2[2].Ligar();


            for (int i = 0; i < lista2.Count; i++)
            {
                Console.WriteLine(lista2[i].Estado);
            }
        }
    }
}

