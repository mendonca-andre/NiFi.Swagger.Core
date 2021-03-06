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
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ScheduleComponentsEntity
    /// </summary>
    [DataContract]
    public partial class ScheduleComponentsEntity :  IEquatable<ScheduleComponentsEntity>, IValidatableObject
    {
        /// <summary>
        /// The desired state of the descendant components
        /// </summary>
        /// <value>The desired state of the descendant components</value>
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
            STOPPED = 2,
            
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            ENABLED = 3,
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 4
        }

        /// <summary>
        /// The desired state of the descendant components
        /// </summary>
        /// <value>The desired state of the descendant components</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleComponentsEntity" /> class.
        /// </summary>
        /// <param name="id">The id of the ProcessGroup.</param>
        /// <param name="state">The desired state of the descendant components.</param>
        /// <param name="components">Optional components to schedule. If not specified, all authorized descendant components will be used..</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed..</param>
        public ScheduleComponentsEntity(string id = default(string), StateEnum? state = default(StateEnum?), Dictionary<string, RevisionDTO> components = default(Dictionary<string, RevisionDTO>), bool? disconnectedNodeAcknowledged = default(bool?))
        {
            this.Id = id;
            this.State = state;
            this.Components = components;
            this.DisconnectedNodeAcknowledged = disconnectedNodeAcknowledged;
        }
        
        /// <summary>
        /// The id of the ProcessGroup
        /// </summary>
        /// <value>The id of the ProcessGroup</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Optional components to schedule. If not specified, all authorized descendant components will be used.
        /// </summary>
        /// <value>Optional components to schedule. If not specified, all authorized descendant components will be used.</value>
        [DataMember(Name="components", EmitDefaultValue=false)]
        public Dictionary<string, RevisionDTO> Components { get; set; }

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
            sb.Append("class ScheduleComponentsEntity {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  State: ").Append(this.State).Append("\n");
            sb.Append("  Components: ").Append(this.Components).Append("\n");
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
            return this.Equals(input as ScheduleComponentsEntity);
        }

        /// <summary>
        /// Returns true if ScheduleComponentsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleComponentsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleComponentsEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Components == input.Components ||
                    this.Components != null &&
                    this.Components.SequenceEqual(input.Components)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Components != null)
                    hashCode = hashCode * 59 + this.Components.GetHashCode();
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
