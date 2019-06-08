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
    /// RemoteProcessGroupDTO
    /// </summary>
    [DataContract]
    public partial class RemoteProcessGroupDTO :  IEquatable<RemoteProcessGroupDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteProcessGroupDTO" /> class.
        /// </summary>
        /// <param name="id">The id of the component..</param>
        /// <param name="versionedComponentId">The ID of the corresponding component that is under version control.</param>
        /// <param name="parentGroupId">The id of parent process group of this component if applicable..</param>
        /// <param name="position">The position of this component in the UI if applicable..</param>
        /// <param name="targetUri">The target URI of the remote process group. If target uri is not set, but uris are set, then returns the first url in the urls. If neither target uri nor uris are set, then returns null..</param>
        /// <param name="targetUris">The target URI of the remote process group. If target uris is not set but target uri is set, then returns a collection containing the single target uri. If neither target uris nor uris are set, then returns null..</param>
        /// <param name="targetSecure">Whether the target is running securely..</param>
        /// <param name="name">The name of the remote process group..</param>
        /// <param name="comments">The comments for the remote process group..</param>
        /// <param name="communicationsTimeout">The time period used for the timeout when communicating with the target..</param>
        /// <param name="yieldDuration">When yielding, this amount of time must elapse before the remote process group is scheduled again..</param>
        /// <param name="transportProtocol">transportProtocol.</param>
        /// <param name="localNetworkInterface">The local network interface to send/receive data. If not specified, any local address is used. If clustered, all nodes must have an interface with this identifier..</param>
        /// <param name="proxyHost">proxyHost.</param>
        /// <param name="proxyPort">proxyPort.</param>
        /// <param name="proxyUser">proxyUser.</param>
        /// <param name="proxyPassword">proxyPassword.</param>
        /// <param name="authorizationIssues">Any remote authorization issues for the remote process group..</param>
        /// <param name="validationErrors">The validation errors for the remote process group. These validation errors represent the problems with the remote process group that must be resolved before it can transmit..</param>
        /// <param name="transmitting">Whether the remote process group is actively transmitting..</param>
        /// <param name="inputPortCount">The number of remote input ports currently available on the target..</param>
        /// <param name="outputPortCount">The number of remote output ports currently available on the target..</param>
        /// <param name="activeRemoteInputPortCount">The number of active remote input ports..</param>
        /// <param name="inactiveRemoteInputPortCount">The number of inactive remote input ports..</param>
        /// <param name="activeRemoteOutputPortCount">The number of active remote output ports..</param>
        /// <param name="inactiveRemoteOutputPortCount">The number of inactive remote output ports..</param>
        /// <param name="flowRefreshed">The timestamp when this remote process group was last refreshed..</param>
        /// <param name="contents">The contents of the remote process group. Will contain available input/output ports..</param>
        public RemoteProcessGroupDTO(string id = default(string), string versionedComponentId = default(string), string parentGroupId = default(string), PositionDTO position = default(PositionDTO), string targetUri = default(string), string targetUris = default(string), bool? targetSecure = default(bool?), string name = default(string), string comments = default(string), string communicationsTimeout = default(string), string yieldDuration = default(string), string transportProtocol = default(string), string localNetworkInterface = default(string), string proxyHost = default(string), int? proxyPort = default(int?), string proxyUser = default(string), string proxyPassword = default(string), List<string> authorizationIssues = default(List<string>), List<string> validationErrors = default(List<string>), bool? transmitting = default(bool?), int? inputPortCount = default(int?), int? outputPortCount = default(int?), int? activeRemoteInputPortCount = default(int?), int? inactiveRemoteInputPortCount = default(int?), int? activeRemoteOutputPortCount = default(int?), int? inactiveRemoteOutputPortCount = default(int?), string flowRefreshed = default(string), RemoteProcessGroupContentsDTO contents = default(RemoteProcessGroupContentsDTO))
        {
            this.Id = id;
            this.VersionedComponentId = versionedComponentId;
            this.ParentGroupId = parentGroupId;
            this.Position = position;
            this.TargetUri = targetUri;
            this.TargetUris = targetUris;
            this.TargetSecure = targetSecure;
            this.Name = name;
            this.Comments = comments;
            this.CommunicationsTimeout = communicationsTimeout;
            this.YieldDuration = yieldDuration;
            this.TransportProtocol = transportProtocol;
            this.LocalNetworkInterface = localNetworkInterface;
            this.ProxyHost = proxyHost;
            this.ProxyPort = proxyPort;
            this.ProxyUser = proxyUser;
            this.ProxyPassword = proxyPassword;
            this.AuthorizationIssues = authorizationIssues;
            this.ValidationErrors = validationErrors;
            this.Transmitting = transmitting;
            this.InputPortCount = inputPortCount;
            this.OutputPortCount = outputPortCount;
            this.ActiveRemoteInputPortCount = activeRemoteInputPortCount;
            this.InactiveRemoteInputPortCount = inactiveRemoteInputPortCount;
            this.ActiveRemoteOutputPortCount = activeRemoteOutputPortCount;
            this.InactiveRemoteOutputPortCount = inactiveRemoteOutputPortCount;
            this.FlowRefreshed = flowRefreshed;
            this.Contents = contents;
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
        /// The target URI of the remote process group. If target uri is not set, but uris are set, then returns the first url in the urls. If neither target uri nor uris are set, then returns null.
        /// </summary>
        /// <value>The target URI of the remote process group. If target uri is not set, but uris are set, then returns the first url in the urls. If neither target uri nor uris are set, then returns null.</value>
        [DataMember(Name="targetUri", EmitDefaultValue=false)]
        public string TargetUri { get; set; }

        /// <summary>
        /// The target URI of the remote process group. If target uris is not set but target uri is set, then returns a collection containing the single target uri. If neither target uris nor uris are set, then returns null.
        /// </summary>
        /// <value>The target URI of the remote process group. If target uris is not set but target uri is set, then returns a collection containing the single target uri. If neither target uris nor uris are set, then returns null.</value>
        [DataMember(Name="targetUris", EmitDefaultValue=false)]
        public string TargetUris { get; set; }

        /// <summary>
        /// Whether the target is running securely.
        /// </summary>
        /// <value>Whether the target is running securely.</value>
        [DataMember(Name="targetSecure", EmitDefaultValue=false)]
        public bool? TargetSecure { get; set; }

        /// <summary>
        /// The name of the remote process group.
        /// </summary>
        /// <value>The name of the remote process group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The comments for the remote process group.
        /// </summary>
        /// <value>The comments for the remote process group.</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// The time period used for the timeout when communicating with the target.
        /// </summary>
        /// <value>The time period used for the timeout when communicating with the target.</value>
        [DataMember(Name="communicationsTimeout", EmitDefaultValue=false)]
        public string CommunicationsTimeout { get; set; }

        /// <summary>
        /// When yielding, this amount of time must elapse before the remote process group is scheduled again.
        /// </summary>
        /// <value>When yielding, this amount of time must elapse before the remote process group is scheduled again.</value>
        [DataMember(Name="yieldDuration", EmitDefaultValue=false)]
        public string YieldDuration { get; set; }

        /// <summary>
        /// Gets or Sets TransportProtocol
        /// </summary>
        [DataMember(Name="transportProtocol", EmitDefaultValue=false)]
        public string TransportProtocol { get; set; }

        /// <summary>
        /// The local network interface to send/receive data. If not specified, any local address is used. If clustered, all nodes must have an interface with this identifier.
        /// </summary>
        /// <value>The local network interface to send/receive data. If not specified, any local address is used. If clustered, all nodes must have an interface with this identifier.</value>
        [DataMember(Name="localNetworkInterface", EmitDefaultValue=false)]
        public string LocalNetworkInterface { get; set; }

        /// <summary>
        /// Gets or Sets ProxyHost
        /// </summary>
        [DataMember(Name="proxyHost", EmitDefaultValue=false)]
        public string ProxyHost { get; set; }

        /// <summary>
        /// Gets or Sets ProxyPort
        /// </summary>
        [DataMember(Name="proxyPort", EmitDefaultValue=false)]
        public int? ProxyPort { get; set; }

        /// <summary>
        /// Gets or Sets ProxyUser
        /// </summary>
        [DataMember(Name="proxyUser", EmitDefaultValue=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// Gets or Sets ProxyPassword
        /// </summary>
        [DataMember(Name="proxyPassword", EmitDefaultValue=false)]
        public string ProxyPassword { get; set; }

        /// <summary>
        /// Any remote authorization issues for the remote process group.
        /// </summary>
        /// <value>Any remote authorization issues for the remote process group.</value>
        [DataMember(Name="authorizationIssues", EmitDefaultValue=false)]
        public List<string> AuthorizationIssues { get; set; }

        /// <summary>
        /// The validation errors for the remote process group. These validation errors represent the problems with the remote process group that must be resolved before it can transmit.
        /// </summary>
        /// <value>The validation errors for the remote process group. These validation errors represent the problems with the remote process group that must be resolved before it can transmit.</value>
        [DataMember(Name="validationErrors", EmitDefaultValue=false)]
        public List<string> ValidationErrors { get; set; }

        /// <summary>
        /// Whether the remote process group is actively transmitting.
        /// </summary>
        /// <value>Whether the remote process group is actively transmitting.</value>
        [DataMember(Name="transmitting", EmitDefaultValue=false)]
        public bool? Transmitting { get; set; }

        /// <summary>
        /// The number of remote input ports currently available on the target.
        /// </summary>
        /// <value>The number of remote input ports currently available on the target.</value>
        [DataMember(Name="inputPortCount", EmitDefaultValue=false)]
        public int? InputPortCount { get; set; }

        /// <summary>
        /// The number of remote output ports currently available on the target.
        /// </summary>
        /// <value>The number of remote output ports currently available on the target.</value>
        [DataMember(Name="outputPortCount", EmitDefaultValue=false)]
        public int? OutputPortCount { get; set; }

        /// <summary>
        /// The number of active remote input ports.
        /// </summary>
        /// <value>The number of active remote input ports.</value>
        [DataMember(Name="activeRemoteInputPortCount", EmitDefaultValue=false)]
        public int? ActiveRemoteInputPortCount { get; set; }

        /// <summary>
        /// The number of inactive remote input ports.
        /// </summary>
        /// <value>The number of inactive remote input ports.</value>
        [DataMember(Name="inactiveRemoteInputPortCount", EmitDefaultValue=false)]
        public int? InactiveRemoteInputPortCount { get; set; }

        /// <summary>
        /// The number of active remote output ports.
        /// </summary>
        /// <value>The number of active remote output ports.</value>
        [DataMember(Name="activeRemoteOutputPortCount", EmitDefaultValue=false)]
        public int? ActiveRemoteOutputPortCount { get; set; }

        /// <summary>
        /// The number of inactive remote output ports.
        /// </summary>
        /// <value>The number of inactive remote output ports.</value>
        [DataMember(Name="inactiveRemoteOutputPortCount", EmitDefaultValue=false)]
        public int? InactiveRemoteOutputPortCount { get; set; }

        /// <summary>
        /// The timestamp when this remote process group was last refreshed.
        /// </summary>
        /// <value>The timestamp when this remote process group was last refreshed.</value>
        [DataMember(Name="flowRefreshed", EmitDefaultValue=false)]
        public string FlowRefreshed { get; set; }

        /// <summary>
        /// The contents of the remote process group. Will contain available input/output ports.
        /// </summary>
        /// <value>The contents of the remote process group. Will contain available input/output ports.</value>
        [DataMember(Name="contents", EmitDefaultValue=false)]
        public RemoteProcessGroupContentsDTO Contents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteProcessGroupDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  VersionedComponentId: ").Append(this.VersionedComponentId).Append("\n");
            sb.Append("  ParentGroupId: ").Append(this.ParentGroupId).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  TargetUri: ").Append(this.TargetUri).Append("\n");
            sb.Append("  TargetUris: ").Append(this.TargetUris).Append("\n");
            sb.Append("  TargetSecure: ").Append(this.TargetSecure).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Comments: ").Append(this.Comments).Append("\n");
            sb.Append("  CommunicationsTimeout: ").Append(this.CommunicationsTimeout).Append("\n");
            sb.Append("  YieldDuration: ").Append(this.YieldDuration).Append("\n");
            sb.Append("  TransportProtocol: ").Append(this.TransportProtocol).Append("\n");
            sb.Append("  LocalNetworkInterface: ").Append(this.LocalNetworkInterface).Append("\n");
            sb.Append("  ProxyHost: ").Append(this.ProxyHost).Append("\n");
            sb.Append("  ProxyPort: ").Append(this.ProxyPort).Append("\n");
            sb.Append("  ProxyUser: ").Append(this.ProxyUser).Append("\n");
            sb.Append("  ProxyPassword: ").Append(this.ProxyPassword).Append("\n");
            sb.Append("  AuthorizationIssues: ").Append(this.AuthorizationIssues).Append("\n");
            sb.Append("  ValidationErrors: ").Append(this.ValidationErrors).Append("\n");
            sb.Append("  Transmitting: ").Append(this.Transmitting).Append("\n");
            sb.Append("  InputPortCount: ").Append(this.InputPortCount).Append("\n");
            sb.Append("  OutputPortCount: ").Append(this.OutputPortCount).Append("\n");
            sb.Append("  ActiveRemoteInputPortCount: ").Append(this.ActiveRemoteInputPortCount).Append("\n");
            sb.Append("  InactiveRemoteInputPortCount: ").Append(this.InactiveRemoteInputPortCount).Append("\n");
            sb.Append("  ActiveRemoteOutputPortCount: ").Append(this.ActiveRemoteOutputPortCount).Append("\n");
            sb.Append("  InactiveRemoteOutputPortCount: ").Append(this.InactiveRemoteOutputPortCount).Append("\n");
            sb.Append("  FlowRefreshed: ").Append(this.FlowRefreshed).Append("\n");
            sb.Append("  Contents: ").Append(this.Contents).Append("\n");
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
            return this.Equals(input as RemoteProcessGroupDTO);
        }

        /// <summary>
        /// Returns true if RemoteProcessGroupDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteProcessGroupDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteProcessGroupDTO input)
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
                    this.TargetUri == input.TargetUri ||
                    (this.TargetUri != null &&
                    this.TargetUri.Equals(input.TargetUri))
                ) && 
                (
                    this.TargetUris == input.TargetUris ||
                    (this.TargetUris != null &&
                    this.TargetUris.Equals(input.TargetUris))
                ) && 
                (
                    this.TargetSecure == input.TargetSecure ||
                    (this.TargetSecure != null &&
                    this.TargetSecure.Equals(input.TargetSecure))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CommunicationsTimeout == input.CommunicationsTimeout ||
                    (this.CommunicationsTimeout != null &&
                    this.CommunicationsTimeout.Equals(input.CommunicationsTimeout))
                ) && 
                (
                    this.YieldDuration == input.YieldDuration ||
                    (this.YieldDuration != null &&
                    this.YieldDuration.Equals(input.YieldDuration))
                ) && 
                (
                    this.TransportProtocol == input.TransportProtocol ||
                    (this.TransportProtocol != null &&
                    this.TransportProtocol.Equals(input.TransportProtocol))
                ) && 
                (
                    this.LocalNetworkInterface == input.LocalNetworkInterface ||
                    (this.LocalNetworkInterface != null &&
                    this.LocalNetworkInterface.Equals(input.LocalNetworkInterface))
                ) && 
                (
                    this.ProxyHost == input.ProxyHost ||
                    (this.ProxyHost != null &&
                    this.ProxyHost.Equals(input.ProxyHost))
                ) && 
                (
                    this.ProxyPort == input.ProxyPort ||
                    (this.ProxyPort != null &&
                    this.ProxyPort.Equals(input.ProxyPort))
                ) && 
                (
                    this.ProxyUser == input.ProxyUser ||
                    (this.ProxyUser != null &&
                    this.ProxyUser.Equals(input.ProxyUser))
                ) && 
                (
                    this.ProxyPassword == input.ProxyPassword ||
                    (this.ProxyPassword != null &&
                    this.ProxyPassword.Equals(input.ProxyPassword))
                ) && 
                (
                    this.AuthorizationIssues == input.AuthorizationIssues ||
                    this.AuthorizationIssues != null &&
                    this.AuthorizationIssues.SequenceEqual(input.AuthorizationIssues)
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                ) && 
                (
                    this.Transmitting == input.Transmitting ||
                    (this.Transmitting != null &&
                    this.Transmitting.Equals(input.Transmitting))
                ) && 
                (
                    this.InputPortCount == input.InputPortCount ||
                    (this.InputPortCount != null &&
                    this.InputPortCount.Equals(input.InputPortCount))
                ) && 
                (
                    this.OutputPortCount == input.OutputPortCount ||
                    (this.OutputPortCount != null &&
                    this.OutputPortCount.Equals(input.OutputPortCount))
                ) && 
                (
                    this.ActiveRemoteInputPortCount == input.ActiveRemoteInputPortCount ||
                    (this.ActiveRemoteInputPortCount != null &&
                    this.ActiveRemoteInputPortCount.Equals(input.ActiveRemoteInputPortCount))
                ) && 
                (
                    this.InactiveRemoteInputPortCount == input.InactiveRemoteInputPortCount ||
                    (this.InactiveRemoteInputPortCount != null &&
                    this.InactiveRemoteInputPortCount.Equals(input.InactiveRemoteInputPortCount))
                ) && 
                (
                    this.ActiveRemoteOutputPortCount == input.ActiveRemoteOutputPortCount ||
                    (this.ActiveRemoteOutputPortCount != null &&
                    this.ActiveRemoteOutputPortCount.Equals(input.ActiveRemoteOutputPortCount))
                ) && 
                (
                    this.InactiveRemoteOutputPortCount == input.InactiveRemoteOutputPortCount ||
                    (this.InactiveRemoteOutputPortCount != null &&
                    this.InactiveRemoteOutputPortCount.Equals(input.InactiveRemoteOutputPortCount))
                ) && 
                (
                    this.FlowRefreshed == input.FlowRefreshed ||
                    (this.FlowRefreshed != null &&
                    this.FlowRefreshed.Equals(input.FlowRefreshed))
                ) && 
                (
                    this.Contents == input.Contents ||
                    (this.Contents != null &&
                    this.Contents.Equals(input.Contents))
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
                if (this.TargetUri != null)
                    hashCode = hashCode * 59 + this.TargetUri.GetHashCode();
                if (this.TargetUris != null)
                    hashCode = hashCode * 59 + this.TargetUris.GetHashCode();
                if (this.TargetSecure != null)
                    hashCode = hashCode * 59 + this.TargetSecure.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CommunicationsTimeout != null)
                    hashCode = hashCode * 59 + this.CommunicationsTimeout.GetHashCode();
                if (this.YieldDuration != null)
                    hashCode = hashCode * 59 + this.YieldDuration.GetHashCode();
                if (this.TransportProtocol != null)
                    hashCode = hashCode * 59 + this.TransportProtocol.GetHashCode();
                if (this.LocalNetworkInterface != null)
                    hashCode = hashCode * 59 + this.LocalNetworkInterface.GetHashCode();
                if (this.ProxyHost != null)
                    hashCode = hashCode * 59 + this.ProxyHost.GetHashCode();
                if (this.ProxyPort != null)
                    hashCode = hashCode * 59 + this.ProxyPort.GetHashCode();
                if (this.ProxyUser != null)
                    hashCode = hashCode * 59 + this.ProxyUser.GetHashCode();
                if (this.ProxyPassword != null)
                    hashCode = hashCode * 59 + this.ProxyPassword.GetHashCode();
                if (this.AuthorizationIssues != null)
                    hashCode = hashCode * 59 + this.AuthorizationIssues.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
                if (this.Transmitting != null)
                    hashCode = hashCode * 59 + this.Transmitting.GetHashCode();
                if (this.InputPortCount != null)
                    hashCode = hashCode * 59 + this.InputPortCount.GetHashCode();
                if (this.OutputPortCount != null)
                    hashCode = hashCode * 59 + this.OutputPortCount.GetHashCode();
                if (this.ActiveRemoteInputPortCount != null)
                    hashCode = hashCode * 59 + this.ActiveRemoteInputPortCount.GetHashCode();
                if (this.InactiveRemoteInputPortCount != null)
                    hashCode = hashCode * 59 + this.InactiveRemoteInputPortCount.GetHashCode();
                if (this.ActiveRemoteOutputPortCount != null)
                    hashCode = hashCode * 59 + this.ActiveRemoteOutputPortCount.GetHashCode();
                if (this.InactiveRemoteOutputPortCount != null)
                    hashCode = hashCode * 59 + this.InactiveRemoteOutputPortCount.GetHashCode();
                if (this.FlowRefreshed != null)
                    hashCode = hashCode * 59 + this.FlowRefreshed.GetHashCode();
                if (this.Contents != null)
                    hashCode = hashCode * 59 + this.Contents.GetHashCode();
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
