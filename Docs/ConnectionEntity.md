# IO.Swagger.Model.ConnectionEntity
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
**Component** | [**ConnectionDTO**](ConnectionDTO.md) |  | [optional] 
**Status** | [**ConnectionStatusDTO**](ConnectionStatusDTO.md) | The status of the connection. | [optional] 
**Bends** | [**List&lt;PositionDTO&gt;**](PositionDTO.md) | The bend points on the connection. | [optional] 
**LabelIndex** | **int?** | The index of the bend point where to place the connection label. | [optional] 
**GetzIndex** | **long?** | The z index of the connection. | [optional] 
**SourceId** | **string** | The identifier of the source of this connection. | [optional] 
**SourceGroupId** | **string** | The identifier of the group of the source of this connection. | [optional] 
**SourceType** | **string** | The type of component the source connectable is. | 
**DestinationId** | **string** | The identifier of the destination of this connection. | [optional] 
**DestinationGroupId** | **string** | The identifier of the group of the destination of this connection. | [optional] 
**DestinationType** | **string** | The type of component the destination connectable is. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

