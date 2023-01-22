using Injection_Lab.Repositories;
using Injection_Lab.Services;

namespace Injection_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dependencias
            var Sender = new SmsServices();

            //var Sender = new EmailServices();
            var Connection = new MysqlConnection();
            //var Connection = new OracleConnection();
            var Repository = new CustomerRepository(Connection);

            var customerServices = new CustomerServices(Repository);
            var CommunityServices = new CommunityServices(Sender);

            var customers = customerServices.GetCustomers();

            var message = "Mesaje enviado a todos los clientes";

            foreach ( var customer in customers ) 
            {
                CommunityServices.SendMessage(customer, message);
            }
        }
    }
}