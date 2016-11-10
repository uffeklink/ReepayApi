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
    /// A page in a sliced event list
    /// </summary>
    [DataContract]
    public partial class EventList :  IEquatable<EventList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventList" /> class.
        /// </summary>
        [JsonConstructor]
        protected EventList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventList" /> class.
        /// </summary>
        /// <param name="Page">Number of current page in paginated list (required).</param>
        /// <param name="Size">Page size in paginated list (required).</param>
        /// <param name="Count">Number of elements in current page (required).</param>
        /// <param name="Content">List of events for current slice (required).</param>
        public EventList(int? Page = null, int? Size = null, int? Count = null, List<ModelEvent> Content = null)
        {
            // to ensure "Page" is required (not null)
            if (Page == null)
            {
                throw new InvalidDataException("Page is a required property for EventList and cannot be null");
            }
            else
            {
                this.Page = Page;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for EventList and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for EventList and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for EventList and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
        }
        
        /// <summary>
        /// Number of current page in paginated list
        /// </summary>
        /// <value>Number of current page in paginated list</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
        /// <summary>
        /// Page size in paginated list
        /// </summary>
        /// <value>Page size in paginated list</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
        /// <summary>
        /// Number of elements in current page
        /// </summary>
        /// <value>Number of elements in current page</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// List of events for current slice
        /// </summary>
        /// <value>List of events for current slice</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<ModelEvent> Content { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventList {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as EventList);
        }

        /// <summary>
        /// Returns true if EventList instances are equal
        /// </summary>
        /// <param name="other">Instance of EventList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
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
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                return hash;
            }
        }
    }

}