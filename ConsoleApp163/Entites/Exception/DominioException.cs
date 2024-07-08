using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp163.Entites.Exception
{
    internal class DominioException : ApplicationException
    {
        public DominioException(string message) : base(message)
        {

        }
    }
}
