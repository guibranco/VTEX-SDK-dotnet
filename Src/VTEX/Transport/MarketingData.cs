// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="MarketingData.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class MarketingData. This class cannot be inherited.
    /// </summary>
    public sealed class MarketingData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the utm source.
        /// </summary>
        /// <value>The utm source.</value>
        [JsonProperty("utmSource")]
        public string UtmSource { get; set; }

        /// <summary>
        /// Gets or sets the utm partner.
        /// </summary>
        /// <value>The utm partner.</value>
        [JsonProperty("utmPartner")]
        public string UtmPartner { get; set; }

        /// <summary>
        /// Gets or sets the utm medium.
        /// </summary>
        /// <value>The utm medium.</value>
        [JsonProperty("utmMedium")]
        public string UtmMedium { get; set; }

        /// <summary>
        /// Gets or sets the utm campaign.
        /// </summary>
        /// <value>The utm campaign.</value>
        [JsonProperty("utmCampaign")]
        public string UtmCampaign { get; set; }

        /// <summary>
        /// Gets or sets the coupon.
        /// </summary>
        /// <value>The coupon.</value>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// Gets or sets the utmi campaign.
        /// </summary>
        /// <value>The utmi campaign.</value>
        [JsonProperty("utmiCampaign")]
        public string UtmiCampaign { get; set; }

        /// <summary>
        /// Gets or sets the utmi page.
        /// </summary>
        /// <value>The utmi page.</value>
        [JsonProperty("utmiPage")]
        public string UtmiPage { get; set; }

        /// <summary>
        /// Gets or sets the utmi part.
        /// </summary>
        /// <value>The utmi part.</value>
        [JsonProperty("utmiPart")]
        public string UtmiPart { get; set; }

        /// <summary>
        /// Gets or sets the marketing tags.
        /// </summary>
        /// <value>The marketing tags.</value>
        [JsonProperty("marketingTags")]
        public NotNullObserver[] MarketingTags { get; set; }
    }
}
