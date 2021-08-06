using System;

namespace laboratorio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01 - Tipo valor byte, int e long
           /* byte b;
            b = byte.MaxValue;
            int i;
            i = int.MaxValue;
            long l;
            l = long.MaxValue;

            Console.WriteLine("Valor maximo de byte: " + b);
            Console.WriteLine("Valor maximo de int: " + i);
            Console.WriteLine("Valor maximo de long: " + l);*/

            //Exercicio 02 - Trabalhando com strings
            /*string strPrimeira = "Alo";
            string strSegunda = "Mundo";
            string strTerceira = strPrimeira + strSegunda;
            int cchTamanho = strTerceira.Length;
            string strQuarta = "Tamanho = " + cchTamanho.ToString();

            Console.WriteLine(strTerceira);
            Console.WriteLine(strQuarta);
            Console.WriteLine(strTerceira.Substring(0,5));*/

            //Exercicio 03 - Trabalhando com objetos do Framework
            /*DateTime dt = new DateTime(2015, 04, 23);
            string strQuinta = dt.ToString();

            Console.WriteLine(strQuinta);*/

            //Exercicio 04 - float, double e decimal
            /*float a = (float)2.50;
            double b = 10.30;
            decimal c = (decimal)2.232;

            Console.WriteLine("{0} {1} {2}", a,b,c);*/

            /*string [] strings = {"This is a string.", "Hello!" , "Nothing.", "yes", "randomize"};
            foreach (var item in strings) {
                bool endsInPeriod = item.EndsWith(".");
                Console.WriteLine("'{0}' ====> ends in a period: {1}", item, endsInPeriod);
            }*/

            /*string original = "aaabbb";
            Console.WriteLine("The original string: '{0}'", original);
            string modified = original.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified);*/

            /*DateTime data = new DateTime();

            Console.WriteLine(data.ToString());
            
            var ndata = data.AddDays(25).AddHours(12).AddSeconds(22);
            
            Console.WriteLine(ndata.ToString());*/

            /*int i = 10;
            float f = 0;
            f = i;//conversão implícita, sem perda de dados.
            System.Console.WriteLine(f);
            f = 0.5F;
            i = (int) f; //conversão explícita, com perda de dados.
            System.Console.WriteLine(i);*/

            /*string stringInteiro = "123456789";
            int valorStringInteiro = Convert.ToInt32(stringInteiro);
            Console.WriteLine(valorStringInteiro);

            Int64 valorInt64 = 123456789;
            int valorInt = Convert.ToInt32(valorInt64);
            Console.WriteLine(valorInt);

            string stringInteiroGrande= "999999999999999999999999999999999999999999999";
            int valorStringInteiroGrande= Convert.ToInt32(stringInteiroGrande);*/
            //Erro de conversão de 64 para 32
            //System.OverflowException: Value was either too large or too small for an Int32.at 
            //System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)at <programa>.<classe>.Main(String[] args) in <diretorio do programa\arquivo.cs>:<linha>

            /*string stringInteiro = "123456789";
            int valorStringInteiro;
            bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);
            Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro);

            string stringInteiroGrande= "999999999999999999999999999999999999999999999";
            int valorStringInteiroGrande;
            bool conversao2= Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
            Console.WriteLine("Conversão efetuada:" + conversao2+ " Valor: " + valorStringInteiroGrande);

            string stringLetras = "abc";
            double valorStringLetras;
            bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
            Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);*/

            /*double valorFracionado = 4.7;
            int valorInteiro1 = (int) valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);
            Console.WriteLine("Conversao explicita = " + valorInteiro1);
            Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);*/

            /*int x = 10;
            double y = 3.4;
            Console.WriteLine("{0}  {1}",x,y);*/

            {
                
            }












        }
    }
}
