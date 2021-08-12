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
		listaStrings.Add("10");*/
		
		//Exercicio 02 - fila de objetos
		/*Queue<Object> q = new Queue<Object>();
		q.Enqueue(".Net Framework");
		q.Enqueue(new Decimal(123.456));
		q.Enqueue(654.321);
		Console.WriteLine(q.Dequeue());
		Console.WriteLine(q.Dequeue());
		Console.WriteLine(q.Dequeue());*/
		
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
		
		foreach(KeyValuePair<int, string> item in paises){
			int codigo = item.Key;
			string pais = item.Value;
			Console.WriteLine("Código {0} = {1}", codigo, pais);
		}
		
		foreach(KeyValuePair<int, string> item in paises){
			int codigo = item.Key;
			string pais = item.Value;
			if("Reino Unidade" == pais){
				Console.WriteLine("O código é " + codigo);
			}
		}*/
		
		/*List<double> listareais = new List<double> {1.5, 2, 5.5, 4, 5.6};
		List<double> listareais2 = new List<double> {7,55,8.3,49,128,2,10.6};
		List<double> listamedia = new List<double> {};
	
	
		//Console.WriteLine(Program.TotalAcimaMedia(listareais));
		//Console.WriteLine(Program.TotalAcimaMedia(listareais2));	
	
		listamedia = Program.ListaAcimaMedia(listareais);
		foreach(double item in listamedia){
			Console.WriteLine(item);
		}
	}	

	public static int TotalAcimaMedia(List<double> lista){
		double soma = 0;
		int contador = 0;
		double media;
		int contadorAcimaMedia = 0;

		foreach(double item in lista){
			soma  += item;
			contador++;
		}

		media = soma / contador;

		//Console.WriteLine(media);
		
		foreach(double item in lista){
			if(item > media){
				contadorAcimaMedia++;
			}
		}

		return contadorAcimaMedia;
	}
	
	
	
	public static List<double> ListaAcimaMedia(List<double> lista){
		double soma = 0;
		int contador = 0;
		double media;
		int contadorAcimaMedia = 0;
		List<double> listaMedia = new List<double>{};

		foreach(double item in lista){
			soma  += item;
			contador++;
		}

		media = soma / contador;

		//Console.WriteLine(media);
		
		foreach(double item in lista){
			if(item > media){
				listaMedia.Add(item);
			}
		}

		return listaMedia;*/
	}
	
	
}		