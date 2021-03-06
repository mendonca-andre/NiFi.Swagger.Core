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
    /// GarbageCollectionDTO
    /// </summary>
    [DataContract]
    public partial class GarbageCollectionDTO :  IEquatable<GarbageCollectionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GarbageCollectionDTO" /> class.
        /// </summary>
        /// <param name="name">The name of the garbage collector..</param>
        /// <param name="collectionCount">The number of times garbage collection has run..</param>
        /// <param name="collectionTime">The total amount of time spent garbage collecting..</param>
        /// <param name="collectionMillis">The total number of milliseconds spent garbage collecting..</param>
        public GarbageCollectionDTO(string name = default(string), long? collectionCount = default(long?), string collectionTime = default(string), long? collectionMillis = default(long?))
        {
            this.Name = name;
            this.CollectionCount = collectionCount;
            this.CollectionTime = collectionTime;
            this.CollectionMillis = collectionMillis;
        }
        
        /// <summary>
        /// The name of the garbage collector.
        /// </summary>
        /// <value>The name of the garbage collector.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of times garbage collection has run.
        /// </summary>
        /// <value>The number of times garbage collection has run.</value>
        [DataMember(Name="collectionCount", EmitDefaultValue=false)]
        public long? CollectionCount { get; set; }

        /// <summary>
        /// The total amount of time spent garbage collecting.
        /// </summary>
        /// <value>The total amount of time spent garbage collecting.</value>
        [DataMember(Name="collectionTime", EmitDefaultValue=false)]
        public string CollectionTime { get; set; }

        /// <summary>
        /// The total number of milliseconds spent garbage collecting.
        /// </summary>
        /// <value>The total number of milliseconds spent garbage collecting.</value>
        [DataMember(Name="collectionMillis", EmitDefaultValue=false)]
        public long? CollectionMillis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GarbageCollectionDTO {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  CollectionCount: ").Append(this.CollectionCount).Append("\n");
            sb.Append("  CollectionTime: ").Append(this.CollectionTime).Append("\n");
            sb.Append("  CollectionMillis: ").Append(this.CollectionMillis).Append("\n");
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
            return this.Equals(input as GarbageCollectionDTO);
        }

        /// <summary>
        /// Returns true if GarbageCollectionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of GarbageCollectionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GarbageCollectionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CollectionCount == input.CollectionCount ||
                    (this.CollectionCount != null &&
                    this.CollectionCount.Equals(input.CollectionCount))
                ) && 
                (
                    this.CollectionTime == input.CollectionTime ||
                    (this.CollectionTime != null &&
                    this.CollectionTime.Equals(input.CollectionTime))
                ) && 
                (
                    this.CollectionMillis == input.CollectionMillis ||
                    (this.CollectionMillis != null &&
                    this.CollectionMillis.Equals(input.CollectionMillis))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CollectionCount != null)
                    hashCode = hashCode * 59 + this.CollectionCount.GetHashCode();
                if (this.CollectionTime != null)
                    hashCode = hashCode * 59 + this.CollectionTime.GetHashCode();
                if (this.CollectionMillis != null)
                    hashCode = hashCode * 59 + this.CollectionMillis.GetHashCode();
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
