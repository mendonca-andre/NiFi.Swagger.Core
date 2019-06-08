# IO.Swagger.Model.VersionedFlowSnapshotEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VersionedFlowSnapshot** | [**VersionedFlowSnapshot**](VersionedFlowSnapshot.md) | The versioned flow snapshot | [optional] 
**ProcessGroupRevision** | [**RevisionDTO**](RevisionDTO.md) | The Revision of the Process Group under Version Control | [optional] 
**RegistryId** | **string** | The ID of the Registry that this flow belongs to | [optional] 
**UpdateDescendantVersionedFlows** | **bool?** | If the Process Group to be updated has a child or descendant Process Group that is also under Version Control, this specifies whether or not the contents of that child/descendant Process Group should be updated. | [optional] 
**DisconnectedNodeAcknowledged** | **bool?** | Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

