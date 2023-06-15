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
    /// InvoiceOneOffInput
    /// </summary>
    [DataContract(Name = "InvoiceOneOffInput")]
    public partial class InvoiceOneOffInput : IEquatable<InvoiceOneOffInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceOneOffInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoiceOneOffInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceOneOffInput" /> class.
        /// </summary>
        /// <param name="invoice">invoice (required).</param>
        public InvoiceOneOffInput(InvoiceOneOffInputInvoice invoice = default(InvoiceOneOffInputInvoice))
        {
            // to ensure "invoice" is required (not null)
            if (invoice == null)
            {
                throw new ArgumentNullException("invoice is a required property for InvoiceOneOffInput and cannot be null");
            }
            this.Invoice = invoice;
        }

        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name = "invoice", IsRequired = true, EmitDefaultValue = true)]
        public InvoiceOneOffInputInvoice Invoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceOneOffInput {\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
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
            return this.Equals(input as InvoiceOneOffInput);
        }

        /// <summary>
        /// Returns true if InvoiceOneOffInput instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceOneOffInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceOneOffInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
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
                if (this.Invoice != null)
                {
                    hashCode = (hashCode * 59) + this.Invoice.GetHashCode();
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
