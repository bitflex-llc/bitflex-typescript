/* 
 * BITFLEX Public API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DepositAddress
    /// </summary>
    [DataContract]
    public partial class DepositAddress :  IEquatable<DepositAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositAddress" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="address">address.</param>
        /// <param name="account">account.</param>
        /// <param name="requireTokenCollect">requireTokenCollect.</param>
        /// <param name="isEthForReturnSent">isEthForReturnSent.</param>
        /// <param name="privateKey">privateKey.</param>
        /// <param name="depositTag">depositTag.</param>
        public DepositAddress(string id = default(string), string userId = default(string), string currencyId = default(string), string address = default(string), string account = default(string), bool requireTokenCollect = default(bool), bool isEthForReturnSent = default(bool), string privateKey = default(string), string depositTag = default(string))
        {
            this.Id = id;
            this.UserId = userId;
            this.CurrencyId = currencyId;
            this.Address = address;
            this.Account = account;
            this.RequireTokenCollect = requireTokenCollect;
            this.IsEthForReturnSent = isEthForReturnSent;
            this.PrivateKey = privateKey;
            this.DepositTag = depositTag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currencyId", EmitDefaultValue=true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=true)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets RequireTokenCollect
        /// </summary>
        [DataMember(Name="requireTokenCollect", EmitDefaultValue=false)]
        public bool RequireTokenCollect { get; set; }

        /// <summary>
        /// Gets or Sets IsEthForReturnSent
        /// </summary>
        [DataMember(Name="isEthForReturnSent", EmitDefaultValue=false)]
        public bool IsEthForReturnSent { get; set; }

        /// <summary>
        /// Gets or Sets PrivateKey
        /// </summary>
        [DataMember(Name="privateKey", EmitDefaultValue=true)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Gets or Sets DepositTag
        /// </summary>
        [DataMember(Name="depositTag", EmitDefaultValue=true)]
        public string DepositTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepositAddress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  RequireTokenCollect: ").Append(RequireTokenCollect).Append("\n");
            sb.Append("  IsEthForReturnSent: ").Append(IsEthForReturnSent).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  DepositTag: ").Append(DepositTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DepositAddress);
        }

        /// <summary>
        /// Returns true if DepositAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.RequireTokenCollect == input.RequireTokenCollect ||
                    this.RequireTokenCollect.Equals(input.RequireTokenCollect)
                ) && 
                (
                    this.IsEthForReturnSent == input.IsEthForReturnSent ||
                    this.IsEthForReturnSent.Equals(input.IsEthForReturnSent)
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.DepositTag == input.DepositTag ||
                    (this.DepositTag != null &&
                    this.DepositTag.Equals(input.DepositTag))
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
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                hashCode = hashCode * 59 + this.RequireTokenCollect.GetHashCode();
                hashCode = hashCode * 59 + this.IsEthForReturnSent.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.DepositTag != null)
                    hashCode = hashCode * 59 + this.DepositTag.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
