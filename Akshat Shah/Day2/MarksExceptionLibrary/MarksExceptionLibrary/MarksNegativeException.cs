using System.Runtime.Serialization;

namespace MarksExceptionLibrary
{
    public class MarksNegativeException : AbstractMarksException
    {
        public MarksNegativeException()
        {
        }

        public MarksNegativeException(string? message) : base(message)
        {
        }

        public MarksNegativeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public MarksNegativeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}