namespace VTEX.Transport
{
    using System.ComponentModel;
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The price class.
    /// This class cannot be inherited.
    /// https://documenter.getpostman.com/view/101975/vtex-pricing-api/6YsWxKT#45e96a27-2f96-f2d3-74b2-9d7b0be0c53a
    /// Use this class to update a price from 04/2018
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class Price
    {
        #region Private fields

        /// <summary>
        /// The list price
        /// </summary>
        private decimal _listPrice;
        /// <summary>
        /// The list price set
        /// </summary>
        private bool _listPriceSet;

        /// <summary>
        /// The cost price
        /// </summary>
        private decimal _costPrice;
        /// <summary>
        /// The cost price set
        /// </summary>
        private bool _costPriceSet;

        /// <summary>
        /// The base price
        /// 
        /// </summary>
        private decimal _basePrice;
        /// <summary>
        /// The base price set
        /// </summary>
        private bool _basePriceSet;

        /// <summary>
        /// The markup
        /// </summary>
        private decimal? _markup;
        /// <summary>
        /// The markup set
        /// </summary>
        private bool _markupSet;

        /// <summary>
        /// The fixed prices
        /// </summary>
        private FixedPrice[] _fixedPrices;
        /// <summary>
        /// The fixed prices set
        /// </summary>
        private bool _fixedPricesSet;

        /// <summary>
        /// The item identifier
        /// </summary>
        private int _itemId;
        /// <summary>
        /// The item identifier set
        /// </summary>
        private bool _itemIdSet;

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the list price.
        /// </summary>
        /// <value>
        /// The list price.
        /// </value>
        [JsonProperty("listPrice")]
        public decimal? ListPrice
        {
            get => _listPriceSet ? _listPrice : (decimal?)null;
            set
            {
                if (!value.HasValue)
                {
                    return;
                }

                _listPrice = value.Value;
                _listPriceSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the cost price.
        /// </summary>
        /// <value>
        /// The cost price.
        /// </value>
        [JsonProperty("costPrice")]
        public decimal CostPrice
        {
            get => _costPrice;
            set
            {
                _costPrice = value;
                _costPriceSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the base price.
        /// </summary>
        /// <value>
        /// The base price.
        /// </value>
        [JsonProperty("basePrice")]
        public decimal BasePrice
        {
            get => _basePrice;
            set
            {
                _basePrice = value;
                _basePriceSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the markup.
        /// </summary>
        /// <value>
        /// The markup.
        /// </value>
        [JsonProperty("markup")]
        public decimal? Markup
        {
            get => _markup;
            set
            {
                _markup = value;
                _markupSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the fixed prices.
        /// </summary>
        /// <value>
        /// The fixed prices.
        /// </value>
        [JsonProperty("fixedPrices")]
        public FixedPrice[] FixedPrices
        {
            get => _fixedPrices;
            set
            {
                _fixedPrices = value;
                _fixedPricesSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>
        /// The item identifier.
        /// </value>
        [JsonProperty("itemId")]
        public int ItemId
        {
            get => _itemId;
            set
            {
                _itemId = value;
                _itemIdSet = true;
            }
        }

        #endregion

        #region Serialization helpers


        /// <summary>
        /// The should serialize list price serialization helper method
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> when the field should be serialized, false otherwise
        /// </returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeListPrice()
        {
            return _listPriceSet;
        }

        /// <summary>
        /// The should serialize cost price serialization helper method
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> when the field should be serialized, false otherwise
        /// </returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCostPrice()
        {
            return _costPriceSet;
        }

        /// <summary>
        /// The should serialize base price serialization helper method
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> when the field should be serialized, false otherwise
        /// </returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePrice()
        {
            return _basePriceSet;
        }

        /// <summary>
        /// The should serialize markup serialization helper method
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> when the field should be serialized, false otherwise
        /// </returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMarkup()
        {
            return _markupSet;
        }

        /// <summary>
        /// The should serialize fixed prices serialization helper method
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> when the field should be serialized, false otherwise
        /// </returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFixedPrices()
        {
            return _fixedPricesSet;
        }

        /// <summary>
        /// The should serialize item identifier serialization helper method
        /// </summary>
        /// <returns>
        /// Returns <c>true</c> when the field should be serialized, false otherwise
        /// </returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeItemId()
        {
            return _itemIdSet;
        }

        #endregion
    }
}
