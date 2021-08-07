using System;

namespace laboratorio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            /*int [] array = new int[5] {10, 20, 30, 40, 50};
            int i;
            for (i = 0; i < array.Length; i++){
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }
            foreach (var item in array){
                Console.WriteLine(item);
            }*/

            /*string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";

            for(iStr = 0; iStr < str.Length; iStr++){
                Console.WriteLine("Indice = "+ iStr + " & Valor = "+ str[iStr]);
                }
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }*/

            /*DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            /*for(iDate = 0; iDate < 2; iDate++){
                Console.WriteLine("Indice = "+ iDate + " & Data = "+ dt[iDate].ToShortDateString());
            }
            foreach (var item in dt)
            {
                Console.WriteLine("Valor: " + item);
            }*/

            //Exercicio 02
            /*int [] array1 = new int[100];
            int [] array2 = new int[100];

            for (int i = 0; i < array1.Length; i++){
                 array1[i] = i;
            }

            for (int j = 0; j < array1.Length; j++){
                array2[j] = array1[j];
            }

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }*/

            int [,] array = new int[5,5];

            for (int linha = 0; linha < 5; linha++){
                for (int coluna = 0; coluna < 5; coluna++){
                    array[linha, coluna] = coluna;
                    Console.Write(array[linha, coluna]);
                }
                Console.WriteLine();
            }
            int soma = 0;
            for (int coluna = 0; coluna < 5; coluna++){
                for (int linha = 0; linha < 5; linha++){
                    
                    soma += array[linha, coluna];
                    
                }
                Console.WriteLine("Coluna: " + coluna + " Soma: " + soma);
            }


        }
    }
}
