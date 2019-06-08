# IO.Swagger.Model.ComponentStateDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComponentId** | **string** | The component identifier. | [optional] 
**StateDescription** | **string** | Description of the state this component persists. | [optional] 
**ClusterState** | [**StateMapDTO**](StateMapDTO.md) | The cluster state for this component, or null if this NiFi is a standalone instance. | [optional] 
**LocalState** | [**StateMapDTO**](StateMapDTO.md) | The local state for this component. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

