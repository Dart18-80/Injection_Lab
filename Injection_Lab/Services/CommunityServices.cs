using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Lab.Services
{
    public class CommunityServices
    {
        private ISender _SenderServices;

        public CommunityServices( ISender sender) 
        {
            _SenderServices = sender;
        }

        public void SendMessage(Customer customer, string message) 
        {
            _SenderServices.Send(customer, message);
        }
    }
}
