/* 
 * NiFi Rest Api
 *
 * The Rest Api provides programmatic access to command and control a NiFi instance in real time. Start and                                              stop processors, monitor queues, query provenance data, and more. Each endpoint below includes a description,                                             definitions of the expected input and output, potential response codes, and the authorizations required                                             to invoke each service.
 *
 * OpenAPI spec version: 1.9.1
 * Contact: dev@nifi.apache.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace NiFi.Swagger.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// TenantsEntity
    /// </summary>
    [DataContract]
    public partial class TenantsEntity :  IEquatable<TenantsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsEntity" /> class.
        /// </summary>
        /// <param name="users">users.</param>
        /// <param name="userGroups">userGroups.</param>
        public TenantsEntity(List<TenantEntity> users = default(List<TenantEntity>), List<TenantEntity> userGroups = default(List<TenantEntity>))
        {
            this.Users = users;
            this.UserGroups = userGroups;
        }
        
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<TenantEntity> Users { get; set; }

        /// <summary>
        /// Gets or Sets UserGroups
        /// </summary>
        [DataMember(Name="userGroups", EmitDefaultValue=false)]
        public List<TenantEntity> UserGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantsEntity {\n");
            sb.Append("  Users: ").Append(this.Users).Append("\n");
            sb.Append("  UserGroups: ").Append(this.UserGroups).Append("\n");
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
            return this.Equals(input as TenantsEntity);
        }

        /// <summary>
        /// Returns true if TenantsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantsEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.UserGroups == input.UserGroups ||
                    this.UserGroups != null &&
                    this.UserGroups.SequenceEqual(input.UserGroups)
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.UserGroups != null)
                    hashCode = hashCode * 59 + this.UserGroups.GetHashCode();
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
