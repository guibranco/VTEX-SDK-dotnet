// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 11-04-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 04/05/2017
// ***********************************************************************
// <copyright file="OrderStatus.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// Enum OrderStatus
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// The approve payment
        /// </summary>
        [HumanReadable("Approve payment")]
        [InternalValue("approve-payment")]
        APPROVE_PAYMENT,

        /// <summary>
        /// The awaiting authorization to dispatch
        /// </summary>
        [HumanReadable("Waiting fulfillment authorization")]
        [InternalValue("waiting-ffmt-authorization")]
        AWAITING_AUTHORIZATION_TO_DISPATCH,

        /// <summary>
        /// The checking invoice
        /// </summary>
        [HumanReadable("Checking invoice")]
        [InternalValue("invoice")]
        CHECKING_INVOICE,

        /// <summary>
        /// The ready for handling
        /// </summary>
        [HumanReadable("Ready for handling")]
        [InternalValue("ready-for-handling")]
        READY_FOR_HANDLING,

        /// <summary>
        /// The handling
        /// </summary>
        [HumanReadable("Handling")]
        [InternalValue("handling")]
        HANDLING,

        /// <summary>
        /// The payment pending
        /// </summary>
        [HumanReadable("Payment pending")]
        [InternalValue("payment-pending")]
        PAYMENT_PENDING,

        /// <summary>
        /// The payment approved
        /// </summary>
        [HumanReadable("Payment approved")]
        [InternalValue("payment-approved")]
        PAYMENT_APPROVED,

        /// <summary>
        /// The start handling
        /// </summary>
        [HumanReadable("Start handling")]
        [InternalValue("start-handling")]
        START_HANDLING,

        /// <summary>
        /// The invoiced
        /// </summary>
        [HumanReadable("Invoiced")]
        [InternalValue("invoiced")]
        INVOICED,

        /// <summary>
        /// The window to cancel
        /// </summary>
        [HumanReadable("Window to cancel")]
        [InternalValue("window-to-cancel")]
        WINDOW_TO_CANCEL,

        /// <summary>
        /// The cancel
        /// </summary>
        [HumanReadable("Cancel")]
        [InternalValue("cancel")]
        CANCEL,

        /// <summary>
        /// The cancellation requested
        /// </summary>
        [HumanReadable("Cancellation requested")]
        [InternalValue("cancellation-requested")]
        CANCELLATION_REQUESTED,

        /// <summary>
        /// The canceled
        /// </summary>
        [HumanReadable("Canceled")]
        [InternalValue("canceled")]
        CANCELED,

        /// <summary>
        /// The shipped
        /// </summary>
        [HumanReadable("Shipped")]
        [InternalValue("shipped")]
        SHIPPED,

        /// <summary>
        /// The authorize fulfillment
        /// </summary>
        [HumanReadable("Authorize fulfillment")]
        [InternalValue("authorize-fulfillment")]
        AUTHORIZE_FULFILLMENT
    }
}
