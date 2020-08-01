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
    /// DatabaseFacade
    /// </summary>
    [DataContract]
    public partial class DatabaseFacade :  IEquatable<DatabaseFacade>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseFacade" /> class.
        /// </summary>
        /// <param name="currentTransaction">currentTransaction.</param>
        /// <param name="autoTransactionsEnabled">autoTransactionsEnabled.</param>
        public DatabaseFacade(IDbContextTransaction currentTransaction = default(IDbContextTransaction), bool autoTransactionsEnabled = default(bool))
        {
            this.CurrentTransaction = currentTransaction;
            this.AutoTransactionsEnabled = autoTransactionsEnabled;
        }
        
        /// <summary>
        /// Gets or Sets CurrentTransaction
        /// </summary>
        [DataMember(Name="currentTransaction", EmitDefaultValue=false)]
        public IDbContextTransaction CurrentTransaction { get; set; }

        /// <summary>
        /// Gets or Sets AutoTransactionsEnabled
        /// </summary>
        [DataMember(Name="autoTransactionsEnabled", EmitDefaultValue=false)]
        public bool AutoTransactionsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name="providerName", EmitDefaultValue=true)]
        public string ProviderName { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseFacade {\n");
            sb.Append("  CurrentTransaction: ").Append(CurrentTransaction).Append("\n");
            sb.Append("  AutoTransactionsEnabled: ").Append(AutoTransactionsEnabled).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
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
            return this.Equals(input as DatabaseFacade);
        }

        /// <summary>
        /// Returns true if DatabaseFacade instances are equal
        /// </summary>
        /// <param name="input">Instance of DatabaseFacade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseFacade input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentTransaction == input.CurrentTransaction ||
                    (this.CurrentTransaction != null &&
                    this.CurrentTransaction.Equals(input.CurrentTransaction))
                ) && 
                (
                    this.AutoTransactionsEnabled == input.AutoTransactionsEnabled ||
                    this.AutoTransactionsEnabled.Equals(input.AutoTransactionsEnabled)
                ) && 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
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
                if (this.CurrentTransaction != null)
                    hashCode = hashCode * 59 + this.CurrentTransaction.GetHashCode();
                hashCode = hashCode * 59 + this.AutoTransactionsEnabled.GetHashCode();
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
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