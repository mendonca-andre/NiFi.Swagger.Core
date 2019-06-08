# IO.Swagger.Model.PropertyDescriptorDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name for the property. | [optional] 
**DisplayName** | **string** | The human readable name for the property. | [optional] 
**Description** | **string** | The description for the property. Used to relay additional details to a user or provide a mechanism of documenting intent. | [optional] 
**DefaultValue** | **string** | The default value for the property. | [optional] 
**AllowableValues** | [**List&lt;AllowableValueEntity&gt;**](AllowableValueEntity.md) | Allowable values for the property. If empty then the allowed values are not constrained. | [optional] 
**Required** | **bool?** | Whether the property is required. | [optional] 
**Sensitive** | **bool?** | Whether the property is sensitive and protected whenever stored or represented. | [optional] 
**Dynamic** | **bool?** | Whether the property is dynamic (user-defined). | [optional] 
**SupportsEl** | **bool?** | Whether the property supports expression language. | [optional] 
**ExpressionLanguageScope** | **string** | Scope of the Expression Language evaluation for the property. | [optional] 
**IdentifiesControllerService** | **string** | If the property identifies a controller service this returns the fully qualified type. | [optional] 
**IdentifiesControllerServiceBundle** | [**BundleDTO**](BundleDTO.md) | If the property identifies a controller service this returns the bundle of the type, null otherwise. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

