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
    /// ChargeUsageObjectBillableMetric
    /// </summary>
    [DataContract(Name = "ChargeUsageObject_billable_metric")]
    public partial class ChargeUsageObjectBillableMetric : IEquatable<ChargeUsageObjectBillableMetric>, IValidatableObject
    {
        /// <summary>
        /// Aggregation type
        /// </summary>
        /// <value>Aggregation type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregationTypeEnum
        {
            /// <summary>
            /// Enum CountAgg for value: count_agg
            /// </summary>
            [EnumMember(Value = "count_agg")]
            CountAgg = 1,

            /// <summary>
            /// Enum SumAgg for value: sum_agg
            /// </summary>
            [EnumMember(Value = "sum_agg")]
            SumAgg = 2,

            /// <summary>
            /// Enum MaxAgg for value: max_agg
            /// </summary>
            [EnumMember(Value = "max_agg")]
            MaxAgg = 3,

            /// <summary>
            /// Enum UniqueCountAgg for value: unique_count_agg
            /// </summary>
            [EnumMember(Value = "unique_count_agg")]
            UniqueCountAgg = 4,

            /// <summary>
            /// Enum RecurringCountAgg for value: recurring_count_agg
            /// </summary>
            [EnumMember(Value = "recurring_count_agg")]
            RecurringCountAgg = 5
        }


        /// <summary>
        /// Aggregation type
        /// </summary>
        /// <value>Aggregation type</value>
        [DataMember(Name = "aggregation_type", EmitDefaultValue = false)]
        public AggregationTypeEnum? AggregationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeUsageObjectBillableMetric" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="aggregationType">Aggregation type.</param>
        public ChargeUsageObjectBillableMetric(Guid lagoId = default(Guid), string name = default(string), string code = default(string), AggregationTypeEnum? aggregationType = default(AggregationTypeEnum?))
        {
            this.LagoId = lagoId;
            this.Name = name;
            this.Code = code;
            this.AggregationType = aggregationType;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "lago_id", EmitDefaultValue = false)]
        public Guid LagoId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Example name</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        /// <example>code</example>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeUsageObjectBillableMetric {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  AggregationType: ").Append(AggregationType).Append("\n");
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
            return this.Equals(input as ChargeUsageObjectBillableMetric);
        }

        /// <summary>
        /// Returns true if ChargeUsageObjectBillableMetric instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeUsageObjectBillableMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeUsageObjectBillableMetric input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LagoId == input.LagoId ||
                    (this.LagoId != null &&
                    this.LagoId.Equals(input.LagoId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.AggregationType == input.AggregationType ||
                    this.AggregationType.Equals(input.AggregationType)
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
                {
                    hashCode = (hashCode * 59) + this.LagoId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AggregationType.GetHashCode();
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
