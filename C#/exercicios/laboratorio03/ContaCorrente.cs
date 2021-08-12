
namespace laboratorio03
{
    public class ContaCorrente 
    {
        public string Titular {get; set;}
        private decimal saldo;
        public const decimal MINIMO_DEPOSITO = 100;
        public void Depositar(decimal valor)
        {
            if (valor >= MINIMO_DEPOSITO)
            {
                saldo += valor;
            }
        }
        //métodos
        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }
        //propriedade não tem parenteses
        public decimal Saldo
        {
            get {return saldo;}
        }

        public ContaCorrente(string titular, decimal saldoInicial)
        {
            //Titular é uma propriedade
            Titular = titular;
            //saldo é um field
            saldo = saldoInicial;
        }

        //sobrecarga ou overload, pode desde que tenham lista de parametros diferentes
        //depois dos : chama o construtor de cima
        public ContaCorrente(string titular) : this(titular, 0)
        {
        }
    }
}