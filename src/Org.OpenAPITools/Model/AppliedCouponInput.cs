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
    /// AppliedCouponInput
    /// </summary>
    [DataContract(Name = "AppliedCouponInput")]
    public partial class AppliedCouponInput : IEquatable<AppliedCouponInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedCouponInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppliedCouponInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedCouponInput" /> class.
        /// </summary>
        /// <param name="appliedCoupon">appliedCoupon (required).</param>
        public AppliedCouponInput(AppliedCouponInputAppliedCoupon appliedCoupon = default(AppliedCouponInputAppliedCoupon))
        {
            // to ensure "appliedCoupon" is required (not null)
            if (appliedCoupon == null)
            {
                throw new ArgumentNullException("appliedCoupon is a required property for AppliedCouponInput and cannot be null");
            }
            this.AppliedCoupon = appliedCoupon;
        }

        /// <summary>
        /// Gets or Sets AppliedCoupon
        /// </summary>
        [DataMember(Name = "applied_coupon", IsRequired = true, EmitDefaultValue = true)]
        public AppliedCouponInputAppliedCoupon AppliedCoupon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppliedCouponInput {\n");
            sb.Append("  AppliedCoupon: ").Append(AppliedCoupon).Append("\n");
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
            return this.Equals(input as AppliedCouponInput);
        }

        /// <summary>
        /// Returns true if AppliedCouponInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AppliedCouponInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppliedCouponInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppliedCoupon == input.AppliedCoupon ||
                    (this.AppliedCoupon != null &&
                    this.AppliedCoupon.Equals(input.AppliedCoupon))
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
                if (this.AppliedCoupon != null)
                {
                    hashCode = (hashCode * 59) + this.AppliedCoupon.GetHashCode();
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
