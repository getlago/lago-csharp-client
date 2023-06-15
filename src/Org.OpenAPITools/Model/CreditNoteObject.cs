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
    /// CreditNoteObject
    /// </summary>
    [DataContract(Name = "CreditNoteObject")]
    public partial class CreditNoteObject : IEquatable<CreditNoteObject>, IValidatableObject
    {
        /// <summary>
        /// Credit status
        /// </summary>
        /// <value>Credit status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreditStatusEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 1,

            /// <summary>
            /// Enum Consumed for value: consumed
            /// </summary>
            [EnumMember(Value = "consumed")]
            Consumed = 2,

            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 3
        }


        /// <summary>
        /// Credit status
        /// </summary>
        /// <value>Credit status</value>
        [DataMember(Name = "credit_status", EmitDefaultValue = false)]
        public CreditStatusEnum? CreditStatus { get; set; }
        /// <summary>
        /// Refund status
        /// </summary>
        /// <value>Refund status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefundStatusEnum
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
        /// Refund status
        /// </summary>
        /// <value>Refund status</value>
        [DataMember(Name = "refund_status", EmitDefaultValue = false)]
        public RefundStatusEnum? RefundStatus { get; set; }
        /// <summary>
        /// Reason
        /// </summary>
        /// <value>Reason</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum DuplicatedCharge for value: duplicated_charge
            /// </summary>
            [EnumMember(Value = "duplicated_charge")]
            DuplicatedCharge = 1,

            /// <summary>
            /// Enum ProductUnsatisfactory for value: product_unsatisfactory
            /// </summary>
            [EnumMember(Value = "product_unsatisfactory")]
            ProductUnsatisfactory = 2,

            /// <summary>
            /// Enum OrderChange for value: order_change
            /// </summary>
            [EnumMember(Value = "order_change")]
            OrderChange = 3,

            /// <summary>
            /// Enum OrderCancellation for value: order_cancellation
            /// </summary>
            [EnumMember(Value = "order_cancellation")]
            OrderCancellation = 4,

            /// <summary>
            /// Enum FraudulentCharge for value: fraudulent_charge
            /// </summary>
            [EnumMember(Value = "fraudulent_charge")]
            FraudulentCharge = 5,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 6
        }


        /// <summary>
        /// Reason
        /// </summary>
        /// <value>Reason</value>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public ReasonEnum Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditNoteObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId (required).</param>
        /// <param name="sequentialId">sequentialId (required).</param>
        /// <param name="number">number (required).</param>
        /// <param name="lagoInvoiceId">lagoInvoiceId (required).</param>
        /// <param name="invoiceNumber">invoiceNumber (required).</param>
        /// <param name="issuingDate">issuingDate (required).</param>
        /// <param name="creditStatus">Credit status.</param>
        /// <param name="refundStatus">Refund status.</param>
        /// <param name="reason">Reason (required).</param>
        /// <param name="description">description.</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="totalAmountCents">totalAmountCents (required).</param>
        /// <param name="totalAmountCurrency">totalAmountCurrency (required).</param>
        /// <param name="vatAmountCents">vatAmountCents (required).</param>
        /// <param name="vatAmountCurrency">vatAmountCurrency (required).</param>
        /// <param name="subTotalVatExcludedAmountCents">subTotalVatExcludedAmountCents (required).</param>
        /// <param name="subTotalVatExcludedAmountCurrency">subTotalVatExcludedAmountCurrency (required).</param>
        /// <param name="balanceAmountCents">balanceAmountCents (required).</param>
        /// <param name="balanceAmountCurrency">balanceAmountCurrency (required).</param>
        /// <param name="creditAmountCents">creditAmountCents (required).</param>
        /// <param name="creditAmountCurrency">creditAmountCurrency (required).</param>
        /// <param name="refundAmountCents">refundAmountCents (required).</param>
        /// <param name="refundAmountCurrency">refundAmountCurrency (required).</param>
        /// <param name="couponsAdjustementAmountCents">couponsAdjustementAmountCents (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="fileUrl">fileUrl.</param>
        /// <param name="items">items.</param>
        public CreditNoteObject(Guid lagoId = default(Guid), int sequentialId = default(int), string number = default(string), Guid lagoInvoiceId = default(Guid), string invoiceNumber = default(string), DateTime issuingDate = default(DateTime), CreditStatusEnum? creditStatus = default(CreditStatusEnum?), RefundStatusEnum? refundStatus = default(RefundStatusEnum?), ReasonEnum reason = default(ReasonEnum), string description = default(string), string currency = default(string), int totalAmountCents = default(int), string totalAmountCurrency = default(string), int vatAmountCents = default(int), string vatAmountCurrency = default(string), int subTotalVatExcludedAmountCents = default(int), string subTotalVatExcludedAmountCurrency = default(string), int balanceAmountCents = default(int), string balanceAmountCurrency = default(string), int creditAmountCents = default(int), string creditAmountCurrency = default(string), int refundAmountCents = default(int), string refundAmountCurrency = default(string), int couponsAdjustementAmountCents = default(int), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string fileUrl = default(string), List<CreditNoteItemObject> items = default(List<CreditNoteItemObject>))
        {
            this.LagoId = lagoId;
            this.SequentialId = sequentialId;
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for CreditNoteObject and cannot be null");
            }
            this.Number = number;
            this.LagoInvoiceId = lagoInvoiceId;
            // to ensure "invoiceNumber" is required (not null)
            if (invoiceNumber == null)
            {
                throw new ArgumentNullException("invoiceNumber is a required property for CreditNoteObject and cannot be null");
            }
            this.InvoiceNumber = invoiceNumber;
            this.IssuingDate = issuingDate;
            this.Reason = reason;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for CreditNoteObject and cannot be null");
            }
            this.Currency = currency;
            this.TotalAmountCents = totalAmountCents;
            // to ensure "totalAmountCurrency" is required (not null)
            if (totalAmountCurrency == null)
            {
                throw new ArgumentNullException("totalAmountCurrency is a required property for CreditNoteObject and cannot be null");
            }
            this.TotalAmountCurrency = totalAmountCurrency;
            this.VatAmountCents = vatAmountCents;
            // to ensure "vatAmountCurrency" is required (not null)
            if (vatAmountCurrency == null)
            {
                throw new ArgumentNullException("vatAmountCurrency is a required property for CreditNoteObject and cannot be null");
            }
            this.VatAmountCurrency = vatAmountCurrency;
            this.SubTotalVatExcludedAmountCents = subTotalVatExcludedAmountCents;
            // to ensure "subTotalVatExcludedAmountCurrency" is required (not null)
            if (subTotalVatExcludedAmountCurrency == null)
            {
                throw new ArgumentNullException("subTotalVatExcludedAmountCurrency is a required property for CreditNoteObject and cannot be null");
            }
            this.SubTotalVatExcludedAmountCurrency = subTotalVatExcludedAmountCurrency;
            this.BalanceAmountCents = balanceAmountCents;
            // to ensure "balanceAmountCurrency" is required (not null)
            if (balanceAmountCurrency == null)
            {
                throw new ArgumentNullException("balanceAmountCurrency is a required property for CreditNoteObject and cannot be null");
            }
            this.BalanceAmountCurrency = balanceAmountCurrency;
            this.CreditAmountCents = creditAmountCents;
            // to ensure "creditAmountCurrency" is required (not null)
            if (creditAmountCurrency == null)
            {
                throw new ArgumentNullException("creditAmountCurrency is a required property for CreditNoteObject and cannot be null");
            }
            this.CreditAmountCurrency = creditAmountCurrency;
            this.RefundAmountCents = refundAmountCents;
            // to ensure "refundAmountCurrency" is required (not null)
            if (refundAmountCurrency == null)
            {
                throw new ArgumentNullException("refundAmountCurrency is a required property for CreditNoteObject and cannot be null");
            }
            this.RefundAmountCurrency = refundAmountCurrency;
            this.CouponsAdjustementAmountCents = couponsAdjustementAmountCents;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreditStatus = creditStatus;
            this.RefundStatus = refundStatus;
            this.Description = description;
            this.FileUrl = fileUrl;
            this.Items = items;
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
        /// <example>1234</example>
        [DataMember(Name = "sequential_id", IsRequired = true, EmitDefaultValue = true)]
        public int SequentialId { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        /// <example>123456789</example>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets LagoInvoiceId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_invoice_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoInvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNumber
        /// </summary>
        /// <example>123456789</example>
        [DataMember(Name = "invoice_number", IsRequired = true, EmitDefaultValue = true)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets IssuingDate
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "issuing_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IssuingDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>description</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCents
        /// </summary>
        /// <example>1220</example>
        [DataMember(Name = "total_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int TotalAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "total_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string TotalAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "vat_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int VatAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "vat_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string VatAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets SubTotalVatExcludedAmountCents
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "sub_total_vat_excluded_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int SubTotalVatExcludedAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets SubTotalVatExcludedAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "sub_total_vat_excluded_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string SubTotalVatExcludedAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets BalanceAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "balance_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int BalanceAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets BalanceAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "balance_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string BalanceAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "credit_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int CreditAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "credit_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string CreditAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets RefundAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "refund_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int RefundAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets RefundAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "refund_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public string RefundAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CouponsAdjustementAmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "coupons_adjustement_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int CouponsAdjustementAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FileUrl
        /// </summary>
        /// <example>https://example.com</example>
        [DataMember(Name = "file_url", EmitDefaultValue = false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<CreditNoteItemObject> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditNoteObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  SequentialId: ").Append(SequentialId).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  LagoInvoiceId: ").Append(LagoInvoiceId).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  IssuingDate: ").Append(IssuingDate).Append("\n");
            sb.Append("  CreditStatus: ").Append(CreditStatus).Append("\n");
            sb.Append("  RefundStatus: ").Append(RefundStatus).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TotalAmountCents: ").Append(TotalAmountCents).Append("\n");
            sb.Append("  TotalAmountCurrency: ").Append(TotalAmountCurrency).Append("\n");
            sb.Append("  VatAmountCents: ").Append(VatAmountCents).Append("\n");
            sb.Append("  VatAmountCurrency: ").Append(VatAmountCurrency).Append("\n");
            sb.Append("  SubTotalVatExcludedAmountCents: ").Append(SubTotalVatExcludedAmountCents).Append("\n");
            sb.Append("  SubTotalVatExcludedAmountCurrency: ").Append(SubTotalVatExcludedAmountCurrency).Append("\n");
            sb.Append("  BalanceAmountCents: ").Append(BalanceAmountCents).Append("\n");
            sb.Append("  BalanceAmountCurrency: ").Append(BalanceAmountCurrency).Append("\n");
            sb.Append("  CreditAmountCents: ").Append(CreditAmountCents).Append("\n");
            sb.Append("  CreditAmountCurrency: ").Append(CreditAmountCurrency).Append("\n");
            sb.Append("  RefundAmountCents: ").Append(RefundAmountCents).Append("\n");
            sb.Append("  RefundAmountCurrency: ").Append(RefundAmountCurrency).Append("\n");
            sb.Append("  CouponsAdjustementAmountCents: ").Append(CouponsAdjustementAmountCents).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as CreditNoteObject);
        }

        /// <summary>
        /// Returns true if CreditNoteObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNoteObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNoteObject input)
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
                    this.LagoInvoiceId == input.LagoInvoiceId ||
                    (this.LagoInvoiceId != null &&
                    this.LagoInvoiceId.Equals(input.LagoInvoiceId))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.IssuingDate == input.IssuingDate ||
                    (this.IssuingDate != null &&
                    this.IssuingDate.Equals(input.IssuingDate))
                ) && 
                (
                    this.CreditStatus == input.CreditStatus ||
                    this.CreditStatus.Equals(input.CreditStatus)
                ) && 
                (
                    this.RefundStatus == input.RefundStatus ||
                    this.RefundStatus.Equals(input.RefundStatus)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                    this.VatAmountCents == input.VatAmountCents ||
                    this.VatAmountCents.Equals(input.VatAmountCents)
                ) && 
                (
                    this.VatAmountCurrency == input.VatAmountCurrency ||
                    (this.VatAmountCurrency != null &&
                    this.VatAmountCurrency.Equals(input.VatAmountCurrency))
                ) && 
                (
                    this.SubTotalVatExcludedAmountCents == input.SubTotalVatExcludedAmountCents ||
                    this.SubTotalVatExcludedAmountCents.Equals(input.SubTotalVatExcludedAmountCents)
                ) && 
                (
                    this.SubTotalVatExcludedAmountCurrency == input.SubTotalVatExcludedAmountCurrency ||
                    (this.SubTotalVatExcludedAmountCurrency != null &&
                    this.SubTotalVatExcludedAmountCurrency.Equals(input.SubTotalVatExcludedAmountCurrency))
                ) && 
                (
                    this.BalanceAmountCents == input.BalanceAmountCents ||
                    this.BalanceAmountCents.Equals(input.BalanceAmountCents)
                ) && 
                (
                    this.BalanceAmountCurrency == input.BalanceAmountCurrency ||
                    (this.BalanceAmountCurrency != null &&
                    this.BalanceAmountCurrency.Equals(input.BalanceAmountCurrency))
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
                    this.RefundAmountCents == input.RefundAmountCents ||
                    this.RefundAmountCents.Equals(input.RefundAmountCents)
                ) && 
                (
                    this.RefundAmountCurrency == input.RefundAmountCurrency ||
                    (this.RefundAmountCurrency != null &&
                    this.RefundAmountCurrency.Equals(input.RefundAmountCurrency))
                ) && 
                (
                    this.CouponsAdjustementAmountCents == input.CouponsAdjustementAmountCents ||
                    this.CouponsAdjustementAmountCents.Equals(input.CouponsAdjustementAmountCents)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.FileUrl == input.FileUrl ||
                    (this.FileUrl != null &&
                    this.FileUrl.Equals(input.FileUrl))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.LagoInvoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoInvoiceId.GetHashCode();
                }
                if (this.InvoiceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNumber.GetHashCode();
                }
                if (this.IssuingDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreditStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.RefundStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalAmountCents.GetHashCode();
                if (this.TotalAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VatAmountCents.GetHashCode();
                if (this.VatAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.VatAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SubTotalVatExcludedAmountCents.GetHashCode();
                if (this.SubTotalVatExcludedAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.SubTotalVatExcludedAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BalanceAmountCents.GetHashCode();
                if (this.BalanceAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreditAmountCents.GetHashCode();
                if (this.CreditAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.CreditAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefundAmountCents.GetHashCode();
                if (this.RefundAmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CouponsAdjustementAmountCents.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.FileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileUrl.GetHashCode();
                }
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
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
