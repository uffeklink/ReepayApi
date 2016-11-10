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
    /// CreateDiscount
    /// </summary>
    [DataContract]
    public partial class CreateDiscount :  IEquatable<CreateDiscount>
    {
        /// <summary>
        /// Time unit use for fixed valid period either `days` or `months`
        /// </summary>
        /// <value>Time unit use for fixed valid period either `days` or `months`</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FixedPeriodUnitEnum
        {
            
            /// <summary>
            /// Enum Months for "months"
            /// </summary>
            [EnumMember(Value = "months")]
            Months,
            
            /// <summary>
            /// Enum Days for "days"
            /// </summary>
            [EnumMember(Value = "days")]
            Days
        }

        /// <summary>
        /// Time unit use for fixed valid period either `days` or `months`
        /// </summary>
        /// <value>Time unit use for fixed valid period either `days` or `months`</value>
        [DataMember(Name="fixed_period_unit", EmitDefaultValue=false)]
        public FixedPeriodUnitEnum? FixedPeriodUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscount" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateDiscount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscount" /> class.
        /// </summary>
        /// <param name="Handle">Per account unique handle for the discount (required).</param>
        /// <param name="Name">Name of discount. Will be used as order line text. (required).</param>
        /// <param name="Description">Optional description of discount.</param>
        /// <param name="Amount">Fixed amount discount deducted from order line amounts including VAT.</param>
        /// <param name="Percentage">Percentage discount applied to each applicable order line.</param>
        /// <param name="ApplyTo">Which order lines the discount is applicable to: &#x60;all&#x60;, &#x60;setup_fee&#x60;, &#x60;plan&#x60;, &#x60;additional_cost&#x60;, &#x60;add_on&#x60; and &#x60;ondemand&#x60; (required).</param>
        /// <param name="FixedCount">Apply discount to a fixed number of invoices.</param>
        /// <param name="FixedPeriodUnit">Time unit use for fixed valid period either &#x60;days&#x60; or &#x60;months&#x60;.</param>
        /// <param name="FixedPeriod">Fixed period length e.g. 12 months or 14 days.</param>
        public CreateDiscount(string Handle = null, string Name = null, string Description = null, int? Amount = null, int? Percentage = null, List<string> ApplyTo = null, int? FixedCount = null, FixedPeriodUnitEnum? FixedPeriodUnit = null, int? FixedPeriod = null)
        {
            // to ensure "Handle" is required (not null)
            if (Handle == null)
            {
                throw new InvalidDataException("Handle is a required property for CreateDiscount and cannot be null");
            }
            else
            {
                this.Handle = Handle;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateDiscount and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ApplyTo" is required (not null)
            if (ApplyTo == null)
            {
                throw new InvalidDataException("ApplyTo is a required property for CreateDiscount and cannot be null");
            }
            else
            {
                this.ApplyTo = ApplyTo;
            }
            this.Description = Description;
            this.Amount = Amount;
            this.Percentage = Percentage;
            this.FixedCount = FixedCount;
            this.FixedPeriodUnit = FixedPeriodUnit;
            this.FixedPeriod = FixedPeriod;
        }
        
        /// <summary>
        /// Per account unique handle for the discount
        /// </summary>
        /// <value>Per account unique handle for the discount</value>
        [DataMember(Name="handle", EmitDefaultValue=false)]
        public string Handle { get; set; }
        /// <summary>
        /// Name of discount. Will be used as order line text.
        /// </summary>
        /// <value>Name of discount. Will be used as order line text.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Optional description of discount
        /// </summary>
        /// <value>Optional description of discount</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Fixed amount discount deducted from order line amounts including VAT
        /// </summary>
        /// <value>Fixed amount discount deducted from order line amounts including VAT</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }
        /// <summary>
        /// Percentage discount applied to each applicable order line
        /// </summary>
        /// <value>Percentage discount applied to each applicable order line</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public int? Percentage { get; set; }
        /// <summary>
        /// Which order lines the discount is applicable to: &#x60;all&#x60;, &#x60;setup_fee&#x60;, &#x60;plan&#x60;, &#x60;additional_cost&#x60;, &#x60;add_on&#x60; and &#x60;ondemand&#x60;
        /// </summary>
        /// <value>Which order lines the discount is applicable to: &#x60;all&#x60;, &#x60;setup_fee&#x60;, &#x60;plan&#x60;, &#x60;additional_cost&#x60;, &#x60;add_on&#x60; and &#x60;ondemand&#x60;</value>
        [DataMember(Name="apply_to", EmitDefaultValue=false)]
        public List<string> ApplyTo { get; set; }
        /// <summary>
        /// Apply discount to a fixed number of invoices
        /// </summary>
        /// <value>Apply discount to a fixed number of invoices</value>
        [DataMember(Name="fixed_count", EmitDefaultValue=false)]
        public int? FixedCount { get; set; }
        /// <summary>
        /// Fixed period length e.g. 12 months or 14 days
        /// </summary>
        /// <value>Fixed period length e.g. 12 months or 14 days</value>
        [DataMember(Name="fixed_period", EmitDefaultValue=false)]
        public int? FixedPeriod { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDiscount {\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  ApplyTo: ").Append(ApplyTo).Append("\n");
            sb.Append("  FixedCount: ").Append(FixedCount).Append("\n");
            sb.Append("  FixedPeriodUnit: ").Append(FixedPeriodUnit).Append("\n");
            sb.Append("  FixedPeriod: ").Append(FixedPeriod).Append("\n");
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
            return this.Equals(obj as CreateDiscount);
        }

        /// <summary>
        /// Returns true if CreateDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Handle == other.Handle ||
                    this.Handle != null &&
                    this.Handle.Equals(other.Handle)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
                ) && 
                (
                    this.ApplyTo == other.ApplyTo ||
                    this.ApplyTo != null &&
                    this.ApplyTo.SequenceEqual(other.ApplyTo)
                ) && 
                (
                    this.FixedCount == other.FixedCount ||
                    this.FixedCount != null &&
                    this.FixedCount.Equals(other.FixedCount)
                ) && 
                (
                    this.FixedPeriodUnit == other.FixedPeriodUnit ||
                    this.FixedPeriodUnit != null &&
                    this.FixedPeriodUnit.Equals(other.FixedPeriodUnit)
                ) && 
                (
                    this.FixedPeriod == other.FixedPeriod ||
                    this.FixedPeriod != null &&
                    this.FixedPeriod.Equals(other.FixedPeriod)
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
                if (this.Handle != null)
                    hash = hash * 59 + this.Handle.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                if (this.ApplyTo != null)
                    hash = hash * 59 + this.ApplyTo.GetHashCode();
                if (this.FixedCount != null)
                    hash = hash * 59 + this.FixedCount.GetHashCode();
                if (this.FixedPeriodUnit != null)
                    hash = hash * 59 + this.FixedPeriodUnit.GetHashCode();
                if (this.FixedPeriod != null)
                    hash = hash * 59 + this.FixedPeriod.GetHashCode();
                return hash;
            }
        }
    }

}