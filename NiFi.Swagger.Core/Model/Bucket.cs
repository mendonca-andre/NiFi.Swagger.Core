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
    using System.Runtime.Serialization;
    using System.Text;

    using Newtonsoft.Json;

    /// <summary>
    /// Bucket
    /// </summary>
    [DataContract]
    public partial class Bucket :  IEquatable<Bucket>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket" /> class.
        /// </summary>
        [JsonConstructor]
        protected Bucket() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket" /> class.
        /// </summary>
        /// <param name="name">The name of the bucket. (required).</param>
        /// <param name="description">A description of the bucket..</param>
        public Bucket(string name = default(string), string description = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Bucket and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Description = description;
        }
        
        /// <summary>
        /// An WebLink to this entity.
        /// </summary>
        /// <value>An WebLink to this entity.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; private set; }

        /// <summary>
        /// An ID to uniquely identify this object.
        /// </summary>
        /// <value>An ID to uniquely identify this object.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; private set; }

        /// <summary>
        /// The name of the bucket.
        /// </summary>
        /// <value>The name of the bucket.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The timestamp of when the bucket was first created. This is set by the server at creation time.
        /// </summary>
        /// <value>The timestamp of when the bucket was first created. This is set by the server at creation time.</value>
        [DataMember(Name="createdTimestamp", EmitDefaultValue=false)]
        public long? CreatedTimestamp { get; private set; }

        /// <summary>
        /// A description of the bucket.
        /// </summary>
        /// <value>A description of the bucket.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The access that the current user has to this bucket.
        /// </summary>
        /// <value>The access that the current user has to this bucket.</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public Permissions Permissions { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bucket {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  CreatedTimestamp: ").Append(this.CreatedTimestamp).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Permissions: ").Append(this.Permissions).Append("\n");
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
            return this.Equals(input as Bucket);
        }

        /// <summary>
        /// Returns true if Bucket instances are equal
        /// </summary>
        /// <param name="input">Instance of Bucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedTimestamp == input.CreatedTimestamp ||
                    (this.CreatedTimestamp != null &&
                    this.CreatedTimestamp.Equals(input.CreatedTimestamp))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedTimestamp != null)
                    hashCode = hashCode * 59 + this.CreatedTimestamp.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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
            // CreatedTimestamp (long?) minimum
            if(this.CreatedTimestamp < (long?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedTimestamp, must be a value greater than or equal to 1.", new [] { "CreatedTimestamp" });
            }

            yield break;
        }
    }

}
