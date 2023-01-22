using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Lab.Services
{
    public class SmsServices : ISender
    {
        public void Send(Customer customer, string message)
        {
            Console.WriteLine($"Mensaje enviado a {customer.Name} desde SMS");
        }
    }
}
