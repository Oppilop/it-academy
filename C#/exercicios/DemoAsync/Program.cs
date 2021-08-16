using System;
using System.Threading.Tasks;

namespace DemoAsync
{
    class Program
    {
        static async Task Main(string[] args)// não esquecer do substituir o void pelo task
        {
            Console.WriteLine("Vou fazer um calculo demorado");
            var resultado = await FazCalculoDemoradoAsync(10);//método async por isso o await 
            Console.WriteLine("Resultado = " + resultado);
        }

        //método vai retornar um obj do tipo task
        //
        static async Task<int> FazCalculoDemoradoAsync(int x)
        {
            Console.WriteLine("Calculando...");
            //delay aguarda o tempo 
            await Task.Delay(5000);
            Console.WriteLine("Finalizando o calculo");
            //o código do return não vai ocorrer antes de 5 seg por causa do array
            return (int)Math.Pow(2,x);
        }
    }
}
