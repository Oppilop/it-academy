namespace laboratorio04
{
    public class CirculoColorido : Circulo
    {
        public string Cor {get; set; }
        public CirculoColorido() : base(0, 0, 1)
        {
            Cor = "vermelho";
        }
        public override string ToString()
        {
            return base.ToString() + $" Cor: {Cor}";
        }

    }
}