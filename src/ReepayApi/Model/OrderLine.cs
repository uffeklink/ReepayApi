/* 
 * Reepay API
 *
 * REST API to manage Reepay resources
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ReepayApi.Model
{
    /// <summary>
    /// OrderLine
    /// </summary>
    [DataContract]
    public partial class OrderLine :  IEquatable<OrderLine>
    {
        /// <summary>
        /// Order line origin, one of the following: `plan`, `ondemand`, `additional_cost`, `credit`, `discount`
        /// </summary>
        /// <value>Order line origin, one of the following: `plan`, `ondemand`, `additional_cost`, `credit`, `discount`</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OriginEnum
        {
            
            /// <summary>
            /// Enum Plan for "plan"
            /// </summary>
            [EnumMember(Value = "plan")]
            Plan,
            
            /// <summary>
            /// Enum Ondemand for "ondemand"
            /// </summary>
            [EnumMember(Value = "ondemand")]
            Ondemand,
            
            /// <summary>
            /// Enum Additionalcost for "additional_cost"
            /// </summary>
            [EnumMember(Value = "additional_cost")]
            Additionalcost,
            
            /// <summary>
            /// Enum Credit for "credit"
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit,
            
            /// <summary>
            /// Enum Discount for "discount"
            /// </summary>
            [EnumMember(Value = "discount")]
            Discount
        }

        /// <summary>
        /// Order line origin, one of the following: `plan`, `ondemand`, `additional_cost`, `credit`, `discount`
        /// </summary>
        /// <value>Order line origin, one of the following: `plan`, `ondemand`, `additional_cost`, `credit`, `discount`</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum? Origin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLine" /> class.
        /// </summary>
        [JsonConstructor]
        protected OrderLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLine" /> class.
        /// </summary>
        /// <param name="Timestamp">Timestamp from order line origin, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. (required).</param>
        /// <param name="DiscountedAmount">Order line amount after potential discount has been deducted.</param>
        /// <param name="PeriodFrom">The start of billing period if the order line is a plan order line for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        /// <param name="PeriodTo">The end of billing period if the order line is a plan order line for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        /// <param name="DiscountPercentage">The discount percentage for discount order lines that has a percentage discount.</param>
        /// <param name="DiscountedOrderLine">For discount order lines a reference to the order line for which the order line is a discount.</param>
        public OrderLine(DateTime? Timestamp = null, int? DiscountedAmount = null, DateTime? PeriodFrom = null, DateTime? PeriodTo = null, int? DiscountPercentage = null, string DiscountedOrderLine = null)
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for OrderLine and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            this.DiscountedAmount = DiscountedAmount;
            this.PeriodFrom = PeriodFrom;
            this.PeriodTo = PeriodTo;
            this.DiscountPercentage = DiscountPercentage;
            this.DiscountedOrderLine = DiscountedOrderLine;
        }
        
        /// <summary>
        /// Per account unique order line id
        /// </summary>
        /// <value>Per account unique order line id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Order line text
        /// </summary>
        /// <value>Order line text</value>
        [DataMember(Name="ordertext", EmitDefaultValue=false)]
        public string Ordertext { get; private set; }
        /// <summary>
        /// Order line total amount including vat
        /// </summary>
        /// <value>Order line total amount including vat</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; private set; }
        /// <summary>
        /// Order line vat percent
        /// </summary>
        /// <value>Order line vat percent</value>
        [DataMember(Name="vat", EmitDefaultValue=false)]
        public float? Vat { get; private set; }
        /// <summary>
        /// Order line quantity
        /// </summary>
        /// <value>Order line quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; private set; }
        /// <summary>
        /// Timestamp from order line origin, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>Timestamp from order line origin, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Order line amount after potential discount has been deducted
        /// </summary>
        /// <value>Order line amount after potential discount has been deducted</value>
        [DataMember(Name="discounted_amount", EmitDefaultValue=false)]
        public int? DiscountedAmount { get; set; }
        /// <summary>
        /// Order line total vat amount
        /// </summary>
        /// <value>Order line total vat amount</value>
        [DataMember(Name="amount_vat", EmitDefaultValue=false)]
        public int? AmountVat { get; private set; }
        /// <summary>
        /// Order line total amount without vat
        /// </summary>
        /// <value>Order line total amount without vat</value>
        [DataMember(Name="amount_ex_vat", EmitDefaultValue=false)]
        public int? AmountExVat { get; private set; }
        /// <summary>
        /// Order line unit amount including vat
        /// </summary>
        /// <value>Order line unit amount including vat</value>
        [DataMember(Name="unit_amount", EmitDefaultValue=false)]
        public int? UnitAmount { get; private set; }
        /// <summary>
        /// Order line unit vat amount
        /// </summary>
        /// <value>Order line unit vat amount</value>
        [DataMember(Name="unit_amount_vat", EmitDefaultValue=false)]
        public int? UnitAmountVat { get; private set; }
        /// <summary>
        /// Order line unit amount without vat
        /// </summary>
        /// <value>Order line unit amount without vat</value>
        [DataMember(Name="unit_amount_ex_vat", EmitDefaultValue=false)]
        public int? UnitAmountExVat { get; private set; }
        /// <summary>
        /// Whether the amount was defined including VAT. E.g. plan amount defined including VAT.
        /// </summary>
        /// <value>Whether the amount was defined including VAT. E.g. plan amount defined including VAT.</value>
        [DataMember(Name="amount_defined_incl_vat", EmitDefaultValue=false)]
        public bool? AmountDefinedInclVat { get; private set; }
        /// <summary>
        /// Handle for additional cost, credit, plan or subscription discount in the case one of those are the origin
        /// </summary>
        /// <value>Handle for additional cost, credit, plan or subscription discount in the case one of those are the origin</value>
        [DataMember(Name="origin_handle", EmitDefaultValue=false)]
        public string OriginHandle { get; private set; }
        /// <summary>
        /// The start of billing period if the order line is a plan order line for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>The start of billing period if the order line is a plan order line for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="period_from", EmitDefaultValue=false)]
        public DateTime? PeriodFrom { get; set; }
        /// <summary>
        /// The end of billing period if the order line is a plan order line for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>The end of billing period if the order line is a plan order line for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="period_to", EmitDefaultValue=false)]
        public DateTime? PeriodTo { get; set; }
        /// <summary>
        /// The discount percentage for discount order lines that has a percentage discount
        /// </summary>
        /// <value>The discount percentage for discount order lines that has a percentage discount</value>
        [DataMember(Name="discount_percentage", EmitDefaultValue=false)]
        public int? DiscountPercentage { get; set; }
        /// <summary>
        /// For discount order lines a reference to the order line for which the order line is a discount
        /// </summary>
        /// <value>For discount order lines a reference to the order line for which the order line is a discount</value>
        [DataMember(Name="discounted_order_line", EmitDefaultValue=false)]
        public string DiscountedOrderLine { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ordertext: ").Append(Ordertext).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  DiscountedAmount: ").Append(DiscountedAmount).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
            sb.Append("  AmountExVat: ").Append(AmountExVat).Append("\n");
            sb.Append("  UnitAmount: ").Append(UnitAmount).Append("\n");
            sb.Append("  UnitAmountVat: ").Append(UnitAmountVat).Append("\n");
            sb.Append("  UnitAmountExVat: ").Append(UnitAmountExVat).Append("\n");
            sb.Append("  AmountDefinedInclVat: ").Append(AmountDefinedInclVat).Append("\n");
            sb.Append("  OriginHandle: ").Append(OriginHandle).Append("\n");
            sb.Append("  PeriodFrom: ").Append(PeriodFrom).Append("\n");
            sb.Append("  PeriodTo: ").Append(PeriodTo).Append("\n");
            sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
            sb.Append("  DiscountedOrderLine: ").Append(DiscountedOrderLine).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderLine);
        }

        /// <summary>
        /// Returns true if OrderLine instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLine other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Ordertext == other.Ordertext ||
                    this.Ordertext != null &&
                    this.Ordertext.Equals(other.Ordertext)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Vat == other.Vat ||
                    this.Vat != null &&
                    this.Vat.Equals(other.Vat)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.DiscountedAmount == other.DiscountedAmount ||
                    this.DiscountedAmount != null &&
                    this.DiscountedAmount.Equals(other.DiscountedAmount)
                ) && 
                (
                    this.AmountVat == other.AmountVat ||
                    this.AmountVat != null &&
                    this.AmountVat.Equals(other.AmountVat)
                ) && 
                (
                    this.AmountExVat == other.AmountExVat ||
                    this.AmountExVat != null &&
                    this.AmountExVat.Equals(other.AmountExVat)
                ) && 
                (
                    this.UnitAmount == other.UnitAmount ||
                    this.UnitAmount != null &&
                    this.UnitAmount.Equals(other.UnitAmount)
                ) && 
                (
                    this.UnitAmountVat == other.UnitAmountVat ||
                    this.UnitAmountVat != null &&
                    this.UnitAmountVat.Equals(other.UnitAmountVat)
                ) && 
                (
                    this.UnitAmountExVat == other.UnitAmountExVat ||
                    this.UnitAmountExVat != null &&
                    this.UnitAmountExVat.Equals(other.UnitAmountExVat)
                ) && 
                (
                    this.AmountDefinedInclVat == other.AmountDefinedInclVat ||
                    this.AmountDefinedInclVat != null &&
                    this.AmountDefinedInclVat.Equals(other.AmountDefinedInclVat)
                ) && 
                (
                    this.OriginHandle == other.OriginHandle ||
                    this.OriginHandle != null &&
                    this.OriginHandle.Equals(other.OriginHandle)
                ) && 
                (
                    this.PeriodFrom == other.PeriodFrom ||
                    this.PeriodFrom != null &&
                    this.PeriodFrom.Equals(other.PeriodFrom)
                ) && 
                (
                    this.PeriodTo == other.PeriodTo ||
                    this.PeriodTo != null &&
                    this.PeriodTo.Equals(other.PeriodTo)
                ) && 
                (
                    this.DiscountPercentage == other.DiscountPercentage ||
                    this.DiscountPercentage != null &&
                    this.DiscountPercentage.Equals(other.DiscountPercentage)
                ) && 
                (
                    this.DiscountedOrderLine == other.DiscountedOrderLine ||
                    this.DiscountedOrderLine != null &&
                    this.DiscountedOrderLine.Equals(other.DiscountedOrderLine)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Ordertext != null)
                    hash = hash * 59 + this.Ordertext.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Vat != null)
                    hash = hash * 59 + this.Vat.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.DiscountedAmount != null)
                    hash = hash * 59 + this.DiscountedAmount.GetHashCode();
                if (this.AmountVat != null)
                    hash = hash * 59 + this.AmountVat.GetHashCode();
                if (this.AmountExVat != null)
                    hash = hash * 59 + this.AmountExVat.GetHashCode();
                if (this.UnitAmount != null)
                    hash = hash * 59 + this.UnitAmount.GetHashCode();
                if (this.UnitAmountVat != null)
                    hash = hash * 59 + this.UnitAmountVat.GetHashCode();
                if (this.UnitAmountExVat != null)
                    hash = hash * 59 + this.UnitAmountExVat.GetHashCode();
                if (this.AmountDefinedInclVat != null)
                    hash = hash * 59 + this.AmountDefinedInclVat.GetHashCode();
                if (this.OriginHandle != null)
                    hash = hash * 59 + this.OriginHandle.GetHashCode();
                if (this.PeriodFrom != null)
                    hash = hash * 59 + this.PeriodFrom.GetHashCode();
                if (this.PeriodTo != null)
                    hash = hash * 59 + this.PeriodTo.GetHashCode();
                if (this.DiscountPercentage != null)
                    hash = hash * 59 + this.DiscountPercentage.GetHashCode();
                if (this.DiscountedOrderLine != null)
                    hash = hash * 59 + this.DiscountedOrderLine.GetHashCode();
                return hash;
            }
        }
    }

}
