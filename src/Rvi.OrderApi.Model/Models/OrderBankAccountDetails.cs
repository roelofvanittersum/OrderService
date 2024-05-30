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
                /// Bank account details for payment
                /// </summary>
            [DataContract]
            public class OrderBankAccountDetails : IEquatable<OrderBankAccountDetails>
            {
                /// <summary>
                    /// Bank account numberr
                    /// </summary>
                    /// <value>Bank account numberr</value>
                [DataMember(Name="accountNumber")]
                    public string AccountNumber { get => AccountNumberValue; set { AccountNumberValue = value; AccountNumberIsSet = true; } }
                    private string AccountNumberValue;
                    public bool AccountNumberIsSet { get; set; }

                /// <summary>
                    /// International Bank Account Number (IBAN)
                    /// </summary>
                    /// <value>International Bank Account Number (IBAN)</value>
                [DataMember(Name="iban")]
                    public string Iban { get => IbanValue; set { IbanValue = value; IbanIsSet = true; } }
                    private string IbanValue;
                    public bool IbanIsSet { get; set; }

                /// <summary>
                    /// Name of the bank
                    /// </summary>
                    /// <value>Name of the bank</value>
                [DataMember(Name="bankName")]
                    public string BankName { get => BankNameValue; set { BankNameValue = value; BankNameIsSet = true; } }
                    private string BankNameValue;
                    public bool BankNameIsSet { get; set; }

                /// <summary>
                    /// Name of the account holder
                    /// </summary>
                    /// <value>Name of the account holder</value>
                [DataMember(Name="accountHolderName")]
                    public string AccountHolderName { get => AccountHolderNameValue; set { AccountHolderNameValue = value; AccountHolderNameIsSet = true; } }
                    private string AccountHolderNameValue;
                    public bool AccountHolderNameIsSet { get; set; }

            /// <summary>
                /// Returns the string presentation of the object
                /// </summary>
            /// <returns>String presentation of the object</returns>
            public override string ToString()
            {
            var sb = new StringBuilder();
            sb.Append("class OrderBankAccountDetails {\n");
                sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
                sb.Append("  Iban: ").Append(Iban).Append("\n");
                sb.Append("  BankName: ").Append(BankName).Append("\n");
                sb.Append("  AccountHolderName: ").Append(AccountHolderName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OrderBankAccountDetails)obj);
            }

            /// <summary>
                /// Returns true if OrderBankAccountDetails instances are equal
                /// </summary>
            /// <param name="other">Instance of OrderBankAccountDetails to be compared</param>
            /// <returns>Boolean</returns>
            public bool Equals(OrderBankAccountDetails other)
            {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                AccountNumber == other.AccountNumber ||
                AccountNumber != null &&
                AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                Iban == other.Iban ||
                Iban != null &&
                Iban.Equals(other.Iban)
                ) && 
                (
                BankName == other.BankName ||
                BankName != null &&
                BankName.Equals(other.BankName)
                ) && 
                (
                AccountHolderName == other.AccountHolderName ||
                AccountHolderName != null &&
                AccountHolderName.Equals(other.AccountHolderName)
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
                if (AccountNumber != null)
                hashCode = hashCode * 59 + AccountNumber.GetHashCode();
                if (Iban != null)
                hashCode = hashCode * 59 + Iban.GetHashCode();
                if (BankName != null)
                hashCode = hashCode * 59 + BankName.GetHashCode();
                if (AccountHolderName != null)
                hashCode = hashCode * 59 + AccountHolderName.GetHashCode();
            return hashCode;
            }
            }

            #region Operators
            #pragma warning disable 1591

            public static bool operator ==(OrderBankAccountDetails left, OrderBankAccountDetails right)
            {
            return Equals(left, right);
            }

            public static bool operator !=(OrderBankAccountDetails left, OrderBankAccountDetails right)
            {
            return !Equals(left, right);
            }

            #pragma warning restore 1591
            #endregion Operators
            }
}