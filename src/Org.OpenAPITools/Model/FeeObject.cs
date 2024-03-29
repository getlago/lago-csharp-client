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
    /// FeeObject
    /// </summary>
    [DataContract(Name = "FeeObject")]
    public partial class FeeObject : IEquatable<FeeObject>, IValidatableObject
    {
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
            Failed = 3,

            /// <summary>
            /// Enum Refunded for value: refunded
            /// </summary>
            [EnumMember(Value = "refunded")]
            Refunded = 4
        }


        /// <summary>
        /// Gets or Sets PaymentStatus
        /// </summary>
        [DataMember(Name = "payment_status", IsRequired = true, EmitDefaultValue = true)]
        public PaymentStatusEnum PaymentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId (required).</param>
        /// <param name="lagoGroupId">lagoGroupId.</param>
        /// <param name="lagoInvoiceId">lagoInvoiceId.</param>
        /// <param name="lagoTrueUpFeeId">lagoTrueUpFeeId.</param>
        /// <param name="lagoTrueUpParentFeeId">lagoTrueUpParentFeeId.</param>
        /// <param name="externalSubscriptionId">externalSubscriptionId.</param>
        /// <param name="amountCents">amountCents (required).</param>
        /// <param name="amountCurrency">amountCurrency (required).</param>
        /// <param name="vatAmountCents">vatAmountCents (required).</param>
        /// <param name="vatAmountCurrency">vatAmountCurrency (required).</param>
        /// <param name="units">units (required).</param>
        /// <param name="totalAmountCents">totalAmountCents.</param>
        /// <param name="totalAmountCurrency">totalAmountCurrency.</param>
        /// <param name="eventsCount">eventsCount.</param>
        /// <param name="payInAdvance">payInAdvance.</param>
        /// <param name="invoiceable">invoiceable.</param>
        /// <param name="fromDate">fromDate.</param>
        /// <param name="toDate">toDate.</param>
        /// <param name="paymentStatus">paymentStatus (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="succeededAt">succeededAt.</param>
        /// <param name="failedAt">failedAt.</param>
        /// <param name="refundedAt">refundedAt.</param>
        /// <param name="item">item (required).</param>
        public FeeObject(Guid lagoId = default(Guid), Guid lagoGroupId = default(Guid), Guid lagoInvoiceId = default(Guid), Guid lagoTrueUpFeeId = default(Guid), Guid lagoTrueUpParentFeeId = default(Guid), string externalSubscriptionId = default(string), int amountCents = default(int), string amountCurrency = default(string), int vatAmountCents = default(int), string vatAmountCurrency = default(string), string units = default(string), int totalAmountCents = default(int), string totalAmountCurrency = default(string), int eventsCount = default(int), bool payInAdvance = default(bool), bool invoiceable = default(bool), DateTime fromDate = default(DateTime), DateTime toDate = default(DateTime), PaymentStatusEnum paymentStatus = default(PaymentStatusEnum), DateTime createdAt = default(DateTime), DateTime succeededAt = default(DateTime), DateTime failedAt = default(DateTime), DateTime refundedAt = default(DateTime), FeeObjectItem item = default(FeeObjectItem))
        {
            this.LagoId = lagoId;
            this.AmountCents = amountCents;
            // to ensure "amountCurrency" is required (not null)
            if (amountCurrency == null)
            {
                throw new ArgumentNullException("amountCurrency is a required property for FeeObject and cannot be null");
            }
            this.AmountCurrency = amountCurrency;
            this.VatAmountCents = vatAmountCents;
            // to ensure "vatAmountCurrency" is required (not null)
            if (vatAmountCurrency == null)
            {
                throw new ArgumentNullException("vatAmountCurrency is a required property for FeeObject and cannot be null");
            }
            this.VatAmountCurrency = vatAmountCurrency;
            // to ensure "units" is required (not null)
            if (units == null)
            {
                throw new ArgumentNullException("units is a required property for FeeObject and cannot be null");
            }
            this.Units = units;
            this.PaymentStatus = paymentStatus;
            this.CreatedAt = createdAt;
            // to ensure "item" is required (not null)
            if (item == null)
            {
                throw new ArgumentNullException("item is a required property for FeeObject and cannot be null");
            }
            this.Item = item;
            this.LagoGroupId = lagoGroupId;
            this.LagoInvoiceId = lagoInvoiceId;
            this.LagoTrueUpFeeId = lagoTrueUpFeeId;
            this.LagoTrueUpParentFeeId = lagoTrueUpParentFeeId;
            this.ExternalSubscriptionId = externalSubscriptionId;
            this.TotalAmountCents = totalAmountCents;
            this.TotalAmountCurrency = totalAmountCurrency;
            this.EventsCount = eventsCount;
            this.PayInAdvance = payInAdvance;
            this.Invoiceable = invoiceable;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.SucceededAt = succeededAt;
            this.FailedAt = failedAt;
            this.RefundedAt = refundedAt;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoId { get; set; }

        /// <summary>
        /// Gets or Sets LagoGroupId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_group_id", EmitDefaultValue = false)]
        public Guid LagoGroupId { get; set; }

        /// <summary>
        /// Gets or Sets LagoInvoiceId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_invoice_id", EmitDefaultValue = false)]
        public Guid LagoInvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets LagoTrueUpFeeId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_true_up_fee_id", EmitDefaultValue = false)]
        public Guid LagoTrueUpFeeId { get; set; }

        /// <summary>
        /// Gets or Sets LagoTrueUpParentFeeId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_true_up_parent_fee_id", EmitDefaultValue = false)]
        public Guid LagoTrueUpParentFeeId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalSubscriptionId
        /// </summary>
        /// <example>54321</example>
        [DataMember(Name = "external_subscription_id", EmitDefaultValue = false)]
        public string ExternalSubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "amount_currency", IsRequired = true, EmitDefaultValue = true)]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCents
        /// </summary>
        /// <example>200</example>
        [DataMember(Name = "vat_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int VatAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "vat_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        public string VatAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        /// <example>2.5</example>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public string Units { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCents
        /// </summary>
        /// <example>1200</example>
        [DataMember(Name = "total_amount_cents", EmitDefaultValue = false)]
        public int TotalAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "total_amount_currency", EmitDefaultValue = false)]
        public string TotalAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets EventsCount
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "events_count", EmitDefaultValue = false)]
        public int EventsCount { get; set; }

        /// <summary>
        /// Gets or Sets PayInAdvance
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "pay_in_advance", EmitDefaultValue = true)]
        public bool PayInAdvance { get; set; }

        /// <summary>
        /// Gets or Sets Invoiceable
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "invoiceable", EmitDefaultValue = true)]
        public bool Invoiceable { get; set; }

        /// <summary>
        /// Gets or Sets FromDate
        /// </summary>
        /// <example>2022-08-08T00:00Z</example>
        [DataMember(Name = "from_date", EmitDefaultValue = false)]
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Gets or Sets ToDate
        /// </summary>
        /// <example>2022-08-08T00:00Z</example>
        [DataMember(Name = "to_date", EmitDefaultValue = false)]
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets SucceededAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "succeeded_at", EmitDefaultValue = false)]
        public DateTime SucceededAt { get; set; }

        /// <summary>
        /// Gets or Sets FailedAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "failed_at", EmitDefaultValue = false)]
        public DateTime FailedAt { get; set; }

        /// <summary>
        /// Gets or Sets RefundedAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "refunded_at", EmitDefaultValue = false)]
        public DateTime RefundedAt { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", IsRequired = true, EmitDefaultValue = true)]
        public FeeObjectItem Item { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeeObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  LagoGroupId: ").Append(LagoGroupId).Append("\n");
            sb.Append("  LagoInvoiceId: ").Append(LagoInvoiceId).Append("\n");
            sb.Append("  LagoTrueUpFeeId: ").Append(LagoTrueUpFeeId).Append("\n");
            sb.Append("  LagoTrueUpParentFeeId: ").Append(LagoTrueUpParentFeeId).Append("\n");
            sb.Append("  ExternalSubscriptionId: ").Append(ExternalSubscriptionId).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  VatAmountCents: ").Append(VatAmountCents).Append("\n");
            sb.Append("  VatAmountCurrency: ").Append(VatAmountCurrency).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  TotalAmountCents: ").Append(TotalAmountCents).Append("\n");
            sb.Append("  TotalAmountCurrency: ").Append(TotalAmountCurrency).Append("\n");
            sb.Append("  EventsCount: ").Append(EventsCount).Append("\n");
            sb.Append("  PayInAdvance: ").Append(PayInAdvance).Append("\n");
            sb.Append("  Invoiceable: ").Append(Invoiceable).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  SucceededAt: ").Append(SucceededAt).Append("\n");
            sb.Append("  FailedAt: ").Append(FailedAt).Append("\n");
            sb.Append("  RefundedAt: ").Append(RefundedAt).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
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
            return this.Equals(input as FeeObject);
        }

        /// <summary>
        /// Returns true if FeeObject instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeObject input)
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
                    this.LagoGroupId == input.LagoGroupId ||
                    (this.LagoGroupId != null &&
                    this.LagoGroupId.Equals(input.LagoGroupId))
                ) && 
                (
                    this.LagoInvoiceId == input.LagoInvoiceId ||
                    (this.LagoInvoiceId != null &&
                    this.LagoInvoiceId.Equals(input.LagoInvoiceId))
                ) && 
                (
                    this.LagoTrueUpFeeId == input.LagoTrueUpFeeId ||
                    (this.LagoTrueUpFeeId != null &&
                    this.LagoTrueUpFeeId.Equals(input.LagoTrueUpFeeId))
                ) && 
                (
                    this.LagoTrueUpParentFeeId == input.LagoTrueUpParentFeeId ||
                    (this.LagoTrueUpParentFeeId != null &&
                    this.LagoTrueUpParentFeeId.Equals(input.LagoTrueUpParentFeeId))
                ) && 
                (
                    this.ExternalSubscriptionId == input.ExternalSubscriptionId ||
                    (this.ExternalSubscriptionId != null &&
                    this.ExternalSubscriptionId.Equals(input.ExternalSubscriptionId))
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
                    this.VatAmountCents == input.VatAmountCents ||
                    this.VatAmountCents.Equals(input.VatAmountCents)
                ) && 
                (
                    this.VatAmountCurrency == input.VatAmountCurrency ||
                    (this.VatAmountCurrency != null &&
                    this.VatAmountCurrency.Equals(input.VatAmountCurrency))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.TotalAmountCents == input.TotalAmountCents ||
                    this.TotalAmountCents.Equals(input.TotalAmountCents)
                ) && 
                (
                    this.TotalAmountCurrency == input.TotalAmountCurrency ||
                    (this.TotalAmountCurrency != null &&
                    this.TotalAmountCurrency.Equals(input.TotalAmountCurrency))
                ) && 
                (
                    this.EventsCount == input.EventsCount ||
                    this.EventsCount.Equals(input.EventsCount)
                ) && 
                (
                    this.PayInAdvance == input.PayInAdvance ||
                    this.PayInAdvance.Equals(input.PayInAdvance)
                ) && 
                (
                    this.Invoiceable == input.Invoiceable ||
                    this.Invoiceable.Equals(input.Invoiceable)
                ) && 
                (
                    this.FromDate == input.FromDate ||
                    (this.FromDate != null &&
                    this.FromDate.Equals(input.FromDate))
                ) && 
                (
                    this.ToDate == input.ToDate ||
                    (this.ToDate != null &&
                    this.ToDate.Equals(input.ToDate))
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    this.PaymentStatus.Equals(input.PaymentStatus)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.SucceededAt == input.SucceededAt ||
                    (this.SucceededAt != null &&
                    this.SucceededAt.Equals(input.SucceededAt))
                ) && 
                (
                    this.FailedAt == input.FailedAt ||
                    (this.FailedAt != null &&
                    this.FailedAt.Equals(input.FailedAt))
                ) && 
                (
                    this.RefundedAt == input.RefundedAt ||
                    (this.RefundedAt != null &&
                    this.RefundedAt.Equals(input.RefundedAt))
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
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
                if (this.LagoGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoGroupId.GetHashCode();
                }
                if (this.LagoInvoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoInvoiceId.GetHashCode();
                }
                if (this.LagoTrueUpFeeId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoTrueUpFeeId.GetHashCode();
                }
                if (this.LagoTrueUpParentFeeId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoTrueUpParentFeeId.GetHashCode();
                }
                if (this.ExternalSubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalSubscriptionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VatAmountCents.GetHashCode();
                if (this.VatAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.VatAmountCurrency.GetHashCode();
                }
                if (this.Units != null)
                {
                    hashCode = (hashCode * 59) + this.Units.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalAmountCents.GetHashCode();
                if (this.TotalAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PayInAdvance.GetHashCode();
                hashCode = (hashCode * 59) + this.Invoiceable.GetHashCode();
                if (this.FromDate != null)
                {
                    hashCode = (hashCode * 59) + this.FromDate.GetHashCode();
                }
                if (this.ToDate != null)
                {
                    hashCode = (hashCode * 59) + this.ToDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentStatus.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.SucceededAt != null)
                {
                    hashCode = (hashCode * 59) + this.SucceededAt.GetHashCode();
                }
                if (this.FailedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FailedAt.GetHashCode();
                }
                if (this.RefundedAt != null)
                {
                    hashCode = (hashCode * 59) + this.RefundedAt.GetHashCode();
                }
                if (this.Item != null)
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
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
