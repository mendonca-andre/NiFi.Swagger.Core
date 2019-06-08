# IO.Swagger.Model.SystemDiagnosticsDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregateSnapshot** | [**SystemDiagnosticsSnapshotDTO**](SystemDiagnosticsSnapshotDTO.md) | A systems diagnostic snapshot that represents the aggregate values of all nodes in the cluster. If the NiFi instance is a standalone instance, rather than a cluster, this represents the stats of the single instance. | [optional] 
**NodeSnapshots** | [**List&lt;NodeSystemDiagnosticsSnapshotDTO&gt;**](NodeSystemDiagnosticsSnapshotDTO.md) | A systems diagnostics snapshot for each node in the cluster. If the NiFi instance is a standalone instance, rather than a cluster, this may be null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

