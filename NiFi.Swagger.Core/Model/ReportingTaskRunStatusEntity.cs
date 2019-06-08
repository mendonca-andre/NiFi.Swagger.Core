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
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ReportingTaskRunStatusEntity
    /// </summary>
    [DataContract]
    public partial class ReportingTaskRunStatusEntity :  IEquatable<ReportingTaskRunStatusEntity>, IValidatableObject
    {
        /// <summary>
        /// The run status of the ReportingTask.
        /// </summary>
        /// <value>The run status of the ReportingTask.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING = 1,
            
            /// <summary>
            /// Enum STOPPED for value: STOPPED
            /// </summary>
            [EnumMember(Value = "STOPPED")]
            STOPPED = 2
        }

        /// <summary>
        /// The run status of the ReportingTask.
        /// </summary>
        /// <value>The run status of the ReportingTask.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingTaskRunStatusEntity" /> class.
        /// </summary>
        /// <param name="revision">The revision for this request/response. The revision is required for any mutable flow requests and is included in all responses..</param>
        /// <param name="state">The run status of the ReportingTask..</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed..</param>
        public ReportingTaskRunStatusEntity(RevisionDTO revision = default(RevisionDTO), StateEnum? state = default(StateEnum?), bool? disconnectedNodeAcknowledged = default(bool?))
        {
            this.Revision = revision;
            this.State = state;
            this.DisconnectedNodeAcknowledged = disconnectedNodeAcknowledged;
        }
        
        /// <summary>
        /// The revision for this request/response. The revision is required for any mutable flow requests and is included in all responses.
        /// </summary>
        /// <value>The revision for this request/response. The revision is required for any mutable flow requests and is included in all responses.</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public RevisionDTO Revision { get; set; }


        /// <summary>
        /// Acknowledges that this node is disconnected to allow for mutable requests to proceed.
        /// </summary>
        /// <value>Acknowledges that this node is disconnected to allow for mutable requests to proceed.</value>
        [DataMember(Name="disconnectedNodeAcknowledged", EmitDefaultValue=false)]
        public bool? DisconnectedNodeAcknowledged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingTaskRunStatusEntity {\n");
            sb.Append("  Revision: ").Append(this.Revision).Append("\n");
            sb.Append("  State: ").Append(this.State).Append("\n");
            sb.Append("  DisconnectedNodeAcknowledged: ").Append(this.DisconnectedNodeAcknowledged).Append("\n");
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
            return this.Equals(input as ReportingTaskRunStatusEntity);
        }

        /// <summary>
        /// Returns true if ReportingTaskRunStatusEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportingTaskRunStatusEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingTaskRunStatusEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.DisconnectedNodeAcknowledged == input.DisconnectedNodeAcknowledged ||
                    (this.DisconnectedNodeAcknowledged != null &&
                    this.DisconnectedNodeAcknowledged.Equals(input.DisconnectedNodeAcknowledged))
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
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.DisconnectedNodeAcknowledged != null)
                    hashCode = hashCode * 59 + this.DisconnectedNodeAcknowledged.GetHashCode();
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
