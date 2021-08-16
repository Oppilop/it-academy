using System;

namespace laboratorio09
{
    class Program
    {
        static void Main(string[] args)
        {
           // inicializa o termometro e mostra seu valor
           TermometroLimite term = new TermometroLimite(5);
           Console.WriteLine(term.ToString());

            // adiciona um tratador ao evento LimiteSuperiorEvent
            term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
            term.TemperaturaNormalEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);

            // aumentar a temperatura além do limite
            term.Aumentar(4);
            Console.WriteLine(term.ToString());
            term.Diminuir(2);
            Console.WriteLine(term.ToString());
            term.Aumentar(5);
            Console.WriteLine(term.ToString());
            term.Aumentar(5);
            Console.WriteLine(term.ToString());

        }

        //codigo para tratamento do evento 
        private static void TrataLimiteSuperior(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
