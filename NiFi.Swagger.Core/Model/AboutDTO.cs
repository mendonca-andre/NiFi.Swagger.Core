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
    /// AboutDTO
    /// </summary>
    [DataContract]
    public partial class AboutDTO :  IEquatable<AboutDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutDTO" /> class.
        /// </summary>
        /// <param name="title">The title to be used on the page and in the about dialog..</param>
        /// <param name="version">The version of this NiFi..</param>
        /// <param name="uri">The URI for the NiFi..</param>
        /// <param name="contentViewerUrl">The URL for the content viewer if configured..</param>
        /// <param name="buildTag">Build tag.</param>
        /// <param name="buildRevision">Build revision or commit hash.</param>
        /// <param name="buildBranch">Build branch.</param>
        /// <param name="buildTimestamp">Build timestamp.</param>
        public AboutDTO(string title = default(string), string version = default(string), string uri = default(string), string contentViewerUrl = default(string), string buildTag = default(string), string buildRevision = default(string), string buildBranch = default(string), string buildTimestamp = default(string))
        {
            this.Title = title;
            this.Version = version;
            this.Uri = uri;
            this.ContentViewerUrl = contentViewerUrl;
            this.BuildTag = buildTag;
            this.BuildRevision = buildRevision;
            this.BuildBranch = buildBranch;
            this.BuildTimestamp = buildTimestamp;
        }
        
        /// <summary>
        /// The title to be used on the page and in the about dialog.
        /// </summary>
        /// <value>The title to be used on the page and in the about dialog.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The version of this NiFi.
        /// </summary>
        /// <value>The version of this NiFi.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// The URI for the NiFi.
        /// </summary>
        /// <value>The URI for the NiFi.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The URL for the content viewer if configured.
        /// </summary>
        /// <value>The URL for the content viewer if configured.</value>
        [DataMember(Name="contentViewerUrl", EmitDefaultValue=false)]
        public string ContentViewerUrl { get; set; }

        /// <summary>
        /// The timezone of the NiFi instance.
        /// </summary>
        /// <value>The timezone of the NiFi instance.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; private set; }

        /// <summary>
        /// Build tag
        /// </summary>
        /// <value>Build tag</value>
        [DataMember(Name="buildTag", EmitDefaultValue=false)]
        public string BuildTag { get; set; }

        /// <summary>
        /// Build revision or commit hash
        /// </summary>
        /// <value>Build revision or commit hash</value>
        [DataMember(Name="buildRevision", EmitDefaultValue=false)]
        public string BuildRevision { get; set; }

        /// <summary>
        /// Build branch
        /// </summary>
        /// <value>Build branch</value>
        [DataMember(Name="buildBranch", EmitDefaultValue=false)]
        public string BuildBranch { get; set; }

        /// <summary>
        /// Build timestamp
        /// </summary>
        /// <value>Build timestamp</value>
        [DataMember(Name="buildTimestamp", EmitDefaultValue=false)]
        public string BuildTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AboutDTO {\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  Version: ").Append(this.Version).Append("\n");
            sb.Append("  Uri: ").Append(this.Uri).Append("\n");
            sb.Append("  ContentViewerUrl: ").Append(this.ContentViewerUrl).Append("\n");
            sb.Append("  Timezone: ").Append(this.Timezone).Append("\n");
            sb.Append("  BuildTag: ").Append(this.BuildTag).Append("\n");
            sb.Append("  BuildRevision: ").Append(this.BuildRevision).Append("\n");
            sb.Append("  BuildBranch: ").Append(this.BuildBranch).Append("\n");
            sb.Append("  BuildTimestamp: ").Append(this.BuildTimestamp).Append("\n");
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
            return this.Equals(input as AboutDTO);
        }

        /// <summary>
        /// Returns true if AboutDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AboutDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AboutDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.ContentViewerUrl == input.ContentViewerUrl ||
                    (this.ContentViewerUrl != null &&
                    this.ContentViewerUrl.Equals(input.ContentViewerUrl))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.BuildTag == input.BuildTag ||
                    (this.BuildTag != null &&
                    this.BuildTag.Equals(input.BuildTag))
                ) && 
                (
                    this.BuildRevision == input.BuildRevision ||
                    (this.BuildRevision != null &&
                    this.BuildRevision.Equals(input.BuildRevision))
                ) && 
                (
                    this.BuildBranch == input.BuildBranch ||
                    (this.BuildBranch != null &&
                    this.BuildBranch.Equals(input.BuildBranch))
                ) && 
                (
                    this.BuildTimestamp == input.BuildTimestamp ||
                    (this.BuildTimestamp != null &&
                    this.BuildTimestamp.Equals(input.BuildTimestamp))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.ContentViewerUrl != null)
                    hashCode = hashCode * 59 + this.ContentViewerUrl.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.BuildTag != null)
                    hashCode = hashCode * 59 + this.BuildTag.GetHashCode();
                if (this.BuildRevision != null)
                    hashCode = hashCode * 59 + this.BuildRevision.GetHashCode();
                if (this.BuildBranch != null)
                    hashCode = hashCode * 59 + this.BuildBranch.GetHashCode();
                if (this.BuildTimestamp != null)
                    hashCode = hashCode * 59 + this.BuildTimestamp.GetHashCode();
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
