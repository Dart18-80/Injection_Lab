using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Lab.Repositories
{
    public class CustomerRepository : IRepository
    {
        private IDbConnection _connection;

        public CustomerRepository(IDbConnection connectionDB) 
        {
            _connection = connectionDB;
        }

        public List<Customer> GetCustomers()
        {
            if (_connection.GetType() == typeof(MysqlConnection))
                Console.WriteLine("Obtengo los clientes de Mysql");
            else if (_connection.GetType() == typeof(OracleConnection))
                Console.WriteLine("Obtengo los clientes de Oracle");

            return new List<Customer> 
            {
                new Customer() {Id = 1, Name = "Diego Ruiz", Email = "diegoruiz@gmail.com", Phone = "45123698"},
                new Customer() {Id = 2, Name = "Luis Ruiz", Email = "luisruiz@gmail.com", Phone = "42169876"}
            };
        }
    }
}
