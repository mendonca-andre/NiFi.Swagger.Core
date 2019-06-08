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
    /// OutputPortsEntity
    /// </summary>
    [DataContract]
    public partial class OutputPortsEntity :  IEquatable<OutputPortsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputPortsEntity" /> class.
        /// </summary>
        /// <param name="outputPorts">outputPorts.</param>
        public OutputPortsEntity(List<PortEntity> outputPorts = default(List<PortEntity>))
        {
            this.OutputPorts = outputPorts;
        }
        
        /// <summary>
        /// Gets or Sets OutputPorts
        /// </summary>
        [DataMember(Name="outputPorts", EmitDefaultValue=false)]
        public List<PortEntity> OutputPorts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputPortsEntity {\n");
            sb.Append("  OutputPorts: ").Append(this.OutputPorts).Append("\n");
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
            return this.Equals(input as OutputPortsEntity);
        }

        /// <summary>
        /// Returns true if OutputPortsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputPortsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputPortsEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputPorts == input.OutputPorts ||
                    this.OutputPorts != null &&
                    this.OutputPorts.SequenceEqual(input.OutputPorts)
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
                if (this.OutputPorts != null)
                    hashCode = hashCode * 59 + this.OutputPorts.GetHashCode();
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