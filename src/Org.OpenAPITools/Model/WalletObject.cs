/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.0.1
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
    /// WalletObject
    /// </summary>
    [DataContract]
    public partial class WalletObject :  IEquatable<WalletObject>, IValidatableObject
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
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="lagoCustomerId">lagoCustomerId.</param>
        /// <param name="externalCustomerId">externalCustomerId.</param>
        /// <param name="status">Status.</param>
        /// <param name="currency">currency.</param>
        /// <param name="name">name.</param>
        /// <param name="rateAmount">rateAmount.</param>
        /// <param name="creditsBalance">creditsBalance.</param>
        /// <param name="balance">balance.</param>
        /// <param name="consumedCredits">consumedCredits.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="expirationAt">expirationAt.</param>
        /// <param name="lastBalanceSyncAt">lastBalanceSyncAt.</param>
        /// <param name="lastConsumedCreditAt">lastConsumedCreditAt.</param>
        /// <param name="terminatedAt">terminatedAt.</param>
        public WalletObject(string lagoId = default(string), string lagoCustomerId = default(string), string externalCustomerId = default(string), StatusEnum? status = default(StatusEnum?), string currency = default(string), string name = default(string), decimal rateAmount = default(decimal), decimal creditsBalance = default(decimal), decimal balance = default(decimal), decimal consumedCredits = default(decimal), string createdAt = default(string), string expirationAt = default(string), string lastBalanceSyncAt = default(string), string lastConsumedCreditAt = default(string), string terminatedAt = default(string))
        {
            this.LagoId = lagoId;
            this.LagoCustomerId = lagoCustomerId;
            this.ExternalCustomerId = externalCustomerId;
            this.Status = status;
            this.Currency = currency;
            this.Name = name;
            this.RateAmount = rateAmount;
            this.CreditsBalance = creditsBalance;
            this.Balance = balance;
            this.ConsumedCredits = consumedCredits;
            this.CreatedAt = createdAt;
            this.ExpirationAt = expirationAt;
            this.LastBalanceSyncAt = lastBalanceSyncAt;
            this.LastConsumedCreditAt = lastConsumedCreditAt;
            this.TerminatedAt = terminatedAt;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }

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
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RateAmount
        /// </summary>
        [DataMember(Name="rate_amount", EmitDefaultValue=false)]
        public decimal RateAmount { get; set; }

        /// <summary>
        /// Gets or Sets CreditsBalance
        /// </summary>
        [DataMember(Name="credits_balance", EmitDefaultValue=false)]
        public decimal CreditsBalance { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public decimal Balance { get; set; }

        /// <summary>
        /// Gets or Sets ConsumedCredits
        /// </summary>
        [DataMember(Name="consumed_credits", EmitDefaultValue=false)]
        public decimal ConsumedCredits { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationAt
        /// </summary>
        [DataMember(Name="expiration_at", EmitDefaultValue=false)]
        public string ExpirationAt { get; set; }

        /// <summary>
        /// Gets or Sets LastBalanceSyncAt
        /// </summary>
        [DataMember(Name="last_balance_sync_at", EmitDefaultValue=false)]
        public string LastBalanceSyncAt { get; set; }

        /// <summary>
        /// Gets or Sets LastConsumedCreditAt
        /// </summary>
        [DataMember(Name="last_consumed_credit_at", EmitDefaultValue=false)]
        public string LastConsumedCreditAt { get; set; }

        /// <summary>
        /// Gets or Sets TerminatedAt
        /// </summary>
        [DataMember(Name="terminated_at", EmitDefaultValue=false)]
        public string TerminatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  LagoCustomerId: ").Append(LagoCustomerId).Append("\n");
            sb.Append("  ExternalCustomerId: ").Append(ExternalCustomerId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RateAmount: ").Append(RateAmount).Append("\n");
            sb.Append("  CreditsBalance: ").Append(CreditsBalance).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  ConsumedCredits: ").Append(ConsumedCredits).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExpirationAt: ").Append(ExpirationAt).Append("\n");
            sb.Append("  LastBalanceSyncAt: ").Append(LastBalanceSyncAt).Append("\n");
            sb.Append("  LastConsumedCreditAt: ").Append(LastConsumedCreditAt).Append("\n");
            sb.Append("  TerminatedAt: ").Append(TerminatedAt).Append("\n");
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
            return this.Equals(input as WalletObject);
        }

        /// <summary>
        /// Returns true if WalletObject instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletObject input)
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
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RateAmount == input.RateAmount ||
                    (this.RateAmount != null &&
                    this.RateAmount.Equals(input.RateAmount))
                ) && 
                (
                    this.CreditsBalance == input.CreditsBalance ||
                    (this.CreditsBalance != null &&
                    this.CreditsBalance.Equals(input.CreditsBalance))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.ConsumedCredits == input.ConsumedCredits ||
                    (this.ConsumedCredits != null &&
                    this.ConsumedCredits.Equals(input.ConsumedCredits))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExpirationAt == input.ExpirationAt ||
                    (this.ExpirationAt != null &&
                    this.ExpirationAt.Equals(input.ExpirationAt))
                ) && 
                (
                    this.LastBalanceSyncAt == input.LastBalanceSyncAt ||
                    (this.LastBalanceSyncAt != null &&
                    this.LastBalanceSyncAt.Equals(input.LastBalanceSyncAt))
                ) && 
                (
                    this.LastConsumedCreditAt == input.LastConsumedCreditAt ||
                    (this.LastConsumedCreditAt != null &&
                    this.LastConsumedCreditAt.Equals(input.LastConsumedCreditAt))
                ) && 
                (
                    this.TerminatedAt == input.TerminatedAt ||
                    (this.TerminatedAt != null &&
                    this.TerminatedAt.Equals(input.TerminatedAt))
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
                if (this.LagoCustomerId != null)
                    hashCode = hashCode * 59 + this.LagoCustomerId.GetHashCode();
                if (this.ExternalCustomerId != null)
                    hashCode = hashCode * 59 + this.ExternalCustomerId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RateAmount != null)
                    hashCode = hashCode * 59 + this.RateAmount.GetHashCode();
                if (this.CreditsBalance != null)
                    hashCode = hashCode * 59 + this.CreditsBalance.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.ConsumedCredits != null)
                    hashCode = hashCode * 59 + this.ConsumedCredits.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExpirationAt != null)
                    hashCode = hashCode * 59 + this.ExpirationAt.GetHashCode();
                if (this.LastBalanceSyncAt != null)
                    hashCode = hashCode * 59 + this.LastBalanceSyncAt.GetHashCode();
                if (this.LastConsumedCreditAt != null)
                    hashCode = hashCode * 59 + this.LastConsumedCreditAt.GetHashCode();
                if (this.TerminatedAt != null)
                    hashCode = hashCode * 59 + this.TerminatedAt.GetHashCode();
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