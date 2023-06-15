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
    /// PlanInput
    /// </summary>
    [DataContract(Name = "PlanInput")]
    public partial class PlanInput : IEquatable<PlanInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlanInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanInput" /> class.
        /// </summary>
        /// <param name="plan">plan (required).</param>
        public PlanInput(PlanInputPlan plan = default(PlanInputPlan))
        {
            // to ensure "plan" is required (not null)
            if (plan == null)
            {
                throw new ArgumentNullException("plan is a required property for PlanInput and cannot be null");
            }
            this.Plan = plan;
        }

        /// <summary>
        /// Gets or Sets Plan
        /// </summary>
        [DataMember(Name = "plan", IsRequired = true, EmitDefaultValue = true)]
        public PlanInputPlan Plan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlanInput {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
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
            return this.Equals(input as PlanInput);
        }

        /// <summary>
        /// Returns true if PlanInput instances are equal
        /// </summary>
        /// <param name="input">Instance of PlanInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Plan == input.Plan ||
                    (this.Plan != null &&
                    this.Plan.Equals(input.Plan))
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
                if (this.Plan != null)
                {
                    hashCode = (hashCode * 59) + this.Plan.GetHashCode();
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
