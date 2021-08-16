using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DemoAsync2
{
    class Programc
    {
        //readonly: não pode receber outra atribuição
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            /*string uri = "https://viacep.com.br/ws/01001000/json/";
            var resposta = await client.GetAsync(uri);
            Console.WriteLine(resposta.StatusCode);
            Console.WriteLine(resposta.IsSuccessStatusCode);
            //                              Pegue e converta 
            Console.WriteLine(await resposta.Content.ReadAsStringAsync());*/

            //maneira rápida de pegar só o conteudo
            /* try
             {
              string uri = "https://viacep.com.br/ws/01001000/json/";
             var resposta = await client.GetStringAsync(uri);
             Console.WriteLine(resposta);
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }*/

            //json com passagem para obj
            try
            {
                string uri = "https://viacep.com.br/ws/01001000/json/";
                //métodos de extensão GetFromJsonAsync
                var resposta = await client.GetFromJsonAsync<viaCep>(uri);
                Console.WriteLine(resposta.Logradouro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
