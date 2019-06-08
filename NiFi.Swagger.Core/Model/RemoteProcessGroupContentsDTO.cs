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
    /// RemoteProcessGroupContentsDTO
    /// </summary>
    [DataContract]
    public partial class RemoteProcessGroupContentsDTO :  IEquatable<RemoteProcessGroupContentsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteProcessGroupContentsDTO" /> class.
        /// </summary>
        /// <param name="inputPorts">The input ports to which data can be sent..</param>
        /// <param name="outputPorts">The output ports from which data can be retrieved..</param>
        public RemoteProcessGroupContentsDTO(List<RemoteProcessGroupPortDTO> inputPorts = default(List<RemoteProcessGroupPortDTO>), List<RemoteProcessGroupPortDTO> outputPorts = default(List<RemoteProcessGroupPortDTO>))
        {
            this.InputPorts = inputPorts;
            this.OutputPorts = outputPorts;
        }
        
        /// <summary>
        /// The input ports to which data can be sent.
        /// </summary>
        /// <value>The input ports to which data can be sent.</value>
        [DataMember(Name="inputPorts", EmitDefaultValue=false)]
        public List<RemoteProcessGroupPortDTO> InputPorts { get; set; }

        /// <summary>
        /// The output ports from which data can be retrieved.
        /// </summary>
        /// <value>The output ports from which data can be retrieved.</value>
        [DataMember(Name="outputPorts", EmitDefaultValue=false)]
        public List<RemoteProcessGroupPortDTO> OutputPorts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteProcessGroupContentsDTO {\n");
            sb.Append("  InputPorts: ").Append(this.InputPorts).Append("\n");
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
            return this.Equals(input as RemoteProcessGroupContentsDTO);
        }

        /// <summary>
        /// Returns true if RemoteProcessGroupContentsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteProcessGroupContentsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteProcessGroupContentsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InputPorts == input.InputPorts ||
                    this.InputPorts != null &&
                    this.InputPorts.SequenceEqual(input.InputPorts)
                ) && 
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
                if (this.InputPorts != null)
                    hashCode = hashCode * 59 + this.InputPorts.GetHashCode();
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
