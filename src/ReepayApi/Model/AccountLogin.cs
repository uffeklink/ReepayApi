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
    /// AccountLogin
    /// </summary>
    [DataContract]
    public partial class AccountLogin :  IEquatable<AccountLogin>
    {
        /// <summary>
        /// Status of the account one of the following `test`, `live`, `closed`, `demo`.
        /// </summary>
        /// <value>Status of the account one of the following `test`, `live`, `closed`, `demo`.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Test for "test"
            /// </summary>
            [EnumMember(Value = "test")]
            Test,
            
            /// <summary>
            /// Enum Live for "live"
            /// </summary>
            [EnumMember(Value = "live")]
            Live,
            
            /// <summary>
            /// Enum Closed for "closed"
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed,
            
            /// <summary>
            /// Enum Demo for "demo"
            /// </summary>
            [EnumMember(Value = "demo")]
            Demo
        }

        /// <summary>
        /// Status of the account one of the following `test`, `live`, `closed`, `demo`.
        /// </summary>
        /// <value>Status of the account one of the following `test`, `live`, `closed`, `demo`.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLogin" /> class.
        /// </summary>
        [JsonConstructor]
        protected AccountLogin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLogin" /> class.
        /// </summary>
        /// <param name="Name">Account name (required).</param>
        /// <param name="Locale">Account locale on the form &#39;language_country&#39; (required).</param>
        /// <param name="Timezone">Account time zone ID as abbreviation or full name. See [Wikipedia](http://en.wikipedia.org/wiki/List_of_tz_database_time_zones) (required).</param>
        public AccountLogin(string Name = null, string Locale = null, string Timezone = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for AccountLogin and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Locale" is required (not null)
            if (Locale == null)
            {
                throw new InvalidDataException("Locale is a required property for AccountLogin and cannot be null");
            }
            else
            {
                this.Locale = Locale;
            }
            // to ensure "Timezone" is required (not null)
            if (Timezone == null)
            {
                throw new InvalidDataException("Timezone is a required property for AccountLogin and cannot be null");
            }
            else
            {
                this.Timezone = Timezone;
            }
        }
        
        /// <summary>
        /// Account id assigned by Reepay
        /// </summary>
        /// <value>Account id assigned by Reepay</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Organisation by subdomain handle
        /// </summary>
        /// <value>Organisation by subdomain handle</value>
        [DataMember(Name="organisation", EmitDefaultValue=false)]
        public string Organisation { get; private set; }
        /// <summary>
        /// Per organisation unique handle for the account
        /// </summary>
        /// <value>Per organisation unique handle for the account</value>
        [DataMember(Name="handle", EmitDefaultValue=false)]
        public string Handle { get; private set; }
        /// <summary>
        /// Currency for the account in [ISO 4217](http://da.wikipedia.org/wiki/ISO_4217) three letter alpha code
        /// </summary>
        /// <value>Currency for the account in [ISO 4217](http://da.wikipedia.org/wiki/ISO_4217) three letter alpha code</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }
        /// <summary>
        /// Account name
        /// </summary>
        /// <value>Account name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Account locale on the form &#39;language_country&#39;
        /// </summary>
        /// <value>Account locale on the form &#39;language_country&#39;</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }
        /// <summary>
        /// Account time zone ID as abbreviation or full name. See [Wikipedia](http://en.wikipedia.org/wiki/List_of_tz_database_time_zones)
        /// </summary>
        /// <value>Account time zone ID as abbreviation or full name. See [Wikipedia](http://en.wikipedia.org/wiki/List_of_tz_database_time_zones)</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountLogin {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Organisation: ").Append(Organisation).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(obj as AccountLogin);
        }

        /// <summary>
        /// Returns true if AccountLogin instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountLogin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountLogin other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Organisation == other.Organisation ||
                    this.Organisation != null &&
                    this.Organisation.Equals(other.Organisation)
                ) && 
                (
                    this.Handle == other.Handle ||
                    this.Handle != null &&
                    this.Handle.Equals(other.Handle)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Organisation != null)
                    hash = hash * 59 + this.Organisation.GetHashCode();
                if (this.Handle != null)
                    hash = hash * 59 + this.Handle.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                return hash;
            }
        }
    }

}
