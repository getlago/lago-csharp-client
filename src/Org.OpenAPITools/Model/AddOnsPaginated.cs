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
    /// AddOnsPaginated
    /// </summary>
    [DataContract(Name = "AddOnsPaginated")]
    public partial class AddOnsPaginated : IEquatable<AddOnsPaginated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnsPaginated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddOnsPaginated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOnsPaginated" /> class.
        /// </summary>
        /// <param name="addOns">addOns (required).</param>
        /// <param name="meta">meta (required).</param>
        public AddOnsPaginated(List<AddOnObject> addOns = default(List<AddOnObject>), PaginationMeta meta = default(PaginationMeta))
        {
            // to ensure "addOns" is required (not null)
            if (addOns == null)
            {
                throw new ArgumentNullException("addOns is a required property for AddOnsPaginated and cannot be null");
            }
            this.AddOns = addOns;
            // to ensure "meta" is required (not null)
            if (meta == null)
            {
                throw new ArgumentNullException("meta is a required property for AddOnsPaginated and cannot be null");
            }
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets AddOns
        /// </summary>
        [DataMember(Name = "add_ons", IsRequired = true, EmitDefaultValue = true)]
        public List<AddOnObject> AddOns { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", IsRequired = true, EmitDefaultValue = true)]
        public PaginationMeta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddOnsPaginated {\n");
            sb.Append("  AddOns: ").Append(AddOns).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as AddOnsPaginated);
        }

        /// <summary>
        /// Returns true if AddOnsPaginated instances are equal
        /// </summary>
        /// <param name="input">Instance of AddOnsPaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddOnsPaginated input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddOns == input.AddOns ||
                    this.AddOns != null &&
                    input.AddOns != null &&
                    this.AddOns.SequenceEqual(input.AddOns)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                if (this.AddOns != null)
                {
                    hashCode = (hashCode * 59) + this.AddOns.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
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
