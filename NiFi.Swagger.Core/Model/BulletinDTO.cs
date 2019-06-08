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
    /// BulletinDTO
    /// </summary>
    [DataContract]
    public partial class BulletinDTO :  IEquatable<BulletinDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulletinDTO" /> class.
        /// </summary>
        /// <param name="id">The id of the bulletin..</param>
        /// <param name="nodeAddress">If clustered, the address of the node from which the bulletin originated..</param>
        /// <param name="category">The category of this bulletin..</param>
        /// <param name="groupId">The group id of the source component..</param>
        /// <param name="sourceId">The id of the source component..</param>
        /// <param name="sourceName">The name of the source component..</param>
        /// <param name="level">The level of the bulletin..</param>
        /// <param name="message">The bulletin message..</param>
        /// <param name="timestamp">When this bulletin was generated..</param>
        public BulletinDTO(long? id = default(long?), string nodeAddress = default(string), string category = default(string), string groupId = default(string), string sourceId = default(string), string sourceName = default(string), string level = default(string), string message = default(string), string timestamp = default(string))
        {
            this.Id = id;
            this.NodeAddress = nodeAddress;
            this.Category = category;
            this.GroupId = groupId;
            this.SourceId = sourceId;
            this.SourceName = sourceName;
            this.Level = level;
            this.Message = message;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// The id of the bulletin.
        /// </summary>
        /// <value>The id of the bulletin.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// If clustered, the address of the node from which the bulletin originated.
        /// </summary>
        /// <value>If clustered, the address of the node from which the bulletin originated.</value>
        [DataMember(Name="nodeAddress", EmitDefaultValue=false)]
        public string NodeAddress { get; set; }

        /// <summary>
        /// The category of this bulletin.
        /// </summary>
        /// <value>The category of this bulletin.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// The group id of the source component.
        /// </summary>
        /// <value>The group id of the source component.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The id of the source component.
        /// </summary>
        /// <value>The id of the source component.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The name of the source component.
        /// </summary>
        /// <value>The name of the source component.</value>
        [DataMember(Name="sourceName", EmitDefaultValue=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// The level of the bulletin.
        /// </summary>
        /// <value>The level of the bulletin.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }

        /// <summary>
        /// The bulletin message.
        /// </summary>
        /// <value>The bulletin message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// When this bulletin was generated.
        /// </summary>
        /// <value>When this bulletin was generated.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulletinDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  NodeAddress: ").Append(this.NodeAddress).Append("\n");
            sb.Append("  Category: ").Append(this.Category).Append("\n");
            sb.Append("  GroupId: ").Append(this.GroupId).Append("\n");
            sb.Append("  SourceId: ").Append(this.SourceId).Append("\n");
            sb.Append("  SourceName: ").Append(this.SourceName).Append("\n");
            sb.Append("  Level: ").Append(this.Level).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
            sb.Append("  Timestamp: ").Append(this.Timestamp).Append("\n");
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
            return this.Equals(input as BulletinDTO);
        }

        /// <summary>
        /// Returns true if BulletinDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BulletinDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulletinDTO input)
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
                    this.NodeAddress == input.NodeAddress ||
                    (this.NodeAddress != null &&
                    this.NodeAddress.Equals(input.NodeAddress))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
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
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.NodeAddress != null)
                    hashCode = hashCode * 59 + this.NodeAddress.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.SourceId != null)
                    hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.SourceName != null)
                    hashCode = hashCode * 59 + this.SourceName.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
