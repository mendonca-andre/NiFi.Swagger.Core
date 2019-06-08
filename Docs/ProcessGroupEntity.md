# IO.Swagger.Model.ProcessGroupEntity
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
**Component** | [**ProcessGroupDTO**](ProcessGroupDTO.md) |  | [optional] 
**Status** | [**ProcessGroupStatusDTO**](ProcessGroupStatusDTO.md) | The status of the process group. | [optional] 
**VersionedFlowSnapshot** | [**VersionedFlowSnapshot**](VersionedFlowSnapshot.md) | Returns the Versioned Flow that describes the contents of the Versioned Flow to be imported | [optional] 
**RunningCount** | **int?** | The number of running components in this process group. | [optional] 
**StoppedCount** | **int?** | The number of stopped components in the process group. | [optional] 
**InvalidCount** | **int?** | The number of invalid components in the process group. | [optional] 
**DisabledCount** | **int?** | The number of disabled components in the process group. | [optional] 
**ActiveRemotePortCount** | **int?** | The number of active remote ports in the process group. | [optional] 
**InactiveRemotePortCount** | **int?** | The number of inactive remote ports in the process group. | [optional] 
**VersionedFlowState** | **string** | The current state of the Process Group, as it relates to the Versioned Flow | [optional] 
**UpToDateCount** | **int?** | The number of up to date versioned process groups in the process group. | [optional] 
**LocallyModifiedCount** | **int?** | The number of locally modified versioned process groups in the process group. | [optional] 
**StaleCount** | **int?** | The number of stale versioned process groups in the process group. | [optional] 
**LocallyModifiedAndStaleCount** | **int?** | The number of locally modified and stale versioned process groups in the process group. | [optional] 
**SyncFailureCount** | **int?** | The number of versioned process groups in the process group that are unable to sync to a registry. | [optional] 
**InputPortCount** | **int?** | The number of input ports in the process group. | [optional] 
**OutputPortCount** | **int?** | The number of output ports in the process group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

