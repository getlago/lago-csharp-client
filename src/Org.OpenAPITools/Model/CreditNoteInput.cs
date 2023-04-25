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
    /// CreditNoteInput
    /// </summary>
    [DataContract]
    public partial class CreditNoteInput :  IEquatable<CreditNoteInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteInput" /> class.
        /// </summary>
        /// <param name="creditNote">creditNote.</param>
        public CreditNoteInput(CreditNoteInputCreditNote creditNote = default(CreditNoteInputCreditNote))
        {
            this.CreditNote = creditNote;
        }

        /// <summary>
        /// Gets or Sets CreditNote
        /// </summary>
        [DataMember(Name="credit_note", EmitDefaultValue=false)]
        public CreditNoteInputCreditNote CreditNote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditNoteInput {\n");
            sb.Append("  CreditNote: ").Append(CreditNote).Append("\n");
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
            return this.Equals(input as CreditNoteInput);
        }

        /// <summary>
        /// Returns true if CreditNoteInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNoteInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNoteInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreditNote == input.CreditNote ||
                    (this.CreditNote != null &&
                    this.CreditNote.Equals(input.CreditNote))
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
                if (this.CreditNote != null)
                    hashCode = hashCode * 59 + this.CreditNote.GetHashCode();
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
