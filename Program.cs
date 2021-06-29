using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsultaViaCep_HTTPClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
            
        static async Task Main(string[] args)
        {
            await ProcessaRepositorio();
        }

        private static async Task ProcessaRepositorio()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositorios = await JsonSerializer.DeserializeAsync<List<Repositorio>>(await streamTask);

            foreach (var rep in repositorios)
            {
                Console.WriteLine(rep.MostraRepositorio());
                Console.WriteLine();
            }
        }
    }
}
