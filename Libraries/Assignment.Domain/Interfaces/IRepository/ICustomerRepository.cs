using Assignment.Domain.Models;
using Assignment.Core.Interfaces;

namespace Assignment.Domain.Interfaces.IRepositories
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        // Geen aanvullende methode-definities nodig omdat IBaseRepository<Customer> al de vereiste methoden bevat
    }
}
