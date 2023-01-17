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
    /// ChargeObject
    /// </summary>
    [DataContract]
    public partial class ChargeObject :  IEquatable<ChargeObject>, IValidatableObject
    {
        /// <summary>
        /// Charge model type
        /// </summary>
        /// <value>Charge model type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChargeModelEnum
        {
            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 1,

            /// <summary>
            /// Enum Graduated for value: graduated
            /// </summary>
            [EnumMember(Value = "graduated")]
            Graduated = 2,

            /// <summary>
            /// Enum Package for value: package
            /// </summary>
            [EnumMember(Value = "package")]
            Package = 3,

            /// <summary>
            /// Enum Percentage for value: percentage
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage = 4,

            /// <summary>
            /// Enum Volume for value: volume
            /// </summary>
            [EnumMember(Value = "volume")]
            Volume = 5

        }

        /// <summary>
        /// Charge model type
        /// </summary>
        /// <value>Charge model type</value>
        [DataMember(Name="charge_model", EmitDefaultValue=false)]
        public ChargeModelEnum? ChargeModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="lagoBillableMetricId">lagoBillableMetricId.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="chargeModel">Charge model type.</param>
        /// <param name="properties">properties.</param>
        /// <param name="groupProperties">groupProperties.</param>
        public ChargeObject(string lagoId = default(string), string lagoBillableMetricId = default(string), string createdAt = default(string), ChargeModelEnum? chargeModel = default(ChargeModelEnum?), Object properties = default(Object), List<GroupPropertiesObject> groupProperties = default(List<GroupPropertiesObject>))
        {
            this.LagoId = lagoId;
            this.LagoBillableMetricId = lagoBillableMetricId;
            this.CreatedAt = createdAt;
            this.ChargeModel = chargeModel;
            this.Properties = properties;
            this.GroupProperties = groupProperties;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }

        /// <summary>
        /// Gets or Sets LagoBillableMetricId
        /// </summary>
        [DataMember(Name="lago_billable_metric_id", EmitDefaultValue=false)]
        public string LagoBillableMetricId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }


        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Object Properties { get; set; }

        /// <summary>
        /// Gets or Sets GroupProperties
        /// </summary>
        [DataMember(Name="group_properties", EmitDefaultValue=false)]
        public List<GroupPropertiesObject> GroupProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  LagoBillableMetricId: ").Append(LagoBillableMetricId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ChargeModel: ").Append(ChargeModel).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  GroupProperties: ").Append(GroupProperties).Append("\n");
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
            return this.Equals(input as ChargeObject);
        }

        /// <summary>
        /// Returns true if ChargeObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LagoId == input.LagoId ||
                    (this.LagoId != null &&
                    this.LagoId.Equals(input.LagoId))
                ) && 
                (
                    this.LagoBillableMetricId == input.LagoBillableMetricId ||
                    (this.LagoBillableMetricId != null &&
                    this.LagoBillableMetricId.Equals(input.LagoBillableMetricId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ChargeModel == input.ChargeModel ||
                    (this.ChargeModel != null &&
                    this.ChargeModel.Equals(input.ChargeModel))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.GroupProperties == input.GroupProperties ||
                    this.GroupProperties != null &&
                    input.GroupProperties != null &&
                    this.GroupProperties.SequenceEqual(input.GroupProperties)
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
                    hashCode = hashCode * 59 + this.LagoId.GetHashCode();
                if (this.LagoBillableMetricId != null)
                    hashCode = hashCode * 59 + this.LagoBillableMetricId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ChargeModel != null)
                    hashCode = hashCode * 59 + this.ChargeModel.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.GroupProperties != null)
                    hashCode = hashCode * 59 + this.GroupProperties.GetHashCode();
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