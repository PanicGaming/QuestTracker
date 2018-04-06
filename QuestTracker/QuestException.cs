using System;
using System.Runtime.Serialization;

namespace QuestTracker
{
    [Serializable]
    internal class QuestException : Exception
    {
        public QuestException()
        {
        }

        public QuestException(string message) : base(message)
        {
        }

        public QuestException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QuestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}