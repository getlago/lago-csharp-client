/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.21.0-beta
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
    /// Coupon
    /// </summary>
    [DataContract]
    public partial class Coupon :  IEquatable<Coupon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coupon" /> class.
        /// </summary>
        /// <param name="coupon">coupon.</param>
        public Coupon(CouponObject coupon = default(CouponObject))
        {
            this._Coupon = coupon;
        }

        /// <summary>
        /// Gets or Sets _Coupon
        /// </summary>
        [DataMember(Name="coupon", EmitDefaultValue=false)]
        public CouponObject _Coupon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Coupon {\n");
            sb.Append("  _Coupon: ").Append(_Coupon).Append("\n");
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
            return this.Equals(input as Coupon);
        }

        /// <summary>
        /// Returns true if Coupon instances are equal
        /// </summary>
        /// <param name="input">Instance of Coupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Coupon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Coupon == input._Coupon ||
                    (this._Coupon != null &&
                    this._Coupon.Equals(input._Coupon))
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
                if (this._Coupon != null)
                    hashCode = hashCode * 59 + this._Coupon.GetHashCode();
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
