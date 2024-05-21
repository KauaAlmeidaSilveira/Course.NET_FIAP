using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Exceptions
{
    public class PersonalizadaException : Exception
    {
        public PersonalizadaException()
        {
        }

        public PersonalizadaException(string? message) : base(message)
        {
        }

        public PersonalizadaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PersonalizadaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
