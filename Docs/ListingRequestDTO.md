# IO.Swagger.Model.ListingRequestDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id for this listing request. | [optional] 
**Uri** | **string** | The URI for future requests to this listing request. | [optional] 
**SubmissionTime** | **string** | The timestamp when the query was submitted. | [optional] 
**LastUpdated** | **string** | The last time this listing request was updated. | [optional] 
**PercentCompleted** | **int?** | The current percent complete. | [optional] 
**Finished** | **bool?** | Whether the query has finished. | [optional] 
**FailureReason** | **string** | The reason, if any, that this listing request failed. | [optional] 
**MaxResults** | **int?** | The maximum number of FlowFileSummary objects to return | [optional] 
**State** | **string** | The current state of the listing request. | [optional] 
**QueueSize** | [**QueueSizeDTO**](QueueSizeDTO.md) | The size of the queue | [optional] 
**FlowFileSummaries** | [**List&lt;FlowFileSummaryDTO&gt;**](FlowFileSummaryDTO.md) | The FlowFile summaries. The summaries will be populated once the request has completed. | [optional] 
**SourceRunning** | **bool?** | Whether the source of the connection is running | [optional] 
**DestinationRunning** | **bool?** | Whether the destination of the connection is running | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

