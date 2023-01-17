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
    /// ChargeUsageObjectCharge
    /// </summary>
    [DataContract]
    public partial class ChargeUsageObjectCharge :  IEquatable<ChargeUsageObjectCharge>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ChargeUsageObjectCharge" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="chargeModel">Charge model type.</param>
        public ChargeUsageObjectCharge(string lagoId = default(string), ChargeModelEnum? chargeModel = default(ChargeModelEnum?))
        {
            this.LagoId = lagoId;
            this.ChargeModel = chargeModel;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeUsageObjectCharge {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  ChargeModel: ").Append(ChargeModel).Append("\n");
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
            return this.Equals(input as ChargeUsageObjectCharge);
        }

        /// <summary>
        /// Returns true if ChargeUsageObjectCharge instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeUsageObjectCharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeUsageObjectCharge input)
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
                    this.ChargeModel == input.ChargeModel ||
                    (this.ChargeModel != null &&
                    this.ChargeModel.Equals(input.ChargeModel))
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
                if (this.ChargeModel != null)
                    hashCode = hashCode * 59 + this.ChargeModel.GetHashCode();
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
