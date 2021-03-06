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
    /// UpdateOrganisation
    /// </summary>
    [DataContract]
    public partial class UpdateOrganisation :  IEquatable<UpdateOrganisation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganisation" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateOrganisation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganisation" /> class.
        /// </summary>
        /// <param name="Subdomain">Organisation subdomain handle in Reepay. Must match [a-z0-9-] and maximum length 64. (required).</param>
        public UpdateOrganisation(string Subdomain = null)
        {
            // to ensure "Subdomain" is required (not null)
            if (Subdomain == null)
            {
                throw new InvalidDataException("Subdomain is a required property for UpdateOrganisation and cannot be null");
            }
            else
            {
                this.Subdomain = Subdomain;
            }
        }
        
        /// <summary>
        /// Organisation subdomain handle in Reepay. Must match [a-z0-9-] and maximum length 64.
        /// </summary>
        /// <value>Organisation subdomain handle in Reepay. Must match [a-z0-9-] and maximum length 64.</value>
        [DataMember(Name="subdomain", EmitDefaultValue=false)]
        public string Subdomain { get; set; }
        /// <summary>
        /// Organisation name
        /// </summary>
        /// <value>Organisation name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOrganisation {\n");
            sb.Append("  Subdomain: ").Append(Subdomain).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as UpdateOrganisation);
        }

        /// <summary>
        /// Returns true if UpdateOrganisation instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateOrganisation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOrganisation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Subdomain == other.Subdomain ||
                    this.Subdomain != null &&
                    this.Subdomain.Equals(other.Subdomain)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Subdomain != null)
                    hash = hash * 59 + this.Subdomain.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }
    }

}
