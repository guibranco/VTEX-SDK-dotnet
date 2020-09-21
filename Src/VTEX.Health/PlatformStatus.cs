// ***********************************************************************

using System;
using CrispyWaffle.Extensions;
using CrispyWaffle.Serialization;
using Newtonsoft.Json;

namespace VTEX.Health
{
    /// <summary>
    /// Class PlatformStatus. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class PlatformStatus
    {
        /// <summary>
        /// Gets or sets the last result.
        /// </summary>
        /// <value>The last result.</value>
        [JsonProperty("lastResult")]
        public DateTime LastResult { get; set; }

        /// <summary>
        /// Gets or sets the last result status internal.
        /// </summary>
        /// <value>The last result status internal.</value>
        [JsonProperty("lastResultStatus")]
        public string LastResultStatus { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonIgnore]
        public ResultStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the status internal.
        /// </summary>
        /// <value>The status internal.</value>
        [JsonProperty("status")]
        public string StatusInternal
        {
            get => Status.GetInternalValue();
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Status = EnumExtensions.GetEnumByInternalValueAttribute<ResultStatus>(value);
                }
            }
        }

    }
}
