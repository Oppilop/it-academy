using System;

namespace laboratorio04
{
    public class Circulo
    {
        //atributos
        private double coordX;
        private double coordY;
        private double raio;

        //Sobrecarga para caso de instancia sem parametros
        public Circulo()
            : this(0, 0, 1)
        {
        }

        //Construtor padrao com parametros
        public Circulo(double x, double y, double r)
        {
            coordX = x;
            coordY = y;
            raio = Math.Abs(r);
        }

        //Propriedades CentroX
        public double CentroX
        {
            get
            {
                return coordX;
            }
            set
            {
                coordX = value;
            }
        }

        //Propriedades CentroY
        public double CentroY
        {
            get
            {
                return coordY;
            }
            set
            {
                coordY = value;
            }
        }

        //Propriedades Raio
        public double Raio
        {
            get
            {
                return raio;
            }
            set
            {
                raio = value;
            }
        }

        //sobrescrita ToString
        public override string ToString()
        {
            return "(X "+ string.Format("{0:F2}", CentroX) + "; "
            + string.Format("Y {0:F2}", CentroY) + ")"
            + " raio = "+ string.Format("{0:F2}", Raio);
        }

    }
}