using RestauranteDashboard.Presentation.Models;

namespace RestauranteDashboard.Presentation.Services.Interfaces
{
    public interface IPagamentoService
    {
        List<ConsultaFormaPagamento> GetAll();
    }
}
