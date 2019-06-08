# IO.Swagger.Model.ActivateControllerServicesEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the ProcessGroup | [optional] 
**State** | **string** | The desired state of the descendant components | [optional] 
**Components** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | Optional services to schedule. If not specified, all authorized descendant controller services will be used. | [optional] 
**DisconnectedNodeAcknowledged** | **bool?** | Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

