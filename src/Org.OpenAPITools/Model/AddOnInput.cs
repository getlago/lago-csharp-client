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
    /// AddOnInput
    /// </summary>
    [DataContract]
    public partial class AddOnInput :  IEquatable<AddOnInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnInput" /> class.
        /// </summary>
        /// <param name="addOn">addOn.</param>
        public AddOnInput(AddOnInputAddOn addOn = default(AddOnInputAddOn))
        {
            this.AddOn = addOn;
        }

        /// <summary>
        /// Gets or Sets AddOn
        /// </summary>
        [DataMember(Name="add_on", EmitDefaultValue=false)]
        public AddOnInputAddOn AddOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOnInput {\n");
            sb.Append("  AddOn: ").Append(AddOn).Append("\n");
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
            return this.Equals(input as AddOnInput);
        }

        /// <summary>
        /// Returns true if AddOnInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddOnInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddOnInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddOn == input.AddOn ||
                    (this.AddOn != null &&
                    this.AddOn.Equals(input.AddOn))
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
                if (this.AddOn != null)
                    hashCode = hashCode * 59 + this.AddOn.GetHashCode();
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
