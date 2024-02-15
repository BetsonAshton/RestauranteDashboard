using RestauranteDashboard.Presentation.Models;
using RestauranteDashboard.Presentation.Services.Interfaces;
using System.Text.Json;

namespace RestauranteDashboard.Presentation.Services
{
    public class PagamentoService : IPagamentoService
    {
        public List<ConsultaFormaPagamento> GetAll()
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync("http://localhost:5129/api/Restaurante").Result;

                if (result.IsSuccessStatusCode)
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    var content = result.Content.ReadAsStringAsync().Result;
                    var pagamentos = JsonSerializer.Deserialize<List<ConsultaFormaPagamento>>(content, options);
                    return pagamentos;
                }
                else
                    return new List<ConsultaFormaPagamento>();
            }
        }
    }

}
