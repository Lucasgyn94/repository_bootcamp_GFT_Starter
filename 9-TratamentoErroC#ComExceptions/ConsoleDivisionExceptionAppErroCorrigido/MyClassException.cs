using System;
using System.Runtime.Serialization;

namespace ConsoleDivisionExceptionAppErroCorrigido
{
    [Serializable]
    public class MyClassException : Exception
    {
        public MyClassException()
        {

        }
        public MyClassException(string? message) : base(message)
        {

        }
        public MyClassException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
        public MyClassException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
        
        public string? MyProperty {get; set;}

    }
}