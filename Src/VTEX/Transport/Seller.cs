// file:	DTOSC\Seller.cs
//
// summary:	Implements the seller class

namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    ///     A seller.
    /// </summary>
    ///
    /// <remarks>
    ///     Versão: 1.51.2931.607
    ///     Autor: Guilherme Branco Stracini
    ///     Data: 31/03/2014.
    /// </remarks>

    public sealed class Seller
	{
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        ///
        /// <value>
        ///     The identifier.
        /// </value>

		[JsonProperty("id")]
		public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        ///
        /// <value>
        ///     The name.
        /// </value>

		[JsonProperty("name")]
		public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the logo.
        /// </summary>
        ///
        /// <value>
        ///     The logo.
        /// </value>

		[JsonProperty("logo")]
		public string Logo { get; set; }
	}
}