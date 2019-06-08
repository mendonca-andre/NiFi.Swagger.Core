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
    /// PortStatusEntity
    /// </summary>
    [DataContract]
    public partial class PortStatusEntity :  IEquatable<PortStatusEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortStatusEntity" /> class.
        /// </summary>
        /// <param name="portStatus">portStatus.</param>
        public PortStatusEntity(PortStatusDTO portStatus = default(PortStatusDTO))
        {
            this.PortStatus = portStatus;
        }
        
        /// <summary>
        /// Gets or Sets PortStatus
        /// </summary>
        [DataMember(Name="portStatus", EmitDefaultValue=false)]
        public PortStatusDTO PortStatus { get; set; }

        /// <summary>
        /// Indicates whether the user can read a given resource.
        /// </summary>
        /// <value>Indicates whether the user can read a given resource.</value>
        [DataMember(Name="canRead", EmitDefaultValue=false)]
        public bool? CanRead { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortStatusEntity {\n");
            sb.Append("  PortStatus: ").Append(this.PortStatus).Append("\n");
            sb.Append("  CanRead: ").Append(this.CanRead).Append("\n");
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
            return this.Equals(input as PortStatusEntity);
        }

        /// <summary>
        /// Returns true if PortStatusEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PortStatusEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortStatusEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortStatus == input.PortStatus ||
                    (this.PortStatus != null &&
                    this.PortStatus.Equals(input.PortStatus))
                ) && 
                (
                    this.CanRead == input.CanRead ||
                    (this.CanRead != null &&
                    this.CanRead.Equals(input.CanRead))
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
                if (this.PortStatus != null)
                    hashCode = hashCode * 59 + this.PortStatus.GetHashCode();
                if (this.CanRead != null)
                    hashCode = hashCode * 59 + this.CanRead.GetHashCode();
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
