using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Lab.Repositories
{
    public interface IRepository
    {
        List<Customer> GetCustomers();
    }
}
