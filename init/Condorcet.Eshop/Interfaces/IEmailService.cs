using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condorcet.Eshop.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(string email);
    }
}
