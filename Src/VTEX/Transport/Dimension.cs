namespace VTEX.Transport
{
    /// <summary>
    /// The dimension class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class Dimension
    {
        /// <summary>
        /// Gets or sets the cubic weight.
        /// </summary>
        /// <value>
        /// The cubic weight.
        /// </value>
        public decimal CubicWeight { get; set; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public decimal Height { get; set; }
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public decimal Length { get; set; }
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public decimal Weight { get; set; }
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public decimal Width { get; set; }
    }
}