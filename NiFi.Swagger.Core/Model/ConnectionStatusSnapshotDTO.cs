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
    /// ConnectionStatusSnapshotDTO
    /// </summary>
    [DataContract]
    public partial class ConnectionStatusSnapshotDTO :  IEquatable<ConnectionStatusSnapshotDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionStatusSnapshotDTO" /> class.
        /// </summary>
        /// <param name="id">The id of the connection..</param>
        /// <param name="groupId">The id of the process group the connection belongs to..</param>
        /// <param name="name">The name of the connection..</param>
        /// <param name="sourceId">The id of the source of the connection..</param>
        /// <param name="sourceName">The name of the source of the connection..</param>
        /// <param name="destinationId">The id of the destination of the connection..</param>
        /// <param name="destinationName">The name of the destination of the connection..</param>
        /// <param name="flowFilesIn">The number of FlowFiles that have come into the connection in the last 5 minutes..</param>
        /// <param name="bytesIn">The size of the FlowFiles that have come into the connection in the last 5 minutes..</param>
        /// <param name="input">The input count/size for the connection in the last 5 minutes, pretty printed..</param>
        /// <param name="flowFilesOut">The number of FlowFiles that have left the connection in the last 5 minutes..</param>
        /// <param name="bytesOut">The number of bytes that have left the connection in the last 5 minutes..</param>
        /// <param name="output">The output count/sie for the connection in the last 5 minutes, pretty printed..</param>
        /// <param name="flowFilesQueued">The number of FlowFiles that are currently queued in the connection..</param>
        /// <param name="bytesQueued">The size of the FlowFiles that are currently queued in the connection..</param>
        /// <param name="queued">The total count and size of queued flowfiles formatted..</param>
        /// <param name="queuedSize">The total size of flowfiles that are queued formatted..</param>
        /// <param name="queuedCount">The number of flowfiles that are queued, pretty printed..</param>
        /// <param name="percentUseCount">Connection percent use regarding queued flow files count and backpressure threshold if configured..</param>
        /// <param name="percentUseBytes">Connection percent use regarding queued flow files size and backpressure threshold if configured..</param>
        public ConnectionStatusSnapshotDTO(string id = default(string), string groupId = default(string), string name = default(string), string sourceId = default(string), string sourceName = default(string), string destinationId = default(string), string destinationName = default(string), int? flowFilesIn = default(int?), long? bytesIn = default(long?), string input = default(string), int? flowFilesOut = default(int?), long? bytesOut = default(long?), string output = default(string), int? flowFilesQueued = default(int?), long? bytesQueued = default(long?), string queued = default(string), string queuedSize = default(string), string queuedCount = default(string), int? percentUseCount = default(int?), int? percentUseBytes = default(int?))
        {
            this.Id = id;
            this.GroupId = groupId;
            this.Name = name;
            this.SourceId = sourceId;
            this.SourceName = sourceName;
            this.DestinationId = destinationId;
            this.DestinationName = destinationName;
            this.FlowFilesIn = flowFilesIn;
            this.BytesIn = bytesIn;
            this.Input = input;
            this.FlowFilesOut = flowFilesOut;
            this.BytesOut = bytesOut;
            this.Output = output;
            this.FlowFilesQueued = flowFilesQueued;
            this.BytesQueued = bytesQueued;
            this.Queued = queued;
            this.QueuedSize = queuedSize;
            this.QueuedCount = queuedCount;
            this.PercentUseCount = percentUseCount;
            this.PercentUseBytes = percentUseBytes;
        }
        
        /// <summary>
        /// The id of the connection.
        /// </summary>
        /// <value>The id of the connection.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The id of the process group the connection belongs to.
        /// </summary>
        /// <value>The id of the process group the connection belongs to.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the connection.
        /// </summary>
        /// <value>The name of the connection.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The id of the source of the connection.
        /// </summary>
        /// <value>The id of the source of the connection.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The name of the source of the connection.
        /// </summary>
        /// <value>The name of the source of the connection.</value>
        [DataMember(Name="sourceName", EmitDefaultValue=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// The id of the destination of the connection.
        /// </summary>
        /// <value>The id of the destination of the connection.</value>
        [DataMember(Name="destinationId", EmitDefaultValue=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// The name of the destination of the connection.
        /// </summary>
        /// <value>The name of the destination of the connection.</value>
        [DataMember(Name="destinationName", EmitDefaultValue=false)]
        public string DestinationName { get; set; }

        /// <summary>
        /// The number of FlowFiles that have come into the connection in the last 5 minutes.
        /// </summary>
        /// <value>The number of FlowFiles that have come into the connection in the last 5 minutes.</value>
        [DataMember(Name="flowFilesIn", EmitDefaultValue=false)]
        public int? FlowFilesIn { get; set; }

        /// <summary>
        /// The size of the FlowFiles that have come into the connection in the last 5 minutes.
        /// </summary>
        /// <value>The size of the FlowFiles that have come into the connection in the last 5 minutes.</value>
        [DataMember(Name="bytesIn", EmitDefaultValue=false)]
        public long? BytesIn { get; set; }

        /// <summary>
        /// The input count/size for the connection in the last 5 minutes, pretty printed.
        /// </summary>
        /// <value>The input count/size for the connection in the last 5 minutes, pretty printed.</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public string Input { get; set; }

        /// <summary>
        /// The number of FlowFiles that have left the connection in the last 5 minutes.
        /// </summary>
        /// <value>The number of FlowFiles that have left the connection in the last 5 minutes.</value>
        [DataMember(Name="flowFilesOut", EmitDefaultValue=false)]
        public int? FlowFilesOut { get; set; }

        /// <summary>
        /// The number of bytes that have left the connection in the last 5 minutes.
        /// </summary>
        /// <value>The number of bytes that have left the connection in the last 5 minutes.</value>
        [DataMember(Name="bytesOut", EmitDefaultValue=false)]
        public long? BytesOut { get; set; }

        /// <summary>
        /// The output count/sie for the connection in the last 5 minutes, pretty printed.
        /// </summary>
        /// <value>The output count/sie for the connection in the last 5 minutes, pretty printed.</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public string Output { get; set; }

        /// <summary>
        /// The number of FlowFiles that are currently queued in the connection.
        /// </summary>
        /// <value>The number of FlowFiles that are currently queued in the connection.</value>
        [DataMember(Name="flowFilesQueued", EmitDefaultValue=false)]
        public int? FlowFilesQueued { get; set; }

        /// <summary>
        /// The size of the FlowFiles that are currently queued in the connection.
        /// </summary>
        /// <value>The size of the FlowFiles that are currently queued in the connection.</value>
        [DataMember(Name="bytesQueued", EmitDefaultValue=false)]
        public long? BytesQueued { get; set; }

        /// <summary>
        /// The total count and size of queued flowfiles formatted.
        /// </summary>
        /// <value>The total count and size of queued flowfiles formatted.</value>
        [DataMember(Name="queued", EmitDefaultValue=false)]
        public string Queued { get; set; }

        /// <summary>
        /// The total size of flowfiles that are queued formatted.
        /// </summary>
        /// <value>The total size of flowfiles that are queued formatted.</value>
        [DataMember(Name="queuedSize", EmitDefaultValue=false)]
        public string QueuedSize { get; set; }

        /// <summary>
        /// The number of flowfiles that are queued, pretty printed.
        /// </summary>
        /// <value>The number of flowfiles that are queued, pretty printed.</value>
        [DataMember(Name="queuedCount", EmitDefaultValue=false)]
        public string QueuedCount { get; set; }

        /// <summary>
        /// Connection percent use regarding queued flow files count and backpressure threshold if configured.
        /// </summary>
        /// <value>Connection percent use regarding queued flow files count and backpressure threshold if configured.</value>
        [DataMember(Name="percentUseCount", EmitDefaultValue=false)]
        public int? PercentUseCount { get; set; }

        /// <summary>
        /// Connection percent use regarding queued flow files size and backpressure threshold if configured.
        /// </summary>
        /// <value>Connection percent use regarding queued flow files size and backpressure threshold if configured.</value>
        [DataMember(Name="percentUseBytes", EmitDefaultValue=false)]
        public int? PercentUseBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionStatusSnapshotDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  GroupId: ").Append(this.GroupId).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  SourceId: ").Append(this.SourceId).Append("\n");
            sb.Append("  SourceName: ").Append(this.SourceName).Append("\n");
            sb.Append("  DestinationId: ").Append(this.DestinationId).Append("\n");
            sb.Append("  DestinationName: ").Append(this.DestinationName).Append("\n");
            sb.Append("  FlowFilesIn: ").Append(this.FlowFilesIn).Append("\n");
            sb.Append("  BytesIn: ").Append(this.BytesIn).Append("\n");
            sb.Append("  Input: ").Append(this.Input).Append("\n");
            sb.Append("  FlowFilesOut: ").Append(this.FlowFilesOut).Append("\n");
            sb.Append("  BytesOut: ").Append(this.BytesOut).Append("\n");
            sb.Append("  Output: ").Append(this.Output).Append("\n");
            sb.Append("  FlowFilesQueued: ").Append(this.FlowFilesQueued).Append("\n");
            sb.Append("  BytesQueued: ").Append(this.BytesQueued).Append("\n");
            sb.Append("  Queued: ").Append(this.Queued).Append("\n");
            sb.Append("  QueuedSize: ").Append(this.QueuedSize).Append("\n");
            sb.Append("  QueuedCount: ").Append(this.QueuedCount).Append("\n");
            sb.Append("  PercentUseCount: ").Append(this.PercentUseCount).Append("\n");
            sb.Append("  PercentUseBytes: ").Append(this.PercentUseBytes).Append("\n");
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
            return this.Equals(input as ConnectionStatusSnapshotDTO);
        }

        /// <summary>
        /// Returns true if ConnectionStatusSnapshotDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionStatusSnapshotDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionStatusSnapshotDTO input)
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
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.SourceName == input.SourceName ||
                    (this.SourceName != null &&
                    this.SourceName.Equals(input.SourceName))
                ) && 
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
                ) && 
                (
                    this.DestinationName == input.DestinationName ||
                    (this.DestinationName != null &&
                    this.DestinationName.Equals(input.DestinationName))
                ) && 
                (
                    this.FlowFilesIn == input.FlowFilesIn ||
                    (this.FlowFilesIn != null &&
                    this.FlowFilesIn.Equals(input.FlowFilesIn))
                ) && 
                (
                    this.BytesIn == input.BytesIn ||
                    (this.BytesIn != null &&
                    this.BytesIn.Equals(input.BytesIn))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.FlowFilesOut == input.FlowFilesOut ||
                    (this.FlowFilesOut != null &&
                    this.FlowFilesOut.Equals(input.FlowFilesOut))
                ) && 
                (
                    this.BytesOut == input.BytesOut ||
                    (this.BytesOut != null &&
                    this.BytesOut.Equals(input.BytesOut))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
                ) && 
                (
                    this.FlowFilesQueued == input.FlowFilesQueued ||
                    (this.FlowFilesQueued != null &&
                    this.FlowFilesQueued.Equals(input.FlowFilesQueued))
                ) && 
                (
                    this.BytesQueued == input.BytesQueued ||
                    (this.BytesQueued != null &&
                    this.BytesQueued.Equals(input.BytesQueued))
                ) && 
                (
                    this.Queued == input.Queued ||
                    (this.Queued != null &&
                    this.Queued.Equals(input.Queued))
                ) && 
                (
                    this.QueuedSize == input.QueuedSize ||
                    (this.QueuedSize != null &&
                    this.QueuedSize.Equals(input.QueuedSize))
                ) && 
                (
                    this.QueuedCount == input.QueuedCount ||
                    (this.QueuedCount != null &&
                    this.QueuedCount.Equals(input.QueuedCount))
                ) && 
                (
                    this.PercentUseCount == input.PercentUseCount ||
                    (this.PercentUseCount != null &&
                    this.PercentUseCount.Equals(input.PercentUseCount))
                ) && 
                (
                    this.PercentUseBytes == input.PercentUseBytes ||
                    (this.PercentUseBytes != null &&
                    this.PercentUseBytes.Equals(input.PercentUseBytes))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SourceName != null)
                    hashCode = hashCode * 59 + this.SourceName.GetHashCode();
                if (this.DestinationId != null)
                    hashCode = hashCode * 59 + this.DestinationId.GetHashCode();
                if (this.DestinationName != null)
                    hashCode = hashCode * 59 + this.DestinationName.GetHashCode();
                if (this.FlowFilesIn != null)
                    hashCode = hashCode * 59 + this.FlowFilesIn.GetHashCode();
                if (this.BytesIn != null)
                    hashCode = hashCode * 59 + this.BytesIn.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.FlowFilesOut != null)
                    hashCode = hashCode * 59 + this.FlowFilesOut.GetHashCode();
                if (this.BytesOut != null)
                    hashCode = hashCode * 59 + this.BytesOut.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.FlowFilesQueued != null)
                    hashCode = hashCode * 59 + this.FlowFilesQueued.GetHashCode();
                if (this.BytesQueued != null)
                    hashCode = hashCode * 59 + this.BytesQueued.GetHashCode();
                if (this.Queued != null)
                    hashCode = hashCode * 59 + this.Queued.GetHashCode();
                if (this.QueuedSize != null)
                    hashCode = hashCode * 59 + this.QueuedSize.GetHashCode();
                if (this.QueuedCount != null)
                    hashCode = hashCode * 59 + this.QueuedCount.GetHashCode();
                if (this.PercentUseCount != null)
                    hashCode = hashCode * 59 + this.PercentUseCount.GetHashCode();
                if (this.PercentUseBytes != null)
                    hashCode = hashCode * 59 + this.PercentUseBytes.GetHashCode();
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
