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
    /// PropertyDescriptorDTO
    /// </summary>
    [DataContract]
    public partial class PropertyDescriptorDTO :  IEquatable<PropertyDescriptorDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDescriptorDTO" /> class.
        /// </summary>
        /// <param name="name">The name for the property..</param>
        /// <param name="displayName">The human readable name for the property..</param>
        /// <param name="description">The description for the property. Used to relay additional details to a user or provide a mechanism of documenting intent..</param>
        /// <param name="defaultValue">The default value for the property..</param>
        /// <param name="allowableValues">Allowable values for the property. If empty then the allowed values are not constrained..</param>
        /// <param name="required">Whether the property is required..</param>
        /// <param name="sensitive">Whether the property is sensitive and protected whenever stored or represented..</param>
        /// <param name="dynamic">Whether the property is dynamic (user-defined)..</param>
        /// <param name="supportsEl">Whether the property supports expression language..</param>
        /// <param name="expressionLanguageScope">Scope of the Expression Language evaluation for the property..</param>
        /// <param name="identifiesControllerService">If the property identifies a controller service this returns the fully qualified type..</param>
        /// <param name="identifiesControllerServiceBundle">If the property identifies a controller service this returns the bundle of the type, null otherwise..</param>
        public PropertyDescriptorDTO(string name = default(string), string displayName = default(string), string description = default(string), string defaultValue = default(string), List<AllowableValueEntity> allowableValues = default(List<AllowableValueEntity>), bool? required = default(bool?), bool? sensitive = default(bool?), bool? dynamic = default(bool?), bool? supportsEl = default(bool?), string expressionLanguageScope = default(string), string identifiesControllerService = default(string), BundleDTO identifiesControllerServiceBundle = default(BundleDTO))
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.DefaultValue = defaultValue;
            this.AllowableValues = allowableValues;
            this.Required = required;
            this.Sensitive = sensitive;
            this.Dynamic = dynamic;
            this.SupportsEl = supportsEl;
            this.ExpressionLanguageScope = expressionLanguageScope;
            this.IdentifiesControllerService = identifiesControllerService;
            this.IdentifiesControllerServiceBundle = identifiesControllerServiceBundle;
        }
        
        /// <summary>
        /// The name for the property.
        /// </summary>
        /// <value>The name for the property.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The human readable name for the property.
        /// </summary>
        /// <value>The human readable name for the property.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description for the property. Used to relay additional details to a user or provide a mechanism of documenting intent.
        /// </summary>
        /// <value>The description for the property. Used to relay additional details to a user or provide a mechanism of documenting intent.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The default value for the property.
        /// </summary>
        /// <value>The default value for the property.</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Allowable values for the property. If empty then the allowed values are not constrained.
        /// </summary>
        /// <value>Allowable values for the property. If empty then the allowed values are not constrained.</value>
        [DataMember(Name="allowableValues", EmitDefaultValue=false)]
        public List<AllowableValueEntity> AllowableValues { get; set; }

        /// <summary>
        /// Whether the property is required.
        /// </summary>
        /// <value>Whether the property is required.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Whether the property is sensitive and protected whenever stored or represented.
        /// </summary>
        /// <value>Whether the property is sensitive and protected whenever stored or represented.</value>
        [DataMember(Name="sensitive", EmitDefaultValue=false)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Whether the property is dynamic (user-defined).
        /// </summary>
        /// <value>Whether the property is dynamic (user-defined).</value>
        [DataMember(Name="dynamic", EmitDefaultValue=false)]
        public bool? Dynamic { get; set; }

        /// <summary>
        /// Whether the property supports expression language.
        /// </summary>
        /// <value>Whether the property supports expression language.</value>
        [DataMember(Name="supportsEl", EmitDefaultValue=false)]
        public bool? SupportsEl { get; set; }

        /// <summary>
        /// Scope of the Expression Language evaluation for the property.
        /// </summary>
        /// <value>Scope of the Expression Language evaluation for the property.</value>
        [DataMember(Name="expressionLanguageScope", EmitDefaultValue=false)]
        public string ExpressionLanguageScope { get; set; }

        /// <summary>
        /// If the property identifies a controller service this returns the fully qualified type.
        /// </summary>
        /// <value>If the property identifies a controller service this returns the fully qualified type.</value>
        [DataMember(Name="identifiesControllerService", EmitDefaultValue=false)]
        public string IdentifiesControllerService { get; set; }

        /// <summary>
        /// If the property identifies a controller service this returns the bundle of the type, null otherwise.
        /// </summary>
        /// <value>If the property identifies a controller service this returns the bundle of the type, null otherwise.</value>
        [DataMember(Name="identifiesControllerServiceBundle", EmitDefaultValue=false)]
        public BundleDTO IdentifiesControllerServiceBundle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyDescriptorDTO {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  DefaultValue: ").Append(this.DefaultValue).Append("\n");
            sb.Append("  AllowableValues: ").Append(this.AllowableValues).Append("\n");
            sb.Append("  Required: ").Append(this.Required).Append("\n");
            sb.Append("  Sensitive: ").Append(this.Sensitive).Append("\n");
            sb.Append("  Dynamic: ").Append(this.Dynamic).Append("\n");
            sb.Append("  SupportsEl: ").Append(this.SupportsEl).Append("\n");
            sb.Append("  ExpressionLanguageScope: ").Append(this.ExpressionLanguageScope).Append("\n");
            sb.Append("  IdentifiesControllerService: ").Append(this.IdentifiesControllerService).Append("\n");
            sb.Append("  IdentifiesControllerServiceBundle: ").Append(this.IdentifiesControllerServiceBundle).Append("\n");
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
            return this.Equals(input as PropertyDescriptorDTO);
        }

        /// <summary>
        /// Returns true if PropertyDescriptorDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyDescriptorDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyDescriptorDTO input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.AllowableValues == input.AllowableValues ||
                    this.AllowableValues != null &&
                    this.AllowableValues.SequenceEqual(input.AllowableValues)
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Sensitive == input.Sensitive ||
                    (this.Sensitive != null &&
                    this.Sensitive.Equals(input.Sensitive))
                ) && 
                (
                    this.Dynamic == input.Dynamic ||
                    (this.Dynamic != null &&
                    this.Dynamic.Equals(input.Dynamic))
                ) && 
                (
                    this.SupportsEl == input.SupportsEl ||
                    (this.SupportsEl != null &&
                    this.SupportsEl.Equals(input.SupportsEl))
                ) && 
                (
                    this.ExpressionLanguageScope == input.ExpressionLanguageScope ||
                    (this.ExpressionLanguageScope != null &&
                    this.ExpressionLanguageScope.Equals(input.ExpressionLanguageScope))
                ) && 
                (
                    this.IdentifiesControllerService == input.IdentifiesControllerService ||
                    (this.IdentifiesControllerService != null &&
                    this.IdentifiesControllerService.Equals(input.IdentifiesControllerService))
                ) && 
                (
                    this.IdentifiesControllerServiceBundle == input.IdentifiesControllerServiceBundle ||
                    (this.IdentifiesControllerServiceBundle != null &&
                    this.IdentifiesControllerServiceBundle.Equals(input.IdentifiesControllerServiceBundle))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.AllowableValues != null)
                    hashCode = hashCode * 59 + this.AllowableValues.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Sensitive != null)
                    hashCode = hashCode * 59 + this.Sensitive.GetHashCode();
                if (this.Dynamic != null)
                    hashCode = hashCode * 59 + this.Dynamic.GetHashCode();
                if (this.SupportsEl != null)
                    hashCode = hashCode * 59 + this.SupportsEl.GetHashCode();
                if (this.ExpressionLanguageScope != null)
                    hashCode = hashCode * 59 + this.ExpressionLanguageScope.GetHashCode();
                if (this.IdentifiesControllerService != null)
                    hashCode = hashCode * 59 + this.IdentifiesControllerService.GetHashCode();
                if (this.IdentifiesControllerServiceBundle != null)
                    hashCode = hashCode * 59 + this.IdentifiesControllerServiceBundle.GetHashCode();
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
