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
    /// VersionControlComponentMappingEntity
    /// </summary>
    [DataContract]
    public partial class VersionControlComponentMappingEntity :  IEquatable<VersionControlComponentMappingEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionControlComponentMappingEntity" /> class.
        /// </summary>
        /// <param name="versionControlComponentMapping">The mapping of Versioned Component Identifiers to instance ID&#39;s.</param>
        /// <param name="processGroupRevision">The revision of the Process Group.</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed..</param>
        /// <param name="versionControlInformation">The Version Control information.</param>
        public VersionControlComponentMappingEntity(Dictionary<string, string> versionControlComponentMapping = default(Dictionary<string, string>), RevisionDTO processGroupRevision = default(RevisionDTO), bool? disconnectedNodeAcknowledged = default(bool?), VersionControlInformationDTO versionControlInformation = default(VersionControlInformationDTO))
        {
            this.VersionControlComponentMapping = versionControlComponentMapping;
            this.ProcessGroupRevision = processGroupRevision;
            this.DisconnectedNodeAcknowledged = disconnectedNodeAcknowledged;
            this.VersionControlInformation = versionControlInformation;
        }
        
        /// <summary>
        /// The mapping of Versioned Component Identifiers to instance ID&#39;s
        /// </summary>
        /// <value>The mapping of Versioned Component Identifiers to instance ID&#39;s</value>
        [DataMember(Name="versionControlComponentMapping", EmitDefaultValue=false)]
        public Dictionary<string, string> VersionControlComponentMapping { get; set; }

        /// <summary>
        /// The revision of the Process Group
        /// </summary>
        /// <value>The revision of the Process Group</value>
        [DataMember(Name="processGroupRevision", EmitDefaultValue=false)]
        public RevisionDTO ProcessGroupRevision { get; set; }

        /// <summary>
        /// Acknowledges that this node is disconnected to allow for mutable requests to proceed.
        /// </summary>
        /// <value>Acknowledges that this node is disconnected to allow for mutable requests to proceed.</value>
        [DataMember(Name="disconnectedNodeAcknowledged", EmitDefaultValue=false)]
        public bool? DisconnectedNodeAcknowledged { get; set; }

        /// <summary>
        /// The Version Control information
        /// </summary>
        /// <value>The Version Control information</value>
        [DataMember(Name="versionControlInformation", EmitDefaultValue=false)]
        public VersionControlInformationDTO VersionControlInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionControlComponentMappingEntity {\n");
            sb.Append("  VersionControlComponentMapping: ").Append(this.VersionControlComponentMapping).Append("\n");
            sb.Append("  ProcessGroupRevision: ").Append(this.ProcessGroupRevision).Append("\n");
            sb.Append("  DisconnectedNodeAcknowledged: ").Append(this.DisconnectedNodeAcknowledged).Append("\n");
            sb.Append("  VersionControlInformation: ").Append(this.VersionControlInformation).Append("\n");
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
            return this.Equals(input as VersionControlComponentMappingEntity);
        }

        /// <summary>
        /// Returns true if VersionControlComponentMappingEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionControlComponentMappingEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionControlComponentMappingEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VersionControlComponentMapping == input.VersionControlComponentMapping ||
                    this.VersionControlComponentMapping != null &&
                    this.VersionControlComponentMapping.SequenceEqual(input.VersionControlComponentMapping)
                ) && 
                (
                    this.ProcessGroupRevision == input.ProcessGroupRevision ||
                    (this.ProcessGroupRevision != null &&
                    this.ProcessGroupRevision.Equals(input.ProcessGroupRevision))
                ) && 
                (
                    this.DisconnectedNodeAcknowledged == input.DisconnectedNodeAcknowledged ||
                    (this.DisconnectedNodeAcknowledged != null &&
                    this.DisconnectedNodeAcknowledged.Equals(input.DisconnectedNodeAcknowledged))
                ) && 
                (
                    this.VersionControlInformation == input.VersionControlInformation ||
                    (this.VersionControlInformation != null &&
                    this.VersionControlInformation.Equals(input.VersionControlInformation))
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
                if (this.VersionControlComponentMapping != null)
                    hashCode = hashCode * 59 + this.VersionControlComponentMapping.GetHashCode();
                if (this.ProcessGroupRevision != null)
                    hashCode = hashCode * 59 + this.ProcessGroupRevision.GetHashCode();
                if (this.DisconnectedNodeAcknowledged != null)
                    hashCode = hashCode * 59 + this.DisconnectedNodeAcknowledged.GetHashCode();
                if (this.VersionControlInformation != null)
                    hashCode = hashCode * 59 + this.VersionControlInformation.GetHashCode();
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
