using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MarksExceptionLibrary
{
    public abstract class AbstractMarksException : Exception
    {
        protected AbstractMarksException()
        {
        }

        protected AbstractMarksException(string? message) : base(message)
        {
        }

        protected AbstractMarksException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        protected AbstractMarksException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
