# IO.Swagger.Model.UpdateControllerServiceReferenceRequestEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the Controller Service. | [optional] 
**State** | **string** | The new state of the references for the controller service. | [optional] 
**ReferencingComponentRevisions** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The revisions for all referencing components. | [optional] 
**DisconnectedNodeAcknowledged** | **bool?** | Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

