# IO.Swagger.Model.VariableRegistryUpdateRequestDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | The unique ID of this request. | [optional] 
**ProcessGroupId** | **string** | The unique ID of the Process Group that the variable registry belongs to | [optional] 
**Uri** | **string** | The URI for future requests to this drop request. | [optional] 
**SubmissionTime** | **string** | The time at which this request was submitted. | [optional] 
**LastUpdated** | **string** | The last time this request was updated. | [optional] 
**Complete** | **bool?** | Whether or not this request has completed | [optional] 
**FailureReason** | **string** | An explanation of why this request failed, or null if this request has not failed | [optional] 
**UpdateSteps** | [**List&lt;VariableRegistryUpdateStepDTO&gt;**](VariableRegistryUpdateStepDTO.md) | The steps that are required in order to complete the request, along with the status of each | [optional] 
**AffectedComponents** | [**List&lt;AffectedComponentEntity&gt;**](AffectedComponentEntity.md) | A set of all components that will be affected if the value of this variable is changed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

