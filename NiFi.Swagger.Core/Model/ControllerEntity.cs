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
    /// ControllerEntity
    /// </summary>
    [DataContract]
    public partial class ControllerEntity :  IEquatable<ControllerEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerEntity" /> class.
        /// </summary>
        /// <param name="controller">controller.</param>
        public ControllerEntity(ControllerDTO controller = default(ControllerDTO))
        {
            this.Controller = controller;
        }
        
        /// <summary>
        /// Gets or Sets Controller
        /// </summary>
        [DataMember(Name="controller", EmitDefaultValue=false)]
        public ControllerDTO Controller { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControllerEntity {\n");
            sb.Append("  Controller: ").Append(this.Controller).Append("\n");
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
            return this.Equals(input as ControllerEntity);
        }

        /// <summary>
        /// Returns true if ControllerEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ControllerEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControllerEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Controller == input.Controller ||
                    (this.Controller != null &&
                    this.Controller.Equals(input.Controller))
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
                if (this.Controller != null)
                    hashCode = hashCode * 59 + this.Controller.GetHashCode();
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
