using Instient.DatabaseContext;
using Instient.Models;
using Instient.Interfaces;

namespace Instient.Repositories 
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly SqlServerContext _SqlServerContext;

        public OrdersRepository(SqlServerContext sqlServerContext){
            _SqlServerContext = sqlServerContext;
        }

        public List<Orders> GetOrders()
        {
            var listOrders = _SqlServerContext.Orders.ToList();
            return listOrders;
        }
    }
}