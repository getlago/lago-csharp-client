/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.20.0-beta
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
    /// BatchEventInputEvent
    /// </summary>
    [DataContract]
    public partial class BatchEventInputEvent :  IEquatable<BatchEventInputEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEventInputEvent" /> class.
        /// </summary>
        /// <param name="transactionId">transactionId.</param>
        /// <param name="externalCustomerId">externalCustomerId.</param>
        /// <param name="code">code.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="externalSubscriptionIds">externalSubscriptionIds.</param>
        /// <param name="properties">properties.</param>
        public BatchEventInputEvent(string transactionId = default(string), string externalCustomerId = default(string), string code = default(string), int timestamp = default(int), List<string> externalSubscriptionIds = default(List<string>), Object properties = default(Object))
        {
            this.TransactionId = transactionId;
            this.ExternalCustomerId = externalCustomerId;
            this.Code = code;
            this.Timestamp = timestamp;
            this.ExternalSubscriptionIds = externalSubscriptionIds;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

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
        public int Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets ExternalSubscriptionIds
        /// </summary>
        [DataMember(Name="external_subscription_ids", EmitDefaultValue=false)]
        public List<string> ExternalSubscriptionIds { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Object Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchEventInputEvent {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  ExternalCustomerId: ").Append(ExternalCustomerId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ExternalSubscriptionIds: ").Append(ExternalSubscriptionIds).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as BatchEventInputEvent);
        }

        /// <summary>
        /// Returns true if BatchEventInputEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchEventInputEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchEventInputEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                    this.ExternalSubscriptionIds == input.ExternalSubscriptionIds ||
                    this.ExternalSubscriptionIds != null &&
                    input.ExternalSubscriptionIds != null &&
                    this.ExternalSubscriptionIds.SequenceEqual(input.ExternalSubscriptionIds)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.ExternalCustomerId != null)
                    hashCode = hashCode * 59 + this.ExternalCustomerId.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.ExternalSubscriptionIds != null)
                    hashCode = hashCode * 59 + this.ExternalSubscriptionIds.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
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
