using System.Runtime.Serialization;

namespace MarksExceptionLibrary
{
    public class MarksOverflowException : AbstractMarksException
    {
        public MarksOverflowException()
        {
        }

        public MarksOverflowException(string? message) : base(message)
        {
        }

        public MarksOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public MarksOverflowException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
