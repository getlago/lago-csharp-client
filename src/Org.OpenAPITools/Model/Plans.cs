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
    /// Plans
    /// </summary>
    [DataContract]
    public partial class Plans :  IEquatable<Plans>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plans" /> class.
        /// </summary>
        /// <param name="plans">plans.</param>
        public Plans(List<PlanObject> plans = default(List<PlanObject>))
        {
            this._Plans = plans;
        }

        /// <summary>
        /// Gets or Sets _Plans
        /// </summary>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public List<PlanObject> _Plans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Plans {\n");
            sb.Append("  _Plans: ").Append(_Plans).Append("\n");
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
            return this.Equals(input as Plans);
        }

        /// <summary>
        /// Returns true if Plans instances are equal
        /// </summary>
        /// <param name="input">Instance of Plans to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Plans input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Plans == input._Plans ||
                    this._Plans != null &&
                    input._Plans != null &&
                    this._Plans.SequenceEqual(input._Plans)
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
                if (this._Plans != null)
                    hashCode = hashCode * 59 + this._Plans.GetHashCode();
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
