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
    /// CouponInputCoupon
    /// </summary>
    [DataContract(Name = "CouponInput_coupon")]
    public partial class CouponInputCoupon : IEquatable<CouponInputCoupon>, IValidatableObject
    {
        /// <summary>
        /// Coupon type
        /// </summary>
        /// <value>Coupon type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CouponTypeEnum
        {
            /// <summary>
            /// Enum FixedAmount for value: fixed_amount
            /// </summary>
            [EnumMember(Value = "fixed_amount")]
            FixedAmount = 1,

            /// <summary>
            /// Enum Percentage for value: percentage
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage = 2
        }


        /// <summary>
        /// Coupon type
        /// </summary>
        /// <value>Coupon type</value>
        [DataMember(Name = "coupon_type", EmitDefaultValue = false)]
        public CouponTypeEnum? CouponType { get; set; }
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
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Expiration type
        /// </summary>
        /// <value>Expiration type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExpirationEnum
        {
            /// <summary>
            /// Enum NoExpiration for value: no_expiration
            /// </summary>
            [EnumMember(Value = "no_expiration")]
            NoExpiration = 1,

            /// <summary>
            /// Enum TimeLimit for value: time_limit
            /// </summary>
            [EnumMember(Value = "time_limit")]
            TimeLimit = 2
        }


        /// <summary>
        /// Expiration type
        /// </summary>
        /// <value>Expiration type</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public ExpirationEnum? Expiration { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponInputCoupon" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="couponType">Coupon type.</param>
        /// <param name="amountCents">amountCents.</param>
        /// <param name="amountCurrency">amountCurrency.</param>
        /// <param name="reusable">reusable.</param>
        /// <param name="percentageRate">percentageRate.</param>
        /// <param name="frequency">Frequency type.</param>
        /// <param name="frequencyDuration">frequencyDuration.</param>
        /// <param name="expirationAt">expirationAt.</param>
        /// <param name="expiration">Expiration type.</param>
        /// <param name="appliesTo">appliesTo.</param>
        public CouponInputCoupon(string name = default(string), string code = default(string), CouponTypeEnum? couponType = default(CouponTypeEnum?), int amountCents = default(int), string amountCurrency = default(string), bool reusable = default(bool), decimal percentageRate = default(decimal), FrequencyEnum? frequency = default(FrequencyEnum?), int frequencyDuration = default(int), DateTime expirationAt = default(DateTime), ExpirationEnum? expiration = default(ExpirationEnum?), CouponInputCouponAppliesTo appliesTo = default(CouponInputCouponAppliesTo))
        {
            this.Name = name;
            this.Code = code;
            this.CouponType = couponType;
            this.AmountCents = amountCents;
            this.AmountCurrency = amountCurrency;
            this.Reusable = reusable;
            this.PercentageRate = percentageRate;
            this.Frequency = frequency;
            this.FrequencyDuration = frequencyDuration;
            this.ExpirationAt = expirationAt;
            this.Expiration = expiration;
            this.AppliesTo = appliesTo;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>coupon1</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        /// <example>example_code</example>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        /// <example>1200</example>
        [DataMember(Name = "amount_cents", EmitDefaultValue = false)]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "amount_currency", EmitDefaultValue = false)]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Reusable
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "reusable", EmitDefaultValue = true)]
        public bool Reusable { get; set; }

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
        /// Gets or Sets ExpirationAt
        /// </summary>
        /// <example>2022-09-14T23:59:59Z</example>
        [DataMember(Name = "expiration_at", EmitDefaultValue = false)]
        public DateTime ExpirationAt { get; set; }

        /// <summary>
        /// Gets or Sets AppliesTo
        /// </summary>
        [DataMember(Name = "applies_to", EmitDefaultValue = false)]
        public CouponInputCouponAppliesTo AppliesTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CouponInputCoupon {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CouponType: ").Append(CouponType).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  Reusable: ").Append(Reusable).Append("\n");
            sb.Append("  PercentageRate: ").Append(PercentageRate).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  FrequencyDuration: ").Append(FrequencyDuration).Append("\n");
            sb.Append("  ExpirationAt: ").Append(ExpirationAt).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  AppliesTo: ").Append(AppliesTo).Append("\n");
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
            return this.Equals(input as CouponInputCoupon);
        }

        /// <summary>
        /// Returns true if CouponInputCoupon instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponInputCoupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponInputCoupon input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CouponType == input.CouponType ||
                    this.CouponType.Equals(input.CouponType)
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
                    this.Reusable == input.Reusable ||
                    this.Reusable.Equals(input.Reusable)
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
                    this.ExpirationAt == input.ExpirationAt ||
                    (this.ExpirationAt != null &&
                    this.ExpirationAt.Equals(input.ExpirationAt))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    this.Expiration.Equals(input.Expiration)
                ) && 
                (
                    this.AppliesTo == input.AppliesTo ||
                    (this.AppliesTo != null &&
                    this.AppliesTo.Equals(input.AppliesTo))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CouponType.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Reusable.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentageRate.GetHashCode();
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                hashCode = (hashCode * 59) + this.FrequencyDuration.GetHashCode();
                if (this.ExpirationAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                if (this.AppliesTo != null)
                {
                    hashCode = (hashCode * 59) + this.AppliesTo.GetHashCode();
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
