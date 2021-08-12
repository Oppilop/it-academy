using System;

namespace laboratorio05_grupo
{
    public class ContaCorrente : Conta
    {
        private const decimal taxaManutencao = 10.0M;

        public ContaCorrente(string t) : base(t)
        {
        }

        public override string Id
        {
            get { return this.Titular + "(CP)"; }
        }

        public decimal Manutencao
        {
            get { return taxaManutencao; }
        }

    }
}