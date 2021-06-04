using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCore
{
    public class NetflixException : Exception
    {


        public NetflixException() : base("El usuario fallo por alguna razon")
        {

        }

        public NetflixException(string message) : base(message)
        {

        }

        public NetflixException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
