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
    /// StateMapDTO
    /// </summary>
    [DataContract]
    public partial class StateMapDTO :  IEquatable<StateMapDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateMapDTO" /> class.
        /// </summary>
        /// <param name="scope">The scope of this StateMap..</param>
        /// <param name="totalEntryCount">The total number of state entries. When the state map is lengthy, only of portion of the entries are returned..</param>
        /// <param name="state">The state..</param>
        public StateMapDTO(string scope = default(string), int? totalEntryCount = default(int?), List<StateEntryDTO> state = default(List<StateEntryDTO>))
        {
            this.Scope = scope;
            this.TotalEntryCount = totalEntryCount;
            this.State = state;
        }
        
        /// <summary>
        /// The scope of this StateMap.
        /// </summary>
        /// <value>The scope of this StateMap.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The total number of state entries. When the state map is lengthy, only of portion of the entries are returned.
        /// </summary>
        /// <value>The total number of state entries. When the state map is lengthy, only of portion of the entries are returned.</value>
        [DataMember(Name="totalEntryCount", EmitDefaultValue=false)]
        public int? TotalEntryCount { get; set; }

        /// <summary>
        /// The state.
        /// </summary>
        /// <value>The state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public List<StateEntryDTO> State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateMapDTO {\n");
            sb.Append("  Scope: ").Append(this.Scope).Append("\n");
            sb.Append("  TotalEntryCount: ").Append(this.TotalEntryCount).Append("\n");
            sb.Append("  State: ").Append(this.State).Append("\n");
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
            return this.Equals(input as StateMapDTO);
        }

        /// <summary>
        /// Returns true if StateMapDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StateMapDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateMapDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.TotalEntryCount == input.TotalEntryCount ||
                    (this.TotalEntryCount != null &&
                    this.TotalEntryCount.Equals(input.TotalEntryCount))
                ) && 
                (
                    this.State == input.State ||
                    this.State != null &&
                    this.State.SequenceEqual(input.State)
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
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.TotalEntryCount != null)
                    hashCode = hashCode * 59 + this.TotalEntryCount.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
