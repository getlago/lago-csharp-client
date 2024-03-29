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
    /// OrganizationInput
    /// </summary>
    [DataContract(Name = "OrganizationInput")]
    public partial class OrganizationInput : IEquatable<OrganizationInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInput" /> class.
        /// </summary>
        /// <param name="organization">organization (required).</param>
        public OrganizationInput(OrganizationInputOrganization organization = default(OrganizationInputOrganization))
        {
            // to ensure "organization" is required (not null)
            if (organization == null)
            {
                throw new ArgumentNullException("organization is a required property for OrganizationInput and cannot be null");
            }
            this.Organization = organization;
        }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", IsRequired = true, EmitDefaultValue = true)]
        public OrganizationInputOrganization Organization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationInput {\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
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
            return this.Equals(input as OrganizationInput);
        }

        /// <summary>
        /// Returns true if OrganizationInput instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
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
                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
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
