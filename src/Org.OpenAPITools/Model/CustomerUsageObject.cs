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
    /// CustomerUsageObject
    /// </summary>
    [DataContract(Name = "CustomerUsageObject")]
    public partial class CustomerUsageObject : IEquatable<CustomerUsageObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerUsageObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerUsageObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerUsageObject" /> class.
        /// </summary>
        /// <param name="fromDatetime">fromDatetime (required).</param>
        /// <param name="toDatetime">toDatetime (required).</param>
        /// <param name="issuingDate">issuingDate (required).</param>
        /// <param name="amountCents">amountCents (required).</param>
        /// <param name="amountCurrency">amountCurrency (required).</param>
        /// <param name="totalAmountCents">totalAmountCents (required).</param>
        /// <param name="totalAmountCurrency">totalAmountCurrency (required).</param>
        /// <param name="vatAmountCents">vatAmountCents (required).</param>
        /// <param name="vatAmountCurrency">vatAmountCurrency (required).</param>
        /// <param name="chargesUsage">chargesUsage (required).</param>
        public CustomerUsageObject(DateTime fromDatetime = default(DateTime), DateTime toDatetime = default(DateTime), DateTime issuingDate = default(DateTime), int amountCents = default(int), string amountCurrency = default(string), int totalAmountCents = default(int), string totalAmountCurrency = default(string), int vatAmountCents = default(int), string vatAmountCurrency = default(string), List<ChargeUsageObject> chargesUsage = default(List<ChargeUsageObject>))
        {
            this.FromDatetime = fromDatetime;
            this.ToDatetime = toDatetime;
            this.IssuingDate = issuingDate;
            this.AmountCents = amountCents;
            // to ensure "amountCurrency" is required (not null)
            if (amountCurrency == null)
            {
                throw new ArgumentNullException("amountCurrency is a required property for CustomerUsageObject and cannot be null");
            }
            this.AmountCurrency = amountCurrency;
            this.TotalAmountCents = totalAmountCents;
            // to ensure "totalAmountCurrency" is required (not null)
            if (totalAmountCurrency == null)
            {
                throw new ArgumentNullException("totalAmountCurrency is a required property for CustomerUsageObject and cannot be null");
            }
            this.TotalAmountCurrency = totalAmountCurrency;
            this.VatAmountCents = vatAmountCents;
            // to ensure "vatAmountCurrency" is required (not null)
            if (vatAmountCurrency == null)
            {
                throw new ArgumentNullException("vatAmountCurrency is a required property for CustomerUsageObject and cannot be null");
            }
            this.VatAmountCurrency = vatAmountCurrency;
            // to ensure "chargesUsage" is required (not null)
            if (chargesUsage == null)
            {
                throw new ArgumentNullException("chargesUsage is a required property for CustomerUsageObject and cannot be null");
            }
            this.ChargesUsage = chargesUsage;
        }

        /// <summary>
        /// Gets or Sets FromDatetime
        /// </summary>
        /// <example>2022-09-14T00:00Z</example>
        [DataMember(Name = "from_datetime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime FromDatetime { get; set; }

        /// <summary>
        /// Gets or Sets ToDatetime
        /// </summary>
        /// <example>2022-09-14T00:00Z</example>
        [DataMember(Name = "to_datetime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime ToDatetime { get; set; }

        /// <summary>
        /// Gets or Sets IssuingDate
        /// </summary>
        /// <example>2022-09-15T00:00Z</example>
        [DataMember(Name = "issuing_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IssuingDate { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        /// <example>1200</example>
        [DataMember(Name = "amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "amount_currency", IsRequired = true, EmitDefaultValue = true)]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCents
        /// </summary>
        /// <example>1400</example>
        [DataMember(Name = "total_amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int TotalAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "total_amount_currency", IsRequired = true, EmitDefaultValue = true)]
        public string TotalAmountCurrency { get; set; }

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
        /// Gets or Sets ChargesUsage
        /// </summary>
        [DataMember(Name = "charges_usage", IsRequired = true, EmitDefaultValue = true)]
        public List<ChargeUsageObject> ChargesUsage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerUsageObject {\n");
            sb.Append("  FromDatetime: ").Append(FromDatetime).Append("\n");
            sb.Append("  ToDatetime: ").Append(ToDatetime).Append("\n");
            sb.Append("  IssuingDate: ").Append(IssuingDate).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  TotalAmountCents: ").Append(TotalAmountCents).Append("\n");
            sb.Append("  TotalAmountCurrency: ").Append(TotalAmountCurrency).Append("\n");
            sb.Append("  VatAmountCents: ").Append(VatAmountCents).Append("\n");
            sb.Append("  VatAmountCurrency: ").Append(VatAmountCurrency).Append("\n");
            sb.Append("  ChargesUsage: ").Append(ChargesUsage).Append("\n");
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
            return this.Equals(input as CustomerUsageObject);
        }

        /// <summary>
        /// Returns true if CustomerUsageObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerUsageObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerUsageObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FromDatetime == input.FromDatetime ||
                    (this.FromDatetime != null &&
                    this.FromDatetime.Equals(input.FromDatetime))
                ) && 
                (
                    this.ToDatetime == input.ToDatetime ||
                    (this.ToDatetime != null &&
                    this.ToDatetime.Equals(input.ToDatetime))
                ) && 
                (
                    this.IssuingDate == input.IssuingDate ||
                    (this.IssuingDate != null &&
                    this.IssuingDate.Equals(input.IssuingDate))
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
                    this.ChargesUsage == input.ChargesUsage ||
                    this.ChargesUsage != null &&
                    input.ChargesUsage != null &&
                    this.ChargesUsage.SequenceEqual(input.ChargesUsage)
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
                if (this.FromDatetime != null)
                {
                    hashCode = (hashCode * 59) + this.FromDatetime.GetHashCode();
                }
                if (this.ToDatetime != null)
                {
                    hashCode = (hashCode * 59) + this.ToDatetime.GetHashCode();
                }
                if (this.IssuingDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCurrency.GetHashCode();
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
                if (this.ChargesUsage != null)
                {
                    hashCode = (hashCode * 59) + this.ChargesUsage.GetHashCode();
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
