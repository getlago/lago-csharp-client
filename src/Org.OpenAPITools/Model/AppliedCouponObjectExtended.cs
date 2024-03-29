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
    /// AppliedCouponObjectExtended
    /// </summary>
    [DataContract(Name = "AppliedCouponObjectExtended")]
    public partial class AppliedCouponObjectExtended : IEquatable<AppliedCouponObjectExtended>, IValidatableObject
    {
        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Terminated for value: terminated
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated = 2
        }


        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Frequency type
        /// </summary>
        /// <value>Frequency type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            /// <summary>
            /// Enum Once for value: once
            /// </summary>
            [EnumMember(Value = "once")]
            Once = 1,

            /// <summary>
            /// Enum Recurring for value: recurring
            /// </summary>
            [EnumMember(Value = "recurring")]
            Recurring = 2
        }


        /// <summary>
        /// Frequency type
        /// </summary>
        /// <value>Frequency type</value>
        [DataMember(Name = "frequency", IsRequired = true, EmitDefaultValue = true)]
        public FrequencyEnum Frequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedCouponObjectExtended" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppliedCouponObjectExtended() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedCouponObjectExtended" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId (required).</param>
        /// <param name="lagoCouponId">lagoCouponId (required).</param>
        /// <param name="couponCode">couponCode (required).</param>
        /// <param name="lagoCustomerId">lagoCustomerId (required).</param>
        /// <param name="externalCustomerId">externalCustomerId (required).</param>
        /// <param name="status">Status (required).</param>
        /// <param name="amountCents">amountCents (required).</param>
        /// <param name="amountCentsRemaining">amountCentsRemaining.</param>
        /// <param name="amountCurrency">amountCurrency (required).</param>
        /// <param name="percentageRate">percentageRate.</param>
        /// <param name="frequency">Frequency type (required).</param>
        /// <param name="frequencyDuration">frequencyDuration.</param>
        /// <param name="frequencyDurationRemaining">frequencyDurationRemaining.</param>
        /// <param name="expirationAt">expirationAt.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="terminatedAt">terminatedAt.</param>
        /// <param name="credits">credits (required).</param>
        public AppliedCouponObjectExtended(Guid lagoId = default(Guid), Guid lagoCouponId = default(Guid), string couponCode = default(string), Guid lagoCustomerId = default(Guid), string externalCustomerId = default(string), StatusEnum status = default(StatusEnum), int amountCents = default(int), int amountCentsRemaining = default(int), string amountCurrency = default(string), decimal percentageRate = default(decimal), FrequencyEnum frequency = default(FrequencyEnum), int frequencyDuration = default(int), int frequencyDurationRemaining = default(int), DateTime expirationAt = default(DateTime), DateTime createdAt = default(DateTime), DateTime terminatedAt = default(DateTime), List<CreditObject> credits = default(List<CreditObject>))
        {
            this.LagoId = lagoId;
            this.LagoCouponId = lagoCouponId;
            // to ensure "couponCode" is required (not null)
            if (couponCode == null)
            {
                throw new ArgumentNullException("couponCode is a required property for AppliedCouponObjectExtended and cannot be null");
            }
            this.CouponCode = couponCode;
            this.LagoCustomerId = lagoCustomerId;
            // to ensure "externalCustomerId" is required (not null)
            if (externalCustomerId == null)
            {
                throw new ArgumentNullException("externalCustomerId is a required property for AppliedCouponObjectExtended and cannot be null");
            }
            this.ExternalCustomerId = externalCustomerId;
            this.Status = status;
            this.AmountCents = amountCents;
            // to ensure "amountCurrency" is required (not null)
            if (amountCurrency == null)
            {
                throw new ArgumentNullException("amountCurrency is a required property for AppliedCouponObjectExtended and cannot be null");
            }
            this.AmountCurrency = amountCurrency;
            this.Frequency = frequency;
            this.CreatedAt = createdAt;
            // to ensure "credits" is required (not null)
            if (credits == null)
            {
                throw new ArgumentNullException("credits is a required property for AppliedCouponObjectExtended and cannot be null");
            }
            this.Credits = credits;
            this.AmountCentsRemaining = amountCentsRemaining;
            this.PercentageRate = percentageRate;
            this.FrequencyDuration = frequencyDuration;
            this.FrequencyDurationRemaining = frequencyDurationRemaining;
            this.ExpirationAt = expirationAt;
            this.TerminatedAt = terminatedAt;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoId { get; set; }

        /// <summary>
        /// Gets or Sets LagoCouponId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_coupon_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoCouponId { get; set; }

        /// <summary>
        /// Gets or Sets CouponCode
        /// </summary>
        /// <example>example_code</example>
        [DataMember(Name = "coupon_code", IsRequired = true, EmitDefaultValue = true)]
        public string CouponCode { get; set; }

        /// <summary>
        /// Gets or Sets LagoCustomerId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_customer_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid LagoCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalCustomerId
        /// </summary>
        /// <example>123456</example>
        [DataMember(Name = "external_customer_id", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        /// <example>1200</example>
        [DataMember(Name = "amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCentsRemaining
        /// </summary>
        /// <example>800</example>
        [DataMember(Name = "amount_cents_remaining", EmitDefaultValue = false)]
        public int AmountCentsRemaining { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "amount_currency", IsRequired = true, EmitDefaultValue = true)]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets PercentageRate
        /// </summary>
        /// <example>25.0</example>
        [DataMember(Name = "percentage_rate", EmitDefaultValue = false)]
        public decimal PercentageRate { get; set; }

        /// <summary>
        /// Gets or Sets FrequencyDuration
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "frequency_duration", EmitDefaultValue = false)]
        public int FrequencyDuration { get; set; }

        /// <summary>
        /// Gets or Sets FrequencyDurationRemaining
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "frequency_duration_remaining", EmitDefaultValue = false)]
        public int FrequencyDurationRemaining { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationAt
        /// </summary>
        /// <example>2022-09-14T23:59:59Z</example>
        [DataMember(Name = "expiration_at", EmitDefaultValue = false)]
        public DateTime ExpirationAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets TerminatedAt
        /// </summary>
        /// <example>2022-09-14T16:35:31Z</example>
        [DataMember(Name = "terminated_at", EmitDefaultValue = false)]
        public DateTime TerminatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name = "credits", IsRequired = true, EmitDefaultValue = true)]
        public List<CreditObject> Credits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppliedCouponObjectExtended {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  LagoCouponId: ").Append(LagoCouponId).Append("\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
            sb.Append("  LagoCustomerId: ").Append(LagoCustomerId).Append("\n");
            sb.Append("  ExternalCustomerId: ").Append(ExternalCustomerId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCentsRemaining: ").Append(AmountCentsRemaining).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  PercentageRate: ").Append(PercentageRate).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  FrequencyDuration: ").Append(FrequencyDuration).Append("\n");
            sb.Append("  FrequencyDurationRemaining: ").Append(FrequencyDurationRemaining).Append("\n");
            sb.Append("  ExpirationAt: ").Append(ExpirationAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  TerminatedAt: ").Append(TerminatedAt).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
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
            return this.Equals(input as AppliedCouponObjectExtended);
        }

        /// <summary>
        /// Returns true if AppliedCouponObjectExtended instances are equal
        /// </summary>
        /// <param name="input">Instance of AppliedCouponObjectExtended to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppliedCouponObjectExtended input)
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
                    this.LagoCouponId == input.LagoCouponId ||
                    (this.LagoCouponId != null &&
                    this.LagoCouponId.Equals(input.LagoCouponId))
                ) && 
                (
                    this.CouponCode == input.CouponCode ||
                    (this.CouponCode != null &&
                    this.CouponCode.Equals(input.CouponCode))
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.AmountCents == input.AmountCents ||
                    this.AmountCents.Equals(input.AmountCents)
                ) && 
                (
                    this.AmountCentsRemaining == input.AmountCentsRemaining ||
                    this.AmountCentsRemaining.Equals(input.AmountCentsRemaining)
                ) && 
                (
                    this.AmountCurrency == input.AmountCurrency ||
                    (this.AmountCurrency != null &&
                    this.AmountCurrency.Equals(input.AmountCurrency))
                ) && 
                (
                    this.PercentageRate == input.PercentageRate ||
                    this.PercentageRate.Equals(input.PercentageRate)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && 
                (
                    this.FrequencyDuration == input.FrequencyDuration ||
                    this.FrequencyDuration.Equals(input.FrequencyDuration)
                ) && 
                (
                    this.FrequencyDurationRemaining == input.FrequencyDurationRemaining ||
                    this.FrequencyDurationRemaining.Equals(input.FrequencyDurationRemaining)
                ) && 
                (
                    this.ExpirationAt == input.ExpirationAt ||
                    (this.ExpirationAt != null &&
                    this.ExpirationAt.Equals(input.ExpirationAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.TerminatedAt == input.TerminatedAt ||
                    (this.TerminatedAt != null &&
                    this.TerminatedAt.Equals(input.TerminatedAt))
                ) && 
                (
                    this.Credits == input.Credits ||
                    this.Credits != null &&
                    input.Credits != null &&
                    this.Credits.SequenceEqual(input.Credits)
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
                if (this.LagoCouponId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoCouponId.GetHashCode();
                }
                if (this.CouponCode != null)
                {
                    hashCode = (hashCode * 59) + this.CouponCode.GetHashCode();
                }
                if (this.LagoCustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.LagoCustomerId.GetHashCode();
                }
                if (this.ExternalCustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalCustomerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountCents.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountCentsRemaining.GetHashCode();
                if (this.AmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PercentageRate.GetHashCode();
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                hashCode = (hashCode * 59) + this.FrequencyDuration.GetHashCode();
                hashCode = (hashCode * 59) + this.FrequencyDurationRemaining.GetHashCode();
                if (this.ExpirationAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.TerminatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.TerminatedAt.GetHashCode();
                }
                if (this.Credits != null)
                {
                    hashCode = (hashCode * 59) + this.Credits.GetHashCode();
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
