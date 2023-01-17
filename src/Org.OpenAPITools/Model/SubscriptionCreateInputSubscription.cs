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
    /// SubscriptionCreateInputSubscription
    /// </summary>
    [DataContract]
    public partial class SubscriptionCreateInputSubscription :  IEquatable<SubscriptionCreateInputSubscription>, IValidatableObject
    {
        /// <summary>
        /// Billing time
        /// </summary>
        /// <value>Billing time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BillingTimeEnum
        {
            /// <summary>
            /// Enum Calendar for value: calendar
            /// </summary>
            [EnumMember(Value = "calendar")]
            Calendar = 1,

            /// <summary>
            /// Enum Anniversary for value: anniversary
            /// </summary>
            [EnumMember(Value = "anniversary")]
            Anniversary = 2

        }

        /// <summary>
        /// Billing time
        /// </summary>
        /// <value>Billing time</value>
        [DataMember(Name="billing_time", EmitDefaultValue=false)]
        public BillingTimeEnum? BillingTime { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateInputSubscription" /> class.
        /// </summary>
        /// <param name="externalCustomerId">externalCustomerId.</param>
        /// <param name="planCode">planCode.</param>
        /// <param name="name">name.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="billingTime">Billing time.</param>
        /// <param name="subscriptionAt">subscriptionAt.</param>
        public SubscriptionCreateInputSubscription(string externalCustomerId = default(string), string planCode = default(string), string name = default(string), string externalId = default(string), BillingTimeEnum? billingTime = default(BillingTimeEnum?), string subscriptionAt = default(string))
        {
            this.ExternalCustomerId = externalCustomerId;
            this.PlanCode = planCode;
            this.Name = name;
            this.ExternalId = externalId;
            this.BillingTime = billingTime;
            this.SubscriptionAt = subscriptionAt;
        }

        /// <summary>
        /// Gets or Sets ExternalCustomerId
        /// </summary>
        [DataMember(Name="external_customer_id", EmitDefaultValue=false)]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets PlanCode
        /// </summary>
        [DataMember(Name="plan_code", EmitDefaultValue=false)]
        public string PlanCode { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }


        /// <summary>
        /// Gets or Sets SubscriptionAt
        /// </summary>
        [DataMember(Name="subscription_at", EmitDefaultValue=false)]
        public string SubscriptionAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionCreateInputSubscription {\n");
            sb.Append("  ExternalCustomerId: ").Append(ExternalCustomerId).Append("\n");
            sb.Append("  PlanCode: ").Append(PlanCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  BillingTime: ").Append(BillingTime).Append("\n");
            sb.Append("  SubscriptionAt: ").Append(SubscriptionAt).Append("\n");
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
            return this.Equals(input as SubscriptionCreateInputSubscription);
        }

        /// <summary>
        /// Returns true if SubscriptionCreateInputSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionCreateInputSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionCreateInputSubscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalCustomerId == input.ExternalCustomerId ||
                    (this.ExternalCustomerId != null &&
                    this.ExternalCustomerId.Equals(input.ExternalCustomerId))
                ) && 
                (
                    this.PlanCode == input.PlanCode ||
                    (this.PlanCode != null &&
                    this.PlanCode.Equals(input.PlanCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.BillingTime == input.BillingTime ||
                    (this.BillingTime != null &&
                    this.BillingTime.Equals(input.BillingTime))
                ) && 
                (
                    this.SubscriptionAt == input.SubscriptionAt ||
                    (this.SubscriptionAt != null &&
                    this.SubscriptionAt.Equals(input.SubscriptionAt))
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
                if (this.ExternalCustomerId != null)
                    hashCode = hashCode * 59 + this.ExternalCustomerId.GetHashCode();
                if (this.PlanCode != null)
                    hashCode = hashCode * 59 + this.PlanCode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.BillingTime != null)
                    hashCode = hashCode * 59 + this.BillingTime.GetHashCode();
                if (this.SubscriptionAt != null)
                    hashCode = hashCode * 59 + this.SubscriptionAt.GetHashCode();
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
