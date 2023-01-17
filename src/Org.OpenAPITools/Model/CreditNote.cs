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
    /// CreditNote
    /// </summary>
    [DataContract]
    public partial class CreditNote :  IEquatable<CreditNote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNote" /> class.
        /// </summary>
        /// <param name="creditNote">creditNote.</param>
        public CreditNote(CreditNoteObject creditNote = default(CreditNoteObject))
        {
            this._CreditNote = creditNote;
        }

        /// <summary>
        /// Gets or Sets _CreditNote
        /// </summary>
        [DataMember(Name="credit_note", EmitDefaultValue=false)]
        public CreditNoteObject _CreditNote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditNote {\n");
            sb.Append("  _CreditNote: ").Append(_CreditNote).Append("\n");
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
            return this.Equals(input as CreditNote);
        }

        /// <summary>
        /// Returns true if CreditNote instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._CreditNote == input._CreditNote ||
                    (this._CreditNote != null &&
                    this._CreditNote.Equals(input._CreditNote))
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
                if (this._CreditNote != null)
                    hashCode = hashCode * 59 + this._CreditNote.GetHashCode();
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
