using Dapper;
using RestauranteDashBoard.Infra.Data.Configurations;
using RestauranteDashBoard.Infra.Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteDashBoard.Infra.Data.Repository
{
    public class PagamentoRepository
    {
        public List<FormasPagamento> GetAll()
        {

            var query = @"
                SELECT FormaPagamento, Valor FROM Pagamentos
            ";
            using (var connection = new SqlConnection(SqlServerConfiguration.ConnectionString))
                {
                    return connection.Query<FormasPagamento>(query).ToList();
                }
            
        }

    }
}
