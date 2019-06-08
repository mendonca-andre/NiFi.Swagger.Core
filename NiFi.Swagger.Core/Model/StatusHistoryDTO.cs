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
    /// StatusHistoryDTO
    /// </summary>
    [DataContract]
    public partial class StatusHistoryDTO :  IEquatable<StatusHistoryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusHistoryDTO" /> class.
        /// </summary>
        /// <param name="generated">When the status history was generated..</param>
        /// <param name="componentDetails">A Map of key/value pairs that describe the component that the status history belongs to.</param>
        /// <param name="fieldDescriptors">The Descriptors that provide information on each of the metrics provided in the status history.</param>
        /// <param name="aggregateSnapshots">A list of StatusSnapshotDTO objects that provide the actual metric values for the component. If the NiFi instance is clustered, this will represent the aggregate status across all nodes. If the NiFi instance is not clustered, this will represent the status of the entire NiFi instance..</param>
        /// <param name="nodeSnapshots">The NodeStatusSnapshotsDTO objects that provide the actual metric values for the component, for each node. If the NiFi instance is not clustered, this value will be null..</param>
        public StatusHistoryDTO(string generated = default(string), Dictionary<string, string> componentDetails = default(Dictionary<string, string>), List<StatusDescriptorDTO> fieldDescriptors = default(List<StatusDescriptorDTO>), List<StatusSnapshotDTO> aggregateSnapshots = default(List<StatusSnapshotDTO>), List<NodeStatusSnapshotsDTO> nodeSnapshots = default(List<NodeStatusSnapshotsDTO>))
        {
            this.Generated = generated;
            this.ComponentDetails = componentDetails;
            this.FieldDescriptors = fieldDescriptors;
            this.AggregateSnapshots = aggregateSnapshots;
            this.NodeSnapshots = nodeSnapshots;
        }
        
        /// <summary>
        /// When the status history was generated.
        /// </summary>
        /// <value>When the status history was generated.</value>
        [DataMember(Name="generated", EmitDefaultValue=false)]
        public string Generated { get; set; }

        /// <summary>
        /// A Map of key/value pairs that describe the component that the status history belongs to
        /// </summary>
        /// <value>A Map of key/value pairs that describe the component that the status history belongs to</value>
        [DataMember(Name="componentDetails", EmitDefaultValue=false)]
        public Dictionary<string, string> ComponentDetails { get; set; }

        /// <summary>
        /// The Descriptors that provide information on each of the metrics provided in the status history
        /// </summary>
        /// <value>The Descriptors that provide information on each of the metrics provided in the status history</value>
        [DataMember(Name="fieldDescriptors", EmitDefaultValue=false)]
        public List<StatusDescriptorDTO> FieldDescriptors { get; set; }

        /// <summary>
        /// A list of StatusSnapshotDTO objects that provide the actual metric values for the component. If the NiFi instance is clustered, this will represent the aggregate status across all nodes. If the NiFi instance is not clustered, this will represent the status of the entire NiFi instance.
        /// </summary>
        /// <value>A list of StatusSnapshotDTO objects that provide the actual metric values for the component. If the NiFi instance is clustered, this will represent the aggregate status across all nodes. If the NiFi instance is not clustered, this will represent the status of the entire NiFi instance.</value>
        [DataMember(Name="aggregateSnapshots", EmitDefaultValue=false)]
        public List<StatusSnapshotDTO> AggregateSnapshots { get; set; }

        /// <summary>
        /// The NodeStatusSnapshotsDTO objects that provide the actual metric values for the component, for each node. If the NiFi instance is not clustered, this value will be null.
        /// </summary>
        /// <value>The NodeStatusSnapshotsDTO objects that provide the actual metric values for the component, for each node. If the NiFi instance is not clustered, this value will be null.</value>
        [DataMember(Name="nodeSnapshots", EmitDefaultValue=false)]
        public List<NodeStatusSnapshotsDTO> NodeSnapshots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusHistoryDTO {\n");
            sb.Append("  Generated: ").Append(this.Generated).Append("\n");
            sb.Append("  ComponentDetails: ").Append(this.ComponentDetails).Append("\n");
            sb.Append("  FieldDescriptors: ").Append(this.FieldDescriptors).Append("\n");
            sb.Append("  AggregateSnapshots: ").Append(this.AggregateSnapshots).Append("\n");
            sb.Append("  NodeSnapshots: ").Append(this.NodeSnapshots).Append("\n");
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
            return this.Equals(input as StatusHistoryDTO);
        }

        /// <summary>
        /// Returns true if StatusHistoryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusHistoryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusHistoryDTO input)
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
                    this.ComponentDetails == input.ComponentDetails ||
                    this.ComponentDetails != null &&
                    this.ComponentDetails.SequenceEqual(input.ComponentDetails)
                ) && 
                (
                    this.FieldDescriptors == input.FieldDescriptors ||
                    this.FieldDescriptors != null &&
                    this.FieldDescriptors.SequenceEqual(input.FieldDescriptors)
                ) && 
                (
                    this.AggregateSnapshots == input.AggregateSnapshots ||
                    this.AggregateSnapshots != null &&
                    this.AggregateSnapshots.SequenceEqual(input.AggregateSnapshots)
                ) && 
                (
                    this.NodeSnapshots == input.NodeSnapshots ||
                    this.NodeSnapshots != null &&
                    this.NodeSnapshots.SequenceEqual(input.NodeSnapshots)
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
                if (this.ComponentDetails != null)
                    hashCode = hashCode * 59 + this.ComponentDetails.GetHashCode();
                if (this.FieldDescriptors != null)
                    hashCode = hashCode * 59 + this.FieldDescriptors.GetHashCode();
                if (this.AggregateSnapshots != null)
                    hashCode = hashCode * 59 + this.AggregateSnapshots.GetHashCode();
                if (this.NodeSnapshots != null)
                    hashCode = hashCode * 59 + this.NodeSnapshots.GetHashCode();
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