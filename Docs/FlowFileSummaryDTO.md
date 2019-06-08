# IO.Swagger.Model.FlowFileSummaryDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The URI that can be used to access this FlowFile. | [optional] 
**Uuid** | **string** | The FlowFile UUID. | [optional] 
**Filename** | **string** | The FlowFile filename. | [optional] 
**Position** | **int?** | The FlowFile&#39;s position in the queue. | [optional] 
**Size** | **long?** | The FlowFile file size. | [optional] 
**QueuedDuration** | **long?** | How long this FlowFile has been enqueued. | [optional] 
**LineageDuration** | **long?** | Duration since the FlowFile&#39;s greatest ancestor entered the flow. | [optional] 
**PenaltyExpiresIn** | **long?** | How long in milliseconds until the FlowFile penalty expires. | [optional] 
**ClusterNodeId** | **string** | The id of the node where this FlowFile resides. | [optional] 
**ClusterNodeAddress** | **string** | The label for the node where this FlowFile resides. | [optional] 
**Penalized** | **bool?** | If the FlowFile is penalized. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

