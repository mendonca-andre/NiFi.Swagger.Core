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
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// DropRequestEntity
    /// </summary>
    [DataContract]
    public partial class DropRequestEntity :  IEquatable<DropRequestEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropRequestEntity" /> class.
        /// </summary>
        /// <param name="dropRequest">dropRequest.</param>
        public DropRequestEntity(DropRequestDTO dropRequest = default(DropRequestDTO))
        {
            this.DropRequest = dropRequest;
        }
        
        /// <summary>
        /// Gets or Sets DropRequest
        /// </summary>
        [DataMember(Name="dropRequest", EmitDefaultValue=false)]
        public DropRequestDTO DropRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DropRequestEntity {\n");
            sb.Append("  DropRequest: ").Append(this.DropRequest).Append("\n");
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
            return this.Equals(input as DropRequestEntity);
        }

        /// <summary>
        /// Returns true if DropRequestEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of DropRequestEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DropRequestEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DropRequest == input.DropRequest ||
                    (this.DropRequest != null &&
                    this.DropRequest.Equals(input.DropRequest))
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
                if (this.DropRequest != null)
                    hashCode = hashCode * 59 + this.DropRequest.GetHashCode();
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
