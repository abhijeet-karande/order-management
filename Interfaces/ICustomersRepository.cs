using Instient.Models;

namespace Instient.Interfaces 
{
    public interface ICustomersRepository
    {
        List<Customers> GetCustomers();
    }
}