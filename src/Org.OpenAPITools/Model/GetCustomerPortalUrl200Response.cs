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
    /// GetCustomerPortalUrl200Response
    /// </summary>
    [DataContract]
    public partial class GetCustomerPortalUrl200Response :  IEquatable<GetCustomerPortalUrl200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerPortalUrl200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCustomerPortalUrl200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerPortalUrl200Response" /> class.
        /// </summary>
        /// <param name="customer">customer (required).</param>
        public GetCustomerPortalUrl200Response(GetCustomerPortalUrl200ResponseCustomer customer = default(GetCustomerPortalUrl200ResponseCustomer))
        {
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new InvalidDataException("customer is a required property for GetCustomerPortalUrl200Response and cannot be null");
            }
            else
            {
                this.Customer = customer;
            }

        }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=true)]
        public GetCustomerPortalUrl200ResponseCustomer Customer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCustomerPortalUrl200Response {\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
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
            return this.Equals(input as GetCustomerPortalUrl200Response);
        }

        /// <summary>
        /// Returns true if GetCustomerPortalUrl200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCustomerPortalUrl200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCustomerPortalUrl200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
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
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
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
