using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteDashBoard.Infra.Data.Entity
{
    public class FormasPagamento
    {
        public string? FormaPagamento { get; set; }
        public decimal Valor { get; set; }
    }
}
