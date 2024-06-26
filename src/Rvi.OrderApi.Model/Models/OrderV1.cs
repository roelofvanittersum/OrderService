/*
 * Dutch Insurance Order API
 *
 * API for placing and fetching orders in the Dutch insurance market
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Rvi.OrderAPI.Model.Converters;

        namespace Rvi.OrderAPI.Model.Models
        { 
            /// <summary>
                /// 
                /// </summary>
            [DataContract]
            public class OrderV1 : IEquatable<OrderV1>
            {
                /// <summary>
                    /// Unique identifier for the insurance product
                    /// </summary>
                    /// <value>Unique identifier for the insurance product</value>
                    [Required]
                [DataMember(Name="productId")]
                    public string ProductId { get => ProductIdValue; set { ProductIdValue = value; ProductIdIsSet = true; } }
                    private string ProductIdValue;
                    public bool ProductIdIsSet { get; set; }

                /// <summary>
                    /// Gets or Sets CustomerDetails
                    /// </summary>
                    [Required]
                [DataMember(Name="customerDetails")]
                    public OrderV1CustomerDetails CustomerDetails { get => CustomerDetailsValue; set { CustomerDetailsValue = value; CustomerDetailsIsSet = true; } }
                    private OrderV1CustomerDetails CustomerDetailsValue;
                    public bool CustomerDetailsIsSet { get; set; }

                /// <summary>
                    /// Gets or Sets Address
                    /// </summary>
                    [Required]
                [DataMember(Name="address")]
                    public OrderV1Address Address { get => AddressValue; set { AddressValue = value; AddressIsSet = true; } }
                    private OrderV1Address AddressValue;
                    public bool AddressIsSet { get; set; }

                /// <summary>
                    /// Gets or Sets BankAccountDetails
                    /// </summary>
                    [Required]
                [DataMember(Name="bankAccountDetails")]
                    public OrderV1BankAccountDetails BankAccountDetails { get => BankAccountDetailsValue; set { BankAccountDetailsValue = value; BankAccountDetailsIsSet = true; } }
                    private OrderV1BankAccountDetails BankAccountDetailsValue;
                    public bool BankAccountDetailsIsSet { get; set; }

            /// <summary>
                /// Returns the string presentation of the object
                /// </summary>
            /// <returns>String presentation of the object</returns>
            public override string ToString()
            {
            var sb = new StringBuilder();
            sb.Append("class OrderV1 {\n");
                sb.Append("  ProductId: ").Append(ProductId).Append("\n");
                sb.Append("  CustomerDetails: ").Append(CustomerDetails).Append("\n");
                sb.Append("  Address: ").Append(Address).Append("\n");
                sb.Append("  BankAccountDetails: ").Append(BankAccountDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
            }

            /// <summary>
                /// Returns the JSON string presentation of the object
                /// </summary>
            /// <returns>JSON string presentation of the object</returns>
            public string ToJson()
            {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            }

            /// <summary>
                /// Returns true if objects are equal
                /// </summary>
            /// <param name="obj">Object to be compared</param>
            /// <returns>Boolean</returns>
            public override bool Equals(object obj)
            {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((OrderV1)obj);
            }

            /// <summary>
                /// Returns true if OrderV1 instances are equal
                /// </summary>
            /// <param name="other">Instance of OrderV1 to be compared</param>
            /// <returns>Boolean</returns>
            public bool Equals(OrderV1 other)
            {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                ProductId == other.ProductId ||
                ProductId != null &&
                ProductId.Equals(other.ProductId)
                ) && 
                (
                CustomerDetails == other.CustomerDetails ||
                CustomerDetails != null &&
                CustomerDetails.Equals(other.CustomerDetails)
                ) && 
                (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
                ) && 
                (
                BankAccountDetails == other.BankAccountDetails ||
                BankAccountDetails != null &&
                BankAccountDetails.Equals(other.BankAccountDetails)
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
            var hashCode = 41;
            // Suitable nullity checks etc, of course :)
                if (ProductId != null)
                hashCode = hashCode * 59 + ProductId.GetHashCode();
                if (CustomerDetails != null)
                hashCode = hashCode * 59 + CustomerDetails.GetHashCode();
                if (Address != null)
                hashCode = hashCode * 59 + Address.GetHashCode();
                if (BankAccountDetails != null)
                hashCode = hashCode * 59 + BankAccountDetails.GetHashCode();
            return hashCode;
            }
            }

            #region Operators
            #pragma warning disable 1591

            public static bool operator ==(OrderV1 left, OrderV1 right)
            {
            return Equals(left, right);
            }

            public static bool operator !=(OrderV1 left, OrderV1 right)
            {
            return !Equals(left, right);
            }

            #pragma warning restore 1591
            #endregion Operators
            }
}