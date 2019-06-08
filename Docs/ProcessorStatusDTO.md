# IO.Swagger.Model.ProcessorStatusDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **string** | The unique ID of the process group that the Processor belongs to | [optional] 
**Id** | **string** | The unique ID of the Processor | [optional] 
**Name** | **string** | The name of the Processor | [optional] 
**Type** | **string** | The type of the Processor | [optional] 
**RunStatus** | **string** | The run status of the Processor | [optional] 
**StatsLastRefreshed** | **string** | The timestamp of when the stats were last refreshed | [optional] 
**AggregateSnapshot** | [**ProcessorStatusSnapshotDTO**](ProcessorStatusSnapshotDTO.md) | A status snapshot that represents the aggregate stats of all nodes in the cluster. If the NiFi instance is a standalone instance, rather than a cluster, this represents the stats of the single instance. | [optional] 
**NodeSnapshots** | [**List&lt;NodeProcessorStatusSnapshotDTO&gt;**](NodeProcessorStatusSnapshotDTO.md) | A status snapshot for each node in the cluster. If the NiFi instance is a standalone instance, rather than a cluster, this may be null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

