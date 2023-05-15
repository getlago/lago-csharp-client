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
    /// WalletsPaginated
    /// </summary>
    [DataContract]
    public partial class WalletsPaginated :  IEquatable<WalletsPaginated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletsPaginated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletsPaginated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletsPaginated" /> class.
        /// </summary>
        /// <param name="wallets">wallets (required).</param>
        /// <param name="meta">meta (required).</param>
        public WalletsPaginated(List<WalletObject> wallets = default(List<WalletObject>), PaginationMeta meta = default(PaginationMeta))
        {
            // to ensure "wallets" is required (not null)
            if (wallets == null)
            {
                throw new InvalidDataException("wallets is a required property for WalletsPaginated and cannot be null");
            }
            else
            {
                this.Wallets = wallets;
            }

            // to ensure "meta" is required (not null)
            if (meta == null)
            {
                throw new InvalidDataException("meta is a required property for WalletsPaginated and cannot be null");
            }
            else
            {
                this.Meta = meta;
            }

        }

        /// <summary>
        /// Gets or Sets Wallets
        /// </summary>
        [DataMember(Name="wallets", EmitDefaultValue=true)]
        public List<WalletObject> Wallets { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=true)]
        public PaginationMeta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletsPaginated {\n");
            sb.Append("  Wallets: ").Append(Wallets).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as WalletsPaginated);
        }

        /// <summary>
        /// Returns true if WalletsPaginated instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletsPaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletsPaginated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Wallets == input.Wallets ||
                    this.Wallets != null &&
                    input.Wallets != null &&
                    this.Wallets.SequenceEqual(input.Wallets)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                if (this.Wallets != null)
                    hashCode = hashCode * 59 + this.Wallets.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
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
