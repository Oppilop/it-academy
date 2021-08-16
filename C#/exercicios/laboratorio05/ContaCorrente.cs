namespace laboratorio05
{
    public class ContaCorrente : Conta
    {
        public const decimal taxaManutencao = 10.0M;

        public ContaCorrente(string t) : base(t)
        {
        }

        public override string Id 
        {
            get { return this.Titular + "(CC)";}
        }

        public void TaxarManutencao()
        {
            this.Saldo = this.Saldo - taxaManutencao;
        }

        public override string ToString()
        {
            return "ID: " + this.Id + "\nSaldo: " + this.Saldo + "\nTaxa Manutenção: " + taxaManutencao;
            
        }

    }
}