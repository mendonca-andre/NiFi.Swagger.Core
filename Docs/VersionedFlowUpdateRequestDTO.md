# IO.Swagger.Model.VersionedFlowUpdateRequestDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | The unique ID of this request. | [optional] 
**ProcessGroupId** | **string** | The unique ID of the Process Group that the variable registry belongs to | [optional] 
**Uri** | **string** | The URI for future requests to this drop request. | [optional] 
**LastUpdated** | **string** | The last time this request was updated. | [optional] 
**Complete** | **bool?** | Whether or not this request has completed | [optional] 
**FailureReason** | **string** | An explanation of why this request failed, or null if this request has not failed | [optional] 
**PercentCompleted** | **int?** | The percentage complete for the request, between 0 and 100 | [optional] 
**State** | **string** | The state of the request | [optional] 
**VersionControlInformation** | [**VersionControlInformationDTO**](VersionControlInformationDTO.md) | The VersionControlInformation that describes where the Versioned Flow is located; this may not be populated until the request is completed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

