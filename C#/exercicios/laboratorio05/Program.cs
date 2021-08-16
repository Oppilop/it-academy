using System;
using System.Collections.Generic;
{
    
}

namespace laboratorio05
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca c1 = new ContaPoupanca(0.02M, DateTime.Now, "111");
            c1.Depositar(5000);
            Console.WriteLine(c1);
            c1.AdicionarRendimento();
            Console.WriteLine(c1);

            Console.WriteLine("==============================");

            ContaCorrente c2 = new ContaCorrente("222");
            c2.Depositar(500);
            Console.WriteLine(c2);
            c2.TaxarManutencao();
            Console.WriteLine(c2);

            List<Conta> contas = new List<Conta>()
            {
                new ContaPoupanca(0.05M, new DateTime(2018,5, 2) , "222"),
                new ContaCorrente("333")
            };

            contas[0].Sacar(50);
            contas[1].Depositar(20);
        }
    }
}
