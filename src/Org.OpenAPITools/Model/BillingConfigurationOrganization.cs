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
    /// BillingConfigurationOrganization
    /// </summary>
    [DataContract(Name = "BillingConfigurationOrganization")]
    public partial class BillingConfigurationOrganization : IEquatable<BillingConfigurationOrganization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingConfigurationOrganization" /> class.
        /// </summary>
        /// <param name="invoiceFooter">invoiceFooter.</param>
        /// <param name="invoiceGracePeriod">invoiceGracePeriod.</param>
        /// <param name="documentLocale">documentLocale.</param>
        /// <param name="vatRate">vatRate.</param>
        public BillingConfigurationOrganization(string invoiceFooter = default(string), int invoiceGracePeriod = default(int), string documentLocale = default(string), decimal vatRate = default(decimal))
        {
            this.InvoiceFooter = invoiceFooter;
            this.InvoiceGracePeriod = invoiceGracePeriod;
            this.DocumentLocale = documentLocale;
            this.VatRate = vatRate;
        }

        /// <summary>
        /// Gets or Sets InvoiceFooter
        /// </summary>
        /// <example>text</example>
        [DataMember(Name = "invoice_footer", EmitDefaultValue = false)]
        public string InvoiceFooter { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceGracePeriod
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "invoice_grace_period", EmitDefaultValue = false)]
        public int InvoiceGracePeriod { get; set; }

        /// <summary>
        /// Gets or Sets DocumentLocale
        /// </summary>
        /// <example>fr</example>
        [DataMember(Name = "document_locale", EmitDefaultValue = false)]
        public string DocumentLocale { get; set; }

        /// <summary>
        /// Gets or Sets VatRate
        /// </summary>
        /// <example>25.0</example>
        [DataMember(Name = "vat_rate", EmitDefaultValue = false)]
        public decimal VatRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingConfigurationOrganization {\n");
            sb.Append("  InvoiceFooter: ").Append(InvoiceFooter).Append("\n");
            sb.Append("  InvoiceGracePeriod: ").Append(InvoiceGracePeriod).Append("\n");
            sb.Append("  DocumentLocale: ").Append(DocumentLocale).Append("\n");
            sb.Append("  VatRate: ").Append(VatRate).Append("\n");
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
            return this.Equals(input as BillingConfigurationOrganization);
        }

        /// <summary>
        /// Returns true if BillingConfigurationOrganization instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingConfigurationOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingConfigurationOrganization input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvoiceFooter == input.InvoiceFooter ||
                    (this.InvoiceFooter != null &&
                    this.InvoiceFooter.Equals(input.InvoiceFooter))
                ) && 
                (
                    this.InvoiceGracePeriod == input.InvoiceGracePeriod ||
                    this.InvoiceGracePeriod.Equals(input.InvoiceGracePeriod)
                ) && 
                (
                    this.DocumentLocale == input.DocumentLocale ||
                    (this.DocumentLocale != null &&
                    this.DocumentLocale.Equals(input.DocumentLocale))
                ) && 
                (
                    this.VatRate == input.VatRate ||
                    this.VatRate.Equals(input.VatRate)
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
                if (this.InvoiceFooter != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceFooter.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvoiceGracePeriod.GetHashCode();
                if (this.DocumentLocale != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentLocale.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VatRate.GetHashCode();
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
