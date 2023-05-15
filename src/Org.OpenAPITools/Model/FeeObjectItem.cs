/*
 * Lago API documentation
 *
 * Lago API allows your application to push customer information and metrics (events) from your application to the billing application.
 *
 * The version of the OpenAPI document: 0.32.0-beta
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
    /// FeeObjectItem
    /// </summary>
    [DataContract]
    public partial class FeeObjectItem :  IEquatable<FeeObjectItem>, IValidatableObject
    {
        /// <summary>
        /// Billing time
        /// </summary>
        /// <value>Billing time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Charge for value: charge
            /// </summary>
            [EnumMember(Value = "charge")]
            Charge = 1,

            /// <summary>
            /// Enum Addon for value: add_on
            /// </summary>
            [EnumMember(Value = "add_on")]
            Addon = 2,

            /// <summary>
            /// Enum Subscription for value: subscription
            /// </summary>
            [EnumMember(Value = "subscription")]
            Subscription = 3,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 4

        }

        /// <summary>
        /// Billing time
        /// </summary>
        /// <value>Billing time</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines ItemType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ItemTypeEnum
        {
            /// <summary>
            /// Enum AddOn for value: AddOn
            /// </summary>
            [EnumMember(Value = "AddOn")]
            AddOn = 1,

            /// <summary>
            /// Enum BillableMetric for value: BillableMetric
            /// </summary>
            [EnumMember(Value = "BillableMetric")]
            BillableMetric = 2,

            /// <summary>
            /// Enum Subscription for value: Subscription
            /// </summary>
            [EnumMember(Value = "Subscription")]
            Subscription = 3,

            /// <summary>
            /// Enum WalletTransaction for value: WalletTransaction
            /// </summary>
            [EnumMember(Value = "WalletTransaction")]
            WalletTransaction = 4

        }

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="item_type", EmitDefaultValue=true)]
        public ItemTypeEnum ItemType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeObjectItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeObjectItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeObjectItem" /> class.
        /// </summary>
        /// <param name="type">Billing time (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="lagoItemId">lagoItemId (required).</param>
        /// <param name="itemType">itemType (required).</param>
        public FeeObjectItem(TypeEnum type = default(TypeEnum), string code = default(string), string name = default(string), Guid lagoItemId = default(Guid), ItemTypeEnum itemType = default(ItemTypeEnum))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for FeeObjectItem and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for FeeObjectItem and cannot be null");
            }
            else
            {
                this.Code = code;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FeeObjectItem and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "lagoItemId" is required (not null)
            if (lagoItemId == null)
            {
                throw new InvalidDataException("lagoItemId is a required property for FeeObjectItem and cannot be null");
            }
            else
            {
                this.LagoItemId = lagoItemId;
            }

            // to ensure "itemType" is required (not null)
            if (itemType == null)
            {
                throw new InvalidDataException("itemType is a required property for FeeObjectItem and cannot be null");
            }
            else
            {
                this.ItemType = itemType;
            }

        }


        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LagoItemId
        /// </summary>
        [DataMember(Name="lago_item_id", EmitDefaultValue=true)]
        public Guid LagoItemId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeObjectItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LagoItemId: ").Append(LagoItemId).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
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
            return this.Equals(input as FeeObjectItem);
        }

        /// <summary>
        /// Returns true if FeeObjectItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeObjectItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeObjectItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LagoItemId == input.LagoItemId ||
                    (this.LagoItemId != null &&
                    this.LagoItemId.Equals(input.LagoItemId))
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LagoItemId != null)
                    hashCode = hashCode * 59 + this.LagoItemId.GetHashCode();
                if (this.ItemType != null)
                    hashCode = hashCode * 59 + this.ItemType.GetHashCode();
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
