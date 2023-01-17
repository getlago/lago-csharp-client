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
    /// BillableMetric
    /// </summary>
    [DataContract]
    public partial class BillableMetric :  IEquatable<BillableMetric>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillableMetric" /> class.
        /// </summary>
        /// <param name="billableMetric">billableMetric.</param>
        public BillableMetric(BillableMetricObject billableMetric = default(BillableMetricObject))
        {
            this._BillableMetric = billableMetric;
        }

        /// <summary>
        /// Gets or Sets _BillableMetric
        /// </summary>
        [DataMember(Name="billable_metric", EmitDefaultValue=false)]
        public BillableMetricObject _BillableMetric { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillableMetric {\n");
            sb.Append("  _BillableMetric: ").Append(_BillableMetric).Append("\n");
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
            return this.Equals(input as BillableMetric);
        }

        /// <summary>
        /// Returns true if BillableMetric instances are equal
        /// </summary>
        /// <param name="input">Instance of BillableMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillableMetric input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._BillableMetric == input._BillableMetric ||
                    (this._BillableMetric != null &&
                    this._BillableMetric.Equals(input._BillableMetric))
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
                if (this._BillableMetric != null)
                    hashCode = hashCode * 59 + this._BillableMetric.GetHashCode();
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
