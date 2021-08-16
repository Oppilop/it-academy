using System;
using System.Collections.Generic;
class Program
{
    //delegate 
    public delegate double OperacaoMatematicaBinaria(double x, double y);

    public delegate void OcorrenciaDeOperacao(double resultado);

    public static event OcorrenciaDeOperacao AoOcorrerOperacao;

    //métodos compativeis com o delegate declarado
    public static double Somar(double x, double y)
    {
        double r = x + y;
        //Console.WriteLine($"A soma de {x} e {y} é igual a {r}.");
        AoOcorrerOperacao.Invoke(r);
        return r;
    }

    public static double Multiplicar(double x, double y)
    {
        double r = x * y;
        //Console.WriteLine($"A multiplicação de {x} e {y} é igual a {r}.");
        AoOcorrerOperacao.Invoke(r);
        return r;
    }

    public static double Potenciar(double x, double y)
    {
        double r = Math.Pow(x, y);
        //Console.WriteLine($"A potencia de {x} e {y} é igual a {r}.");
        AoOcorrerOperacao.Invoke(r);
        return r;
    }

    static void Main(string[] args)
    {
        //OperacaoMatematicaBinaria op = new OperacaoMatematicaBinaria(Potenciar);
        //op(20, 10);

        // List<OperacaoMatematicaBinaria> operacoes = new List<OperacaoMatematicaBinaria>();
        // operacoes.Add(new OperacaoMatematicaBinaria(Somar));
        // operacoes.Add(new OperacaoMatematicaBinaria(Multiplicar));
        // operacoes.Add(new OperacaoMatematicaBinaria(Potenciar));

        // foreach (var item in operacoes)
        // {
        //     item(10, 2);
        //     item(20, 3);
        //     item(30, 4);
        //     Console.WriteLine();
        // }

        //maneira de adicionar um método anonimo ao delegate
        // operacoes.Add(delegate (double a, double b)
        // {
        //     double r = a / b;
        //     Console.WriteLine($"A divisão de {a} por {b} é igual a {r}.");
        //     return r;
        // });

        // foreach (var item in operacoes)
        // {
        //     item(10, 2);
        //     item(20, 3);
        //     item(30, 4);
        //     Console.WriteLine();
        // }

        AoOcorrerOperacao += MostrarResultadoNaTela;
        AoOcorrerOperacao += EnviarResultadoPorEmail;
        AoOcorrerOperacao += GravarResultadoEmArquivo;

        // a variavel do tipo delegate está apontando para 3 métodos
        OperacaoMatematicaBinaria opMulticast = Somar;
        opMulticast += Multiplicar;
        opMulticast += Potenciar;
        opMulticast += delegate (double a, double b)
        {
            double r =  a/b;
            //Console.WriteLine($"A divisão de {a} por {b} é igual a {r}.");
            AoOcorrerOperacao.Invoke(r);
            return r;
        };

        opMulticast(2, 3);
    }

    public static void MostrarResultadoNaTela(double r)
    {
        Console.WriteLine($"Resultado: {r}");
    }

    public static void EnviarResultadoPorEmail(double r)
    {
        Console.WriteLine($"Enviando e-mail com resultado {r}...");
    }

    public static void GravarResultadoEmArquivo(double r)
    {
        Console.WriteLine($"Gravando arquivo com resultado {r}...");
    }
}
