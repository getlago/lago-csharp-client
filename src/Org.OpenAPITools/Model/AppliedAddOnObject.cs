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
    /// AppliedAddOnObject
    /// </summary>
    [DataContract(Name = "AppliedAddOnObject")]
    public partial class AppliedAddOnObject : IEquatable<AppliedAddOnObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedAddOnObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppliedAddOnObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedAddOnObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId (required).</param>
        /// <param name="lagoAddOnId">lagoAddOnId (required).</param>
        /// <param name="addOnCode">addOnCode (required).</param>
        /// <param name="lagoCustomerId">lagoCustomerId (required).</param>
        /// <param name="externalCustomerId">externalCustomerId (required).</param>
        /// <param name="amountCents">amountCents (required).</param>
        /// <param name="amountCurrency">amountCurrency (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public AppliedAddOnObject(Guid lagoId = default(Guid), Guid lagoAddOnId = default(Guid), string addOnCode = default(string), Guid lagoCustomerId = default(Guid), string externalCustomerId = default(string), int amountCents = default(int), string amountCurrency = default(string), DateTime createdAt = default(DateTime))
        {
            this.LagoId = lagoId;
            this.LagoAddOnId = lagoAddOnId;
            // to ensure "addOnCode" is required (not null)
            if (addOnCode == null)
            {
                throw new ArgumentNullException("addOnCode is a required property for AppliedAddOnObject and cannot be null");
            }
            this.AddOnCode = addOnCode;
            this.LagoCustomerId = lagoCustomerId;
            // to ensure "externalCustomerId" is required (not null)
            if (externalCustomerId == null)
            {
                throw new ArgumentNullException("externalCustomerId is a required property for AppliedAddOnObject and cannot be null");
            }
            this.ExternalCustomerId = externalCustomerId;
            this.AmountCents = amountCents;
            // to ensure "amountCurrency" is required (not null)
            if (amountCurrency == null)
            {
                throw new ArgumentNullException("amountCurrency is a required property for AppliedAddOnObject and cannot be null");
            }
            this.AmountCurrency = amountCurrency;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoId { get; set; }

        /// <summary>
        /// Gets or Sets LagoAddOnId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_add_on_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoAddOnId { get; set; }

        /// <summary>
        /// Gets or Sets AddOnCode
        /// </summary>
        /// <example>code</example>
        [DataMember(Name = "add_on_code", IsRequired = true, EmitDefaultValue = true)]
        public string AddOnCode { get; set; }

        /// <summary>
        /// Gets or Sets LagoCustomerId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_customer_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalCustomerId
        /// </summary>
        /// <example>1234567</example>
        [DataMember(Name = "external_customer_id", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalCustomerId { get; set; }

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
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppliedAddOnObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  LagoAddOnId: ").Append(LagoAddOnId).Append("\n");
            sb.Append("  AddOnCode: ").Append(AddOnCode).Append("\n");
            sb.Append("  LagoCustomerId: ").Append(LagoCustomerId).Append("\n");
            sb.Append("  ExternalCustomerId: ").Append(ExternalCustomerId).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as AppliedAddOnObject);
        }

        /// <summary>
        /// Returns true if AppliedAddOnObject instances are equal
        /// </summary>
        /// <param name="input">Instance of AppliedAddOnObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppliedAddOnObject input)
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
                    this.LagoAddOnId == input.LagoAddOnId ||
                    (this.LagoAddOnId != null &&
                    this.LagoAddOnId.Equals(input.LagoAddOnId))
                ) && 
                (
                    this.AddOnCode == input.AddOnCode ||
                    (this.AddOnCode != null &&
                    this.AddOnCode.Equals(input.AddOnCode))
                ) && 
                (
                    this.LagoCustomerId == input.LagoCustomerId ||
                    (this.LagoCustomerId != null &&
                    this.LagoCustomerId.Equals(input.LagoCustomerId))
                ) && 
                (
                    this.ExternalCustomerId == input.ExternalCustomerId ||
                    (this.ExternalCustomerId != null &&
                    this.ExternalCustomerId.Equals(input.ExternalCustomerId))
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.LagoAddOnId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoAddOnId.GetHashCode();
                }
                if (this.AddOnCode != null)
                {
                    hashCode = (hashCode * 59) + this.AddOnCode.GetHashCode();
                }
                if (this.LagoCustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoCustomerId.GetHashCode();
                }
                if (this.ExternalCustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalCustomerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCurrency.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
