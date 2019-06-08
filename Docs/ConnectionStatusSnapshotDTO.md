# IO.Swagger.Model.ConnectionStatusSnapshotDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the connection. | [optional] 
**GroupId** | **string** | The id of the process group the connection belongs to. | [optional] 
**Name** | **string** | The name of the connection. | [optional] 
**SourceId** | **string** | The id of the source of the connection. | [optional] 
**SourceName** | **string** | The name of the source of the connection. | [optional] 
**DestinationId** | **string** | The id of the destination of the connection. | [optional] 
**DestinationName** | **string** | The name of the destination of the connection. | [optional] 
**FlowFilesIn** | **int?** | The number of FlowFiles that have come into the connection in the last 5 minutes. | [optional] 
**BytesIn** | **long?** | The size of the FlowFiles that have come into the connection in the last 5 minutes. | [optional] 
**Input** | **string** | The input count/size for the connection in the last 5 minutes, pretty printed. | [optional] 
**FlowFilesOut** | **int?** | The number of FlowFiles that have left the connection in the last 5 minutes. | [optional] 
**BytesOut** | **long?** | The number of bytes that have left the connection in the last 5 minutes. | [optional] 
**Output** | **string** | The output count/sie for the connection in the last 5 minutes, pretty printed. | [optional] 
**FlowFilesQueued** | **int?** | The number of FlowFiles that are currently queued in the connection. | [optional] 
**BytesQueued** | **long?** | The size of the FlowFiles that are currently queued in the connection. | [optional] 
**Queued** | **string** | The total count and size of queued flowfiles formatted. | [optional] 
**QueuedSize** | **string** | The total size of flowfiles that are queued formatted. | [optional] 
**QueuedCount** | **string** | The number of flowfiles that are queued, pretty printed. | [optional] 
**PercentUseCount** | **int?** | Connection percent use regarding queued flow files count and backpressure threshold if configured. | [optional] 
**PercentUseBytes** | **int?** | Connection percent use regarding queued flow files size and backpressure threshold if configured. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

