/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.21.0-beta
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
    /// CreditNoteObject
    /// </summary>
    [DataContract]
    public partial class CreditNoteObject :  IEquatable<CreditNoteObject>, IValidatableObject
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
        [DataMember(Name="credit_status", EmitDefaultValue=false)]
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
        [DataMember(Name="refund_status", EmitDefaultValue=false)]
        public RefundStatusEnum? RefundStatus { get; set; }
        /// <summary>
        /// Reason
        /// </summary>
        /// <value>Reason</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum Duplicatedcharge for value: duplicated_charge
            /// </summary>
            [EnumMember(Value = "duplicated_charge")]
            Duplicatedcharge = 1,

            /// <summary>
            /// Enum Productunsatisfactory for value: product_unsatisfactory
            /// </summary>
            [EnumMember(Value = "product_unsatisfactory")]
            Productunsatisfactory = 2,

            /// <summary>
            /// Enum Orderchange for value: order_change
            /// </summary>
            [EnumMember(Value = "order_change")]
            Orderchange = 3,

            /// <summary>
            /// Enum Ordercancellation for value: order_cancellation
            /// </summary>
            [EnumMember(Value = "order_cancellation")]
            Ordercancellation = 4,

            /// <summary>
            /// Enum Fraudulentcharge for value: fraudulent_charge
            /// </summary>
            [EnumMember(Value = "fraudulent_charge")]
            Fraudulentcharge = 5,

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
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="sequentialId">sequentialId.</param>
        /// <param name="number">number.</param>
        /// <param name="lagoInvoiceId">lagoInvoiceId.</param>
        /// <param name="invoiceNumber">invoiceNumber.</param>
        /// <param name="issuingDate">issuingDate.</param>
        /// <param name="creditStatus">Credit status.</param>
        /// <param name="refundStatus">Refund status.</param>
        /// <param name="reason">Reason.</param>
        /// <param name="description">description.</param>
        /// <param name="totalAmountCents">totalAmountCents.</param>
        /// <param name="totalAmountCurrency">totalAmountCurrency.</param>
        /// <param name="vatAmountCents">vatAmountCents.</param>
        /// <param name="vatAmountCurrency">vatAmountCurrency.</param>
        /// <param name="subTotalVatExcludedAmountCents">subTotalVatExcludedAmountCents.</param>
        /// <param name="subTotalVatExcludedAmountCurrency">subTotalVatExcludedAmountCurrency.</param>
        /// <param name="balanceAmountCents">balanceAmountCents.</param>
        /// <param name="balanceAmountCurrency">balanceAmountCurrency.</param>
        /// <param name="creditAmountCents">creditAmountCents.</param>
        /// <param name="creditAmountCurrency">creditAmountCurrency.</param>
        /// <param name="refundAmountCents">refundAmountCents.</param>
        /// <param name="refundAmountCurrency">refundAmountCurrency.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="fileUrl">fileUrl.</param>
        /// <param name="customer">customer.</param>
        /// <param name="items">items.</param>
        public CreditNoteObject(string lagoId = default(string), int sequentialId = default(int), string number = default(string), string lagoInvoiceId = default(string), string invoiceNumber = default(string), string issuingDate = default(string), CreditStatusEnum? creditStatus = default(CreditStatusEnum?), RefundStatusEnum? refundStatus = default(RefundStatusEnum?), ReasonEnum? reason = default(ReasonEnum?), string description = default(string), int totalAmountCents = default(int), string totalAmountCurrency = default(string), int vatAmountCents = default(int), string vatAmountCurrency = default(string), int subTotalVatExcludedAmountCents = default(int), string subTotalVatExcludedAmountCurrency = default(string), int balanceAmountCents = default(int), string balanceAmountCurrency = default(string), int creditAmountCents = default(int), string creditAmountCurrency = default(string), int refundAmountCents = default(int), string refundAmountCurrency = default(string), string createdAt = default(string), string updatedAt = default(string), string fileUrl = default(string), CustomerObject customer = default(CustomerObject), List<CreditNoteItemObject> items = default(List<CreditNoteItemObject>))
        {
            this.LagoId = lagoId;
            this.SequentialId = sequentialId;
            this.Number = number;
            this.LagoInvoiceId = lagoInvoiceId;
            this.InvoiceNumber = invoiceNumber;
            this.IssuingDate = issuingDate;
            this.CreditStatus = creditStatus;
            this.RefundStatus = refundStatus;
            this.Reason = reason;
            this.Description = description;
            this.TotalAmountCents = totalAmountCents;
            this.TotalAmountCurrency = totalAmountCurrency;
            this.VatAmountCents = vatAmountCents;
            this.VatAmountCurrency = vatAmountCurrency;
            this.SubTotalVatExcludedAmountCents = subTotalVatExcludedAmountCents;
            this.SubTotalVatExcludedAmountCurrency = subTotalVatExcludedAmountCurrency;
            this.BalanceAmountCents = balanceAmountCents;
            this.BalanceAmountCurrency = balanceAmountCurrency;
            this.CreditAmountCents = creditAmountCents;
            this.CreditAmountCurrency = creditAmountCurrency;
            this.RefundAmountCents = refundAmountCents;
            this.RefundAmountCurrency = refundAmountCurrency;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FileUrl = fileUrl;
            this.Customer = customer;
            this.Items = items;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }

        /// <summary>
        /// Gets or Sets SequentialId
        /// </summary>
        [DataMember(Name="sequential_id", EmitDefaultValue=false)]
        public int SequentialId { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets LagoInvoiceId
        /// </summary>
        [DataMember(Name="lago_invoice_id", EmitDefaultValue=false)]
        public string LagoInvoiceId { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceNumber
        /// </summary>
        [DataMember(Name="invoice_number", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or Sets IssuingDate
        /// </summary>
        [DataMember(Name="issuing_date", EmitDefaultValue=false)]
        public string IssuingDate { get; set; }




        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCents
        /// </summary>
        [DataMember(Name="total_amount_cents", EmitDefaultValue=false)]
        public int TotalAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCurrency
        /// </summary>
        [DataMember(Name="total_amount_currency", EmitDefaultValue=false)]
        public string TotalAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCents
        /// </summary>
        [DataMember(Name="vat_amount_cents", EmitDefaultValue=false)]
        public int VatAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCurrency
        /// </summary>
        [DataMember(Name="vat_amount_currency", EmitDefaultValue=false)]
        public string VatAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets SubTotalVatExcludedAmountCents
        /// </summary>
        [DataMember(Name="sub_total_vat_excluded_amount_cents", EmitDefaultValue=false)]
        public int SubTotalVatExcludedAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets SubTotalVatExcludedAmountCurrency
        /// </summary>
        [DataMember(Name="sub_total_vat_excluded_amount_currency", EmitDefaultValue=false)]
        public string SubTotalVatExcludedAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets BalanceAmountCents
        /// </summary>
        [DataMember(Name="balance_amount_cents", EmitDefaultValue=false)]
        public int BalanceAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets BalanceAmountCurrency
        /// </summary>
        [DataMember(Name="balance_amount_currency", EmitDefaultValue=false)]
        public string BalanceAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountCents
        /// </summary>
        [DataMember(Name="credit_amount_cents", EmitDefaultValue=false)]
        public int CreditAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets CreditAmountCurrency
        /// </summary>
        [DataMember(Name="credit_amount_currency", EmitDefaultValue=false)]
        public string CreditAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets RefundAmountCents
        /// </summary>
        [DataMember(Name="refund_amount_cents", EmitDefaultValue=false)]
        public int RefundAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets RefundAmountCurrency
        /// </summary>
        [DataMember(Name="refund_amount_currency", EmitDefaultValue=false)]
        public string RefundAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FileUrl
        /// </summary>
        [DataMember(Name="file_url", EmitDefaultValue=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public CustomerObject Customer { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<CreditNoteItemObject> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
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
                    (this.CreditStatus != null &&
                    this.CreditStatus.Equals(input.CreditStatus))
                ) && 
                (
                    this.RefundStatus == input.RefundStatus ||
                    (this.RefundStatus != null &&
                    this.RefundStatus.Equals(input.RefundStatus))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TotalAmountCents == input.TotalAmountCents ||
                    (this.TotalAmountCents != null &&
                    this.TotalAmountCents.Equals(input.TotalAmountCents))
                ) && 
                (
                    this.TotalAmountCurrency == input.TotalAmountCurrency ||
                    (this.TotalAmountCurrency != null &&
                    this.TotalAmountCurrency.Equals(input.TotalAmountCurrency))
                ) && 
                (
                    this.VatAmountCents == input.VatAmountCents ||
                    (this.VatAmountCents != null &&
                    this.VatAmountCents.Equals(input.VatAmountCents))
                ) && 
                (
                    this.VatAmountCurrency == input.VatAmountCurrency ||
                    (this.VatAmountCurrency != null &&
                    this.VatAmountCurrency.Equals(input.VatAmountCurrency))
                ) && 
                (
                    this.SubTotalVatExcludedAmountCents == input.SubTotalVatExcludedAmountCents ||
                    (this.SubTotalVatExcludedAmountCents != null &&
                    this.SubTotalVatExcludedAmountCents.Equals(input.SubTotalVatExcludedAmountCents))
                ) && 
                (
                    this.SubTotalVatExcludedAmountCurrency == input.SubTotalVatExcludedAmountCurrency ||
                    (this.SubTotalVatExcludedAmountCurrency != null &&
                    this.SubTotalVatExcludedAmountCurrency.Equals(input.SubTotalVatExcludedAmountCurrency))
                ) && 
                (
                    this.BalanceAmountCents == input.BalanceAmountCents ||
                    (this.BalanceAmountCents != null &&
                    this.BalanceAmountCents.Equals(input.BalanceAmountCents))
                ) && 
                (
                    this.BalanceAmountCurrency == input.BalanceAmountCurrency ||
                    (this.BalanceAmountCurrency != null &&
                    this.BalanceAmountCurrency.Equals(input.BalanceAmountCurrency))
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
                    this.RefundAmountCents == input.RefundAmountCents ||
                    (this.RefundAmountCents != null &&
                    this.RefundAmountCents.Equals(input.RefundAmountCents))
                ) && 
                (
                    this.RefundAmountCurrency == input.RefundAmountCurrency ||
                    (this.RefundAmountCurrency != null &&
                    this.RefundAmountCurrency.Equals(input.RefundAmountCurrency))
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
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
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
                    hashCode = hashCode * 59 + this.LagoId.GetHashCode();
                if (this.SequentialId != null)
                    hashCode = hashCode * 59 + this.SequentialId.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.LagoInvoiceId != null)
                    hashCode = hashCode * 59 + this.LagoInvoiceId.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.IssuingDate != null)
                    hashCode = hashCode * 59 + this.IssuingDate.GetHashCode();
                if (this.CreditStatus != null)
                    hashCode = hashCode * 59 + this.CreditStatus.GetHashCode();
                if (this.RefundStatus != null)
                    hashCode = hashCode * 59 + this.RefundStatus.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TotalAmountCents != null)
                    hashCode = hashCode * 59 + this.TotalAmountCents.GetHashCode();
                if (this.TotalAmountCurrency != null)
                    hashCode = hashCode * 59 + this.TotalAmountCurrency.GetHashCode();
                if (this.VatAmountCents != null)
                    hashCode = hashCode * 59 + this.VatAmountCents.GetHashCode();
                if (this.VatAmountCurrency != null)
                    hashCode = hashCode * 59 + this.VatAmountCurrency.GetHashCode();
                if (this.SubTotalVatExcludedAmountCents != null)
                    hashCode = hashCode * 59 + this.SubTotalVatExcludedAmountCents.GetHashCode();
                if (this.SubTotalVatExcludedAmountCurrency != null)
                    hashCode = hashCode * 59 + this.SubTotalVatExcludedAmountCurrency.GetHashCode();
                if (this.BalanceAmountCents != null)
                    hashCode = hashCode * 59 + this.BalanceAmountCents.GetHashCode();
                if (this.BalanceAmountCurrency != null)
                    hashCode = hashCode * 59 + this.BalanceAmountCurrency.GetHashCode();
                if (this.CreditAmountCents != null)
                    hashCode = hashCode * 59 + this.CreditAmountCents.GetHashCode();
                if (this.CreditAmountCurrency != null)
                    hashCode = hashCode * 59 + this.CreditAmountCurrency.GetHashCode();
                if (this.RefundAmountCents != null)
                    hashCode = hashCode * 59 + this.RefundAmountCents.GetHashCode();
                if (this.RefundAmountCurrency != null)
                    hashCode = hashCode * 59 + this.RefundAmountCurrency.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.FileUrl != null)
                    hashCode = hashCode * 59 + this.FileUrl.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
