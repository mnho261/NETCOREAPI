using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}
