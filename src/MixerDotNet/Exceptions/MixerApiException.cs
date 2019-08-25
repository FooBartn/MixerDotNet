using System;
using System.Runtime.Serialization;

namespace MixerDotNet.Exceptions
{
    [Serializable]
    public class MixerApiException : Exception
    {
        public MixerApiException()
        {
        }

        public MixerApiException(string message) : base(message)
        {
        }

        public MixerApiException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MixerApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
