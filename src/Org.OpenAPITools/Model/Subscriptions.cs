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
    /// Subscriptions
    /// </summary>
    [DataContract]
    public partial class Subscriptions :  IEquatable<Subscriptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscriptions" /> class.
        /// </summary>
        /// <param name="subscriptions">subscriptions.</param>
        public Subscriptions(List<SubscriptionObject> subscriptions = default(List<SubscriptionObject>))
        {
            this._Subscriptions = subscriptions;
        }

        /// <summary>
        /// Gets or Sets _Subscriptions
        /// </summary>
        [DataMember(Name="subscriptions", EmitDefaultValue=false)]
        public List<SubscriptionObject> _Subscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscriptions {\n");
            sb.Append("  _Subscriptions: ").Append(_Subscriptions).Append("\n");
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
            return this.Equals(input as Subscriptions);
        }

        /// <summary>
        /// Returns true if Subscriptions instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscriptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscriptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Subscriptions == input._Subscriptions ||
                    this._Subscriptions != null &&
                    input._Subscriptions != null &&
                    this._Subscriptions.SequenceEqual(input._Subscriptions)
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
                if (this._Subscriptions != null)
                    hashCode = hashCode * 59 + this._Subscriptions.GetHashCode();
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
