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
    /// UpdateSubscriptionPlan
    /// </summary>
    [DataContract]
    public partial class UpdateSubscriptionPlan :  IEquatable<UpdateSubscriptionPlan>
    {
        /// <summary>
        /// How to handle a potential initial partial billing period for fixed day scheduling. The options are to bill for a full period, bill prorated for the partial period, bill a zero amoumt, or not to consider the period before first fixed day a billing period. The default is to bill prorated. Options: `bill_full`, `bill_prorated`, `bill_zero_amount`, `no_bill`.
        /// </summary>
        /// <value>How to handle a potential initial partial billing period for fixed day scheduling. The options are to bill for a full period, bill prorated for the partial period, bill a zero amoumt, or not to consider the period before first fixed day a billing period. The default is to bill prorated. Options: `bill_full`, `bill_prorated`, `bill_zero_amount`, `no_bill`.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PartialPeriodHandlingEnum
        {
            
            /// <summary>
            /// Enum Billfull for "bill_full"
            /// </summary>
            [EnumMember(Value = "bill_full")]
            Billfull,
            
            /// <summary>
            /// Enum Billprorated for "bill_prorated"
            /// </summary>
            [EnumMember(Value = "bill_prorated")]
            Billprorated,
            
            /// <summary>
            /// Enum Billzeroamount for "bill_zero_amount"
            /// </summary>
            [EnumMember(Value = "bill_zero_amount")]
            Billzeroamount,
            
            /// <summary>
            /// Enum Nobill for "no_bill"
            /// </summary>
            [EnumMember(Value = "no_bill")]
            Nobill
        }

        /// <summary>
        /// How to handle a potential initial partial billing period for fixed day scheduling. The options are to bill for a full period, bill prorated for the partial period, bill a zero amoumt, or not to consider the period before first fixed day a billing period. The default is to bill prorated. Options: `bill_full`, `bill_prorated`, `bill_zero_amount`, `no_bill`.
        /// </summary>
        /// <value>How to handle a potential initial partial billing period for fixed day scheduling. The options are to bill for a full period, bill prorated for the partial period, bill a zero amoumt, or not to consider the period before first fixed day a billing period. The default is to bill prorated. Options: `bill_full`, `bill_prorated`, `bill_zero_amount`, `no_bill`.</value>
        [DataMember(Name="partial_period_handling", EmitDefaultValue=false)]
        public PartialPeriodHandlingEnum? PartialPeriodHandling { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionPlan" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateSubscriptionPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionPlan" /> class.
        /// </summary>
        /// <param name="Name">Name of the plan (required).</param>
        /// <param name="Description">Description of the plan.</param>
        /// <param name="Vat">Optional vat for this plan. Account default is used if none given..</param>
        /// <param name="DunningPlan">Dunning plan handle.</param>
        /// <param name="RenewalReminderEmailDays">Optional renewal reminder email settings. Number of days before next billing to send a reminder email..</param>
        /// <param name="TrialReminderEmailDays">Optional end of trial reminder email settings. Number of days before end of trial to send a reminder email..</param>
        /// <param name="PartialPeriodHandling">How to handle a potential initial partial billing period for fixed day scheduling. The options are to bill for a full period, bill prorated for the partial period, bill a zero amoumt, or not to consider the period before first fixed day a billing period. The default is to bill prorated. Options: &#x60;bill_full&#x60;, &#x60;bill_prorated&#x60;, &#x60;bill_zero_amount&#x60;, &#x60;no_bill&#x60;..</param>
        public UpdateSubscriptionPlan(string Name = null, string Description = null, float? Vat = null, string DunningPlan = null, int? RenewalReminderEmailDays = null, int? TrialReminderEmailDays = null, PartialPeriodHandlingEnum? PartialPeriodHandling = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for UpdateSubscriptionPlan and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Description = Description;
            this.Vat = Vat;
            this.DunningPlan = DunningPlan;
            this.RenewalReminderEmailDays = RenewalReminderEmailDays;
            this.TrialReminderEmailDays = TrialReminderEmailDays;
            this.PartialPeriodHandling = PartialPeriodHandling;
        }
        
        /// <summary>
        /// Name of the plan
        /// </summary>
        /// <value>Name of the plan</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the plan
        /// </summary>
        /// <value>Description of the plan</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Optional vat for this plan. Account default is used if none given.
        /// </summary>
        /// <value>Optional vat for this plan. Account default is used if none given.</value>
        [DataMember(Name="vat", EmitDefaultValue=false)]
        public float? Vat { get; set; }
        /// <summary>
        /// Dunning plan handle
        /// </summary>
        /// <value>Dunning plan handle</value>
        [DataMember(Name="dunning_plan", EmitDefaultValue=false)]
        public string DunningPlan { get; set; }
        /// <summary>
        /// Optional renewal reminder email settings. Number of days before next billing to send a reminder email.
        /// </summary>
        /// <value>Optional renewal reminder email settings. Number of days before next billing to send a reminder email.</value>
        [DataMember(Name="renewal_reminder_email_days", EmitDefaultValue=false)]
        public int? RenewalReminderEmailDays { get; set; }
        /// <summary>
        /// Optional end of trial reminder email settings. Number of days before end of trial to send a reminder email.
        /// </summary>
        /// <value>Optional end of trial reminder email settings. Number of days before end of trial to send a reminder email.</value>
        [DataMember(Name="trial_reminder_email_days", EmitDefaultValue=false)]
        public int? TrialReminderEmailDays { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubscriptionPlan {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  DunningPlan: ").Append(DunningPlan).Append("\n");
            sb.Append("  RenewalReminderEmailDays: ").Append(RenewalReminderEmailDays).Append("\n");
            sb.Append("  TrialReminderEmailDays: ").Append(TrialReminderEmailDays).Append("\n");
            sb.Append("  PartialPeriodHandling: ").Append(PartialPeriodHandling).Append("\n");
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
            return this.Equals(obj as UpdateSubscriptionPlan);
        }

        /// <summary>
        /// Returns true if UpdateSubscriptionPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateSubscriptionPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSubscriptionPlan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Vat == other.Vat ||
                    this.Vat != null &&
                    this.Vat.Equals(other.Vat)
                ) && 
                (
                    this.DunningPlan == other.DunningPlan ||
                    this.DunningPlan != null &&
                    this.DunningPlan.Equals(other.DunningPlan)
                ) && 
                (
                    this.RenewalReminderEmailDays == other.RenewalReminderEmailDays ||
                    this.RenewalReminderEmailDays != null &&
                    this.RenewalReminderEmailDays.Equals(other.RenewalReminderEmailDays)
                ) && 
                (
                    this.TrialReminderEmailDays == other.TrialReminderEmailDays ||
                    this.TrialReminderEmailDays != null &&
                    this.TrialReminderEmailDays.Equals(other.TrialReminderEmailDays)
                ) && 
                (
                    this.PartialPeriodHandling == other.PartialPeriodHandling ||
                    this.PartialPeriodHandling != null &&
                    this.PartialPeriodHandling.Equals(other.PartialPeriodHandling)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Vat != null)
                    hash = hash * 59 + this.Vat.GetHashCode();
                if (this.DunningPlan != null)
                    hash = hash * 59 + this.DunningPlan.GetHashCode();
                if (this.RenewalReminderEmailDays != null)
                    hash = hash * 59 + this.RenewalReminderEmailDays.GetHashCode();
                if (this.TrialReminderEmailDays != null)
                    hash = hash * 59 + this.TrialReminderEmailDays.GetHashCode();
                if (this.PartialPeriodHandling != null)
                    hash = hash * 59 + this.PartialPeriodHandling.GetHashCode();
                return hash;
            }
        }
    }

}
