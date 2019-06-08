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
    /// ProvenanceResultsDTO
    /// </summary>
    [DataContract]
    public partial class ProvenanceResultsDTO :  IEquatable<ProvenanceResultsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceResultsDTO" /> class.
        /// </summary>
        /// <param name="provenanceEvents">The provenance events that matched the search criteria..</param>
        /// <param name="total">The total number of results formatted..</param>
        /// <param name="totalCount">The total number of results..</param>
        /// <param name="generated">Then the search was performed..</param>
        /// <param name="oldestEvent">The oldest event available in the provenance repository..</param>
        /// <param name="timeOffset">The time offset of the server that&#39;s used for event time..</param>
        /// <param name="errors">Any errors that occurred while performing the provenance request..</param>
        public ProvenanceResultsDTO(List<ProvenanceEventDTO> provenanceEvents = default(List<ProvenanceEventDTO>), string total = default(string), long? totalCount = default(long?), string generated = default(string), string oldestEvent = default(string), int? timeOffset = default(int?), List<string> errors = default(List<string>))
        {
            this.ProvenanceEvents = provenanceEvents;
            this.Total = total;
            this.TotalCount = totalCount;
            this.Generated = generated;
            this.OldestEvent = oldestEvent;
            this.TimeOffset = timeOffset;
            this.Errors = errors;
        }
        
        /// <summary>
        /// The provenance events that matched the search criteria.
        /// </summary>
        /// <value>The provenance events that matched the search criteria.</value>
        [DataMember(Name="provenanceEvents", EmitDefaultValue=false)]
        public List<ProvenanceEventDTO> ProvenanceEvents { get; set; }

        /// <summary>
        /// The total number of results formatted.
        /// </summary>
        /// <value>The total number of results formatted.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public string Total { get; set; }

        /// <summary>
        /// The total number of results.
        /// </summary>
        /// <value>The total number of results.</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// Then the search was performed.
        /// </summary>
        /// <value>Then the search was performed.</value>
        [DataMember(Name="generated", EmitDefaultValue=false)]
        public string Generated { get; set; }

        /// <summary>
        /// The oldest event available in the provenance repository.
        /// </summary>
        /// <value>The oldest event available in the provenance repository.</value>
        [DataMember(Name="oldestEvent", EmitDefaultValue=false)]
        public string OldestEvent { get; set; }

        /// <summary>
        /// The time offset of the server that&#39;s used for event time.
        /// </summary>
        /// <value>The time offset of the server that&#39;s used for event time.</value>
        [DataMember(Name="timeOffset", EmitDefaultValue=false)]
        public int? TimeOffset { get; set; }

        /// <summary>
        /// Any errors that occurred while performing the provenance request.
        /// </summary>
        /// <value>Any errors that occurred while performing the provenance request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProvenanceResultsDTO {\n");
            sb.Append("  ProvenanceEvents: ").Append(this.ProvenanceEvents).Append("\n");
            sb.Append("  Total: ").Append(this.Total).Append("\n");
            sb.Append("  TotalCount: ").Append(this.TotalCount).Append("\n");
            sb.Append("  Generated: ").Append(this.Generated).Append("\n");
            sb.Append("  OldestEvent: ").Append(this.OldestEvent).Append("\n");
            sb.Append("  TimeOffset: ").Append(this.TimeOffset).Append("\n");
            sb.Append("  Errors: ").Append(this.Errors).Append("\n");
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
            return this.Equals(input as ProvenanceResultsDTO);
        }

        /// <summary>
        /// Returns true if ProvenanceResultsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProvenanceResultsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProvenanceResultsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProvenanceEvents == input.ProvenanceEvents ||
                    this.ProvenanceEvents != null &&
                    this.ProvenanceEvents.SequenceEqual(input.ProvenanceEvents)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.Generated == input.Generated ||
                    (this.Generated != null &&
                    this.Generated.Equals(input.Generated))
                ) && 
                (
                    this.OldestEvent == input.OldestEvent ||
                    (this.OldestEvent != null &&
                    this.OldestEvent.Equals(input.OldestEvent))
                ) && 
                (
                    this.TimeOffset == input.TimeOffset ||
                    (this.TimeOffset != null &&
                    this.TimeOffset.Equals(input.TimeOffset))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.ProvenanceEvents != null)
                    hashCode = hashCode * 59 + this.ProvenanceEvents.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Generated != null)
                    hashCode = hashCode * 59 + this.Generated.GetHashCode();
                if (this.OldestEvent != null)
                    hashCode = hashCode * 59 + this.OldestEvent.GetHashCode();
                if (this.TimeOffset != null)
                    hashCode = hashCode * 59 + this.TimeOffset.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
