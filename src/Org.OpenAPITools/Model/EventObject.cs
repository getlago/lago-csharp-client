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
    /// EventObject
    /// </summary>
    [DataContract]
    public partial class EventObject :  IEquatable<EventObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="transactionId">transactionId.</param>
        /// <param name="lagoCustomerId">lagoCustomerId.</param>
        /// <param name="externalCustomerId">externalCustomerId.</param>
        /// <param name="code">code.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="properties">properties.</param>
        /// <param name="lagoSubscriptionId">lagoSubscriptionId.</param>
        /// <param name="externalSubscriptionId">externalSubscriptionId.</param>
        /// <param name="createdAt">createdAt.</param>
        public EventObject(string lagoId = default(string), string transactionId = default(string), string lagoCustomerId = default(string), string externalCustomerId = default(string), string code = default(string), string timestamp = default(string), Object properties = default(Object), string lagoSubscriptionId = default(string), string externalSubscriptionId = default(string), string createdAt = default(string))
        {
            this.LagoId = lagoId;
            this.TransactionId = transactionId;
            this.LagoCustomerId = lagoCustomerId;
            this.ExternalCustomerId = externalCustomerId;
            this.Code = code;
            this.Timestamp = timestamp;
            this.Properties = properties;
            this.LagoSubscriptionId = lagoSubscriptionId;
            this.ExternalSubscriptionId = externalSubscriptionId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

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
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Object Properties { get; set; }

        /// <summary>
        /// Gets or Sets LagoSubscriptionId
        /// </summary>
        [DataMember(Name="lago_subscription_id", EmitDefaultValue=false)]
        public string LagoSubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalSubscriptionId
        /// </summary>
        [DataMember(Name="external_subscription_id", EmitDefaultValue=false)]
        public string ExternalSubscriptionId { get; set; }

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
            sb.Append("class EventObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  LagoCustomerId: ").Append(LagoCustomerId).Append("\n");
            sb.Append("  ExternalCustomerId: ").Append(ExternalCustomerId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  LagoSubscriptionId: ").Append(LagoSubscriptionId).Append("\n");
            sb.Append("  ExternalSubscriptionId: ").Append(ExternalSubscriptionId).Append("\n");
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
            return this.Equals(input as EventObject);
        }

        /// <summary>
        /// Returns true if EventObject instances are equal
        /// </summary>
        /// <param name="input">Instance of EventObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventObject input)
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
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.LagoSubscriptionId == input.LagoSubscriptionId ||
                    (this.LagoSubscriptionId != null &&
                    this.LagoSubscriptionId.Equals(input.LagoSubscriptionId))
                ) && 
                (
                    this.ExternalSubscriptionId == input.ExternalSubscriptionId ||
                    (this.ExternalSubscriptionId != null &&
                    this.ExternalSubscriptionId.Equals(input.ExternalSubscriptionId))
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.LagoCustomerId != null)
                    hashCode = hashCode * 59 + this.LagoCustomerId.GetHashCode();
                if (this.ExternalCustomerId != null)
                    hashCode = hashCode * 59 + this.ExternalCustomerId.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.LagoSubscriptionId != null)
                    hashCode = hashCode * 59 + this.LagoSubscriptionId.GetHashCode();
                if (this.ExternalSubscriptionId != null)
                    hashCode = hashCode * 59 + this.ExternalSubscriptionId.GetHashCode();
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
