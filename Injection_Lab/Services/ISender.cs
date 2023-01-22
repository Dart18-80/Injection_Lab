using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Lab.Services
{
    public interface ISender
    {
        void Send(Customer customer, string message);
    }
}
