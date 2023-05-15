/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.32.0-beta
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
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId (required).</param>
        /// <param name="lagoCustomerId">lagoCustomerId (required).</param>
        /// <param name="externalCustomerId">externalCustomerId (required).</param>
        /// <param name="status">Status (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="name">name.</param>
        /// <param name="rateAmount">rateAmount (required).</param>
        /// <param name="creditsBalance">creditsBalance (required).</param>
        /// <param name="balance">balance (required).</param>
        /// <param name="balanceCents">balanceCents (required).</param>
        /// <param name="consumedCredits">consumedCredits (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="expirationAt">expirationAt.</param>
        /// <param name="lastBalanceSyncAt">lastBalanceSyncAt.</param>
        /// <param name="lastConsumedCreditAt">lastConsumedCreditAt.</param>
        /// <param name="terminatedAt">terminatedAt.</param>
        public WalletObject(Guid lagoId = default(Guid), Guid lagoCustomerId = default(Guid), string externalCustomerId = default(string), StatusEnum status = default(StatusEnum), string currency = default(string), string name = default(string), decimal rateAmount = default(decimal), decimal creditsBalance = default(decimal), decimal balance = default(decimal), int balanceCents = default(int), decimal consumedCredits = default(decimal), DateTime createdAt = default(DateTime), DateTime expirationAt = default(DateTime), DateTime lastBalanceSyncAt = default(DateTime), DateTime lastConsumedCreditAt = default(DateTime), DateTime terminatedAt = default(DateTime))
        {
            // to ensure "lagoId" is required (not null)
            if (lagoId == null)
            {
                throw new InvalidDataException("lagoId is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.LagoId = lagoId;
            }

            // to ensure "lagoCustomerId" is required (not null)
            if (lagoCustomerId == null)
            {
                throw new InvalidDataException("lagoCustomerId is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.LagoCustomerId = lagoCustomerId;
            }

            // to ensure "externalCustomerId" is required (not null)
            if (externalCustomerId == null)
            {
                throw new InvalidDataException("externalCustomerId is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.ExternalCustomerId = externalCustomerId;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }

            // to ensure "rateAmount" is required (not null)
            if (rateAmount == null)
            {
                throw new InvalidDataException("rateAmount is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.RateAmount = rateAmount;
            }

            // to ensure "creditsBalance" is required (not null)
            if (creditsBalance == null)
            {
                throw new InvalidDataException("creditsBalance is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.CreditsBalance = creditsBalance;
            }

            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new InvalidDataException("balance is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.Balance = balance;
            }

            // to ensure "balanceCents" is required (not null)
            if (balanceCents == null)
            {
                throw new InvalidDataException("balanceCents is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.BalanceCents = balanceCents;
            }

            // to ensure "consumedCredits" is required (not null)
            if (consumedCredits == null)
            {
                throw new InvalidDataException("consumedCredits is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.ConsumedCredits = consumedCredits;
            }

            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for WalletObject and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }

            this.Name = name;
            this.ExpirationAt = expirationAt;
            this.LastBalanceSyncAt = lastBalanceSyncAt;
            this.LastConsumedCreditAt = lastConsumedCreditAt;
            this.TerminatedAt = terminatedAt;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=true)]
        public Guid LagoId { get; set; }

        /// <summary>
        /// Gets or Sets LagoCustomerId
        /// </summary>
        [DataMember(Name="lago_customer_id", EmitDefaultValue=true)]
        public Guid LagoCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalCustomerId
        /// </summary>
        [DataMember(Name="external_customer_id", EmitDefaultValue=true)]
        public string ExternalCustomerId { get; set; }


        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RateAmount
        /// </summary>
        [DataMember(Name="rate_amount", EmitDefaultValue=true)]
        public decimal RateAmount { get; set; }

        /// <summary>
        /// Gets or Sets CreditsBalance
        /// </summary>
        [DataMember(Name="credits_balance", EmitDefaultValue=true)]
        public decimal CreditsBalance { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=true)]
        [Obsolete]
        public decimal Balance { get; set; }

        /// <summary>
        /// Gets or Sets BalanceCents
        /// </summary>
        [DataMember(Name="balance_cents", EmitDefaultValue=true)]
        public int BalanceCents { get; set; }

        /// <summary>
        /// Gets or Sets ConsumedCredits
        /// </summary>
        [DataMember(Name="consumed_credits", EmitDefaultValue=true)]
        public decimal ConsumedCredits { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationAt
        /// </summary>
        [DataMember(Name="expiration_at", EmitDefaultValue=false)]
        public DateTime ExpirationAt { get; set; }

        /// <summary>
        /// Gets or Sets LastBalanceSyncAt
        /// </summary>
        [DataMember(Name="last_balance_sync_at", EmitDefaultValue=false)]
        public DateTime LastBalanceSyncAt { get; set; }

        /// <summary>
        /// Gets or Sets LastConsumedCreditAt
        /// </summary>
        [DataMember(Name="last_consumed_credit_at", EmitDefaultValue=false)]
        public DateTime LastConsumedCreditAt { get; set; }

        /// <summary>
        /// Gets or Sets TerminatedAt
        /// </summary>
        [DataMember(Name="terminated_at", EmitDefaultValue=false)]
        public DateTime TerminatedAt { get; set; }

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
            sb.Append("  BalanceCents: ").Append(BalanceCents).Append("\n");
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
                    this.BalanceCents == input.BalanceCents ||
                    (this.BalanceCents != null &&
                    this.BalanceCents.Equals(input.BalanceCents))
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
                if (this.BalanceCents != null)
                    hashCode = hashCode * 59 + this.BalanceCents.GetHashCode();
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
