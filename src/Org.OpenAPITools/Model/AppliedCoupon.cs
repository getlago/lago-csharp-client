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
    /// AppliedCoupon
    /// </summary>
    [DataContract]
    public partial class AppliedCoupon :  IEquatable<AppliedCoupon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedCoupon" /> class.
        /// </summary>
        /// <param name="appliedCoupon">appliedCoupon.</param>
        public AppliedCoupon(AppliedCouponObject appliedCoupon = default(AppliedCouponObject))
        {
            this._AppliedCoupon = appliedCoupon;
        }

        /// <summary>
        /// Gets or Sets _AppliedCoupon
        /// </summary>
        [DataMember(Name="applied_coupon", EmitDefaultValue=false)]
        public AppliedCouponObject _AppliedCoupon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppliedCoupon {\n");
            sb.Append("  _AppliedCoupon: ").Append(_AppliedCoupon).Append("\n");
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
            return this.Equals(input as AppliedCoupon);
        }

        /// <summary>
        /// Returns true if AppliedCoupon instances are equal
        /// </summary>
        /// <param name="input">Instance of AppliedCoupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppliedCoupon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._AppliedCoupon == input._AppliedCoupon ||
                    (this._AppliedCoupon != null &&
                    this._AppliedCoupon.Equals(input._AppliedCoupon))
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
                if (this._AppliedCoupon != null)
                    hashCode = hashCode * 59 + this._AppliedCoupon.GetHashCode();
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
