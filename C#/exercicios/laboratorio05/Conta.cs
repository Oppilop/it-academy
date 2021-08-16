namespace laboratorio05
{
    public abstract class Conta
    {
        //atributos
        private decimal saldo;
        private string titular;

        public Conta(string t)
        {
            titular = t;
        }

        public decimal Saldo
        {
            get {return saldo;}
            set {saldo = value;}
        }

        public string Titular
        {
            get {return titular;}
        }

        //Propriedade abstrata de leitura que retorna um identificador da conta, será implemetada por classes derivadas
        public abstract string Id
        {
            get;
        }

        //virtual, permite que seja sobrescrito
        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
        }
    }
}