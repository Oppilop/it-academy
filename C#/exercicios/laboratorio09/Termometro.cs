namespace laboratorio09
{
    public class Termometro
    {
        //atributos
        private double valor;

        //construtor sem parametros
        public Termometro()
        {
            valor = 0.0;
        }

        //propriedade de leitura e escrita para o atributo valor
        public double Temperatura
        {
            get {return valor;}
            set {valor = value;}
        }

        //métodos com possibilidade de sobrecarga
        virtual public void Aumentar()
        {
            valor += 0.1;
        }

        virtual public void Aumentar(double quantia)
        {
            valor += quantia;
        }

        virtual public void Diminuir()
        {
            valor -= 0.1;
        }

        virtual public void Diminuir(double quantia)
        {
            valor -= quantia;
        }

        //sobrescrita do ToString
        public override string ToString()
        {
            return valor.ToString();
        }

    }
}