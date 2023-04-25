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
    /// AppliedAddOnObject
    /// </summary>
    [DataContract]
    public partial class AppliedAddOnObject :  IEquatable<AppliedAddOnObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedAddOnObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="lagoAddOnId">lagoAddOnId.</param>
        /// <param name="addOnCode">addOnCode.</param>
        /// <param name="lagoCustomerId">lagoCustomerId.</param>
        /// <param name="externalCustomerId">externalCustomerId.</param>
        /// <param name="amountCents">amountCents.</param>
        /// <param name="amountCurrency">amountCurrency.</param>
        /// <param name="createdAt">createdAt.</param>
        public AppliedAddOnObject(string lagoId = default(string), string lagoAddOnId = default(string), string addOnCode = default(string), string lagoCustomerId = default(string), string externalCustomerId = default(string), int amountCents = default(int), string amountCurrency = default(string), string createdAt = default(string))
        {
            this.LagoId = lagoId;
            this.LagoAddOnId = lagoAddOnId;
            this.AddOnCode = addOnCode;
            this.LagoCustomerId = lagoCustomerId;
            this.ExternalCustomerId = externalCustomerId;
            this.AmountCents = amountCents;
            this.AmountCurrency = amountCurrency;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }

        /// <summary>
        /// Gets or Sets LagoAddOnId
        /// </summary>
        [DataMember(Name="lago_add_on_id", EmitDefaultValue=false)]
        public string LagoAddOnId { get; set; }

        /// <summary>
        /// Gets or Sets AddOnCode
        /// </summary>
        [DataMember(Name="add_on_code", EmitDefaultValue=false)]
        public string AddOnCode { get; set; }

        /// <summary>
        /// Gets or Sets LagoCustomerId
        /// </summary>
        [DataMember(Name="lago_customer_id", EmitDefaultValue=false)]
        public string LagoCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalCustomerId
        /// </summary>
        [DataMember(Name="external_customer_id", EmitDefaultValue=false)]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        [DataMember(Name="amount_cents", EmitDefaultValue=false)]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        [DataMember(Name="amount_currency", EmitDefaultValue=false)]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
                return false;

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
                    (this.AmountCents != null &&
                    this.AmountCents.Equals(input.AmountCents))
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
                    hashCode = hashCode * 59 + this.LagoId.GetHashCode();
                if (this.LagoAddOnId != null)
                    hashCode = hashCode * 59 + this.LagoAddOnId.GetHashCode();
                if (this.AddOnCode != null)
                    hashCode = hashCode * 59 + this.AddOnCode.GetHashCode();
                if (this.LagoCustomerId != null)
                    hashCode = hashCode * 59 + this.LagoCustomerId.GetHashCode();
                if (this.ExternalCustomerId != null)
                    hashCode = hashCode * 59 + this.ExternalCustomerId.GetHashCode();
                if (this.AmountCents != null)
                    hashCode = hashCode * 59 + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                    hashCode = hashCode * 59 + this.AmountCurrency.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
