using System;

namespace laboratorio05
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca c1 = new ContaPoupanca(2.0M, DateTime.Now, "111");
            Console.WriteLine(c1.Id);
            Console.WriteLine(c1.DataAniversario);
            Console.WriteLine(c1.Saldo);
        }
    }
}
