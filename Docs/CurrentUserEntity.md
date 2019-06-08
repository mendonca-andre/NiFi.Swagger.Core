# IO.Swagger.Model.CurrentUserEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identity** | **string** | The user identity being serialized. | [optional] 
**Anonymous** | **bool?** | Whether the current user is anonymous. | [optional] 
**ProvenancePermissions** | [**PermissionsDTO**](PermissionsDTO.md) | Permissions for querying provenance. | [optional] 
**CountersPermissions** | [**PermissionsDTO**](PermissionsDTO.md) | Permissions for accessing counters. | [optional] 
**TenantsPermissions** | [**PermissionsDTO**](PermissionsDTO.md) | Permissions for accessing tenants. | [optional] 
**ControllerPermissions** | [**PermissionsDTO**](PermissionsDTO.md) | Permissions for accessing the controller. | [optional] 
**PoliciesPermissions** | [**PermissionsDTO**](PermissionsDTO.md) | Permissions for accessing the policies. | [optional] 
**SystemPermissions** | [**PermissionsDTO**](PermissionsDTO.md) | Permissions for accessing system. | [optional] 
**RestrictedComponentsPermissions** | [**PermissionsDTO**](PermissionsDTO.md) | Permissions for accessing restricted components. Note: the read permission are not used and will always be false. | [optional] 
**ComponentRestrictionPermissions** | [**List&lt;ComponentRestrictionPermissionDTO&gt;**](ComponentRestrictionPermissionDTO.md) | Permissions for specific component restrictions. | [optional] 
**CanVersionFlows** | **bool?** | Whether the current user can version flows. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

