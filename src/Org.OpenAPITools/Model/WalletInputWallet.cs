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
    /// WalletInputWallet
    /// </summary>
    [DataContract(Name = "WalletInput_wallet")]
    public partial class WalletInputWallet : IEquatable<WalletInputWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletInputWallet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletInputWallet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletInputWallet" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="rateAmount">rateAmount (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="paidCredits">paidCredits.</param>
        /// <param name="grantedCredits">grantedCredits.</param>
        /// <param name="externalCustomerId">externalCustomerId (required).</param>
        /// <param name="expirationAt">expirationAt.</param>
        public WalletInputWallet(string name = default(string), decimal rateAmount = default(decimal), string currency = default(string), decimal paidCredits = default(decimal), decimal grantedCredits = default(decimal), string externalCustomerId = default(string), DateTime expirationAt = default(DateTime))
        {
            this.RateAmount = rateAmount;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for WalletInputWallet and cannot be null");
            }
            this.Currency = currency;
            // to ensure "externalCustomerId" is required (not null)
            if (externalCustomerId == null)
            {
                throw new ArgumentNullException("externalCustomerId is a required property for WalletInputWallet and cannot be null");
            }
            this.ExternalCustomerId = externalCustomerId;
            this.Name = name;
            this.PaidCredits = paidCredits;
            this.GrantedCredits = grantedCredits;
            this.ExpirationAt = expirationAt;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Wallet name</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RateAmount
        /// </summary>
        /// <example>2.0</example>
        [DataMember(Name = "rate_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal RateAmount { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets PaidCredits
        /// </summary>
        /// <example>500.0</example>
        [DataMember(Name = "paid_credits", EmitDefaultValue = false)]
        public decimal PaidCredits { get; set; }

        /// <summary>
        /// Gets or Sets GrantedCredits
        /// </summary>
        /// <example>10.0</example>
        [DataMember(Name = "granted_credits", EmitDefaultValue = false)]
        public decimal GrantedCredits { get; set; }

        /// <summary>
        /// Gets or Sets ExternalCustomerId
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "external_customer_id", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalCustomerId { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationAt
        /// </summary>
        /// <example>2022-09-14T23:59:59Z</example>
        [DataMember(Name = "expiration_at", EmitDefaultValue = false)]
        public DateTime ExpirationAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletInputWallet {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RateAmount: ").Append(RateAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaidCredits: ").Append(PaidCredits).Append("\n");
            sb.Append("  GrantedCredits: ").Append(GrantedCredits).Append("\n");
            sb.Append("  ExternalCustomerId: ").Append(ExternalCustomerId).Append("\n");
            sb.Append("  ExpirationAt: ").Append(ExpirationAt).Append("\n");
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
            return this.Equals(input as WalletInputWallet);
        }

        /// <summary>
        /// Returns true if WalletInputWallet instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletInputWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletInputWallet input)
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
                    this.RateAmount == input.RateAmount ||
                    this.RateAmount.Equals(input.RateAmount)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PaidCredits == input.PaidCredits ||
                    this.PaidCredits.Equals(input.PaidCredits)
                ) && 
                (
                    this.GrantedCredits == input.GrantedCredits ||
                    this.GrantedCredits.Equals(input.GrantedCredits)
                ) && 
                (
                    this.ExternalCustomerId == input.ExternalCustomerId ||
                    (this.ExternalCustomerId != null &&
                    this.ExternalCustomerId.Equals(input.ExternalCustomerId))
                ) && 
                (
                    this.ExpirationAt == input.ExpirationAt ||
                    (this.ExpirationAt != null &&
                    this.ExpirationAt.Equals(input.ExpirationAt))
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
                hashCode = (hashCode * 59) + this.RateAmount.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaidCredits.GetHashCode();
                hashCode = (hashCode * 59) + this.GrantedCredits.GetHashCode();
                if (this.ExternalCustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalCustomerId.GetHashCode();
                }
                if (this.ExpirationAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationAt.GetHashCode();
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
