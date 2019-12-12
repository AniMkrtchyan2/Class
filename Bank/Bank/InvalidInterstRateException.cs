using System;
using System.Runtime.Serialization;

namespace Bank
{
    [Serializable]
    internal class InvalidInterstRateException : Exception
    {
        private string v;
        private double interestRate;

        public InvalidInterstRateException()
        {
        }

        public InvalidInterstRateException(string message) : base(message)
        {
        }

        public InvalidInterstRateException(string v, double interestRate)
        {
            this.v = v;
            this.interestRate = interestRate;
        }

        public InvalidInterstRateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidInterstRateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}