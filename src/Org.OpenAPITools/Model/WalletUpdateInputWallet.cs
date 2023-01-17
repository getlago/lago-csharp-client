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
    /// WalletUpdateInputWallet
    /// </summary>
    [DataContract]
    public partial class WalletUpdateInputWallet :  IEquatable<WalletUpdateInputWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletUpdateInputWallet" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="expirationAt">expirationAt.</param>
        public WalletUpdateInputWallet(string name = default(string), string expirationAt = default(string))
        {
            this.Name = name;
            this.ExpirationAt = expirationAt;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            sb.Append("class WalletUpdateInputWallet {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as WalletUpdateInputWallet);
        }

        /// <summary>
        /// Returns true if WalletUpdateInputWallet instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletUpdateInputWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletUpdateInputWallet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExpirationAt != null)
                    hashCode = hashCode * 59 + this.ExpirationAt.GetHashCode();
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
