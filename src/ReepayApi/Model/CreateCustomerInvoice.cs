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
    /// CreateCustomerInvoice
    /// </summary>
    [DataContract]
    public partial class CreateCustomerInvoice :  IEquatable<CreateCustomerInvoice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerInvoice" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateCustomerInvoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerInvoice" /> class.
        /// </summary>
        /// <param name="_Ref">Optional reference to avoid double creations. Only one invoice can be created per reference..</param>
        /// <param name="OrderLines">Orderlines for the invoice (required).</param>
        /// <param name="ManualTransfer">Optional manual tranfer. If given the invoice will be settled using the manual transfer transaction..</param>
        /// <param name="PaymentMethod">Payment method id to use for invoice. Must be provided if no manual transfer is given..</param>
        public CreateCustomerInvoice(string _Ref = null, List<CreateOrderLine> OrderLines = null, ManualSettleTransfer ManualTransfer = null, string PaymentMethod = null)
        {
            // to ensure "OrderLines" is required (not null)
            if (OrderLines == null)
            {
                throw new InvalidDataException("OrderLines is a required property for CreateCustomerInvoice and cannot be null");
            }
            else
            {
                this.OrderLines = OrderLines;
            }
            this._Ref = _Ref;
            this.ManualTransfer = ManualTransfer;
            this.PaymentMethod = PaymentMethod;
        }
        
        /// <summary>
        /// Optional reference to avoid double creations. Only one invoice can be created per reference.
        /// </summary>
        /// <value>Optional reference to avoid double creations. Only one invoice can be created per reference.</value>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string _Ref { get; set; }
        /// <summary>
        /// Orderlines for the invoice
        /// </summary>
        /// <value>Orderlines for the invoice</value>
        [DataMember(Name="order_lines", EmitDefaultValue=false)]
        public List<CreateOrderLine> OrderLines { get; set; }
        /// <summary>
        /// Optional manual tranfer. If given the invoice will be settled using the manual transfer transaction.
        /// </summary>
        /// <value>Optional manual tranfer. If given the invoice will be settled using the manual transfer transaction.</value>
        [DataMember(Name="manual_transfer", EmitDefaultValue=false)]
        public ManualSettleTransfer ManualTransfer { get; set; }
        /// <summary>
        /// Payment method id to use for invoice. Must be provided if no manual transfer is given.
        /// </summary>
        /// <value>Payment method id to use for invoice. Must be provided if no manual transfer is given.</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomerInvoice {\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
            sb.Append("  OrderLines: ").Append(OrderLines).Append("\n");
            sb.Append("  ManualTransfer: ").Append(ManualTransfer).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
            return this.Equals(obj as CreateCustomerInvoice);
        }

        /// <summary>
        /// Returns true if CreateCustomerInvoice instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCustomerInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomerInvoice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Ref == other._Ref ||
                    this._Ref != null &&
                    this._Ref.Equals(other._Ref)
                ) && 
                (
                    this.OrderLines == other.OrderLines ||
                    this.OrderLines != null &&
                    this.OrderLines.SequenceEqual(other.OrderLines)
                ) && 
                (
                    this.ManualTransfer == other.ManualTransfer ||
                    this.ManualTransfer != null &&
                    this.ManualTransfer.Equals(other.ManualTransfer)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
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
                if (this._Ref != null)
                    hash = hash * 59 + this._Ref.GetHashCode();
                if (this.OrderLines != null)
                    hash = hash * 59 + this.OrderLines.GetHashCode();
                if (this.ManualTransfer != null)
                    hash = hash * 59 + this.ManualTransfer.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                return hash;
            }
        }
    }

}