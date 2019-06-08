# IO.Swagger.Model.DropRequestDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id for this drop request. | [optional] 
**Uri** | **string** | The URI for future requests to this drop request. | [optional] 
**SubmissionTime** | **string** | The timestamp when the query was submitted. | [optional] 
**LastUpdated** | **string** | The last time this drop request was updated. | [optional] 
**PercentCompleted** | **int?** | The current percent complete. | [optional] 
**Finished** | **bool?** | Whether the query has finished. | [optional] 
**FailureReason** | **string** | The reason, if any, that this drop request failed. | [optional] 
**CurrentCount** | **int?** | The number of flow files currently queued. | [optional] 
**CurrentSize** | **long?** | The size of flow files currently queued in bytes. | [optional] 
**Current** | **string** | The count and size of flow files currently queued. | [optional] 
**OriginalCount** | **int?** | The number of flow files to be dropped as a result of this request. | [optional] 
**OriginalSize** | **long?** | The size of flow files to be dropped as a result of this request in bytes. | [optional] 
**Original** | **string** | The count and size of flow files to be dropped as a result of this request. | [optional] 
**DroppedCount** | **int?** | The number of flow files that have been dropped thus far. | [optional] 
**DroppedSize** | **long?** | The size of flow files that have been dropped thus far in bytes. | [optional] 
**Dropped** | **string** | The count and size of flow files that have been dropped thus far. | [optional] 
**State** | **string** | The current state of the drop request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

