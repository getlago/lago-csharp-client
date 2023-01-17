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
    /// FeeObject
    /// </summary>
    [DataContract]
    public partial class FeeObject :  IEquatable<FeeObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="lagoGroupId">lagoGroupId.</param>
        /// <param name="amountCents">amountCents.</param>
        /// <param name="amountCurrency">amountCurrency.</param>
        /// <param name="vatAmountCents">vatAmountCents.</param>
        /// <param name="vatAmountCurrency">vatAmountCurrency.</param>
        /// <param name="units">units.</param>
        /// <param name="eventsCount">eventsCount.</param>
        /// <param name="item">item.</param>
        public FeeObject(string lagoId = default(string), string lagoGroupId = default(string), int amountCents = default(int), string amountCurrency = default(string), int vatAmountCents = default(int), string vatAmountCurrency = default(string), decimal units = default(decimal), int eventsCount = default(int), FeeObjectItem item = default(FeeObjectItem))
        {
            this.LagoId = lagoId;
            this.LagoGroupId = lagoGroupId;
            this.AmountCents = amountCents;
            this.AmountCurrency = amountCurrency;
            this.VatAmountCents = vatAmountCents;
            this.VatAmountCurrency = vatAmountCurrency;
            this.Units = units;
            this.EventsCount = eventsCount;
            this.Item = item;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }

        /// <summary>
        /// Gets or Sets LagoGroupId
        /// </summary>
        [DataMember(Name="lago_group_id", EmitDefaultValue=false)]
        public string LagoGroupId { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        [DataMember(Name="amount_cents", EmitDefaultValue=false)]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        [DataMember(Name="amount_currency", EmitDefaultValue=false)]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCents
        /// </summary>
        [DataMember(Name="vat_amount_cents", EmitDefaultValue=false)]
        public int VatAmountCents { get; set; }

        /// <summary>
        /// Gets or Sets VatAmountCurrency
        /// </summary>
        [DataMember(Name="vat_amount_currency", EmitDefaultValue=false)]
        public string VatAmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public decimal Units { get; set; }

        /// <summary>
        /// Gets or Sets EventsCount
        /// </summary>
        [DataMember(Name="events_count", EmitDefaultValue=false)]
        public int EventsCount { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public FeeObjectItem Item { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  LagoGroupId: ").Append(LagoGroupId).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  VatAmountCents: ").Append(VatAmountCents).Append("\n");
            sb.Append("  VatAmountCurrency: ").Append(VatAmountCurrency).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  EventsCount: ").Append(EventsCount).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
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
            return this.Equals(input as FeeObject);
        }

        /// <summary>
        /// Returns true if FeeObject instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LagoId == input.LagoId ||
                    (this.LagoId != null &&
                    this.LagoId.Equals(input.LagoId))
                ) && 
                (
                    this.LagoGroupId == input.LagoGroupId ||
                    (this.LagoGroupId != null &&
                    this.LagoGroupId.Equals(input.LagoGroupId))
                ) && 
                (
                    this.AmountCents == input.AmountCents ||
                    (this.AmountCents != null &&
                    this.AmountCents.Equals(input.AmountCents))
                ) && 
                (
                    this.AmountCurrency == input.AmountCurrency ||
                    (this.AmountCurrency != null &&
                    this.AmountCurrency.Equals(input.AmountCurrency))
                ) && 
                (
                    this.VatAmountCents == input.VatAmountCents ||
                    (this.VatAmountCents != null &&
                    this.VatAmountCents.Equals(input.VatAmountCents))
                ) && 
                (
                    this.VatAmountCurrency == input.VatAmountCurrency ||
                    (this.VatAmountCurrency != null &&
                    this.VatAmountCurrency.Equals(input.VatAmountCurrency))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.EventsCount == input.EventsCount ||
                    (this.EventsCount != null &&
                    this.EventsCount.Equals(input.EventsCount))
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
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
                if (this.LagoId != null)
                    hashCode = hashCode * 59 + this.LagoId.GetHashCode();
                if (this.LagoGroupId != null)
                    hashCode = hashCode * 59 + this.LagoGroupId.GetHashCode();
                if (this.AmountCents != null)
                    hashCode = hashCode * 59 + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                    hashCode = hashCode * 59 + this.AmountCurrency.GetHashCode();
                if (this.VatAmountCents != null)
                    hashCode = hashCode * 59 + this.VatAmountCents.GetHashCode();
                if (this.VatAmountCurrency != null)
                    hashCode = hashCode * 59 + this.VatAmountCurrency.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.EventsCount != null)
                    hashCode = hashCode * 59 + this.EventsCount.GetHashCode();
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
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