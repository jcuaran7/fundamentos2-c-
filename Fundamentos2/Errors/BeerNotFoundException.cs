using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos2.Errors
{
    internal class BeerNotFoundException : Exception
    {
        public BeerNotFoundException() : base()
        {
        }
        public BeerNotFoundException(string? message) : base(message)
        {

        }
        public BeerNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
