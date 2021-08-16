//Laboratorio 08 - Collections

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//Exercicio 01
		/*List<string> listaStrings = new List<string>();
		listaStrings.Add("Um");
		listaStrings.Add("Hello");
		listaStrings.Add("World");
		Console.WriteLine(listaStrings[0]);
		Console.WriteLine(listaStrings[1]);
		Console.WriteLine(listaStrings[2]);
		listaStrings.Add("10");
		Console.WriteLine(listaStrings[3]);*/
		
		//Exercicio 02 - fila de objetos
		/*Queue<Object> q = new Queue<Object>();
		q.Enqueue(".Net Framework");
		q.Enqueue(new Decimal(123.456));
		q.Enqueue(654.321);
		Console.WriteLine(q.Dequeue());
		Console.WriteLine(q.Dequeue());
		Console.WriteLine(q.Dequeue());
		Console.WriteLine(q.Count);*/

		/*Queue<int> minhaFila = new Queue<int>();
		minhaFila.Enqueue(10);
		minhaFila.Enqueue(200);
		minhaFila.Enqueue(1000);
		Console.WriteLine(minhaFila.Dequeue());
		Console.WriteLine(minhaFila.Dequeue());
		Console.WriteLine(minhaFila.Dequeue());*/
		
		//Exercicio 03
		/*Dictionary<int, string> paises = new Dictionary<int, string>();
		paises[44] = "Reino Unido";
		paises[33] = "França";
		paises[55] = "Brasil";
		Console.WriteLine("O código 55 é: {0}", paises[55]);
		
		foreach(KeyValuePair<int, string> item in paises)
		{
			int codigo = item.Key;
			string pais = item.Value;
			Console.WriteLine("Código {0} = {1}", codigo, pais);
		}
		
		foreach(KeyValuePair<int, string> item in paises){
			int codigo = item.Key;
			string pais = item.Value;
			if("Reino Unido" == pais){
				Console.WriteLine("O código é " + codigo);
			}
		}*/
		
		List<dynamic> listareais = new List<dynamic> {1.5, 2, 5.5, 4, 5.6};
		List<dynamic> listareais2 = new List<dynamic> {7,55,8.3,49,128,2,10.6};
		List<dynamic> listamedia = new List<dynamic>();
	
	
		Console.WriteLine(Program.TotalAcimaMedia(listareais));
		Console.WriteLine(Program.TotalAcimaMedia(listareais2));	
	
		listamedia = Program.ListaAcimaMedia(listareais);
		foreach(double item in listamedia)
		{
			Console.WriteLine("Listareais: " + item);
		}

		listamedia = Program.ListaAcimaMedia(listareais2);
		foreach(double item in listamedia)
		{
			Console.WriteLine("Listareais2: " + item);
		}
	}

	//lista que retorna o número de elementos acima da média
	public static int TotalAcimaMedia(List<dynamic> lista){
		
		double media = calculaMediaDeLista(lista);
		int contadorAcimaMedia = 0;

		foreach(double item in lista){
			if(item > media){
				contadorAcimaMedia++;
			}
		}

		return contadorAcimaMedia;
	}
	

	//visibilidade, static, retorno, nome método, parametro ou argumentos
	public static List<dynamic> ListaAcimaMedia(List<dynamic> lista)
	{
		
		double media = calculaMediaDeLista(lista);
	
		List<dynamic> listaMedia = new List<dynamic>{};
		
		foreach(double item in lista){
			if(item > media){
				listaMedia.Add(item);
			}
		}
		return listaMedia;
	}
	
	//método para calcular média
	public static double calculaMediaDeLista(List<dynamic> lista)
	{
		double soma = 0;
		int contador = 0;
		double media;
		
		foreach(double item in lista){
			soma += item;
			contador++;
		}

		media = soma / contador;

		return media;
	}
}	
		