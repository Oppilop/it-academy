using System;
using System.Collections.Generic;
//Herança e sobrescrita de métodos

namespace laboratorio04
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // Circulo circ1 = new Circulo();
            // Console.WriteLine("X: " + circ1.CentroX);
            // Console.WriteLine("Y: " + circ1.CentroY);
            // Console.WriteLine("R: " + circ1.Raio);
            // Console.WriteLine(circ1.ToString());
            // Console.WriteLine("===============");

            // Circulo circ2 = new Circulo(2.4, 5, 3);
            // Console.WriteLine("X: " + circ2.CentroX);
            // Console.WriteLine("Y: " + circ2.CentroY);
            // Console.WriteLine("R: " + circ2.Raio);
            // Console.WriteLine("===============");

            // CirculoColorido circ3 = new CirculoColorido();
            // Console.WriteLine("X: " + circ3.CentroX);
            // Console.WriteLine("Y: " + circ3.CentroY);
            // Console.WriteLine("R: " + circ3.Raio);
            // Console.WriteLine("C: " + circ3.Cor);
            // Console.WriteLine("===============");


            // CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            // Console.WriteLine("X: " + circ4.CentroX);
            // Console.WriteLine("Y: " + circ4.CentroY);
            // Console.WriteLine("R: " + circ4.Raio);
            // Console.WriteLine("C: " + circ4.Cor);
            // Console.WriteLine("===============");

            // CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido();
            // Console.WriteLine(circ5);
            // CirculoColoridoPreenchido circ6 = new CirculoColoridoPreenchido(3, 4, 5, "preto", "red");
            // Console.WriteLine(circ6);
           
            Circulo[] lista = new Circulo[6];
            lista[0] = new Circulo();
            lista[1] = new CirculoColorido();
            lista[2] = new CirculoColoridoPreenchido();
            lista[3] = new Circulo(1, 2, 0);
            lista[4] = new CirculoColorido(5, 6, 7, "rosa");
            lista[5] = new CirculoColoridoPreenchido(8, 9, 0, "verde", "amarelo");

            foreach (Circulo item in lista)
            {
                Console.WriteLine(item);
            }

        }
    }
}
