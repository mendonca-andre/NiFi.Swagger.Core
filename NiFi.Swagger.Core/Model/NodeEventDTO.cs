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
    /// NodeEventDTO
    /// </summary>
    [DataContract]
    public partial class NodeEventDTO :  IEquatable<NodeEventDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeEventDTO" /> class.
        /// </summary>
        /// <param name="timestamp">The timestamp of the node event..</param>
        /// <param name="category">The category of the node event..</param>
        /// <param name="message">The message in the node event..</param>
        public NodeEventDTO(string timestamp = default(string), string category = default(string), string message = default(string))
        {
            this.Timestamp = timestamp;
            this.Category = category;
            this.Message = message;
        }
        
        /// <summary>
        /// The timestamp of the node event.
        /// </summary>
        /// <value>The timestamp of the node event.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// The category of the node event.
        /// </summary>
        /// <value>The category of the node event.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// The message in the node event.
        /// </summary>
        /// <value>The message in the node event.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeEventDTO {\n");
            sb.Append("  Timestamp: ").Append(this.Timestamp).Append("\n");
            sb.Append("  Category: ").Append(this.Category).Append("\n");
            sb.Append("  Message: ").Append(this.Message).Append("\n");
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
            return this.Equals(input as NodeEventDTO);
        }

        /// <summary>
        /// Returns true if NodeEventDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeEventDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeEventDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
