using System;

namespace laboratorio04_grupo
{
    class Program
    {
        static void Main(string[] args)
        {
         /* Circulo circ1 = new Circulo();
          Console.WriteLine(circ1.CentroX);
          Console.WriteLine(circ1.CentroY);
          Console.WriteLine(circ1.Raio);
          Console.WriteLine(circ1.ToString());


          Circulo circ2 = new Circulo(2.4, 5, 3);
          Console.WriteLine(circ2.CentroX);
          Console.WriteLine(circ2.CentroY);
          Console.WriteLine(circ2.Raio);
          Console.WriteLine(circ2.ToString());


          CirculoColorido circ3 = new CirculoColorido();
          Console.WriteLine(circ3.CentroX);
          Console.WriteLine(circ3.CentroY);
          Console.WriteLine(circ3.Raio);
          Console.WriteLine(circ3.Cor);
          Console.WriteLine(circ3.ToString());


          CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
          Console.WriteLine(circ4.CentroX);
          Console.WriteLine(circ4.CentroY); 
          Console.WriteLine(circ4.Raio);
          Console.WriteLine(circ4.Cor);
          Console.WriteLine(circ4.ToString());*/
        /* Porque é possível instanciar por parametro, porém não 
        é possível usar o conteúdo? */ 
          Circulo c = new CirculoColorido(2.5, 4.1, 3, "Azul");
          //(c.Cor)
           //Console.WriteLine(c.ToString());
          /*CirculoColoridoPreenchido  circ5 = new CirculoColoridoPreenchido();
          Console.WriteLine(circ5.ToString());

          CirculoColoridoPreenchido  circ6 = new CirculoColoridoPreenchido(1.2, 2.5, 5, "purple", "yellow");
          Console.WriteLine(circ6.ToString());*/

        Circulo[] arrayCirculos = new Circulo[3];
        arrayCirculos[0] = new Circulo(1.2, 3, 6);
        arrayCirculos[1] = new CirculoColorido(2, 5, 6.6, "purple");
        arrayCirculos[2] = new CirculoColoridoPreenchido(1, 3.5, 6, "purple", "yellow");

        foreach (Circulo item in arrayCirculos)
        {
            Console.WriteLine(item);
        }

        }

    }
}
