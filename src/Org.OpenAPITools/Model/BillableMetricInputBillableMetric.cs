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
    /// BillableMetricInputBillableMetric
    /// </summary>
    [DataContract]
    public partial class BillableMetricInputBillableMetric :  IEquatable<BillableMetricInputBillableMetric>, IValidatableObject
    {
        /// <summary>
        /// Aggregation type
        /// </summary>
        /// <value>Aggregation type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregationTypeEnum
        {
            /// <summary>
            /// Enum Countagg for value: count_agg
            /// </summary>
            [EnumMember(Value = "count_agg")]
            Countagg = 1,

            /// <summary>
            /// Enum Sumagg for value: sum_agg
            /// </summary>
            [EnumMember(Value = "sum_agg")]
            Sumagg = 2,

            /// <summary>
            /// Enum Maxagg for value: max_agg
            /// </summary>
            [EnumMember(Value = "max_agg")]
            Maxagg = 3,

            /// <summary>
            /// Enum Uniquecountagg for value: unique_count_agg
            /// </summary>
            [EnumMember(Value = "unique_count_agg")]
            Uniquecountagg = 4,

            /// <summary>
            /// Enum Recurringcountagg for value: recurring_count_agg
            /// </summary>
            [EnumMember(Value = "recurring_count_agg")]
            Recurringcountagg = 5

        }

        /// <summary>
        /// Aggregation type
        /// </summary>
        /// <value>Aggregation type</value>
        [DataMember(Name="aggregation_type", EmitDefaultValue=false)]
        public AggregationTypeEnum? AggregationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillableMetricInputBillableMetric" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="description">description.</param>
        /// <param name="fieldName">fieldName.</param>
        /// <param name="aggregationType">Aggregation type.</param>
        /// <param name="group">group.</param>
        public BillableMetricInputBillableMetric(string name = default(string), string code = default(string), string description = default(string), string fieldName = default(string), AggregationTypeEnum? aggregationType = default(AggregationTypeEnum?), BillableMetricGroup group = default(BillableMetricGroup))
        {
            this.Name = name;
            this.Code = code;
            this.Description = description;
            this.FieldName = fieldName;
            this.AggregationType = aggregationType;
            this.Group = group;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="field_name", EmitDefaultValue=false)]
        public string FieldName { get; set; }


        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public BillableMetricGroup Group { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillableMetricInputBillableMetric {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  AggregationType: ").Append(AggregationType).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(input as BillableMetricInputBillableMetric);
        }

        /// <summary>
        /// Returns true if BillableMetricInputBillableMetric instances are equal
        /// </summary>
        /// <param name="input">Instance of BillableMetricInputBillableMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillableMetricInputBillableMetric input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.AggregationType == input.AggregationType ||
                    (this.AggregationType != null &&
                    this.AggregationType.Equals(input.AggregationType))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.AggregationType != null)
                    hashCode = hashCode * 59 + this.AggregationType.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
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
