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
    /// PlanObject
    /// </summary>
    [DataContract]
    public partial class PlanObject :  IEquatable<PlanObject>, IValidatableObject
    {
        /// <summary>
        /// Plan interval
        /// </summary>
        /// <value>Plan interval</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalEnum
        {
            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 1,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 2,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 3

        }

        /// <summary>
        /// Plan interval
        /// </summary>
        /// <value>Plan interval</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public IntervalEnum? Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanObject" /> class.
        /// </summary>
        /// <param name="lagoId">lagoId.</param>
        /// <param name="name">name.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="code">code.</param>
        /// <param name="interval">Plan interval.</param>
        /// <param name="description">description.</param>
        /// <param name="amountCents">amountCents.</param>
        /// <param name="amountCurrency">amountCurrency.</param>
        /// <param name="trialPeriod">trialPeriod.</param>
        /// <param name="payInAdvance">payInAdvance.</param>
        /// <param name="billChargesMonthly">billChargesMonthly.</param>
        /// <param name="charges">charges.</param>
        public PlanObject(string lagoId = default(string), string name = default(string), string createdAt = default(string), string code = default(string), IntervalEnum? interval = default(IntervalEnum?), string description = default(string), int amountCents = default(int), string amountCurrency = default(string), decimal trialPeriod = default(decimal), bool payInAdvance = default(bool), bool billChargesMonthly = default(bool), List<ChargeObject> charges = default(List<ChargeObject>))
        {
            this.LagoId = lagoId;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.Code = code;
            this.Interval = interval;
            this.Description = description;
            this.AmountCents = amountCents;
            this.AmountCurrency = amountCurrency;
            this.TrialPeriod = trialPeriod;
            this.PayInAdvance = payInAdvance;
            this.BillChargesMonthly = billChargesMonthly;
            this.Charges = charges;
        }

        /// <summary>
        /// Gets or Sets LagoId
        /// </summary>
        [DataMember(Name="lago_id", EmitDefaultValue=false)]
        public string LagoId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }


        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

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
        /// Gets or Sets TrialPeriod
        /// </summary>
        [DataMember(Name="trial_period", EmitDefaultValue=false)]
        public decimal TrialPeriod { get; set; }

        /// <summary>
        /// Gets or Sets PayInAdvance
        /// </summary>
        [DataMember(Name="pay_in_advance", EmitDefaultValue=false)]
        public bool PayInAdvance { get; set; }

        /// <summary>
        /// Gets or Sets BillChargesMonthly
        /// </summary>
        [DataMember(Name="bill_charges_monthly", EmitDefaultValue=false)]
        public bool BillChargesMonthly { get; set; }

        /// <summary>
        /// Gets or Sets Charges
        /// </summary>
        [DataMember(Name="charges", EmitDefaultValue=false)]
        public List<ChargeObject> Charges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanObject {\n");
            sb.Append("  LagoId: ").Append(LagoId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
            sb.Append("  AmountCurrency: ").Append(AmountCurrency).Append("\n");
            sb.Append("  TrialPeriod: ").Append(TrialPeriod).Append("\n");
            sb.Append("  PayInAdvance: ").Append(PayInAdvance).Append("\n");
            sb.Append("  BillChargesMonthly: ").Append(BillChargesMonthly).Append("\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
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
            return this.Equals(input as PlanObject);
        }

        /// <summary>
        /// Returns true if PlanObject instances are equal
        /// </summary>
        /// <param name="input">Instance of PlanObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanObject input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.TrialPeriod == input.TrialPeriod ||
                    (this.TrialPeriod != null &&
                    this.TrialPeriod.Equals(input.TrialPeriod))
                ) && 
                (
                    this.PayInAdvance == input.PayInAdvance ||
                    (this.PayInAdvance != null &&
                    this.PayInAdvance.Equals(input.PayInAdvance))
                ) && 
                (
                    this.BillChargesMonthly == input.BillChargesMonthly ||
                    (this.BillChargesMonthly != null &&
                    this.BillChargesMonthly.Equals(input.BillChargesMonthly))
                ) && 
                (
                    this.Charges == input.Charges ||
                    this.Charges != null &&
                    input.Charges != null &&
                    this.Charges.SequenceEqual(input.Charges)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AmountCents != null)
                    hashCode = hashCode * 59 + this.AmountCents.GetHashCode();
                if (this.AmountCurrency != null)
                    hashCode = hashCode * 59 + this.AmountCurrency.GetHashCode();
                if (this.TrialPeriod != null)
                    hashCode = hashCode * 59 + this.TrialPeriod.GetHashCode();
                if (this.PayInAdvance != null)
                    hashCode = hashCode * 59 + this.PayInAdvance.GetHashCode();
                if (this.BillChargesMonthly != null)
                    hashCode = hashCode * 59 + this.BillChargesMonthly.GetHashCode();
                if (this.Charges != null)
                    hashCode = hashCode * 59 + this.Charges.GetHashCode();
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
