namespace laboratorio04
{
    //CirculoColorido está herdando Circulo
    public class CirculoColorido : Circulo
    {
        //atributo
        private string minhaCor;

        //Propriedades
        public string Cor 
        {
            get 
            {
                return minhaCor;
            }
            set
            {
                minhaCor = value;
            }
        }

        //construtor sem parametros
        public CirculoColorido()
        {
            minhaCor = "preto";
        }
        
        //construtor com parametros proprios e herdados da classe Circulo
        public CirculoColorido(double x, double y, double r, string c) : base(x, y, r)
        {
            minhaCor = c;
        }

        //sobrescrita do ToString
        public override string ToString()
        {
            return base.ToString() + " cor = " + Cor;
        }
    }
}