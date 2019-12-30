namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class BridgeException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />

    [Serializable]
    public class BridgeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeException"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="innerException">The inner exception.</param>
        public BridgeException(string query, Exception innerException)
            : base($"Unable to query the Bridge with query {query}, see inner exception for details.", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected BridgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
