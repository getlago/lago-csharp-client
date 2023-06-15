/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.36.0-beta
 * Contact: tech@getlago.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InvoiceObjectExtended
    /// </summary>
    [DataContract(Name = "InvoiceObjectExtended")]
    public partial class InvoiceObjectExtended : IEquatable<InvoiceObjectExtended>, IValidatableObject
    {
        /// <summary>
        /// Defines InvoiceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InvoiceTypeEnum
        {
            /// <summary>
            /// Enum Subscription for value: subscription
            /// </summary>
            [EnumMember(Value = "subscription")]
            Subscription = 1,

            /// <summary>
            /// Enum AddOn for value: add_on
            /// </summary>
            [EnumMember(Value = "add_on")]
            AddOn = 2,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 3,

            /// <summary>
            /// Enum OneOff for value: one_off
            /// </summary>
            [EnumMember(Value = "one_off")]
            OneOff = 4
        }


        /// <summary>
        /// Gets or Sets InvoiceType
        /// </summary>
        [DataMember(Name = "invoice_type", IsRequired = true, EmitDefaultValue = true)]
        public InvoiceTypeEnum InvoiceType { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,

            /// <summary>
            /// Enum Finalized for value: finalized
            /// </summary>
            [EnumMember(Value = "finalized")]
            Finalized = 2
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Defines PaymentStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentStatusEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Succeeded for value: succeeded
            /// </summary>
            [EnumMember(Value = "succeeded")]
            Succeeded = 2,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 3
        }


        /// <summary>
        /// Gets or Sets PaymentStatus
        /// </summary>
        [DataMember(Name = "payment_status", IsRequired = true, EmitDefaultValue = true)]
        public PaymentStatusEnum PaymentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceObjectExtended" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceObjectExtended() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceObjectExtended" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId (required).</param>
        /// <param name="sequentialId">sequentialId (required).</param>
        /// <param name="number">number (required).</param>
        /// <param name="issuingDate">issuingDate (required).</param>
        /// <param name="invoiceType">invoiceType (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="paymentStatus">paymentStatus (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="feesAmountCents">feesAmountCents (required).</param>
        /// <param name="couponsAmountCents">couponsAmountCents (required).</param>
        /// <param name="creditNotesAmountCents">creditNotesAmountCents (required).</param>
        /// <param name="subTotalVatExcludedAmountCents">subTotalVatExcludedAmountCents (required).</param>
        /// <param name="vatAmountCents">vatAmountCents (required).</param>
        /// <param name="subTotalVatIncludedAmountCents">subTotalVatIncludedAmountCents (required).</param>
        /// <param name="prepaidCreditAmountCents">prepaidCreditAmountCents (required).</param>
        /// <param name="totalAmountCents">totalAmountCents (required).</param>
        /// <param name="versionNumber">versionNumber (required).</param>
        /// <param name="amountCents">amountCents (required).</param>
        /// <param name="amountCurrency">amountCurrency (required).</param>
        /// <param name="vatAmountCurrency">vatAmountCurrency (required).</param>
        /// <param name="creditAmountCents">creditAmountCents (required).</param>
        /// <param name="creditAmountCurrency">creditAmountCurrency (required).</param>
        /// <param name="totalAmountCurrency">totalAmountCurrency (required).</param>
        /// <param name="legacy">legacy (required).</param>
        /// <param name="fileUrl">fileUrl.</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="credits">credits (required).</param>
        /// <param name="fees">fees (required).</param>
        /// <param name="subscriptions">subscriptions (required).</param>
        public InvoiceObjectExtended(Guid lagoId = default(Guid), int sequentialId = default(int), string number = default(string), DateTime issuingDate = default(DateTime), InvoiceTypeEnum invoiceType = default(InvoiceTypeEnum), StatusEnum status = default(StatusEnum), PaymentStatusEnum paymentStatus = default(PaymentStatusEnum), string currency = default(string), int feesAmountCents = default(int), int couponsAmountCents = default(int), int creditNotesAmountCents = default(int), int subTotalVatExcludedAmountCents = default(int), int vatAmountCents = default(int), int subTotalVatIncludedAmountCents = default(int), int prepaidCreditAmountCents = default(int), int totalAmountCents = default(int), int versionNumber = default(int), int amountCents = default(int), string amountCurrency = default(string), string vatAmountCurrency = default(string), int creditAmountCents = default(int), string creditAmountCurrency = default(string), string totalAmountCurrency = default(string), bool legacy = default(bool), string fileUrl = default(string), CustomerObject customer = default(CustomerObject), List<InvoiceMetadataObject> metadata = default(List<InvoiceMetadataObject>), List<CreditObject> credits = default(List<CreditObject>), List<FeeObject> fees = default(List<FeeObject>), List<SubscriptionObject> subscriptions = default(List<SubscriptionObject>))
        {
            this.LagoId = lagoId;
            this.SequentialId = sequentialId;
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.Number = number;
            this.IssuingDate = issuingDate;
            this.InvoiceType = invoiceType;
            this.Status = status;
            this.PaymentStatus = paymentStatus;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.Currency = currency;
            this.FeesAmountCents = feesAmountCents;
            this.CouponsAmountCents = couponsAmountCents;
            this.CreditNotesAmountCents = creditNotesAmountCents;
            this.SubTotalVatExcludedAmountCents = subTotalVatExcludedAmountCents;
            this.VatAmountCents = vatAmountCents;
            this.SubTotalVatIncludedAmountCents = subTotalVatIncludedAmountCents;
            this.PrepaidCreditAmountCents = prepaidCreditAmountCents;
            this.TotalAmountCents = totalAmountCents;
            this.VersionNumber = versionNumber;
            this.AmountCents = amountCents;
            // to ensure "amountCurrency" is required (not null)
            if (amountCurrency == null)
            {
                throw new ArgumentNullException("amountCurrency is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.AmountCurrency = amountCurrency;
            // to ensure "vatAmountCurrency" is required (not null)
            if (vatAmountCurrency == null)
            {
                throw new ArgumentNullException("vatAmountCurrency is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.VatAmountCurrency = vatAmountCurrency;
            this.CreditAmountCents = creditAmountCents;
            // to ensure "creditAmountCurrency" is required (not null)
            if (creditAmountCurrency == null)
            {
                throw new ArgumentNullException("creditAmountCurrency is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.CreditAmountCurrency = creditAmountCurrency;
            // to ensure "totalAmountCurrency" is required (not null)
            if (totalAmountCurrency == null)
            {
                throw new ArgumentNullException("totalAmountCurrency is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.TotalAmountCurrency = totalAmountCurrency;
            this.Legacy = legacy;
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new ArgumentNullException("customer is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.Customer = customer;
            // to ensure "credits" is required (not null)
            if (credits == null)
            {
                throw new ArgumentNullException("credits is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.Credits = credits;
            // to ensure "fees" is required (not null)
            if (fees == null)
            {
                throw new ArgumentNullException("fees is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.Fees = fees;
            // to ensure "subscriptions" is required (not null)
            if (subscriptions == null)
            {
                throw new ArgumentNullException("subscriptions is a required property for InvoiceObjectExtended and cannot be null");
            }
            this.Subscriptions = subscriptions;
            this.FileUrl = fileUrl;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoId { get; set; }

        /// <summary>
        /// Gets or Sets SequentialId
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "sequential_id", IsRequired = true, EmitDefaultValue = true)]
        public int SequentialId { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        /// <example>222345</example>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets IssuingDate
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "issuing_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IssuingDate { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets FeesAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "fees_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int FeesAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CouponsAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "coupons_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int CouponsAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CreditNotesAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "credit_notes_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int CreditNotesAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets SubTotalVatExcludedAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "sub_total_vat_excluded_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int SubTotalVatExcludedAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "vat_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int VatAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets SubTotalVatIncludedAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "sub_total_vat_included_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int SubTotalVatIncludedAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets PrepaidCreditAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "prepaid_credit_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int PrepaidCreditAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "total_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int TotalAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "version_number", IsRequired = true, EmitDefaultValue = true)]
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        /// <example>1200</example>
        [DataMember(Name = "amount_cents", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "vat_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string VatAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "credit_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public int CreditAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "credit_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string CreditAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "total_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string TotalAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Legacy
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "legacy", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public bool Legacy { get; set; }

        /// <summary>
        /// Gets or Sets FileUrl
        /// </summary>
        /// <example>https://example.com</example>
        [DataMember(Name = "file_url", EmitDefaultValue = false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", IsRequired = true, EmitDefaultValue = true)]
        public CustomerObject Customer { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public List<InvoiceMetadataObject> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name = "credits", IsRequired = true, EmitDefaultValue = true)]
        public List<CreditObject> Credits { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [DataMember(Name = "fees", IsRequired = true, EmitDefaultValue = true)]
        public List<FeeObject> Fees { get; set; }

        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name = "subscriptions", IsRequired = true, EmitDefaultValue = true)]
        public List<SubscriptionObject> Subscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceObjectExtended {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  SequentialId: ").Append(SequentialId).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  IssuingDate: ").Append(IssuingDate).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  FeesAmountCents: ").Append(FeesAmountCents).Append("\n");
            sb.Append("  CouponsAmountCents: ").Append(CouponsAmountCents).Append("\n");
            sb.Append("  CreditNotesAmountCents: ").Append(CreditNotesAmountCents).Append("\n");
            sb.Append("  SubTotalVatExcludedAmountCents: ").Append(SubTotalVatExcludedAmountCents).Append("\n");
            sb.Append("  VatAmountCents: ").Append(VatAmountCents).Append("\n");
            sb.Append("  SubTotalVatIncludedAmountCents: ").Append(SubTotalVatIncludedAmountCents).Append("\n");
            sb.Append("  PrepaidCreditAmountCents: ").Append(PrepaidCreditAmountCents).Append("\n");
            sb.Append("  TotalAmountCents: ").Append(TotalAmountCents).Append("\n");
            sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  VatAmountCurrency: ").Append(VatAmountCurrency).Append("\n");
            sb.Append("  CreditAmountCents: ").Append(CreditAmountCents).Append("\n");
            sb.Append("  CreditAmountCurrency: ").Append(CreditAmountCurrency).Append("\n");
            sb.Append("  TotalAmountCurrency: ").Append(TotalAmountCurrency).Append("\n");
            sb.Append("  Legacy: ").Append(Legacy).Append("\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvoiceObjectExtended);
        }

        /// <summary>
        /// Returns true if InvoiceObjectExtended instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceObjectExtended to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceObjectExtended input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LagoId == input.LagoId ||
                    (this.LagoId != null &&
                    this.LagoId.Equals(input.LagoId))
                ) && 
                (
                    this.SequentialId == input.SequentialId ||
                    this.SequentialId.Equals(input.SequentialId)
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.IssuingDate == input.IssuingDate ||
                    (this.IssuingDate != null &&
                    this.IssuingDate.Equals(input.IssuingDate))
                ) && 
                (
                    this.InvoiceType == input.InvoiceType ||
                    this.InvoiceType.Equals(input.InvoiceType)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    this.PaymentStatus.Equals(input.PaymentStatus)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.FeesAmountCents == input.FeesAmountCents ||
                    this.FeesAmountCents.Equals(input.FeesAmountCents)
                ) && 
                (
                    this.CouponsAmountCents == input.CouponsAmountCents ||
                    this.CouponsAmountCents.Equals(input.CouponsAmountCents)
                ) && 
                (
                    this.CreditNotesAmountCents == input.CreditNotesAmountCents ||
                    this.CreditNotesAmountCents.Equals(input.CreditNotesAmountCents)
                ) && 
                (
                    this.SubTotalVatExcludedAmountCents == input.SubTotalVatExcludedAmountCents ||
                    this.SubTotalVatExcludedAmountCents.Equals(input.SubTotalVatExcludedAmountCents)
                ) && 
                (
                    this.VatAmountCents == input.VatAmountCents ||
                    this.VatAmountCents.Equals(input.VatAmountCents)
                ) && 
                (
                    this.SubTotalVatIncludedAmountCents == input.SubTotalVatIncludedAmountCents ||
                    this.SubTotalVatIncludedAmountCents.Equals(input.SubTotalVatIncludedAmountCents)
                ) && 
                (
                    this.PrepaidCreditAmountCents == input.PrepaidCreditAmountCents ||
                    this.PrepaidCreditAmountCents.Equals(input.PrepaidCreditAmountCents)
                ) && 
                (
                    this.TotalAmountCents == input.TotalAmountCents ||
                    this.TotalAmountCents.Equals(input.TotalAmountCents)
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    this.VersionNumber.Equals(input.VersionNumber)
                ) && 
                (
                    this.AmountCents == input.AmountCents ||
                    this.AmountCents.Equals(input.AmountCents)
                ) && 
                (
                    this.AmountCurrency == input.AmountCurrency ||
                    (this.AmountCurrency != null &&
                    this.AmountCurrency.Equals(input.AmountCurrency))
                ) && 
                (
                    this.VatAmountCurrency == input.VatAmountCurrency ||
                    (this.VatAmountCurrency != null &&
                    this.VatAmountCurrency.Equals(input.VatAmountCurrency))
                ) && 
                (
                    this.CreditAmountCents == input.CreditAmountCents ||
                    this.CreditAmountCents.Equals(input.CreditAmountCents)
                ) && 
                (
                    this.CreditAmountCurrency == input.CreditAmountCurrency ||
                    (this.CreditAmountCurrency != null &&
                    this.CreditAmountCurrency.Equals(input.CreditAmountCurrency))
                ) && 
                (
                    this.TotalAmountCurrency == input.TotalAmountCurrency ||
                    (this.TotalAmountCurrency != null &&
                    this.TotalAmountCurrency.Equals(input.TotalAmountCurrency))
                ) && 
                (
                    this.Legacy == input.Legacy ||
                    this.Legacy.Equals(input.Legacy)
                ) && 
                (
                    this.FileUrl == input.FileUrl ||
                    (this.FileUrl != null &&
                    this.FileUrl.Equals(input.FileUrl))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Credits == input.Credits ||
                    this.Credits != null &&
                    input.Credits != null &&
                    this.Credits.SequenceEqual(input.Credits)
                ) && 
                (
                    this.Fees == input.Fees ||
                    this.Fees != null &&
                    input.Fees != null &&
                    this.Fees.SequenceEqual(input.Fees)
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    input.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LagoId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SequentialId.GetHashCode();
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.IssuingDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvoiceType.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentStatus.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FeesAmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.CouponsAmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditNotesAmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.SubTotalVatExcludedAmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.VatAmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.SubTotalVatIncludedAmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.PrepaidCreditAmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalAmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.VersionNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCurrency.GetHashCode();
                }
                if (this.VatAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.VatAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreditAmountCents.GetHashCode();
                if (this.CreditAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.CreditAmountCurrency.GetHashCode();
                }
                if (this.TotalAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Legacy.GetHashCode();
                if (this.FileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileUrl.GetHashCode();
                }
                if (this.Customer != null)
                {
                    hashCode = (hashCode * 59) + this.Customer.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Credits != null)
                {
                    hashCode = (hashCode * 59) + this.Credits.GetHashCode();
                }
                if (this.Fees != null)
                {
                    hashCode = (hashCode * 59) + this.Fees.GetHashCode();
                }
                if (this.Subscriptions != null)
                {
                    hashCode = (hashCode * 59) + this.Subscriptions.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
