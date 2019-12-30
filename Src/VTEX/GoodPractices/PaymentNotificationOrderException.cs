namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class PaymentNotificationOrderException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class PaymentNotificationOrderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentNotificationOrderException" /> class.
        /// </summary>
        /// <param name="sequence">The order identifier.</param>
        /// <param name="innerException">The inner exception.</param>
        public PaymentNotificationOrderException(int sequence, Exception innerException)
            : base($"Unable to send payment notification for the order {sequence}", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentNotificationOrderException"/> class.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="innerException">The inner exception.</param>
        public PaymentNotificationOrderException(string orderId, Exception innerException)
            : base($"Unable to send payment notification for the order {orderId}", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentNotificationOrderException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected PaymentNotificationOrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
