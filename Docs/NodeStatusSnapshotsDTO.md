# IO.Swagger.Model.NodeStatusSnapshotsDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeId** | **string** | The id of the node. | [optional] 
**Address** | **string** | The node&#39;s host/ip address. | [optional] 
**ApiPort** | **int?** | The port the node is listening for API requests. | [optional] 
**StatusSnapshots** | [**List&lt;StatusSnapshotDTO&gt;**](StatusSnapshotDTO.md) | A list of StatusSnapshotDTO objects that provide the actual metric values for the component for this node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

