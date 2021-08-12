using System;

namespace laboratorio05_grupo
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta[] contas = new Conta[2];
            contas[0] = new ContaPoupanca(5.2M, DateTime.Now, "000");
            contas[1] = new ContaCorrente("111");

            ((ContaPoupanca)contas[1]).AdicionarRendimento();
             ContaCorrente c1 = (ContaCorrente)contas[1];
             Console.WriteLine(c1.Manutencao);

        }
    }
}
