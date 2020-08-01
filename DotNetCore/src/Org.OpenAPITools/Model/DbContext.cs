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
    /// DbContext
    /// </summary>
    [DataContract]
    public partial class DbContext :  IEquatable<DbContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DbContext" /> class.
        /// </summary>
        /// <param name="database">database.</param>
        /// <param name="changeTracker">changeTracker.</param>
        /// <param name="model">model.</param>
        /// <param name="contextId">contextId.</param>
        public DbContext(DatabaseFacade database = default(DatabaseFacade), ChangeTracker changeTracker = default(ChangeTracker), Object model = default(Object), DbContextId contextId = default(DbContextId))
        {
            this.Database = database;
            this.ChangeTracker = changeTracker;
            this.Model = model;
            this.ContextId = contextId;
        }
        
        /// <summary>
        /// Gets or Sets Database
        /// </summary>
        [DataMember(Name="database", EmitDefaultValue=false)]
        public DatabaseFacade Database { get; set; }

        /// <summary>
        /// Gets or Sets ChangeTracker
        /// </summary>
        [DataMember(Name="changeTracker", EmitDefaultValue=false)]
        public ChangeTracker ChangeTracker { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public Object Model { get; set; }

        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public DbContextId ContextId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbContext {\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  ChangeTracker: ").Append(ChangeTracker).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
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
            return this.Equals(input as DbContext);
        }

        /// <summary>
        /// Returns true if DbContext instances are equal
        /// </summary>
        /// <param name="input">Instance of DbContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DbContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.ChangeTracker == input.ChangeTracker ||
                    (this.ChangeTracker != null &&
                    this.ChangeTracker.Equals(input.ChangeTracker))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.ContextId == input.ContextId ||
                    (this.ContextId != null &&
                    this.ContextId.Equals(input.ContextId))
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
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.ChangeTracker != null)
                    hashCode = hashCode * 59 + this.ChangeTracker.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.ContextId != null)
                    hashCode = hashCode * 59 + this.ContextId.GetHashCode();
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
