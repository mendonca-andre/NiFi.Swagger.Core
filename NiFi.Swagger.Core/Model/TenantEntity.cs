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
    /// TenantEntity
    /// </summary>
    [DataContract]
    public partial class TenantEntity :  IEquatable<TenantEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantEntity" /> class.
        /// </summary>
        /// <param name="revision">The revision for this request/response. The revision is required for any mutable flow requests and is included in all responses..</param>
        /// <param name="id">The id of the component..</param>
        /// <param name="uri">The URI for futures requests to the component..</param>
        /// <param name="position">The position of this component in the UI if applicable..</param>
        /// <param name="permissions">The permissions for this component..</param>
        /// <param name="bulletins">The bulletins for this component..</param>
        /// <param name="disconnectedNodeAcknowledged">Acknowledges that this node is disconnected to allow for mutable requests to proceed..</param>
        /// <param name="component">component.</param>
        public TenantEntity(RevisionDTO revision = default(RevisionDTO), string id = default(string), string uri = default(string), PositionDTO position = default(PositionDTO), PermissionsDTO permissions = default(PermissionsDTO), List<BulletinEntity> bulletins = default(List<BulletinEntity>), bool? disconnectedNodeAcknowledged = default(bool?), TenantDTO component = default(TenantDTO))
        {
            this.Revision = revision;
            this.Id = id;
            this.Uri = uri;
            this.Position = position;
            this.Permissions = permissions;
            this.Bulletins = bulletins;
            this.DisconnectedNodeAcknowledged = disconnectedNodeAcknowledged;
            this.Component = component;
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
        public TenantDTO Component { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantEntity {\n");
            sb.Append("  Revision: ").Append(this.Revision).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Uri: ").Append(this.Uri).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  Permissions: ").Append(this.Permissions).Append("\n");
            sb.Append("  Bulletins: ").Append(this.Bulletins).Append("\n");
            sb.Append("  DisconnectedNodeAcknowledged: ").Append(this.DisconnectedNodeAcknowledged).Append("\n");
            sb.Append("  Component: ").Append(this.Component).Append("\n");
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
            return this.Equals(input as TenantEntity);
        }

        /// <summary>
        /// Returns true if TenantEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantEntity input)
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
