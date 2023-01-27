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
    /// CustomerInputCustomer
    /// </summary>
    [DataContract]
    public partial class CustomerInputCustomer :  IEquatable<CustomerInputCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInputCustomer" /> class.
        /// </summary>
        /// <param name="externalId">externalId.</param>
        /// <param name="name">name.</param>
        /// <param name="country">country.</param>
        /// <param name="addressLine1">addressLine1.</param>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="state">state.</param>
        /// <param name="zipode">zipode.</param>
        /// <param name="email">email.</param>
        /// <param name="city">city.</param>
        /// <param name="url">url.</param>
        /// <param name="phone">phone.</param>
        /// <param name="lagoUrl">lagoUrl.</param>
        /// <param name="legalName">legalName.</param>
        /// <param name="legalNumber">legalNumber.</param>
        /// <param name="currency">currency.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="billingConfiguration">billingConfiguration.</param>
        public CustomerInputCustomer(string externalId = default(string), string name = default(string), string country = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string state = default(string), string zipode = default(string), string email = default(string), string city = default(string), string url = default(string), string phone = default(string), string lagoUrl = default(string), string legalName = default(string), string legalNumber = default(string), string currency = default(string), string timezone = default(string), BillingConfigurationCustomer billingConfiguration = default(BillingConfigurationCustomer))
        {
            this.ExternalId = externalId;
            this.Name = name;
            this.Country = country;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.State = state;
            this.Zipode = zipode;
            this.Email = email;
            this.City = city;
            this.Url = url;
            this.Phone = phone;
            this.LagoUrl = lagoUrl;
            this.LegalName = legalName;
            this.LegalNumber = legalNumber;
            this.Currency = currency;
            this.Timezone = timezone;
            this.BillingConfiguration = billingConfiguration;
        }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name="address_line1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="address_line2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zipode
        /// </summary>
        [DataMember(Name="zipode", EmitDefaultValue=false)]
        public string Zipode { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets LagoUrl
        /// </summary>
        [DataMember(Name="lago_url", EmitDefaultValue=false)]
        public string LagoUrl { get; set; }

        /// <summary>
        /// Gets or Sets LegalName
        /// </summary>
        [DataMember(Name="legal_name", EmitDefaultValue=false)]
        public string LegalName { get; set; }

        /// <summary>
        /// Gets or Sets LegalNumber
        /// </summary>
        [DataMember(Name="legal_number", EmitDefaultValue=false)]
        public string LegalNumber { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets BillingConfiguration
        /// </summary>
        [DataMember(Name="billing_configuration", EmitDefaultValue=false)]
        public BillingConfigurationCustomer BillingConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerInputCustomer {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zipode: ").Append(Zipode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  LagoUrl: ").Append(LagoUrl).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  LegalNumber: ").Append(LegalNumber).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  BillingConfiguration: ").Append(BillingConfiguration).Append("\n");
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
            return this.Equals(input as CustomerInputCustomer);
        }

        /// <summary>
        /// Returns true if CustomerInputCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerInputCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerInputCustomer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Zipode == input.Zipode ||
                    (this.Zipode != null &&
                    this.Zipode.Equals(input.Zipode))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.LagoUrl == input.LagoUrl ||
                    (this.LagoUrl != null &&
                    this.LagoUrl.Equals(input.LagoUrl))
                ) && 
                (
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.LegalNumber == input.LegalNumber ||
                    (this.LegalNumber != null &&
                    this.LegalNumber.Equals(input.LegalNumber))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.BillingConfiguration == input.BillingConfiguration ||
                    (this.BillingConfiguration != null &&
                    this.BillingConfiguration.Equals(input.BillingConfiguration))
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Zipode != null)
                    hashCode = hashCode * 59 + this.Zipode.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.LagoUrl != null)
                    hashCode = hashCode * 59 + this.LagoUrl.GetHashCode();
                if (this.LegalName != null)
                    hashCode = hashCode * 59 + this.LegalName.GetHashCode();
                if (this.LegalNumber != null)
                    hashCode = hashCode * 59 + this.LegalNumber.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.BillingConfiguration != null)
                    hashCode = hashCode * 59 + this.BillingConfiguration.GetHashCode();
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
