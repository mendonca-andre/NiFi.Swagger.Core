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
    /// ControllerStatusEntity
    /// </summary>
    [DataContract]
    public partial class ControllerStatusEntity :  IEquatable<ControllerStatusEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerStatusEntity" /> class.
        /// </summary>
        /// <param name="controllerStatus">controllerStatus.</param>
        public ControllerStatusEntity(ControllerStatusDTO controllerStatus = default(ControllerStatusDTO))
        {
            this.ControllerStatus = controllerStatus;
        }
        
        /// <summary>
        /// Gets or Sets ControllerStatus
        /// </summary>
        [DataMember(Name="controllerStatus", EmitDefaultValue=false)]
        public ControllerStatusDTO ControllerStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControllerStatusEntity {\n");
            sb.Append("  ControllerStatus: ").Append(this.ControllerStatus).Append("\n");
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
            return this.Equals(input as ControllerStatusEntity);
        }

        /// <summary>
        /// Returns true if ControllerStatusEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ControllerStatusEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControllerStatusEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ControllerStatus == input.ControllerStatus ||
                    (this.ControllerStatus != null &&
                    this.ControllerStatus.Equals(input.ControllerStatus))
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
                if (this.ControllerStatus != null)
                    hashCode = hashCode * 59 + this.ControllerStatus.GetHashCode();
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
