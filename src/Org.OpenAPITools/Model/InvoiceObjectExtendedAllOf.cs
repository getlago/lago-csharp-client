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
    /// InvoiceObjectExtendedAllOf
    /// </summary>
    [DataContract(Name = "InvoiceObjectExtended_allOf")]
    public partial class InvoiceObjectExtendedAllOf : IEquatable<InvoiceObjectExtendedAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceObjectExtendedAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceObjectExtendedAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceObjectExtendedAllOf" /> class.
        /// </summary>
        /// <param name="credits">credits (required).</param>
        /// <param name="fees">fees (required).</param>
        /// <param name="subscriptions">subscriptions (required).</param>
        public InvoiceObjectExtendedAllOf(List<CreditObject> credits = default(List<CreditObject>), List<FeeObject> fees = default(List<FeeObject>), List<SubscriptionObject> subscriptions = default(List<SubscriptionObject>))
        {
            // to ensure "credits" is required (not null)
            if (credits == null)
            {
                throw new ArgumentNullException("credits is a required property for InvoiceObjectExtendedAllOf and cannot be null");
            }
            this.Credits = credits;
            // to ensure "fees" is required (not null)
            if (fees == null)
            {
                throw new ArgumentNullException("fees is a required property for InvoiceObjectExtendedAllOf and cannot be null");
            }
            this.Fees = fees;
            // to ensure "subscriptions" is required (not null)
            if (subscriptions == null)
            {
                throw new ArgumentNullException("subscriptions is a required property for InvoiceObjectExtendedAllOf and cannot be null");
            }
            this.Subscriptions = subscriptions;
        }

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
            sb.Append("class InvoiceObjectExtendedAllOf {\n");
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
            return this.Equals(input as InvoiceObjectExtendedAllOf);
        }

        /// <summary>
        /// Returns true if InvoiceObjectExtendedAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceObjectExtendedAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceObjectExtendedAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
