using Instient.Models;

namespace Instient.Interfaces 
{
    public interface IOrdersRepository
    {
        List<Orders> GetOrders();
    }
}