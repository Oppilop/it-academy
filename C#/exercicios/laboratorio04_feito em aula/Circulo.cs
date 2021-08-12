namespace laboratorio04
{
    public class Circulo //: Object (um circulo é um tipo de objeto)
    {
        public double CentroX {get; set;}
        public double CentroY {get; set;}
        public double Raio {get; set;}

        public Circulo(double x, double y, double r)
        {
            CentroX = x;
            CentroY = y;
            Raio = r;
        }

        public override string ToString()
        {
            return $"Centro: ({CentroX}, {CentroY}), Raio: {Raio}";
        }


    }
}