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
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ConnectionEntity
    /// </summary>
    [DataContract]
    public partial class ConnectionEntity :  IEquatable<ConnectionEntity>, IValidatableObject
    {
        /// <summary>
        /// The type of component the source connectable is.
        /// </summary>
        /// <value>The type of component the source connectable is.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceTypeEnum
        {
            
            /// <summary>
            /// Enum PROCESSOR for value: PROCESSOR
            /// </summary>
            [EnumMember(Value = "PROCESSOR")]
            PROCESSOR = 1,
            
            /// <summary>
            /// Enum REMOTEINPUTPORT for value: REMOTE_INPUT_PORT
            /// </summary>
            [EnumMember(Value = "REMOTE_INPUT_PORT")]
            REMOTEINPUTPORT = 2,
            
            /// <summary>
            /// Enum REMOTEOUTPUTPORT for value: REMOTE_OUTPUT_PORT
            /// </summary>
            [EnumMember(Value = "REMOTE_OUTPUT_PORT")]
            REMOTEOUTPUTPORT = 3,
            
            /// <summary>
            /// Enum INPUTPORT for value: INPUT_PORT
            /// </summary>
            [EnumMember(Value = "INPUT_PORT")]
            INPUTPORT = 4,
            
            /// <summary>
            /// Enum OUTPUTPORT for value: OUTPUT_PORT
            /// </summary>
            [EnumMember(Value = "OUTPUT_PORT")]
            OUTPUTPORT = 5,
            
            /// <summary>
            /// Enum FUNNEL for value: FUNNEL
            /// </summary>
            [EnumMember(Value = "FUNNEL")]
            FUNNEL = 6
        }

        /// <summary>
        /// The type of component the source connectable is.
        /// </summary>
        /// <value>The type of component the source connectable is.</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// The type of component the destination connectable is.
        /// </summary>
        /// <value>The type of component the destination connectable is.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DestinationTypeEnum
        {
            
            /// <summary>
            /// Enum PROCESSOR for value: PROCESSOR
            /// </summary>
            [EnumMember(Value = "PROCESSOR")]
            PROCESSOR = 1,
            
            /// <summary>
            /// Enum REMOTEINPUTPORT for value: REMOTE_INPUT_PORT
            /// </summary>
            [EnumMember(Value = "REMOTE_INPUT_PORT")]
            REMOTEINPUTPORT = 2,
            
            /// <summary>
            /// Enum REMOTEOUTPUTPORT for value: REMOTE_OUTPUT_PORT
            /// </summary>
            [EnumMember(Value = "REMOTE_OUTPUT_PORT")]
            REMOTEOUTPUTPORT = 3,
            
            /// <summary>
            /// Enum INPUTPORT for value: INPUT_PORT
            /// </summary>
            [EnumMember(Value = "INPUT_PORT")]
            INPUTPORT = 4,
            
            /// <summary>
            /// Enum OUTPUTPORT for value: OUTPUT_PORT
            /// </summary>
            [EnumMember(Value = "OUTPUT_PORT")]
            OUTPUTPORT = 5,
            
            /// <summary>
            /// Enum FUNNEL for value: FUNNEL
            /// </summary>
            [EnumMember(Value = "FUNNEL")]
            FUNNEL = 6
        }

        /// <summary>
        /// The type of component the destination connectable is.
        /// </summary>
        /// <value>The type of component the destination connectable is.</value>
        [DataMember(Name="destinationType", EmitDefaultValue=false)]
        public DestinationTypeEnum DestinationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionEntity" /> class.
        /// </summary>
        [JsonConstructor]
        protected ConnectionEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionEntity" /> class.
        /// </summary>
        /// <param name="revision">The revision for this request/response. The revision is required for any mutable flow requests and is included in all responses..</param>
        /// <param name="id">The id of the component..</param>
        /// <param name="uri">The URI for futures requests to the component..</param>
        /// <param name="position">The position of this component in the UI if applicable..</param>
        /// <param name="permissions">The permissions for this component..</param>
        /// <param name="bulletins">The bulletins for this component..</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed..</param>
        /// <param name="component">component.</param>
        /// <param name="status">The status of the connection..</param>
        /// <param name="bends">The bend points on the connection..</param>
        /// <param name="labelIndex">The index of the bend point where to place the connection label..</param>
        /// <param name="getzIndex">The z index of the connection..</param>
        /// <param name="sourceId">The identifier of the source of this connection..</param>
        /// <param name="sourceGroupId">The identifier of the group of the source of this connection..</param>
        /// <param name="sourceType">The type of component the source connectable is. (required).</param>
        /// <param name="destinationId">The identifier of the destination of this connection..</param>
        /// <param name="destinationGroupId">The identifier of the group of the destination of this connection..</param>
        /// <param name="destinationType">The type of component the destination connectable is. (required).</param>
        public ConnectionEntity(RevisionDTO revision = default(RevisionDTO), string id = default(string), string uri = default(string), PositionDTO position = default(PositionDTO), PermissionsDTO permissions = default(PermissionsDTO), List<BulletinEntity> bulletins = default(List<BulletinEntity>), bool? disconnectedNodeAcknowledged = default(bool?), ConnectionDTO component = default(ConnectionDTO), ConnectionStatusDTO status = default(ConnectionStatusDTO), List<PositionDTO> bends = default(List<PositionDTO>), int? labelIndex = default(int?), long? getzIndex = default(long?), string sourceId = default(string), string sourceGroupId = default(string), SourceTypeEnum sourceType = default(SourceTypeEnum), string destinationId = default(string), string destinationGroupId = default(string), DestinationTypeEnum destinationType = default(DestinationTypeEnum))
        {
            // to ensure "sourceType" is required (not null)
            if (sourceType == null)
            {
                throw new InvalidDataException("sourceType is a required property for ConnectionEntity and cannot be null");
            }
            else
            {
                this.SourceType = sourceType;
            }
            // to ensure "destinationType" is required (not null)
            if (destinationType == null)
            {
                throw new InvalidDataException("destinationType is a required property for ConnectionEntity and cannot be null");
            }
            else
            {
                this.DestinationType = destinationType;
            }
            this.Revision = revision;
            this.Id = id;
            this.Uri = uri;
            this.Position = position;
            this.Permissions = permissions;
            this.Bulletins = bulletins;
            this.DisconnectedNodeAcknowledged = disconnectedNodeAcknowledged;
            this.Component = component;
            this.Status = status;
            this.Bends = bends;
            this.LabelIndex = labelIndex;
            this.GetzIndex = getzIndex;
            this.SourceId = sourceId;
            this.SourceGroupId = sourceGroupId;
            this.DestinationId = destinationId;
            this.DestinationGroupId = destinationGroupId;
        }
        
        /// <summary>
        /// The revision for this request/response. The revision is required for any mutable flow requests and is included in all responses.
        /// </summary>
        /// <value>The revision for this request/response. The revision is required for any mutable flow requests and is included in all responses.</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public RevisionDTO Revision { get; set; }

        /// <summary>
        /// The id of the component.
        /// </summary>
        /// <value>The id of the component.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The URI for futures requests to the component.
        /// </summary>
        /// <value>The URI for futures requests to the component.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The position of this component in the UI if applicable.
        /// </summary>
        /// <value>The position of this component in the UI if applicable.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public PositionDTO Position { get; set; }

        /// <summary>
        /// The permissions for this component.
        /// </summary>
        /// <value>The permissions for this component.</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public PermissionsDTO Permissions { get; set; }

        /// <summary>
        /// The bulletins for this component.
        /// </summary>
        /// <value>The bulletins for this component.</value>
        [DataMember(Name="bulletins", EmitDefaultValue=false)]
        public List<BulletinEntity> Bulletins { get; set; }

        /// <summary>
        /// Acknowledges that this node is disconnected to allow for mutable requests to proceed.
        /// </summary>
        /// <value>Acknowledges that this node is disconnected to allow for mutable requests to proceed.</value>
        [DataMember(Name="disconnectedNodeAcknowledged", EmitDefaultValue=false)]
        public bool? DisconnectedNodeAcknowledged { get; set; }

        /// <summary>
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public ConnectionDTO Component { get; set; }

        /// <summary>
        /// The status of the connection.
        /// </summary>
        /// <value>The status of the connection.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ConnectionStatusDTO Status { get; set; }

        /// <summary>
        /// The bend points on the connection.
        /// </summary>
        /// <value>The bend points on the connection.</value>
        [DataMember(Name="bends", EmitDefaultValue=false)]
        public List<PositionDTO> Bends { get; set; }

        /// <summary>
        /// The index of the bend point where to place the connection label.
        /// </summary>
        /// <value>The index of the bend point where to place the connection label.</value>
        [DataMember(Name="labelIndex", EmitDefaultValue=false)]
        public int? LabelIndex { get; set; }

        /// <summary>
        /// The z index of the connection.
        /// </summary>
        /// <value>The z index of the connection.</value>
        [DataMember(Name="getzIndex", EmitDefaultValue=false)]
        public long? GetzIndex { get; set; }

        /// <summary>
        /// The identifier of the source of this connection.
        /// </summary>
        /// <value>The identifier of the source of this connection.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The identifier of the group of the source of this connection.
        /// </summary>
        /// <value>The identifier of the group of the source of this connection.</value>
        [DataMember(Name="sourceGroupId", EmitDefaultValue=false)]
        public string SourceGroupId { get; set; }


        /// <summary>
        /// The identifier of the destination of this connection.
        /// </summary>
        /// <value>The identifier of the destination of this connection.</value>
        [DataMember(Name="destinationId", EmitDefaultValue=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// The identifier of the group of the destination of this connection.
        /// </summary>
        /// <value>The identifier of the group of the destination of this connection.</value>
        [DataMember(Name="destinationGroupId", EmitDefaultValue=false)]
        public string DestinationGroupId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionEntity {\n");
            sb.Append("  Revision: ").Append(this.Revision).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Uri: ").Append(this.Uri).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  Permissions: ").Append(this.Permissions).Append("\n");
            sb.Append("  Bulletins: ").Append(this.Bulletins).Append("\n");
            sb.Append("  DisconnectedNodeAcknowledged: ").Append(this.DisconnectedNodeAcknowledged).Append("\n");
            sb.Append("  Component: ").Append(this.Component).Append("\n");
            sb.Append("  Status: ").Append(this.Status).Append("\n");
            sb.Append("  Bends: ").Append(this.Bends).Append("\n");
            sb.Append("  LabelIndex: ").Append(this.LabelIndex).Append("\n");
            sb.Append("  GetzIndex: ").Append(this.GetzIndex).Append("\n");
            sb.Append("  SourceId: ").Append(this.SourceId).Append("\n");
            sb.Append("  SourceGroupId: ").Append(this.SourceGroupId).Append("\n");
            sb.Append("  SourceType: ").Append(this.SourceType).Append("\n");
            sb.Append("  DestinationId: ").Append(this.DestinationId).Append("\n");
            sb.Append("  DestinationGroupId: ").Append(this.DestinationGroupId).Append("\n");
            sb.Append("  DestinationType: ").Append(this.DestinationType).Append("\n");
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
            return this.Equals(input as ConnectionEntity);
        }

        /// <summary>
        /// Returns true if ConnectionEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionEntity input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.Bulletins == input.Bulletins ||
                    this.Bulletins != null &&
                    this.Bulletins.SequenceEqual(input.Bulletins)
                ) && 
                (
                    this.DisconnectedNodeAcknowledged == input.DisconnectedNodeAcknowledged ||
                    (this.DisconnectedNodeAcknowledged != null &&
                    this.DisconnectedNodeAcknowledged.Equals(input.DisconnectedNodeAcknowledged))
                ) && 
                (
                    this.Component == input.Component ||
                    (this.Component != null &&
                    this.Component.Equals(input.Component))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Bends == input.Bends ||
                    this.Bends != null &&
                    this.Bends.SequenceEqual(input.Bends)
                ) && 
                (
                    this.LabelIndex == input.LabelIndex ||
                    (this.LabelIndex != null &&
                    this.LabelIndex.Equals(input.LabelIndex))
                ) && 
                (
                    this.GetzIndex == input.GetzIndex ||
                    (this.GetzIndex != null &&
                    this.GetzIndex.Equals(input.GetzIndex))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.SourceGroupId == input.SourceGroupId ||
                    (this.SourceGroupId != null &&
                    this.SourceGroupId.Equals(input.SourceGroupId))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
                ) && 
                (
                    this.DestinationGroupId == input.DestinationGroupId ||
                    (this.DestinationGroupId != null &&
                    this.DestinationGroupId.Equals(input.DestinationGroupId))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Bulletins != null)
                    hashCode = hashCode * 59 + this.Bulletins.GetHashCode();
                if (this.DisconnectedNodeAcknowledged != null)
                    hashCode = hashCode * 59 + this.DisconnectedNodeAcknowledged.GetHashCode();
                if (this.Component != null)
                    hashCode = hashCode * 59 + this.Component.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Bends != null)
                    hashCode = hashCode * 59 + this.Bends.GetHashCode();
                if (this.LabelIndex != null)
                    hashCode = hashCode * 59 + this.LabelIndex.GetHashCode();
                if (this.GetzIndex != null)
                    hashCode = hashCode * 59 + this.GetzIndex.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SourceGroupId != null)
                    hashCode = hashCode * 59 + this.SourceGroupId.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.DestinationId != null)
                    hashCode = hashCode * 59 + this.DestinationId.GetHashCode();
                if (this.DestinationGroupId != null)
                    hashCode = hashCode * 59 + this.DestinationGroupId.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
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
