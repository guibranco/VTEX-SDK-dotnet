namespace VTEX
{
    /// <summary>
    /// Class PlatformConstants.
    /// </summary>

    internal static class PlatformConstants
    {
        /// <summary>
        /// The rest oms feed
        /// </summary>
        public const string OMS_FEED = "oms/pvt/feed/orders/status/";

        /// <summary>
        /// The rest oms orders
        /// </summary>
        public const string OMS_ORDERS = "oms/pvt/orders";

        /// <summary>
        /// The rest oms invoices
        /// </summary>
        public const string OMS_INVOICES = "oms/pub/orders";

        /// <summary>
        /// The rest oms tracking
        /// </summary>
        public const string OMS_TRACKING = "oms/pvt/orders/{0}/invoice/{1}/tracking";

        /// <summary>
        /// The rest log warehouses
        /// </summary>
        public const string LOG_WAREHOUSES = "logistics/pvt/inventory/warehouseitembalances";

        /// <summary>
        /// The rest pci transactions
        /// </summary>
        public const string PCI_TRANSACTIONS = "pvt/transactions";

        /// <summary>
        /// The rest log reservations
        /// </summary>
        public const string LOG_RESERVATIONS = "logistics/pvt/inventory/reservations";

        /// <summary>
        /// The rest log inventory
        /// </summary>
        public const string LOG_INVENTORY = "logistics/pvt/inventory/skus";

        /// <summary>
        /// The rest bridge search
        /// </summary>
        public const string BRIDGE_SEARCH = "bridge/mb/search";

        /// <summary>
        /// The pricing endpoint.
        /// </summary>
        public const string PRICING = "pricing/prices";

        /// <summary>
        /// The rest catalog
        /// </summary>
        public const string CATALOG = "catalog_system/pvt";

        /// <summary>
        /// The rest catalog pub
        /// </summary>
        public const string CATALOG_PUB = "catalog_system/pub";
    }
}
