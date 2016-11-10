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
    /// UserAccount
    /// </summary>
    [DataContract]
    public partial class UserAccount :  IEquatable<UserAccount>
    {
        /// <summary>
        /// State of user for account: `active`, `invited`
        /// </summary>
        /// <value>State of user for account: `active`, `invited`</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Invited for "invited"
            /// </summary>
            [EnumMember(Value = "invited")]
            Invited
        }

        /// <summary>
        /// State of user for account: `active`, `invited`
        /// </summary>
        /// <value>State of user for account: `active`, `invited`</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccount" /> class.
        /// </summary>
        [JsonConstructor]
        protected UserAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccount" /> class.
        /// </summary>
        /// <param name="Id">Unique id for the user assigned by Reepay (required).</param>
        /// <param name="Email">User email (required).</param>
        /// <param name="Name">User name.</param>
        /// <param name="Groups">List of user groups (required).</param>
        /// <param name="Permissions">List of user permissions (required).</param>
        /// <param name="VerifiedEmail">Email verified (required) (default to false).</param>
        public UserAccount(string Id = null, string Email = null, string Name = null, List<string> Groups = null, List<string> Permissions = null, bool? VerifiedEmail = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Groups" is required (not null)
            if (Groups == null)
            {
                throw new InvalidDataException("Groups is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.Groups = Groups;
            }
            // to ensure "Permissions" is required (not null)
            if (Permissions == null)
            {
                throw new InvalidDataException("Permissions is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.Permissions = Permissions;
            }
            // to ensure "VerifiedEmail" is required (not null)
            if (VerifiedEmail == null)
            {
                throw new InvalidDataException("VerifiedEmail is a required property for UserAccount and cannot be null");
            }
            else
            {
                this.VerifiedEmail = VerifiedEmail;
            }
            this.Name = Name;
        }
        
        /// <summary>
        /// Unique id for the user assigned by Reepay
        /// </summary>
        /// <value>Unique id for the user assigned by Reepay</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// User email
        /// </summary>
        /// <value>User email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        /// <value>User name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// List of user groups
        /// </summary>
        /// <value>List of user groups</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }
        /// <summary>
        /// List of user permissions
        /// </summary>
        /// <value>List of user permissions</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }
        /// <summary>
        /// Email verified
        /// </summary>
        /// <value>Email verified</value>
        [DataMember(Name="verified_email", EmitDefaultValue=false)]
        public bool? VerifiedEmail { get; set; }
        /// <summary>
        /// Expiry date for invite
        /// </summary>
        /// <value>Expiry date for invite</value>
        [DataMember(Name="invite_expires", EmitDefaultValue=false)]
        public DateTime? InviteExpires { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  VerifiedEmail: ").Append(VerifiedEmail).Append("\n");
            sb.Append("  InviteExpires: ").Append(InviteExpires).Append("\n");
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
            return this.Equals(obj as UserAccount);
        }

        /// <summary>
        /// Returns true if UserAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccount other)
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
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) && 
                (
                    this.VerifiedEmail == other.VerifiedEmail ||
                    this.VerifiedEmail != null &&
                    this.VerifiedEmail.Equals(other.VerifiedEmail)
                ) && 
                (
                    this.InviteExpires == other.InviteExpires ||
                    this.InviteExpires != null &&
                    this.InviteExpires.Equals(other.InviteExpires)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                if (this.VerifiedEmail != null)
                    hash = hash * 59 + this.VerifiedEmail.GetHashCode();
                if (this.InviteExpires != null)
                    hash = hash * 59 + this.InviteExpires.GetHashCode();
                return hash;
            }
        }
    }

}