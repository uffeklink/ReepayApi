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
    /// Coupon
    /// </summary>
    [DataContract]
    public partial class Coupon :  IEquatable<Coupon>
    {
        /// <summary>
        /// Coupon state `active`, `expired`, `deleted` or `generating`
        /// </summary>
        /// <value>Coupon state `active`, `expired`, `deleted` or `generating`</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted,
            
            /// <summary>
            /// Enum Expired for "expired"
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired,
            
            /// <summary>
            /// Enum Generating for "generating"
            /// </summary>
            [EnumMember(Value = "generating")]
            Generating
        }

        /// <summary>
        /// Coupon type either `single` or `set`
        /// </summary>
        /// <value>Coupon type either `single` or `set`</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Single for "single"
            /// </summary>
            [EnumMember(Value = "single")]
            Single,
            
            /// <summary>
            /// Enum Set for "set"
            /// </summary>
            [EnumMember(Value = "set")]
            Set
        }

        /// <summary>
        /// The expire reason if expired. One of `early`, `valid_until` or `max`. Respectively on demand early expire, valid until has passed or max redemptions has been reached.
        /// </summary>
        /// <value>The expire reason if expired. One of `early`, `valid_until` or `max`. Respectively on demand early expire, valid until has passed or max redemptions has been reached.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExpireReasonEnum
        {
            
            /// <summary>
            /// Enum Early for "early"
            /// </summary>
            [EnumMember(Value = "early")]
            Early,
            
            /// <summary>
            /// Enum Validuntil for "valid_until"
            /// </summary>
            [EnumMember(Value = "valid_until")]
            Validuntil,
            
            /// <summary>
            /// Enum Max for "max"
            /// </summary>
            [EnumMember(Value = "max")]
            Max
        }

        /// <summary>
        /// Coupon state `active`, `expired`, `deleted` or `generating`
        /// </summary>
        /// <value>Coupon state `active`, `expired`, `deleted` or `generating`</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Coupon type either `single` or `set`
        /// </summary>
        /// <value>Coupon type either `single` or `set`</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The expire reason if expired. One of `early`, `valid_until` or `max`. Respectively on demand early expire, valid until has passed or max redemptions has been reached.
        /// </summary>
        /// <value>The expire reason if expired. One of `early`, `valid_until` or `max`. Respectively on demand early expire, valid until has passed or max redemptions has been reached.</value>
        [DataMember(Name="expire_reason", EmitDefaultValue=false)]
        public ExpireReasonEnum? ExpireReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Coupon" /> class.
        /// </summary>
        [JsonConstructor]
        protected Coupon() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Coupon" /> class.
        /// </summary>
        /// <param name="Handle">Per account unique handle for the coupon (required).</param>
        /// <param name="Code">The coupon code. Maximum 100 characters. (required).</param>
        /// <param name="Discount">Discount to use for coupon (required).</param>
        /// <param name="Name">Internal name for the coupon. (required).</param>
        /// <param name="State">Coupon state &#x60;active&#x60;, &#x60;expired&#x60;, &#x60;deleted&#x60; or &#x60;generating&#x60; (required).</param>
        /// <param name="Type">Coupon type either &#x60;single&#x60; or &#x60;set&#x60; (required).</param>
        /// <param name="Redemptions">Number of times the coupon has been redeemed (required).</param>
        /// <param name="Expired">Date and time for expire if state expired. In ISO-8601 extended offset date-time format..</param>
        /// <param name="Created">Date when the coupon was created. In ISO-8601 extended offset date-time format. (required).</param>
        /// <param name="AllPlans">Whether all plans are eligible for this coupon. Defaults to false. (default to false).</param>
        /// <param name="EligiblePlans">If not all_plans are set to true, then the set of eligible plan handles must be defined..</param>
        /// <param name="MaxRedemptions">Optional maximum number of times this coupon can be redeemed..</param>
        /// <param name="ValidUntil">Optional date and time until which the coupon is redeemable. In ISO-8601 extended offset date-time format..</param>
        /// <param name="ExpireReason">The expire reason if expired. One of &#x60;early&#x60;, &#x60;valid_until&#x60; or &#x60;max&#x60;. Respectively on demand early expire, valid until has passed or max redemptions has been reached..</param>
        public Coupon(string Handle = null, string Code = null, string Discount = null, string Name = null, StateEnum? State = null, TypeEnum? Type = null, int? Redemptions = null, DateTime? Expired = null, DateTime? Created = null, bool? AllPlans = null, List<string> EligiblePlans = null, int? MaxRedemptions = null, DateTime? ValidUntil = null, ExpireReasonEnum? ExpireReason = null)
        {
            // to ensure "Handle" is required (not null)
            if (Handle == null)
            {
                throw new InvalidDataException("Handle is a required property for Coupon and cannot be null");
            }
            else
            {
                this.Handle = Handle;
            }
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for Coupon and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Discount" is required (not null)
            if (Discount == null)
            {
                throw new InvalidDataException("Discount is a required property for Coupon and cannot be null");
            }
            else
            {
                this.Discount = Discount;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Coupon and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for Coupon and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Coupon and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Redemptions" is required (not null)
            if (Redemptions == null)
            {
                throw new InvalidDataException("Redemptions is a required property for Coupon and cannot be null");
            }
            else
            {
                this.Redemptions = Redemptions;
            }
            // to ensure "Created" is required (not null)
            if (Created == null)
            {
                throw new InvalidDataException("Created is a required property for Coupon and cannot be null");
            }
            else
            {
                this.Created = Created;
            }
            this.Expired = Expired;
            // use default value if no "AllPlans" provided
            if (AllPlans == null)
            {
                this.AllPlans = false;
            }
            else
            {
                this.AllPlans = AllPlans;
            }
            this.EligiblePlans = EligiblePlans;
            this.MaxRedemptions = MaxRedemptions;
            this.ValidUntil = ValidUntil;
            this.ExpireReason = ExpireReason;
        }
        
        /// <summary>
        /// Per account unique handle for the coupon
        /// </summary>
        /// <value>Per account unique handle for the coupon</value>
        [DataMember(Name="handle", EmitDefaultValue=false)]
        public string Handle { get; set; }
        /// <summary>
        /// The coupon code. Maximum 100 characters.
        /// </summary>
        /// <value>The coupon code. Maximum 100 characters.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// Discount to use for coupon
        /// </summary>
        /// <value>Discount to use for coupon</value>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public string Discount { get; set; }
        /// <summary>
        /// Internal name for the coupon.
        /// </summary>
        /// <value>Internal name for the coupon.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Number of times the coupon has been redeemed
        /// </summary>
        /// <value>Number of times the coupon has been redeemed</value>
        [DataMember(Name="redemptions", EmitDefaultValue=false)]
        public int? Redemptions { get; set; }
        /// <summary>
        /// Date and time for expire if state expired. In ISO-8601 extended offset date-time format.
        /// </summary>
        /// <value>Date and time for expire if state expired. In ISO-8601 extended offset date-time format.</value>
        [DataMember(Name="expired", EmitDefaultValue=false)]
        public DateTime? Expired { get; set; }
        /// <summary>
        /// Date when the coupon was created. In ISO-8601 extended offset date-time format.
        /// </summary>
        /// <value>Date when the coupon was created. In ISO-8601 extended offset date-time format.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Whether all plans are eligible for this coupon. Defaults to false.
        /// </summary>
        /// <value>Whether all plans are eligible for this coupon. Defaults to false.</value>
        [DataMember(Name="all_plans", EmitDefaultValue=false)]
        public bool? AllPlans { get; set; }
        /// <summary>
        /// If not all_plans are set to true, then the set of eligible plan handles must be defined.
        /// </summary>
        /// <value>If not all_plans are set to true, then the set of eligible plan handles must be defined.</value>
        [DataMember(Name="eligible_plans", EmitDefaultValue=false)]
        public List<string> EligiblePlans { get; set; }
        /// <summary>
        /// Optional maximum number of times this coupon can be redeemed.
        /// </summary>
        /// <value>Optional maximum number of times this coupon can be redeemed.</value>
        [DataMember(Name="max_redemptions", EmitDefaultValue=false)]
        public int? MaxRedemptions { get; set; }
        /// <summary>
        /// Optional date and time until which the coupon is redeemable. In ISO-8601 extended offset date-time format.
        /// </summary>
        /// <value>Optional date and time until which the coupon is redeemable. In ISO-8601 extended offset date-time format.</value>
        [DataMember(Name="valid_until", EmitDefaultValue=false)]
        public DateTime? ValidUntil { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Coupon {\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Redemptions: ").Append(Redemptions).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  AllPlans: ").Append(AllPlans).Append("\n");
            sb.Append("  EligiblePlans: ").Append(EligiblePlans).Append("\n");
            sb.Append("  MaxRedemptions: ").Append(MaxRedemptions).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  ExpireReason: ").Append(ExpireReason).Append("\n");
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
            return this.Equals(obj as Coupon);
        }

        /// <summary>
        /// Returns true if Coupon instances are equal
        /// </summary>
        /// <param name="other">Instance of Coupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Coupon other)
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
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Redemptions == other.Redemptions ||
                    this.Redemptions != null &&
                    this.Redemptions.Equals(other.Redemptions)
                ) && 
                (
                    this.Expired == other.Expired ||
                    this.Expired != null &&
                    this.Expired.Equals(other.Expired)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.AllPlans == other.AllPlans ||
                    this.AllPlans != null &&
                    this.AllPlans.Equals(other.AllPlans)
                ) && 
                (
                    this.EligiblePlans == other.EligiblePlans ||
                    this.EligiblePlans != null &&
                    this.EligiblePlans.SequenceEqual(other.EligiblePlans)
                ) && 
                (
                    this.MaxRedemptions == other.MaxRedemptions ||
                    this.MaxRedemptions != null &&
                    this.MaxRedemptions.Equals(other.MaxRedemptions)
                ) && 
                (
                    this.ValidUntil == other.ValidUntil ||
                    this.ValidUntil != null &&
                    this.ValidUntil.Equals(other.ValidUntil)
                ) && 
                (
                    this.ExpireReason == other.ExpireReason ||
                    this.ExpireReason != null &&
                    this.ExpireReason.Equals(other.ExpireReason)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Redemptions != null)
                    hash = hash * 59 + this.Redemptions.GetHashCode();
                if (this.Expired != null)
                    hash = hash * 59 + this.Expired.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.AllPlans != null)
                    hash = hash * 59 + this.AllPlans.GetHashCode();
                if (this.EligiblePlans != null)
                    hash = hash * 59 + this.EligiblePlans.GetHashCode();
                if (this.MaxRedemptions != null)
                    hash = hash * 59 + this.MaxRedemptions.GetHashCode();
                if (this.ValidUntil != null)
                    hash = hash * 59 + this.ValidUntil.GetHashCode();
                if (this.ExpireReason != null)
                    hash = hash * 59 + this.ExpireReason.GetHashCode();
                return hash;
            }
        }
    }

}
