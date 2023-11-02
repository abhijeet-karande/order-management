using Instient.DatabaseContext;
using Instient.Models;
using Instient.Interfaces;

namespace Instient.Repositories 
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly SqlServerContext _SqlServerContext;

        public CustomersRepository(SqlServerContext sqlServerContext){
            _SqlServerContext = sqlServerContext;
        }

        public List<Customers> GetCustomers()
        {
            var listCustomers = _SqlServerContext.Customers.ToList();
            return listCustomers;
        }
    }
}