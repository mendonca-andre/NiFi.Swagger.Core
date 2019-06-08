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
    /// ConnectionDTO
    /// </summary>
    [DataContract]
    public partial class ConnectionDTO :  IEquatable<ConnectionDTO>, IValidatableObject
    {
        /// <summary>
        /// How to load balance the data in this Connection across the nodes in the cluster.
        /// </summary>
        /// <value>How to load balance the data in this Connection across the nodes in the cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LoadBalanceStrategyEnum
        {
            
            /// <summary>
            /// Enum DONOTLOADBALANCE for value: DO_NOT_LOAD_BALANCE
            /// </summary>
            [EnumMember(Value = "DO_NOT_LOAD_BALANCE")]
            DONOTLOADBALANCE = 1,
            
            /// <summary>
            /// Enum PARTITIONBYATTRIBUTE for value: PARTITION_BY_ATTRIBUTE
            /// </summary>
            [EnumMember(Value = "PARTITION_BY_ATTRIBUTE")]
            PARTITIONBYATTRIBUTE = 2,
            
            /// <summary>
            /// Enum ROUNDROBIN for value: ROUND_ROBIN
            /// </summary>
            [EnumMember(Value = "ROUND_ROBIN")]
            ROUNDROBIN = 3,
            
            /// <summary>
            /// Enum SINGLENODE for value: SINGLE_NODE
            /// </summary>
            [EnumMember(Value = "SINGLE_NODE")]
            SINGLENODE = 4
        }

        /// <summary>
        /// How to load balance the data in this Connection across the nodes in the cluster.
        /// </summary>
        /// <value>How to load balance the data in this Connection across the nodes in the cluster.</value>
        [DataMember(Name="loadBalanceStrategy", EmitDefaultValue=false)]
        public LoadBalanceStrategyEnum? LoadBalanceStrategy { get; set; }
        /// <summary>
        /// Whether or not data should be compressed when being transferred between nodes in the cluster.
        /// </summary>
        /// <value>Whether or not data should be compressed when being transferred between nodes in the cluster.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LoadBalanceCompressionEnum
        {
            
            /// <summary>
            /// Enum DONOTCOMPRESS for value: DO_NOT_COMPRESS
            /// </summary>
            [EnumMember(Value = "DO_NOT_COMPRESS")]
            DONOTCOMPRESS = 1,
            
            /// <summary>
            /// Enum COMPRESSATTRIBUTESONLY for value: COMPRESS_ATTRIBUTES_ONLY
            /// </summary>
            [EnumMember(Value = "COMPRESS_ATTRIBUTES_ONLY")]
            COMPRESSATTRIBUTESONLY = 2,
            
            /// <summary>
            /// Enum COMPRESSATTRIBUTESANDCONTENT for value: COMPRESS_ATTRIBUTES_AND_CONTENT
            /// </summary>
            [EnumMember(Value = "COMPRESS_ATTRIBUTES_AND_CONTENT")]
            COMPRESSATTRIBUTESANDCONTENT = 3
        }

        /// <summary>
        /// Whether or not data should be compressed when being transferred between nodes in the cluster.
        /// </summary>
        /// <value>Whether or not data should be compressed when being transferred between nodes in the cluster.</value>
        [DataMember(Name="loadBalanceCompression", EmitDefaultValue=false)]
        public LoadBalanceCompressionEnum? LoadBalanceCompression { get; set; }
        /// <summary>
        /// The current status of the Connection&#39;s Load Balancing Activities. Status can indicate that Load Balancing is not configured for the connection, that Load Balancing is configured but inactive (not currently transferring data to another node), or that Load Balancing is configured and actively transferring data to another node.
        /// </summary>
        /// <value>The current status of the Connection&#39;s Load Balancing Activities. Status can indicate that Load Balancing is not configured for the connection, that Load Balancing is configured but inactive (not currently transferring data to another node), or that Load Balancing is configured and actively transferring data to another node.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LoadBalanceStatusEnum
        {
            
            /// <summary>
            /// Enum NOTCONFIGURED for value: LOAD_BALANCE_NOT_CONFIGURED
            /// </summary>
            [EnumMember(Value = "LOAD_BALANCE_NOT_CONFIGURED")]
            NOTCONFIGURED = 1,
            
            /// <summary>
            /// Enum INACTIVE for value: LOAD_BALANCE_INACTIVE
            /// </summary>
            [EnumMember(Value = "LOAD_BALANCE_INACTIVE")]
            INACTIVE = 2,
            
            /// <summary>
            /// Enum ACTIVE for value: LOAD_BALANCE_ACTIVE
            /// </summary>
            [EnumMember(Value = "LOAD_BALANCE_ACTIVE")]
            ACTIVE = 3
        }

        /// <summary>
        /// The current status of the Connection&#39;s Load Balancing Activities. Status can indicate that Load Balancing is not configured for the connection, that Load Balancing is configured but inactive (not currently transferring data to another node), or that Load Balancing is configured and actively transferring data to another node.
        /// </summary>
        /// <value>The current status of the Connection&#39;s Load Balancing Activities. Status can indicate that Load Balancing is not configured for the connection, that Load Balancing is configured but inactive (not currently transferring data to another node), or that Load Balancing is configured and actively transferring data to another node.</value>
        [DataMember(Name="loadBalanceStatus", EmitDefaultValue=false)]
        public LoadBalanceStatusEnum? LoadBalanceStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionDTO" /> class.
        /// </summary>
        /// <param name="id">The id of the component..</param>
        /// <param name="versionedComponentId">The ID of the corresponding component that is under version control.</param>
        /// <param name="parentGroupId">The id of parent process group of this component if applicable..</param>
        /// <param name="position">The position of this component in the UI if applicable..</param>
        /// <param name="source">The source of the connection..</param>
        /// <param name="destination">The destination of the connection..</param>
        /// <param name="name">The name of the connection..</param>
        /// <param name="labelIndex">The index of the bend point where to place the connection label..</param>
        /// <param name="getzIndex">The z index of the connection..</param>
        /// <param name="selectedRelationships">The selected relationship that comprise the connection..</param>
        /// <param name="backPressureObjectThreshold">The object count threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue..</param>
        /// <param name="backPressureDataSizeThreshold">The object data size threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue..</param>
        /// <param name="flowFileExpiration">The amount of time a flow file may be in the flow before it will be automatically aged out of the flow. Once a flow file reaches this age it will be terminated from the flow the next time a processor attempts to start work on it..</param>
        /// <param name="prioritizers">The comparators used to prioritize the queue..</param>
        /// <param name="bends">The bend points on the connection..</param>
        /// <param name="loadBalanceStrategy">How to load balance the data in this Connection across the nodes in the cluster..</param>
        /// <param name="loadBalancePartitionAttribute">The FlowFile Attribute to use for determining which node a FlowFile will go to if the Load Balancing Strategy is set to PARTITION_BY_ATTRIBUTE.</param>
        /// <param name="loadBalanceCompression">Whether or not data should be compressed when being transferred between nodes in the cluster..</param>
        public ConnectionDTO(string id = default(string), string versionedComponentId = default(string), string parentGroupId = default(string), PositionDTO position = default(PositionDTO), ConnectableDTO source = default(ConnectableDTO), ConnectableDTO destination = default(ConnectableDTO), string name = default(string), int? labelIndex = default(int?), long? getzIndex = default(long?), List<string> selectedRelationships = default(List<string>), long? backPressureObjectThreshold = default(long?), string backPressureDataSizeThreshold = default(string), string flowFileExpiration = default(string), List<string> prioritizers = default(List<string>), List<PositionDTO> bends = default(List<PositionDTO>), LoadBalanceStrategyEnum? loadBalanceStrategy = default(LoadBalanceStrategyEnum?), string loadBalancePartitionAttribute = default(string), LoadBalanceCompressionEnum? loadBalanceCompression = default(LoadBalanceCompressionEnum?))
        {
            this.Id = id;
            this.VersionedComponentId = versionedComponentId;
            this.ParentGroupId = parentGroupId;
            this.Position = position;
            this.Source = source;
            this.Destination = destination;
            this.Name = name;
            this.LabelIndex = labelIndex;
            this.GetzIndex = getzIndex;
            this.SelectedRelationships = selectedRelationships;
            this.BackPressureObjectThreshold = backPressureObjectThreshold;
            this.BackPressureDataSizeThreshold = backPressureDataSizeThreshold;
            this.FlowFileExpiration = flowFileExpiration;
            this.Prioritizers = prioritizers;
            this.Bends = bends;
            this.LoadBalanceStrategy = loadBalanceStrategy;
            this.LoadBalancePartitionAttribute = loadBalancePartitionAttribute;
            this.LoadBalanceCompression = loadBalanceCompression;
        }
        
        /// <summary>
        /// The id of the component.
        /// </summary>
        /// <value>The id of the component.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the corresponding component that is under version control
        /// </summary>
        /// <value>The ID of the corresponding component that is under version control</value>
        [DataMember(Name="versionedComponentId", EmitDefaultValue=false)]
        public string VersionedComponentId { get; set; }

        /// <summary>
        /// The id of parent process group of this component if applicable.
        /// </summary>
        /// <value>The id of parent process group of this component if applicable.</value>
        [DataMember(Name="parentGroupId", EmitDefaultValue=false)]
        public string ParentGroupId { get; set; }

        /// <summary>
        /// The position of this component in the UI if applicable.
        /// </summary>
        /// <value>The position of this component in the UI if applicable.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public PositionDTO Position { get; set; }

        /// <summary>
        /// The source of the connection.
        /// </summary>
        /// <value>The source of the connection.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public ConnectableDTO Source { get; set; }

        /// <summary>
        /// The destination of the connection.
        /// </summary>
        /// <value>The destination of the connection.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public ConnectableDTO Destination { get; set; }

        /// <summary>
        /// The name of the connection.
        /// </summary>
        /// <value>The name of the connection.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        /// The selected relationship that comprise the connection.
        /// </summary>
        /// <value>The selected relationship that comprise the connection.</value>
        [DataMember(Name="selectedRelationships", EmitDefaultValue=false)]
        public List<string> SelectedRelationships { get; set; }

        /// <summary>
        /// The relationships that the source of the connection currently supports.
        /// </summary>
        /// <value>The relationships that the source of the connection currently supports.</value>
        [DataMember(Name="availableRelationships", EmitDefaultValue=false)]
        public List<string> AvailableRelationships { get; private set; }

        /// <summary>
        /// The object count threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue.
        /// </summary>
        /// <value>The object count threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue.</value>
        [DataMember(Name="backPressureObjectThreshold", EmitDefaultValue=false)]
        public long? BackPressureObjectThreshold { get; set; }

        /// <summary>
        /// The object data size threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue.
        /// </summary>
        /// <value>The object data size threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue.</value>
        [DataMember(Name="backPressureDataSizeThreshold", EmitDefaultValue=false)]
        public string BackPressureDataSizeThreshold { get; set; }

        /// <summary>
        /// The amount of time a flow file may be in the flow before it will be automatically aged out of the flow. Once a flow file reaches this age it will be terminated from the flow the next time a processor attempts to start work on it.
        /// </summary>
        /// <value>The amount of time a flow file may be in the flow before it will be automatically aged out of the flow. Once a flow file reaches this age it will be terminated from the flow the next time a processor attempts to start work on it.</value>
        [DataMember(Name="flowFileExpiration", EmitDefaultValue=false)]
        public string FlowFileExpiration { get; set; }

        /// <summary>
        /// The comparators used to prioritize the queue.
        /// </summary>
        /// <value>The comparators used to prioritize the queue.</value>
        [DataMember(Name="prioritizers", EmitDefaultValue=false)]
        public List<string> Prioritizers { get; set; }

        /// <summary>
        /// The bend points on the connection.
        /// </summary>
        /// <value>The bend points on the connection.</value>
        [DataMember(Name="bends", EmitDefaultValue=false)]
        public List<PositionDTO> Bends { get; set; }


        /// <summary>
        /// The FlowFile Attribute to use for determining which node a FlowFile will go to if the Load Balancing Strategy is set to PARTITION_BY_ATTRIBUTE
        /// </summary>
        /// <value>The FlowFile Attribute to use for determining which node a FlowFile will go to if the Load Balancing Strategy is set to PARTITION_BY_ATTRIBUTE</value>
        [DataMember(Name="loadBalancePartitionAttribute", EmitDefaultValue=false)]
        public string LoadBalancePartitionAttribute { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  VersionedComponentId: ").Append(this.VersionedComponentId).Append("\n");
            sb.Append("  ParentGroupId: ").Append(this.ParentGroupId).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  Source: ").Append(this.Source).Append("\n");
            sb.Append("  Destination: ").Append(this.Destination).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  LabelIndex: ").Append(this.LabelIndex).Append("\n");
            sb.Append("  GetzIndex: ").Append(this.GetzIndex).Append("\n");
            sb.Append("  SelectedRelationships: ").Append(this.SelectedRelationships).Append("\n");
            sb.Append("  AvailableRelationships: ").Append(this.AvailableRelationships).Append("\n");
            sb.Append("  BackPressureObjectThreshold: ").Append(this.BackPressureObjectThreshold).Append("\n");
            sb.Append("  BackPressureDataSizeThreshold: ").Append(this.BackPressureDataSizeThreshold).Append("\n");
            sb.Append("  FlowFileExpiration: ").Append(this.FlowFileExpiration).Append("\n");
            sb.Append("  Prioritizers: ").Append(this.Prioritizers).Append("\n");
            sb.Append("  Bends: ").Append(this.Bends).Append("\n");
            sb.Append("  LoadBalanceStrategy: ").Append(this.LoadBalanceStrategy).Append("\n");
            sb.Append("  LoadBalancePartitionAttribute: ").Append(this.LoadBalancePartitionAttribute).Append("\n");
            sb.Append("  LoadBalanceCompression: ").Append(this.LoadBalanceCompression).Append("\n");
            sb.Append("  LoadBalanceStatus: ").Append(this.LoadBalanceStatus).Append("\n");
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
            return this.Equals(input as ConnectionDTO);
        }

        /// <summary>
        /// Returns true if ConnectionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionDTO input)
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
                    this.VersionedComponentId == input.VersionedComponentId ||
                    (this.VersionedComponentId != null &&
                    this.VersionedComponentId.Equals(input.VersionedComponentId))
                ) && 
                (
                    this.ParentGroupId == input.ParentGroupId ||
                    (this.ParentGroupId != null &&
                    this.ParentGroupId.Equals(input.ParentGroupId))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.SelectedRelationships == input.SelectedRelationships ||
                    this.SelectedRelationships != null &&
                    this.SelectedRelationships.SequenceEqual(input.SelectedRelationships)
                ) && 
                (
                    this.AvailableRelationships == input.AvailableRelationships ||
                    this.AvailableRelationships != null &&
                    this.AvailableRelationships.SequenceEqual(input.AvailableRelationships)
                ) && 
                (
                    this.BackPressureObjectThreshold == input.BackPressureObjectThreshold ||
                    (this.BackPressureObjectThreshold != null &&
                    this.BackPressureObjectThreshold.Equals(input.BackPressureObjectThreshold))
                ) && 
                (
                    this.BackPressureDataSizeThreshold == input.BackPressureDataSizeThreshold ||
                    (this.BackPressureDataSizeThreshold != null &&
                    this.BackPressureDataSizeThreshold.Equals(input.BackPressureDataSizeThreshold))
                ) && 
                (
                    this.FlowFileExpiration == input.FlowFileExpiration ||
                    (this.FlowFileExpiration != null &&
                    this.FlowFileExpiration.Equals(input.FlowFileExpiration))
                ) && 
                (
                    this.Prioritizers == input.Prioritizers ||
                    this.Prioritizers != null &&
                    this.Prioritizers.SequenceEqual(input.Prioritizers)
                ) && 
                (
                    this.Bends == input.Bends ||
                    this.Bends != null &&
                    this.Bends.SequenceEqual(input.Bends)
                ) && 
                (
                    this.LoadBalanceStrategy == input.LoadBalanceStrategy ||
                    (this.LoadBalanceStrategy != null &&
                    this.LoadBalanceStrategy.Equals(input.LoadBalanceStrategy))
                ) && 
                (
                    this.LoadBalancePartitionAttribute == input.LoadBalancePartitionAttribute ||
                    (this.LoadBalancePartitionAttribute != null &&
                    this.LoadBalancePartitionAttribute.Equals(input.LoadBalancePartitionAttribute))
                ) && 
                (
                    this.LoadBalanceCompression == input.LoadBalanceCompression ||
                    (this.LoadBalanceCompression != null &&
                    this.LoadBalanceCompression.Equals(input.LoadBalanceCompression))
                ) && 
                (
                    this.LoadBalanceStatus == input.LoadBalanceStatus ||
                    (this.LoadBalanceStatus != null &&
                    this.LoadBalanceStatus.Equals(input.LoadBalanceStatus))
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
                if (this.VersionedComponentId != null)
                    hashCode = hashCode * 59 + this.VersionedComponentId.GetHashCode();
                if (this.ParentGroupId != null)
                    hashCode = hashCode * 59 + this.ParentGroupId.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LabelIndex != null)
                    hashCode = hashCode * 59 + this.LabelIndex.GetHashCode();
                if (this.GetzIndex != null)
                    hashCode = hashCode * 59 + this.GetzIndex.GetHashCode();
                if (this.SelectedRelationships != null)
                    hashCode = hashCode * 59 + this.SelectedRelationships.GetHashCode();
                if (this.AvailableRelationships != null)
                    hashCode = hashCode * 59 + this.AvailableRelationships.GetHashCode();
                if (this.BackPressureObjectThreshold != null)
                    hashCode = hashCode * 59 + this.BackPressureObjectThreshold.GetHashCode();
                if (this.BackPressureDataSizeThreshold != null)
                    hashCode = hashCode * 59 + this.BackPressureDataSizeThreshold.GetHashCode();
                if (this.FlowFileExpiration != null)
                    hashCode = hashCode * 59 + this.FlowFileExpiration.GetHashCode();
                if (this.Prioritizers != null)
                    hashCode = hashCode * 59 + this.Prioritizers.GetHashCode();
                if (this.Bends != null)
                    hashCode = hashCode * 59 + this.Bends.GetHashCode();
                if (this.LoadBalanceStrategy != null)
                    hashCode = hashCode * 59 + this.LoadBalanceStrategy.GetHashCode();
                if (this.LoadBalancePartitionAttribute != null)
                    hashCode = hashCode * 59 + this.LoadBalancePartitionAttribute.GetHashCode();
                if (this.LoadBalanceCompression != null)
                    hashCode = hashCode * 59 + this.LoadBalanceCompression.GetHashCode();
                if (this.LoadBalanceStatus != null)
                    hashCode = hashCode * 59 + this.LoadBalanceStatus.GetHashCode();
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