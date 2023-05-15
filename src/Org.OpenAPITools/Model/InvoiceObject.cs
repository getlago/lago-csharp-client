/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.32.0-beta
 * Contact: tech@getlago.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InvoiceObject
    /// </summary>
    [DataContract]
    public partial class InvoiceObject :  IEquatable<InvoiceObject>, IValidatableObject
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
            /// Enum Addon for value: add_on
            /// </summary>
            [EnumMember(Value = "add_on")]
            Addon = 2,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 3

        }

        /// <summary>
        /// Gets or Sets InvoiceType
        /// </summary>
        [DataMember(Name="invoice_type", EmitDefaultValue=true)]
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
        [DataMember(Name="status", EmitDefaultValue=true)]
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
        [DataMember(Name="payment_status", EmitDefaultValue=true)]
        public PaymentStatusEnum PaymentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceObject" /> class.
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
        public InvoiceObject(Guid lagoId = default(Guid), int sequentialId = default(int), string number = default(string), DateTime issuingDate = default(DateTime), InvoiceTypeEnum invoiceType = default(InvoiceTypeEnum), StatusEnum status = default(StatusEnum), PaymentStatusEnum paymentStatus = default(PaymentStatusEnum), string currency = default(string), int feesAmountCents = default(int), int couponsAmountCents = default(int), int creditNotesAmountCents = default(int), int subTotalVatExcludedAmountCents = default(int), int vatAmountCents = default(int), int subTotalVatIncludedAmountCents = default(int), int prepaidCreditAmountCents = default(int), int totalAmountCents = default(int), int versionNumber = default(int), int amountCents = default(int), string amountCurrency = default(string), string vatAmountCurrency = default(string), int creditAmountCents = default(int), string creditAmountCurrency = default(string), string totalAmountCurrency = default(string), bool legacy = default(bool), string fileUrl = default(string), CustomerObject customer = default(CustomerObject), List<InvoiceMetadataObject> metadata = default(List<InvoiceMetadataObject>))
        {
            // to ensure "lagoId" is required (not null)
            if (lagoId == null)
            {
                throw new InvalidDataException("lagoId is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.LagoId = lagoId;
            }

            // to ensure "sequentialId" is required (not null)
            if (sequentialId == null)
            {
                throw new InvalidDataException("sequentialId is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.SequentialId = sequentialId;
            }

            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.Number = number;
            }

            // to ensure "issuingDate" is required (not null)
            if (issuingDate == null)
            {
                throw new InvalidDataException("issuingDate is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.IssuingDate = issuingDate;
            }

            // to ensure "invoiceType" is required (not null)
            if (invoiceType == null)
            {
                throw new InvalidDataException("invoiceType is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.InvoiceType = invoiceType;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "paymentStatus" is required (not null)
            if (paymentStatus == null)
            {
                throw new InvalidDataException("paymentStatus is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.PaymentStatus = paymentStatus;
            }

            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }

            // to ensure "feesAmountCents" is required (not null)
            if (feesAmountCents == null)
            {
                throw new InvalidDataException("feesAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.FeesAmountCents = feesAmountCents;
            }

            // to ensure "couponsAmountCents" is required (not null)
            if (couponsAmountCents == null)
            {
                throw new InvalidDataException("couponsAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.CouponsAmountCents = couponsAmountCents;
            }

            // to ensure "creditNotesAmountCents" is required (not null)
            if (creditNotesAmountCents == null)
            {
                throw new InvalidDataException("creditNotesAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.CreditNotesAmountCents = creditNotesAmountCents;
            }

            // to ensure "subTotalVatExcludedAmountCents" is required (not null)
            if (subTotalVatExcludedAmountCents == null)
            {
                throw new InvalidDataException("subTotalVatExcludedAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.SubTotalVatExcludedAmountCents = subTotalVatExcludedAmountCents;
            }

            // to ensure "vatAmountCents" is required (not null)
            if (vatAmountCents == null)
            {
                throw new InvalidDataException("vatAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.VatAmountCents = vatAmountCents;
            }

            // to ensure "subTotalVatIncludedAmountCents" is required (not null)
            if (subTotalVatIncludedAmountCents == null)
            {
                throw new InvalidDataException("subTotalVatIncludedAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.SubTotalVatIncludedAmountCents = subTotalVatIncludedAmountCents;
            }

            // to ensure "prepaidCreditAmountCents" is required (not null)
            if (prepaidCreditAmountCents == null)
            {
                throw new InvalidDataException("prepaidCreditAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.PrepaidCreditAmountCents = prepaidCreditAmountCents;
            }

            // to ensure "totalAmountCents" is required (not null)
            if (totalAmountCents == null)
            {
                throw new InvalidDataException("totalAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.TotalAmountCents = totalAmountCents;
            }

            // to ensure "versionNumber" is required (not null)
            if (versionNumber == null)
            {
                throw new InvalidDataException("versionNumber is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.VersionNumber = versionNumber;
            }

            // to ensure "amountCents" is required (not null)
            if (amountCents == null)
            {
                throw new InvalidDataException("amountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.AmountCents = amountCents;
            }

            // to ensure "amountCurrency" is required (not null)
            if (amountCurrency == null)
            {
                throw new InvalidDataException("amountCurrency is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.AmountCurrency = amountCurrency;
            }

            // to ensure "vatAmountCurrency" is required (not null)
            if (vatAmountCurrency == null)
            {
                throw new InvalidDataException("vatAmountCurrency is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.VatAmountCurrency = vatAmountCurrency;
            }

            // to ensure "creditAmountCents" is required (not null)
            if (creditAmountCents == null)
            {
                throw new InvalidDataException("creditAmountCents is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.CreditAmountCents = creditAmountCents;
            }

            // to ensure "creditAmountCurrency" is required (not null)
            if (creditAmountCurrency == null)
            {
                throw new InvalidDataException("creditAmountCurrency is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.CreditAmountCurrency = creditAmountCurrency;
            }

            // to ensure "totalAmountCurrency" is required (not null)
            if (totalAmountCurrency == null)
            {
                throw new InvalidDataException("totalAmountCurrency is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.TotalAmountCurrency = totalAmountCurrency;
            }

            // to ensure "legacy" is required (not null)
            if (legacy == null)
            {
                throw new InvalidDataException("legacy is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.Legacy = legacy;
            }

            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new InvalidDataException("customer is a required property for InvoiceObject and cannot be null");
            }
            else
            {
                this.Customer = customer;
            }

            this.FileUrl = fileUrl;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=true)]
        public Guid LagoId { get; set; }

        /// <summary>
        /// Gets or Sets SequentialId
        /// </summary>
        [DataMember(Name="sequential_id", EmitDefaultValue=true)]
        public int SequentialId { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets IssuingDate
        /// </summary>
        [DataMember(Name="issuing_date", EmitDefaultValue=true)]
        public DateTime IssuingDate { get; set; }




        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets FeesAmountCents
        /// </summary>
        [DataMember(Name="fees_amount_cents", EmitDefaultValue=true)]
        public int FeesAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CouponsAmountCents
        /// </summary>
        [DataMember(Name="coupons_amount_cents", EmitDefaultValue=true)]
        public int CouponsAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CreditNotesAmountCents
        /// </summary>
        [DataMember(Name="credit_notes_amount_cents", EmitDefaultValue=true)]
        public int CreditNotesAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets SubTotalVatExcludedAmountCents
        /// </summary>
        [DataMember(Name="sub_total_vat_excluded_amount_cents", EmitDefaultValue=true)]
        public int SubTotalVatExcludedAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCents
        /// </summary>
        [DataMember(Name="vat_amount_cents", EmitDefaultValue=true)]
        public int VatAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets SubTotalVatIncludedAmountCents
        /// </summary>
        [DataMember(Name="sub_total_vat_included_amount_cents", EmitDefaultValue=true)]
        public int SubTotalVatIncludedAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets PrepaidCreditAmountCents
        /// </summary>
        [DataMember(Name="prepaid_credit_amount_cents", EmitDefaultValue=true)]
        public int PrepaidCreditAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCents
        /// </summary>
        [DataMember(Name="total_amount_cents", EmitDefaultValue=true)]
        public int TotalAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets VersionNumber
        /// </summary>
        [DataMember(Name="version_number", EmitDefaultValue=true)]
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        [DataMember(Name="amount_cents", EmitDefaultValue=true)]
        [Obsolete]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        [DataMember(Name="amount_currency", EmitDefaultValue=true)]
        [Obsolete]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCurrency
        /// </summary>
        [DataMember(Name="vat_amount_currency", EmitDefaultValue=true)]
        [Obsolete]
        public string VatAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountCents
        /// </summary>
        [DataMember(Name="credit_amount_cents", EmitDefaultValue=true)]
        [Obsolete]
        public int CreditAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountCurrency
        /// </summary>
        [DataMember(Name="credit_amount_currency", EmitDefaultValue=true)]
        [Obsolete]
        public string CreditAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCurrency
        /// </summary>
        [DataMember(Name="total_amount_currency", EmitDefaultValue=true)]
        [Obsolete]
        public string TotalAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Legacy
        /// </summary>
        [DataMember(Name="legacy", EmitDefaultValue=true)]
        [Obsolete]
        public bool Legacy { get; set; }

        /// <summary>
        /// Gets or Sets FileUrl
        /// </summary>
        [DataMember(Name="file_url", EmitDefaultValue=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=true)]
        public CustomerObject Customer { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public List<InvoiceMetadataObject> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceObject {\n");
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
            return this.Equals(input as InvoiceObject);
        }

        /// <summary>
        /// Returns true if InvoiceObject instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LagoId == input.LagoId ||
                    (this.LagoId != null &&
                    this.LagoId.Equals(input.LagoId))
                ) && 
                (
                    this.SequentialId == input.SequentialId ||
                    (this.SequentialId != null &&
                    this.SequentialId.Equals(input.SequentialId))
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
                    (this.InvoiceType != null &&
                    this.InvoiceType.Equals(input.InvoiceType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    (this.PaymentStatus != null &&
                    this.PaymentStatus.Equals(input.PaymentStatus))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.FeesAmountCents == input.FeesAmountCents ||
                    (this.FeesAmountCents != null &&
                    this.FeesAmountCents.Equals(input.FeesAmountCents))
                ) && 
                (
                    this.CouponsAmountCents == input.CouponsAmountCents ||
                    (this.CouponsAmountCents != null &&
                    this.CouponsAmountCents.Equals(input.CouponsAmountCents))
                ) && 
                (
                    this.CreditNotesAmountCents == input.CreditNotesAmountCents ||
                    (this.CreditNotesAmountCents != null &&
                    this.CreditNotesAmountCents.Equals(input.CreditNotesAmountCents))
                ) && 
                (
                    this.SubTotalVatExcludedAmountCents == input.SubTotalVatExcludedAmountCents ||
                    (this.SubTotalVatExcludedAmountCents != null &&
                    this.SubTotalVatExcludedAmountCents.Equals(input.SubTotalVatExcludedAmountCents))
                ) && 
                (
                    this.VatAmountCents == input.VatAmountCents ||
                    (this.VatAmountCents != null &&
                    this.VatAmountCents.Equals(input.VatAmountCents))
                ) && 
                (
                    this.SubTotalVatIncludedAmountCents == input.SubTotalVatIncludedAmountCents ||
                    (this.SubTotalVatIncludedAmountCents != null &&
                    this.SubTotalVatIncludedAmountCents.Equals(input.SubTotalVatIncludedAmountCents))
                ) && 
                (
                    this.PrepaidCreditAmountCents == input.PrepaidCreditAmountCents ||
                    (this.PrepaidCreditAmountCents != null &&
                    this.PrepaidCreditAmountCents.Equals(input.PrepaidCreditAmountCents))
                ) && 
                (
                    this.TotalAmountCents == input.TotalAmountCents ||
                    (this.TotalAmountCents != null &&
                    this.TotalAmountCents.Equals(input.TotalAmountCents))
                ) && 
                (
                    this.VersionNumber == input.VersionNumber ||
                    (this.VersionNumber != null &&
                    this.VersionNumber.Equals(input.VersionNumber))
                ) && 
                (
                    this.AmountCents == input.AmountCents ||
                    (this.AmountCents != null &&
                    this.AmountCents.Equals(input.AmountCents))
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
                    (this.CreditAmountCents != null &&
                    this.CreditAmountCents.Equals(input.CreditAmountCents))
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
                    (this.Legacy != null &&
                    this.Legacy.Equals(input.Legacy))
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
                    hashCode = hashCode * 59 + this.LagoId.GetHashCode();
                if (this.SequentialId != null)
                    hashCode = hashCode * 59 + this.SequentialId.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IssuingDate != null)
                    hashCode = hashCode * 59 + this.IssuingDate.GetHashCode();
                if (this.InvoiceType != null)
                    hashCode = hashCode * 59 + this.InvoiceType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PaymentStatus != null)
                    hashCode = hashCode * 59 + this.PaymentStatus.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.FeesAmountCents != null)
                    hashCode = hashCode * 59 + this.FeesAmountCents.GetHashCode();
                if (this.CouponsAmountCents != null)
                    hashCode = hashCode * 59 + this.CouponsAmountCents.GetHashCode();
                if (this.CreditNotesAmountCents != null)
                    hashCode = hashCode * 59 + this.CreditNotesAmountCents.GetHashCode();
                if (this.SubTotalVatExcludedAmountCents != null)
                    hashCode = hashCode * 59 + this.SubTotalVatExcludedAmountCents.GetHashCode();
                if (this.VatAmountCents != null)
                    hashCode = hashCode * 59 + this.VatAmountCents.GetHashCode();
                if (this.SubTotalVatIncludedAmountCents != null)
                    hashCode = hashCode * 59 + this.SubTotalVatIncludedAmountCents.GetHashCode();
                if (this.PrepaidCreditAmountCents != null)
                    hashCode = hashCode * 59 + this.PrepaidCreditAmountCents.GetHashCode();
                if (this.TotalAmountCents != null)
                    hashCode = hashCode * 59 + this.TotalAmountCents.GetHashCode();
                if (this.VersionNumber != null)
                    hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.AmountCents != null)
                    hashCode = hashCode * 59 + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                    hashCode = hashCode * 59 + this.AmountCurrency.GetHashCode();
                if (this.VatAmountCurrency != null)
                    hashCode = hashCode * 59 + this.VatAmountCurrency.GetHashCode();
                if (this.CreditAmountCents != null)
                    hashCode = hashCode * 59 + this.CreditAmountCents.GetHashCode();
                if (this.CreditAmountCurrency != null)
                    hashCode = hashCode * 59 + this.CreditAmountCurrency.GetHashCode();
                if (this.TotalAmountCurrency != null)
                    hashCode = hashCode * 59 + this.TotalAmountCurrency.GetHashCode();
                if (this.Legacy != null)
                    hashCode = hashCode * 59 + this.Legacy.GetHashCode();
                if (this.FileUrl != null)
                    hashCode = hashCode * 59 + this.FileUrl.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
