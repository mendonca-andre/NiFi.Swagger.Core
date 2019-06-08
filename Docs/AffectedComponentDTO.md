# IO.Swagger.Model.AffectedComponentDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessGroupId** | **string** | The UUID of the Process Group that this component is in | [optional] 
**Id** | **string** | The UUID of this component | [optional] 
**ReferenceType** | **string** | The type of this component | [optional] 
**Name** | **string** | The name of this component. | [optional] 
**State** | **string** | The scheduled state of a processor or reporting task referencing a controller service. If this component is another controller service, this field represents the controller service state. | [optional] 
**ActiveThreadCount** | **int?** | The number of active threads for the referencing component. | [optional] 
**ValidationErrors** | **List&lt;string&gt;** | The validation errors for the component. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

