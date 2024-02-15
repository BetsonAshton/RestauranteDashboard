using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteDashBoard.Infra.Data.Entity;
using RestauranteDashBoard.Infra.Data.Repository;

namespace RestauranteDashboard.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {

        private readonly PagamentoRepository _pagamentoRepository;

        public RestauranteController(PagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                var totalFormasPagamento =  _pagamentoRepository.GetAll();
                return Ok(totalFormasPagamento);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao recuperar os dados do pagamento: {ex}");
                return StatusCode(500, $"Erro ao recuperar os dados do pagamento: {ex.Message}");
            }
        }
    }
}
