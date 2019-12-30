namespace VTEX.Configuration
{
    using CrispyWaffle.Serialization;
    using System.ComponentModel;

    /// <summary>
    /// VTEX configuration class.
    /// </summary>
    /// <seealso cref="IVTEXConfiguration" />
    [Serializer]
    public sealed class VTEXConfiguration : IVTEXConfiguration
    {
        #region Public properties

        /// <summary>
        /// The host
        /// </summary>
        [Localizable(false)]
        public string Host { get; set; }

        /// <summary>
        /// The host port
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        #endregion

    }
}
