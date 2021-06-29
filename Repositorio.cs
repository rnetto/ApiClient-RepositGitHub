
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ConsultaViaCep_HTTPClient
{
    public class Repositorio
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Nome { get; set; }
        [JsonPropertyName("private")]
        public bool Privado { get; set; }
        [JsonPropertyName("html_url")]
        public string Url { get; set; }
        [JsonPropertyName("description")]
        public string Descricao { get; set; }

        public string MostraRepositorio()
        {
            return "ID: " + Id
                + "\nNome: " + Nome
                + "\nPrivado: " + Privado
                + "\nURL: " + Url
                + "\nDiscrição: " + Descricao;
        }
    }
}
