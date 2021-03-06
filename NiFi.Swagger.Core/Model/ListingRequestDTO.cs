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
    /// ListingRequestDTO
    /// </summary>
    [DataContract]
    public partial class ListingRequestDTO :  IEquatable<ListingRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingRequestDTO" /> class.
        /// </summary>
        /// <param name="id">The id for this listing request..</param>
        /// <param name="uri">The URI for future requests to this listing request..</param>
        /// <param name="submissionTime">The timestamp when the query was submitted..</param>
        /// <param name="lastUpdated">The last time this listing request was updated..</param>
        /// <param name="percentCompleted">The current percent complete..</param>
        /// <param name="finished">Whether the query has finished..</param>
        /// <param name="failureReason">The reason, if any, that this listing request failed..</param>
        /// <param name="maxResults">The maximum number of FlowFileSummary objects to return.</param>
        /// <param name="state">The current state of the listing request..</param>
        /// <param name="queueSize">The size of the queue.</param>
        /// <param name="flowFileSummaries">The FlowFile summaries. The summaries will be populated once the request has completed..</param>
        /// <param name="sourceRunning">Whether the source of the connection is running.</param>
        /// <param name="destinationRunning">Whether the destination of the connection is running.</param>
        public ListingRequestDTO(string id = default(string), string uri = default(string), string submissionTime = default(string), string lastUpdated = default(string), int? percentCompleted = default(int?), bool? finished = default(bool?), string failureReason = default(string), int? maxResults = default(int?), string state = default(string), QueueSizeDTO queueSize = default(QueueSizeDTO), List<FlowFileSummaryDTO> flowFileSummaries = default(List<FlowFileSummaryDTO>), bool? sourceRunning = default(bool?), bool? destinationRunning = default(bool?))
        {
            this.Id = id;
            this.Uri = uri;
            this.SubmissionTime = submissionTime;
            this.LastUpdated = lastUpdated;
            this.PercentCompleted = percentCompleted;
            this.Finished = finished;
            this.FailureReason = failureReason;
            this.MaxResults = maxResults;
            this.State = state;
            this.QueueSize = queueSize;
            this.FlowFileSummaries = flowFileSummaries;
            this.SourceRunning = sourceRunning;
            this.DestinationRunning = destinationRunning;
        }
        
        /// <summary>
        /// The id for this listing request.
        /// </summary>
        /// <value>The id for this listing request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The URI for future requests to this listing request.
        /// </summary>
        /// <value>The URI for future requests to this listing request.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The timestamp when the query was submitted.
        /// </summary>
        /// <value>The timestamp when the query was submitted.</value>
        [DataMember(Name="submissionTime", EmitDefaultValue=false)]
        public string SubmissionTime { get; set; }

        /// <summary>
        /// The last time this listing request was updated.
        /// </summary>
        /// <value>The last time this listing request was updated.</value>
        [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// The current percent complete.
        /// </summary>
        /// <value>The current percent complete.</value>
        [DataMember(Name="percentCompleted", EmitDefaultValue=false)]
        public int? PercentCompleted { get; set; }

        /// <summary>
        /// Whether the query has finished.
        /// </summary>
        /// <value>Whether the query has finished.</value>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public bool? Finished { get; set; }

        /// <summary>
        /// The reason, if any, that this listing request failed.
        /// </summary>
        /// <value>The reason, if any, that this listing request failed.</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public string FailureReason { get; set; }

        /// <summary>
        /// The maximum number of FlowFileSummary objects to return
        /// </summary>
        /// <value>The maximum number of FlowFileSummary objects to return</value>
        [DataMember(Name="maxResults", EmitDefaultValue=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The current state of the listing request.
        /// </summary>
        /// <value>The current state of the listing request.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// The size of the queue
        /// </summary>
        /// <value>The size of the queue</value>
        [DataMember(Name="queueSize", EmitDefaultValue=false)]
        public QueueSizeDTO QueueSize { get; set; }

        /// <summary>
        /// The FlowFile summaries. The summaries will be populated once the request has completed.
        /// </summary>
        /// <value>The FlowFile summaries. The summaries will be populated once the request has completed.</value>
        [DataMember(Name="flowFileSummaries", EmitDefaultValue=false)]
        public List<FlowFileSummaryDTO> FlowFileSummaries { get; set; }

        /// <summary>
        /// Whether the source of the connection is running
        /// </summary>
        /// <value>Whether the source of the connection is running</value>
        [DataMember(Name="sourceRunning", EmitDefaultValue=false)]
        public bool? SourceRunning { get; set; }

        /// <summary>
        /// Whether the destination of the connection is running
        /// </summary>
        /// <value>Whether the destination of the connection is running</value>
        [DataMember(Name="destinationRunning", EmitDefaultValue=false)]
        public bool? DestinationRunning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingRequestDTO {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Uri: ").Append(this.Uri).Append("\n");
            sb.Append("  SubmissionTime: ").Append(this.SubmissionTime).Append("\n");
            sb.Append("  LastUpdated: ").Append(this.LastUpdated).Append("\n");
            sb.Append("  PercentCompleted: ").Append(this.PercentCompleted).Append("\n");
            sb.Append("  Finished: ").Append(this.Finished).Append("\n");
            sb.Append("  FailureReason: ").Append(this.FailureReason).Append("\n");
            sb.Append("  MaxResults: ").Append(this.MaxResults).Append("\n");
            sb.Append("  State: ").Append(this.State).Append("\n");
            sb.Append("  QueueSize: ").Append(this.QueueSize).Append("\n");
            sb.Append("  FlowFileSummaries: ").Append(this.FlowFileSummaries).Append("\n");
            sb.Append("  SourceRunning: ").Append(this.SourceRunning).Append("\n");
            sb.Append("  DestinationRunning: ").Append(this.DestinationRunning).Append("\n");
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
            return this.Equals(input as ListingRequestDTO);
        }

        /// <summary>
        /// Returns true if ListingRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingRequestDTO input)
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
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.SubmissionTime == input.SubmissionTime ||
                    (this.SubmissionTime != null &&
                    this.SubmissionTime.Equals(input.SubmissionTime))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.PercentCompleted == input.PercentCompleted ||
                    (this.PercentCompleted != null &&
                    this.PercentCompleted.Equals(input.PercentCompleted))
                ) && 
                (
                    this.Finished == input.Finished ||
                    (this.Finished != null &&
                    this.Finished.Equals(input.Finished))
                ) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && 
                (
                    this.MaxResults == input.MaxResults ||
                    (this.MaxResults != null &&
                    this.MaxResults.Equals(input.MaxResults))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.QueueSize == input.QueueSize ||
                    (this.QueueSize != null &&
                    this.QueueSize.Equals(input.QueueSize))
                ) && 
                (
                    this.FlowFileSummaries == input.FlowFileSummaries ||
                    this.FlowFileSummaries != null &&
                    this.FlowFileSummaries.SequenceEqual(input.FlowFileSummaries)
                ) && 
                (
                    this.SourceRunning == input.SourceRunning ||
                    (this.SourceRunning != null &&
                    this.SourceRunning.Equals(input.SourceRunning))
                ) && 
                (
                    this.DestinationRunning == input.DestinationRunning ||
                    (this.DestinationRunning != null &&
                    this.DestinationRunning.Equals(input.DestinationRunning))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.SubmissionTime != null)
                    hashCode = hashCode * 59 + this.SubmissionTime.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.PercentCompleted != null)
                    hashCode = hashCode * 59 + this.PercentCompleted.GetHashCode();
                if (this.Finished != null)
                    hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.MaxResults != null)
                    hashCode = hashCode * 59 + this.MaxResults.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.QueueSize != null)
                    hashCode = hashCode * 59 + this.QueueSize.GetHashCode();
                if (this.FlowFileSummaries != null)
                    hashCode = hashCode * 59 + this.FlowFileSummaries.GetHashCode();
                if (this.SourceRunning != null)
                    hashCode = hashCode * 59 + this.SourceRunning.GetHashCode();
                if (this.DestinationRunning != null)
                    hashCode = hashCode * 59 + this.DestinationRunning.GetHashCode();
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
