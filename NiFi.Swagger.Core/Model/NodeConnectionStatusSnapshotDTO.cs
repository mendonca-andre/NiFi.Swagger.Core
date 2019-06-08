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
    /// NodeConnectionStatusSnapshotDTO
    /// </summary>
    [DataContract]
    public partial class NodeConnectionStatusSnapshotDTO :  IEquatable<NodeConnectionStatusSnapshotDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeConnectionStatusSnapshotDTO" /> class.
        /// </summary>
        /// <param name="nodeId">The unique ID that identifies the node.</param>
        /// <param name="address">The API address of the node.</param>
        /// <param name="apiPort">The API port used to communicate with the node.</param>
        /// <param name="statusSnapshot">The connection status snapshot from the node..</param>
        public NodeConnectionStatusSnapshotDTO(string nodeId = default(string), string address = default(string), int? apiPort = default(int?), ConnectionStatusSnapshotDTO statusSnapshot = default(ConnectionStatusSnapshotDTO))
        {
            this.NodeId = nodeId;
            this.Address = address;
            this.ApiPort = apiPort;
            this.StatusSnapshot = statusSnapshot;
        }
        
        /// <summary>
        /// The unique ID that identifies the node
        /// </summary>
        /// <value>The unique ID that identifies the node</value>
        [DataMember(Name="nodeId", EmitDefaultValue=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The API address of the node
        /// </summary>
        /// <value>The API address of the node</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// The API port used to communicate with the node
        /// </summary>
        /// <value>The API port used to communicate with the node</value>
        [DataMember(Name="apiPort", EmitDefaultValue=false)]
        public int? ApiPort { get; set; }

        /// <summary>
        /// The connection status snapshot from the node.
        /// </summary>
        /// <value>The connection status snapshot from the node.</value>
        [DataMember(Name="statusSnapshot", EmitDefaultValue=false)]
        public ConnectionStatusSnapshotDTO StatusSnapshot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeConnectionStatusSnapshotDTO {\n");
            sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
            sb.Append("  Address: ").Append(this.Address).Append("\n");
            sb.Append("  ApiPort: ").Append(this.ApiPort).Append("\n");
            sb.Append("  StatusSnapshot: ").Append(this.StatusSnapshot).Append("\n");
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
            return this.Equals(input as NodeConnectionStatusSnapshotDTO);
        }

        /// <summary>
        /// Returns true if NodeConnectionStatusSnapshotDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeConnectionStatusSnapshotDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeConnectionStatusSnapshotDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ApiPort == input.ApiPort ||
                    (this.ApiPort != null &&
                    this.ApiPort.Equals(input.ApiPort))
                ) && 
                (
                    this.StatusSnapshot == input.StatusSnapshot ||
                    (this.StatusSnapshot != null &&
                    this.StatusSnapshot.Equals(input.StatusSnapshot))
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
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ApiPort != null)
                    hashCode = hashCode * 59 + this.ApiPort.GetHashCode();
                if (this.StatusSnapshot != null)
                    hashCode = hashCode * 59 + this.StatusSnapshot.GetHashCode();
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
