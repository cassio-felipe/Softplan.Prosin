using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
namespace CalculaJurosAPI.Infra
{
    public class JurosApi : IJurosApi
    {
        private Uri _jurosUri { get; }
        private readonly string _apiFinanceiroTaxaJuros = "https://localhost:5003/taxaJuros";
        private readonly HttpClient _httpClient;

        public JurosApi()
        {
            _jurosUri = new Uri(_apiFinanceiroTaxaJuros);
            _httpClient = new HttpClient();
        }
        public async Task<decimal> GetJuros()
        {
            Stream response = await _httpClient.GetStreamAsync(_jurosUri);
            var taxaAtual = await JsonSerializer.DeserializeAsync<decimal>(response);

            return taxaAtual;
        }
    }
}