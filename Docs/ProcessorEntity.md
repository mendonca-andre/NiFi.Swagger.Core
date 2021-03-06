# IO.Swagger.Model.ProcessorEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Revision** | [**RevisionDTO**](RevisionDTO.md) | The revision for this request/response. The revision is required for any mutable flow requests and is included in all responses. | [optional] 
**Id** | **string** | The id of the component. | [optional] 
**Uri** | **string** | The URI for futures requests to the component. | [optional] 
**Position** | [**PositionDTO**](PositionDTO.md) | The position of this component in the UI if applicable. | [optional] 
**Permissions** | [**PermissionsDTO**](PermissionsDTO.md) | The permissions for this component. | [optional] 
**Bulletins** | [**List&lt;BulletinEntity&gt;**](BulletinEntity.md) | The bulletins for this component. | [optional] 
**DisconnectedNodeAcknowledged** | **bool?** | Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] 
**Component** | [**ProcessorDTO**](ProcessorDTO.md) |  | [optional] 
**InputRequirement** | **string** | The input requirement for this processor. | [optional] 
**Status** | [**ProcessorStatusDTO**](ProcessorStatusDTO.md) |  | [optional] 
**OperatePermissions** | [**PermissionsDTO**](PermissionsDTO.md) | The permissions for this component operations. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

