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
    /// BitcoinBasedCurrency
    /// </summary>
    [DataContract]
    public partial class BitcoinBasedCurrency :  IEquatable<BitcoinBasedCurrency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitcoinBasedCurrency" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="rpcIp">rpcIp.</param>
        /// <param name="rpcPort">rpcPort.</param>
        /// <param name="rpcUsername">rpcUsername.</param>
        /// <param name="rpcPassword">rpcPassword.</param>
        public BitcoinBasedCurrency(string id = default(string), string currencyId = default(string), string rpcIp = default(string), string rpcPort = default(string), string rpcUsername = default(string), string rpcPassword = default(string))
        {
            this.Id = id;
            this.CurrencyId = currencyId;
            this.RpcIp = rpcIp;
            this.RpcPort = rpcPort;
            this.RpcUsername = rpcUsername;
            this.RpcPassword = rpcPassword;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currencyId", EmitDefaultValue=true)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets RpcIp
        /// </summary>
        [DataMember(Name="rpcIp", EmitDefaultValue=true)]
        public string RpcIp { get; set; }

        /// <summary>
        /// Gets or Sets RpcPort
        /// </summary>
        [DataMember(Name="rpcPort", EmitDefaultValue=true)]
        public string RpcPort { get; set; }

        /// <summary>
        /// Gets or Sets RpcUsername
        /// </summary>
        [DataMember(Name="rpcUsername", EmitDefaultValue=true)]
        public string RpcUsername { get; set; }

        /// <summary>
        /// Gets or Sets RpcPassword
        /// </summary>
        [DataMember(Name="rpcPassword", EmitDefaultValue=true)]
        public string RpcPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BitcoinBasedCurrency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  RpcIp: ").Append(RpcIp).Append("\n");
            sb.Append("  RpcPort: ").Append(RpcPort).Append("\n");
            sb.Append("  RpcUsername: ").Append(RpcUsername).Append("\n");
            sb.Append("  RpcPassword: ").Append(RpcPassword).Append("\n");
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
            return this.Equals(input as BitcoinBasedCurrency);
        }

        /// <summary>
        /// Returns true if BitcoinBasedCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of BitcoinBasedCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BitcoinBasedCurrency input)
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
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.RpcIp == input.RpcIp ||
                    (this.RpcIp != null &&
                    this.RpcIp.Equals(input.RpcIp))
                ) && 
                (
                    this.RpcPort == input.RpcPort ||
                    (this.RpcPort != null &&
                    this.RpcPort.Equals(input.RpcPort))
                ) && 
                (
                    this.RpcUsername == input.RpcUsername ||
                    (this.RpcUsername != null &&
                    this.RpcUsername.Equals(input.RpcUsername))
                ) && 
                (
                    this.RpcPassword == input.RpcPassword ||
                    (this.RpcPassword != null &&
                    this.RpcPassword.Equals(input.RpcPassword))
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
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.RpcIp != null)
                    hashCode = hashCode * 59 + this.RpcIp.GetHashCode();
                if (this.RpcPort != null)
                    hashCode = hashCode * 59 + this.RpcPort.GetHashCode();
                if (this.RpcUsername != null)
                    hashCode = hashCode * 59 + this.RpcUsername.GetHashCode();
                if (this.RpcPassword != null)
                    hashCode = hashCode * 59 + this.RpcPassword.GetHashCode();
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
