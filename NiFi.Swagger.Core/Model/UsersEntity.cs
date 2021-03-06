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
    /// UsersEntity
    /// </summary>
    [DataContract]
    public partial class UsersEntity :  IEquatable<UsersEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersEntity" /> class.
        /// </summary>
        /// <param name="generated">When this content was generated..</param>
        /// <param name="users">users.</param>
        public UsersEntity(string generated = default(string), List<UserEntity> users = default(List<UserEntity>))
        {
            this.Generated = generated;
            this.Users = users;
        }
        
        /// <summary>
        /// When this content was generated.
        /// </summary>
        /// <value>When this content was generated.</value>
        [DataMember(Name="generated", EmitDefaultValue=false)]
        public string Generated { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserEntity> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersEntity {\n");
            sb.Append("  Generated: ").Append(this.Generated).Append("\n");
            sb.Append("  Users: ").Append(this.Users).Append("\n");
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
            return this.Equals(input as UsersEntity);
        }

        /// <summary>
        /// Returns true if UsersEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of UsersEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Generated == input.Generated ||
                    (this.Generated != null &&
                    this.Generated.Equals(input.Generated))
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.Generated != null)
                    hashCode = hashCode * 59 + this.Generated.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
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
