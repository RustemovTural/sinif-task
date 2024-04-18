using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class NotAvailableException:Exception
    {
        public NotAvailableException()
        {
        }

        public NotAvailableException(string message) : base(message)
        {

        }
    }
}
