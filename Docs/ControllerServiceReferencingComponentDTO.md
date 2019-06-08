# IO.Swagger.Model.ControllerServiceReferencingComponentDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **string** | The group id for the component referencing a controller service. If this component is another controller service or a reporting task, this field is blank. | [optional] 
**Id** | **string** | The id of the component referencing a controller service. | [optional] 
**Name** | **string** | The name of the component referencing a controller service. | [optional] 
**Type** | **string** | The type of the component referencing a controller service in simple Java class name format without package name. | [optional] 
**State** | **string** | The scheduled state of a processor or reporting task referencing a controller service. If this component is another controller service, this field represents the controller service state. | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** | The properties for the component. | [optional] 
**Descriptors** | [**Dictionary&lt;string, PropertyDescriptorDTO&gt;**](PropertyDescriptorDTO.md) | The descriptors for the component properties. | [optional] 
**ValidationErrors** | **List&lt;string&gt;** | The validation errors for the component. | [optional] 
**ReferenceType** | **string** | The type of reference this is. | [optional] 
**ActiveThreadCount** | **int?** | The number of active threads for the referencing component. | [optional] 
**ReferenceCycle** | **bool?** | If the referencing component represents a controller service, this indicates whether it has already been represented in this hierarchy. | [optional] 
**ReferencingComponents** | [**List&lt;ControllerServiceReferencingComponentEntity&gt;**](ControllerServiceReferencingComponentEntity.md) | If the referencing component represents a controller service, these are the components that reference it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

