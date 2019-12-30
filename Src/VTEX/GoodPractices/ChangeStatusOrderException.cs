namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class ChangeStatusOrderException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class ChangeStatusOrderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeStatusOrderException"/> class.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="status">The status.</param>
        /// <param name="innerException">The inner exception.</param>
        public ChangeStatusOrderException(string orderId, string status, Exception innerException)
            : base($"Unable to change status to {status} in order {orderId}", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeStatusOrderException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected ChangeStatusOrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
