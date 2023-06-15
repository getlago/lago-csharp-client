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
    /// ChargeUsageObject
    /// </summary>
    [DataContract(Name = "ChargeUsageObject")]
    public partial class ChargeUsageObject : IEquatable<ChargeUsageObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeUsageObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChargeUsageObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeUsageObject" /> class.
        /// </summary>
        /// <param name="units">units (required).</param>
        /// <param name="amountCents">amountCents (required).</param>
        /// <param name="amountCurrency">amountCurrency (required).</param>
        /// <param name="charge">charge (required).</param>
        /// <param name="billableMetric">billableMetric (required).</param>
        /// <param name="groups">groups (required).</param>
        public ChargeUsageObject(decimal units = default(decimal), int amountCents = default(int), string amountCurrency = default(string), ChargeUsageObjectCharge charge = default(ChargeUsageObjectCharge), ChargeUsageObjectBillableMetric billableMetric = default(ChargeUsageObjectBillableMetric), List<ChargeUsageObjectGroupsInner> groups = default(List<ChargeUsageObjectGroupsInner>))
        {
            this.Units = units;
            this.AmountCents = amountCents;
            // to ensure "amountCurrency" is required (not null)
            if (amountCurrency == null)
            {
                throw new ArgumentNullException("amountCurrency is a required property for ChargeUsageObject and cannot be null");
            }
            this.AmountCurrency = amountCurrency;
            // to ensure "charge" is required (not null)
            if (charge == null)
            {
                throw new ArgumentNullException("charge is a required property for ChargeUsageObject and cannot be null");
            }
            this.Charge = charge;
            // to ensure "billableMetric" is required (not null)
            if (billableMetric == null)
            {
                throw new ArgumentNullException("billableMetric is a required property for ChargeUsageObject and cannot be null");
            }
            this.BillableMetric = billableMetric;
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new ArgumentNullException("groups is a required property for ChargeUsageObject and cannot be null");
            }
            this.Groups = groups;
        }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        /// <example>3.0</example>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public decimal Units { get; set; }

        /// <summary>
        /// Gets or Sets AmountCents
        /// </summary>
        /// <example>1200</example>
        [DataMember(Name = "amount_cents", IsRequired = true, EmitDefaultValue = true)]
        public int AmountCents { get; set; }

        /// <summary>
        /// Gets or Sets AmountCurrency
        /// </summary>
        /// <example>EUR</example>
        [DataMember(Name = "amount_currency", IsRequired = true, EmitDefaultValue = true)]
        public string AmountCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Charge
        /// </summary>
        [DataMember(Name = "charge", IsRequired = true, EmitDefaultValue = true)]
        public ChargeUsageObjectCharge Charge { get; set; }

        /// <summary>
        /// Gets or Sets BillableMetric
        /// </summary>
        [DataMember(Name = "billable_metric", IsRequired = true, EmitDefaultValue = true)]
        public ChargeUsageObjectBillableMetric BillableMetric { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", IsRequired = true, EmitDefaultValue = true)]
        public List<ChargeUsageObjectGroupsInner> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeUsageObject {\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  BillableMetric: ").Append(BillableMetric).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as ChargeUsageObject);
        }

        /// <summary>
        /// Returns true if ChargeUsageObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeUsageObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeUsageObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.AmountCents == input.AmountCents ||
                    this.AmountCents.Equals(input.AmountCents)
                ) && 
                (
                    this.AmountCurrency == input.AmountCurrency ||
                    (this.AmountCurrency != null &&
                    this.AmountCurrency.Equals(input.AmountCurrency))
                ) && 
                (
                    this.Charge == input.Charge ||
                    (this.Charge != null &&
                    this.Charge.Equals(input.Charge))
                ) && 
                (
                    this.BillableMetric == input.BillableMetric ||
                    (this.BillableMetric != null &&
                    this.BillableMetric.Equals(input.BillableMetric))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCurrency.GetHashCode();
                }
                if (this.Charge != null)
                {
                    hashCode = (hashCode * 59) + this.Charge.GetHashCode();
                }
                if (this.BillableMetric != null)
                {
                    hashCode = (hashCode * 59) + this.BillableMetric.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
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
