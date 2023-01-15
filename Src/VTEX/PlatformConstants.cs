// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="PlatformConstants.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        public const string OmsFeed = "oms/pvt/feed/orders/status/";

        /// <summary>
        /// The rest oms orders
        /// </summary>
        public const string OmsOrders = "oms/pvt/orders";

        /// <summary>
        /// The rest oms invoices
        /// </summary>
        public const string OmsInvoices = "oms/pub/orders";

        /// <summary>
        /// The rest oms tracking
        /// </summary>
        public const string OmsTracking = "oms/pvt/orders/{0}/invoice/{1}/tracking";

        /// <summary>
        /// The rest log warehouses
        /// </summary>
        public const string LogWarehouses = "logistics/pvt/inventory/warehouseitembalances";

        /// <summary>
        /// The rest pci transactions
        /// </summary>
        public const string PciTransactions = "pvt/transactions";

        /// <summary>
        /// The rest log reservations
        /// </summary>
        public const string LogReservations = "logistics/pvt/inventory/reservations";

        /// <summary>
        /// The rest log inventory
        /// </summary>
        public const string LogInventory = "logistics/pvt/inventory/skus";

        /// <summary>
        /// The rest bridge search
        /// </summary>
        public const string BridgeSearch = "bridge/mb/search";

        /// <summary>
        /// The pricing endpoint.
        /// </summary>
        public const string Pricing = "pricing/prices";

        /// <summary>
        /// The rest catalog
        /// </summary>
        public const string Catalog = "catalog_system/pvt";

        /// <summary>
        /// The rest catalog pub
        /// </summary>
        public const string CatalogPub = "catalog_system/pub";
    }
}
