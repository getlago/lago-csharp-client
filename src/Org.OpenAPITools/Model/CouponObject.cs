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
    /// CouponObject
    /// </summary>
    [DataContract]
    public partial class CouponObject :  IEquatable<CouponObject>, IValidatableObject
    {
        /// <summary>
        /// Coupon type
        /// </summary>
        /// <value>Coupon type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CouponTypeEnum
        {
            /// <summary>
            /// Enum Fixedamount for value: fixed_amount
            /// </summary>
            [EnumMember(Value = "fixed_amount")]
            Fixedamount = 1,

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
        [DataMember(Name="coupon_type", EmitDefaultValue=false)]
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
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Expiration type
        /// </summary>
        /// <value>Expiration type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExpirationEnum
        {
            /// <summary>
            /// Enum Noexpiration for value: no_expiration
            /// </summary>
            [EnumMember(Value = "no_expiration")]
            Noexpiration = 1,

            /// <summary>
            /// Enum Timelimit for value: time_limit
            /// </summary>
            [EnumMember(Value = "time_limit")]
            Timelimit = 2

        }

        /// <summary>
        /// Expiration type
        /// </summary>
        /// <value>Expiration type</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public ExpirationEnum? Expiration { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="couponType">Coupon type.</param>
        /// <param name="amountCents">amountCents.</param>
        /// <param name="amountCurrency">amountCurrency.</param>
        /// <param name="reusable">reusable.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="percentageRate">percentageRate.</param>
        /// <param name="frequency">Frequency type.</param>
        /// <param name="frequencyDuration">frequencyDuration.</param>
        /// <param name="expirationAt">expirationAt.</param>
        /// <param name="expiration">Expiration type.</param>
        public CouponObject(string lagoId = default(string), string name = default(string), string code = default(string), CouponTypeEnum? couponType = default(CouponTypeEnum?), int amountCents = default(int), string amountCurrency = default(string), bool reusable = default(bool), string createdAt = default(string), decimal percentageRate = default(decimal), FrequencyEnum? frequency = default(FrequencyEnum?), int frequencyDuration = default(int), string expirationAt = default(string), ExpirationEnum? expiration = default(ExpirationEnum?))
        {
            this.LagoId = lagoId;
            this.Name = name;
            this.Code = code;
            this.CouponType = couponType;
            this.AmountCents = amountCents;
            this.AmountCurrency = amountCurrency;
            this.Reusable = reusable;
            this.CreatedAt = createdAt;
            this.PercentageRate = percentageRate;
            this.Frequency = frequency;
            this.FrequencyDuration = frequencyDuration;
            this.ExpirationAt = expirationAt;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }


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
        /// Gets or Sets Reusable
        /// </summary>
        [DataMember(Name="reusable", EmitDefaultValue=false)]
        public bool Reusable { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets PercentageRate
        /// </summary>
        [DataMember(Name="percentage_rate", EmitDefaultValue=false)]
        public decimal PercentageRate { get; set; }


        /// <summary>
        /// Gets or Sets FrequencyDuration
        /// </summary>
        [DataMember(Name="frequency_duration", EmitDefaultValue=false)]
        public int FrequencyDuration { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationAt
        /// </summary>
        [DataMember(Name="expiration_at", EmitDefaultValue=false)]
        public string ExpirationAt { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CouponType: ").Append(CouponType).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  Reusable: ").Append(Reusable).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  PercentageRate: ").Append(PercentageRate).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  FrequencyDuration: ").Append(FrequencyDuration).Append("\n");
            sb.Append("  ExpirationAt: ").Append(ExpirationAt).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(input as CouponObject);
        }

        /// <summary>
        /// Returns true if CouponObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponObject input)
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
                    (this.CouponType != null &&
                    this.CouponType.Equals(input.CouponType))
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
                    this.Reusable == input.Reusable ||
                    (this.Reusable != null &&
                    this.Reusable.Equals(input.Reusable))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.PercentageRate == input.PercentageRate ||
                    (this.PercentageRate != null &&
                    this.PercentageRate.Equals(input.PercentageRate))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.FrequencyDuration == input.FrequencyDuration ||
                    (this.FrequencyDuration != null &&
                    this.FrequencyDuration.Equals(input.FrequencyDuration))
                ) && 
                (
                    this.ExpirationAt == input.ExpirationAt ||
                    (this.ExpirationAt != null &&
                    this.ExpirationAt.Equals(input.ExpirationAt))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CouponType != null)
                    hashCode = hashCode * 59 + this.CouponType.GetHashCode();
                if (this.AmountCents != null)
                    hashCode = hashCode * 59 + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                    hashCode = hashCode * 59 + this.AmountCurrency.GetHashCode();
                if (this.Reusable != null)
                    hashCode = hashCode * 59 + this.Reusable.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.PercentageRate != null)
                    hashCode = hashCode * 59 + this.PercentageRate.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.FrequencyDuration != null)
                    hashCode = hashCode * 59 + this.FrequencyDuration.GetHashCode();
                if (this.ExpirationAt != null)
                    hashCode = hashCode * 59 + this.ExpirationAt.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
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
