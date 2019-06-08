# IO.Swagger.Model.NodeDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeId** | **string** | The id of the node. | [optional] 
**Address** | **string** | The node&#39;s host/ip address. | [optional] 
**ApiPort** | **int?** | The port the node is listening for API requests. | [optional] 
**Status** | **string** | The node&#39;s status. | [optional] 
**Heartbeat** | **string** | the time of the nodes&#39;s last heartbeat. | [optional] 
**ConnectionRequested** | **string** | The time of the node&#39;s last connection request. | [optional] 
**Roles** | **List&lt;string&gt;** | The roles of this node. | [optional] 
**ActiveThreadCount** | **int?** | The active threads for the NiFi on the node. | [optional] 
**Queued** | **string** | The queue the NiFi on the node. | [optional] 
**Events** | [**List&lt;NodeEventDTO&gt;**](NodeEventDTO.md) | The node&#39;s events. | [optional] 
**NodeStartTime** | **string** | The time at which this Node was last refreshed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

