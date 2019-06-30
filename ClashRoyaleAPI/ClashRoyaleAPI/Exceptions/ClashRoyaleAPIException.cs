using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Exceptions
{
    public class ClashRoyaleAPIException : Exception
    {
        public ClashRoyaleAPIException()
        {
        }

        public ClashRoyaleAPIException(string message) : base(message)
        {
        }

        public ClashRoyaleAPIException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
