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
                /// Address details for the customer
                /// </summary>
            [DataContract]
            public class OrderAddress : IEquatable<OrderAddress>
            {
                /// <summary>
                    /// Street address
                    /// </summary>
                    /// <value>Street address</value>
                [DataMember(Name="street")]
                    public string Street { get => StreetValue; set { StreetValue = value; StreetIsSet = true; } }
                    private string StreetValue;
                    public bool StreetIsSet { get; set; }

                /// <summary>
                    /// City
                    /// </summary>
                    /// <value>City</value>
                [DataMember(Name="city")]
                    public string City { get => CityValue; set { CityValue = value; CityIsSet = true; } }
                    private string CityValue;
                    public bool CityIsSet { get; set; }

                /// <summary>
                    /// Postal code
                    /// </summary>
                    /// <value>Postal code</value>
                [DataMember(Name="postalCode")]
                    public string PostalCode { get => PostalCodeValue; set { PostalCodeValue = value; PostalCodeIsSet = true; } }
                    private string PostalCodeValue;
                    public bool PostalCodeIsSet { get; set; }

            /// <summary>
                /// Returns the string presentation of the object
                /// </summary>
            /// <returns>String presentation of the object</returns>
            public override string ToString()
            {
            var sb = new StringBuilder();
            sb.Append("class OrderAddress {\n");
                sb.Append("  Street: ").Append(Street).Append("\n");
                sb.Append("  City: ").Append(City).Append("\n");
                sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OrderAddress)obj);
            }

            /// <summary>
                /// Returns true if OrderAddress instances are equal
                /// </summary>
            /// <param name="other">Instance of OrderAddress to be compared</param>
            /// <returns>Boolean</returns>
            public bool Equals(OrderAddress other)
            {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                Street == other.Street ||
                Street != null &&
                Street.Equals(other.Street)
                ) && 
                (
                City == other.City ||
                City != null &&
                City.Equals(other.City)
                ) && 
                (
                PostalCode == other.PostalCode ||
                PostalCode != null &&
                PostalCode.Equals(other.PostalCode)
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
                if (Street != null)
                hashCode = hashCode * 59 + Street.GetHashCode();
                if (City != null)
                hashCode = hashCode * 59 + City.GetHashCode();
                if (PostalCode != null)
                hashCode = hashCode * 59 + PostalCode.GetHashCode();
            return hashCode;
            }
            }

            #region Operators
            #pragma warning disable 1591

            public static bool operator ==(OrderAddress left, OrderAddress right)
            {
            return Equals(left, right);
            }

            public static bool operator !=(OrderAddress left, OrderAddress right)
            {
            return !Equals(left, right);
            }

            #pragma warning restore 1591
            #endregion Operators
            }
}