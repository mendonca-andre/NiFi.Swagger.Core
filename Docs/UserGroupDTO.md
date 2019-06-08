# IO.Swagger.Model.UserGroupDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the component. | [optional] 
**VersionedComponentId** | **string** | The ID of the corresponding component that is under version control | [optional] 
**ParentGroupId** | **string** | The id of parent process group of this component if applicable. | [optional] 
**Position** | [**PositionDTO**](PositionDTO.md) | The position of this component in the UI if applicable. | [optional] 
**Identity** | **string** | The identity of the tenant. | [optional] 
**Configurable** | **bool?** | Whether this tenant is configurable. | [optional] 
**Users** | [**List&lt;TenantEntity&gt;**](TenantEntity.md) | The users that belong to the user group. | [optional] 
**AccessPolicies** | [**List&lt;AccessPolicyEntity&gt;**](AccessPolicyEntity.md) | The access policies this user group belongs to. This field was incorrectly defined as an AccessPolicyEntity. For compatibility reasons the field will remain of this type, however only the fields that are present in the AccessPolicySummaryEntity will be populated here. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

