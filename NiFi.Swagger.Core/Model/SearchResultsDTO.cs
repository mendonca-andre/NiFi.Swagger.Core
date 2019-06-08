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
    /// SearchResultsDTO
    /// </summary>
    [DataContract]
    public partial class SearchResultsDTO :  IEquatable<SearchResultsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultsDTO" /> class.
        /// </summary>
        /// <param name="processorResults">The processors that matched the search..</param>
        /// <param name="connectionResults">The connections that matched the search..</param>
        /// <param name="processGroupResults">The process groups that matched the search..</param>
        /// <param name="inputPortResults">The input ports that matched the search..</param>
        /// <param name="outputPortResults">The output ports that matched the search..</param>
        /// <param name="remoteProcessGroupResults">The remote process groups that matched the search..</param>
        /// <param name="funnelResults">The funnels that matched the search..</param>
        public SearchResultsDTO(List<ComponentSearchResultDTO> processorResults = default(List<ComponentSearchResultDTO>), List<ComponentSearchResultDTO> connectionResults = default(List<ComponentSearchResultDTO>), List<ComponentSearchResultDTO> processGroupResults = default(List<ComponentSearchResultDTO>), List<ComponentSearchResultDTO> inputPortResults = default(List<ComponentSearchResultDTO>), List<ComponentSearchResultDTO> outputPortResults = default(List<ComponentSearchResultDTO>), List<ComponentSearchResultDTO> remoteProcessGroupResults = default(List<ComponentSearchResultDTO>), List<ComponentSearchResultDTO> funnelResults = default(List<ComponentSearchResultDTO>))
        {
            this.ProcessorResults = processorResults;
            this.ConnectionResults = connectionResults;
            this.ProcessGroupResults = processGroupResults;
            this.InputPortResults = inputPortResults;
            this.OutputPortResults = outputPortResults;
            this.RemoteProcessGroupResults = remoteProcessGroupResults;
            this.FunnelResults = funnelResults;
        }
        
        /// <summary>
        /// The processors that matched the search.
        /// </summary>
        /// <value>The processors that matched the search.</value>
        [DataMember(Name="processorResults", EmitDefaultValue=false)]
        public List<ComponentSearchResultDTO> ProcessorResults { get; set; }

        /// <summary>
        /// The connections that matched the search.
        /// </summary>
        /// <value>The connections that matched the search.</value>
        [DataMember(Name="connectionResults", EmitDefaultValue=false)]
        public List<ComponentSearchResultDTO> ConnectionResults { get; set; }

        /// <summary>
        /// The process groups that matched the search.
        /// </summary>
        /// <value>The process groups that matched the search.</value>
        [DataMember(Name="processGroupResults", EmitDefaultValue=false)]
        public List<ComponentSearchResultDTO> ProcessGroupResults { get; set; }

        /// <summary>
        /// The input ports that matched the search.
        /// </summary>
        /// <value>The input ports that matched the search.</value>
        [DataMember(Name="inputPortResults", EmitDefaultValue=false)]
        public List<ComponentSearchResultDTO> InputPortResults { get; set; }

        /// <summary>
        /// The output ports that matched the search.
        /// </summary>
        /// <value>The output ports that matched the search.</value>
        [DataMember(Name="outputPortResults", EmitDefaultValue=false)]
        public List<ComponentSearchResultDTO> OutputPortResults { get; set; }

        /// <summary>
        /// The remote process groups that matched the search.
        /// </summary>
        /// <value>The remote process groups that matched the search.</value>
        [DataMember(Name="remoteProcessGroupResults", EmitDefaultValue=false)]
        public List<ComponentSearchResultDTO> RemoteProcessGroupResults { get; set; }

        /// <summary>
        /// The funnels that matched the search.
        /// </summary>
        /// <value>The funnels that matched the search.</value>
        [DataMember(Name="funnelResults", EmitDefaultValue=false)]
        public List<ComponentSearchResultDTO> FunnelResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResultsDTO {\n");
            sb.Append("  ProcessorResults: ").Append(this.ProcessorResults).Append("\n");
            sb.Append("  ConnectionResults: ").Append(this.ConnectionResults).Append("\n");
            sb.Append("  ProcessGroupResults: ").Append(this.ProcessGroupResults).Append("\n");
            sb.Append("  InputPortResults: ").Append(this.InputPortResults).Append("\n");
            sb.Append("  OutputPortResults: ").Append(this.OutputPortResults).Append("\n");
            sb.Append("  RemoteProcessGroupResults: ").Append(this.RemoteProcessGroupResults).Append("\n");
            sb.Append("  FunnelResults: ").Append(this.FunnelResults).Append("\n");
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
            return this.Equals(input as SearchResultsDTO);
        }

        /// <summary>
        /// Returns true if SearchResultsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessorResults == input.ProcessorResults ||
                    this.ProcessorResults != null &&
                    this.ProcessorResults.SequenceEqual(input.ProcessorResults)
                ) && 
                (
                    this.ConnectionResults == input.ConnectionResults ||
                    this.ConnectionResults != null &&
                    this.ConnectionResults.SequenceEqual(input.ConnectionResults)
                ) && 
                (
                    this.ProcessGroupResults == input.ProcessGroupResults ||
                    this.ProcessGroupResults != null &&
                    this.ProcessGroupResults.SequenceEqual(input.ProcessGroupResults)
                ) && 
                (
                    this.InputPortResults == input.InputPortResults ||
                    this.InputPortResults != null &&
                    this.InputPortResults.SequenceEqual(input.InputPortResults)
                ) && 
                (
                    this.OutputPortResults == input.OutputPortResults ||
                    this.OutputPortResults != null &&
                    this.OutputPortResults.SequenceEqual(input.OutputPortResults)
                ) && 
                (
                    this.RemoteProcessGroupResults == input.RemoteProcessGroupResults ||
                    this.RemoteProcessGroupResults != null &&
                    this.RemoteProcessGroupResults.SequenceEqual(input.RemoteProcessGroupResults)
                ) && 
                (
                    this.FunnelResults == input.FunnelResults ||
                    this.FunnelResults != null &&
                    this.FunnelResults.SequenceEqual(input.FunnelResults)
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
                if (this.ProcessorResults != null)
                    hashCode = hashCode * 59 + this.ProcessorResults.GetHashCode();
                if (this.ConnectionResults != null)
                    hashCode = hashCode * 59 + this.ConnectionResults.GetHashCode();
                if (this.ProcessGroupResults != null)
                    hashCode = hashCode * 59 + this.ProcessGroupResults.GetHashCode();
                if (this.InputPortResults != null)
                    hashCode = hashCode * 59 + this.InputPortResults.GetHashCode();
                if (this.OutputPortResults != null)
                    hashCode = hashCode * 59 + this.OutputPortResults.GetHashCode();
                if (this.RemoteProcessGroupResults != null)
                    hashCode = hashCode * 59 + this.RemoteProcessGroupResults.GetHashCode();
                if (this.FunnelResults != null)
                    hashCode = hashCode * 59 + this.FunnelResults.GetHashCode();
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