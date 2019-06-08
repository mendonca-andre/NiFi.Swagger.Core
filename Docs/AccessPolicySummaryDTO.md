# IO.Swagger.Model.AccessPolicySummaryDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the component. | [optional] 
**VersionedComponentId** | **string** | The ID of the corresponding component that is under version control | [optional] 
**ParentGroupId** | **string** | The id of parent process group of this component if applicable. | [optional] 
**Position** | [**PositionDTO**](PositionDTO.md) | The position of this component in the UI if applicable. | [optional] 
**Resource** | **string** | The resource for this access policy. | [optional] 
**Action** | **string** | The action associated with this access policy. | [optional] 
**ComponentReference** | [**ComponentReferenceEntity**](ComponentReferenceEntity.md) | Component this policy references if applicable. | [optional] 
**Configurable** | **bool?** | Whether this policy is configurable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

