namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The change order exception class.
    /// This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class ChangeOrderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeOrderException"/> class.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="innerException">The inner exception.</param>
        public ChangeOrderException(string orderId, Exception innerException)
            : base(string.Format(Resources.ChangeOrderException, orderId), innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeOrderException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected ChangeOrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
