namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;

    /// <summary>
    /// Class Installments. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class Installments
    {
        /// <summary>
        /// Gets or sets the instructions.
        /// </summary>
        /// <value>The instructions.</value>
        public string Instructions { get; set; }
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or sets the bank code.
        /// </summary>
        /// <value>The bank code.</value>
        public string BankCode { get; set; }
        /// <summary>
        /// Gets or sets the original bank code.
        /// </summary>
        /// <value>The original bank code.</value>
        public string OriginalBankCode { get; set; }
        /// <summary>
        /// Gets or sets the branch code.
        /// </summary>
        /// <value>The branch code.</value>
        public string BranchCode { get; set; }
        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        /// <value>The account.</value>
        public string Account { get; set; }
        /// <summary>
        /// Gets or sets the kind of the document.
        /// </summary>
        /// <value>The kind of the document.</value>
        public string DocumentKind { get; set; }
        /// <summary>
        /// Gets or sets the type of the currency.
        /// </summary>
        /// <value>The type of the currency.</value>
        public string CurrencyType { get; set; }
        /// <summary>
        /// Gets or sets the acceptance.
        /// </summary>
        /// <value>The acceptance.</value>
        public string Acceptance { get; set; }
        /// <summary>
        /// Gets or sets the portfolio.
        /// </summary>
        /// <value>The portfolio.</value>
        public string Portfolio { get; set; }
        /// <summary>
        /// Gets or sets the payment place.
        /// </summary>
        /// <value>The payment place.</value>
        public string PaymentPlace { get; set; }
        /// <summary>
        /// Gets or sets the bar code.
        /// </summary>
        /// <value>The bar code.</value>
        public BarCode BarCode { get; set; }
        /// <summary>
        /// Gets or sets our number.
        /// </summary>
        /// <value>Our number.</value>
        public string OurNumber { get; set; }
        /// <summary>
        /// Gets or sets the index of the invoice.
        /// </summary>
        /// <value>The index of the invoice.</value>
        public string InvoiceIndex { get; set; }
        /// <summary>
        /// Gets or sets the document number.
        /// </summary>
        /// <value>The document number.</value>
        public string DocumentNumber { get; set; }
        /// <summary>
        /// Gets or sets for bank.
        /// </summary>
        /// <value>For bank.</value>
        public string ForBank { get; set; }
        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>The due date.</value>
        public string DueDate { get; set; }
        /// <summary>
        /// Gets or sets the document date.
        /// </summary>
        /// <value>The document date.</value>
        public string DocumentDate { get; set; }
        /// <summary>
        /// Gets or sets the processing date.
        /// </summary>
        /// <value>The processing date.</value>
        public string ProcessingDate { get; set; }
        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>The name of the customer.</value>
        public string CustomerName { get; set; }
        /// <summary>
        /// Gets or sets the customer address.
        /// </summary>
        /// <value>The customer address.</value>
        public string CustomerAddress { get; set; }
        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>The document.</value>
        public string Document { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public double Value { get; set; }
        /// <summary>
        /// Gets or sets the installment.
        /// </summary>
        /// <value>The installment.</value>
        public int Installment { get; set; }
        /// <summary>
        /// Gets or sets the URL company image.
        /// </summary>
        /// <value>The URL company image.</value>
        public string UrlCompanyImage { get; set; }
        /// <summary>
        /// Gets or sets the URL market image.
        /// </summary>
        /// <value>
        /// The URL market image.
        /// </value>
        public string UrlMarketImage { get; set; }
        /// <summary>
        /// Gets or sets the transferor code.
        /// </summary>
        /// <value>
        /// The transferor code.
        /// </value>
        public string TransferorCode { get; set; }
    }
}
