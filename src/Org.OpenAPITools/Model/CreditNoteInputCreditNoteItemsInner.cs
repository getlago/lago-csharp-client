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
    /// CreditNoteInputCreditNoteItemsInner
    /// </summary>
    [DataContract(Name = "CreditNoteInput_credit_note_items_inner")]
    public partial class CreditNoteInputCreditNoteItemsInner : IEquatable<CreditNoteInputCreditNoteItemsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteInputCreditNoteItemsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditNoteInputCreditNoteItemsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteInputCreditNoteItemsInner" /> class.
        /// </summary>
        /// <param name="feeId">feeId (required).</param>
        /// <param name="amountCents">amountCents (required).</param>
        public CreditNoteInputCreditNoteItemsInner(Guid feeId = default(Guid), int amountCents = default(int))
        {
            this.FeeId = feeId;
            this.AmountCents = amountCents;
        }

        /// <summary>
        /// Gets or Sets FeeId
        /// </summary>
        /// <example>1a901a90-1a90-1a90-1a90-1a901a901a90</example>
        [DataMember(Name = "fee_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid FeeId { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int AmountCents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditNoteInputCreditNoteItemsInner {\n");
            sb.Append("  FeeId: ").Append(FeeId).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
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
            return this.Equals(input as CreditNoteInputCreditNoteItemsInner);
        }

        /// <summary>
        /// Returns true if CreditNoteInputCreditNoteItemsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNoteInputCreditNoteItemsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNoteInputCreditNoteItemsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FeeId == input.FeeId ||
                    (this.FeeId != null &&
                    this.FeeId.Equals(input.FeeId))
                ) && 
                (
                    this.AmountCents == input.AmountCents ||
                    this.AmountCents.Equals(input.AmountCents)
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
                if (this.FeeId != null)
                {
                    hashCode = (hashCode * 59) + this.FeeId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AmountCents.GetHashCode();
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
