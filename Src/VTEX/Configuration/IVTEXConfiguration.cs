namespace VTEX.Configuration
{
    using System.ComponentModel;

    /// <summary>
    /// VTEX configuration data interface
    /// </summary>

    public interface IVTEXConfiguration
    {
        /// <summary>
        /// Gets or sets the host
        /// </summary>
        [Localizable(false)]
        string Host { get; set; }

        /// <summary>
        /// Gets or sets the port
        /// </summary>
        int Port { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        string Password { get; set; }
    }
}
