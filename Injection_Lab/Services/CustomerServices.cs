using Injection_Lab.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Lab.Services
{
    public class CustomerServices
    {
        private IRepository _repository;

        public CustomerServices(IRepository repository) 
        {
            _repository = repository;
        }

        public List<Customer> GetCustomers() 
        {
            return _repository.GetCustomers();
        }
    }
}
