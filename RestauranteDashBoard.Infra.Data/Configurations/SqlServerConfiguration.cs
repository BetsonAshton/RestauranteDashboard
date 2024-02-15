using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RestauranteDashBoard.Infra.Data.Configurations
{
    public class SqlServerConfiguration
    {
        public static string ConnectionString
           => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BD_RestauranteDashboard;Integrated Security=True;Connect Timeout=30;Encrypt=False";
    }
}
