# IO.Swagger.Model.ConnectionStatusDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the connection | [optional] 
**GroupId** | **string** | The ID of the Process Group that the connection belongs to | [optional] 
**Name** | **string** | The name of the connection | [optional] 
**StatsLastRefreshed** | **string** | The timestamp of when the stats were last refreshed | [optional] 
**SourceId** | **string** | The ID of the source component | [optional] 
**SourceName** | **string** | The name of the source component | [optional] 
**DestinationId** | **string** | The ID of the destination component | [optional] 
**DestinationName** | **string** | The name of the destination component | [optional] 
**AggregateSnapshot** | [**ConnectionStatusSnapshotDTO**](ConnectionStatusSnapshotDTO.md) | The status snapshot that represents the aggregate stats of the cluster | [optional] 
**NodeSnapshots** | [**List&lt;NodeConnectionStatusSnapshotDTO&gt;**](NodeConnectionStatusSnapshotDTO.md) | A list of status snapshots for each node | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

