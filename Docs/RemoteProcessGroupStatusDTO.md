# IO.Swagger.Model.RemoteProcessGroupStatusDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **string** | The unique ID of the process group that the Processor belongs to | [optional] 
**Id** | **string** | The unique ID of the Processor | [optional] 
**Name** | **string** | The name of the remote process group. | [optional] 
**TargetUri** | **string** | The URI of the target system. | [optional] 
**TransmissionStatus** | **string** | The transmission status of the remote process group. | [optional] 
**StatsLastRefreshed** | **string** | The time the status for the process group was last refreshed. | [optional] 
**ValidationStatus** | **string** | Indicates whether the component is valid, invalid, or still in the process of validating (i.e., it is unknown whether or not the component is valid) | [optional] 
**AggregateSnapshot** | [**RemoteProcessGroupStatusSnapshotDTO**](RemoteProcessGroupStatusSnapshotDTO.md) | A status snapshot that represents the aggregate stats of all nodes in the cluster. If the NiFi instance is a standalone instance, rather than a cluster, this represents the stats of the single instance. | [optional] 
**NodeSnapshots** | [**List&lt;NodeRemoteProcessGroupStatusSnapshotDTO&gt;**](NodeRemoteProcessGroupStatusSnapshotDTO.md) | A status snapshot for each node in the cluster. If the NiFi instance is a standalone instance, rather than a cluster, this may be null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

