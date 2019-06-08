# IO.Swagger.Model.ProcessGroupFlowDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the component. | [optional] 
**Uri** | **string** | The URI for futures requests to the component. | [optional] 
**ParentGroupId** | **string** | The id of parent process group of this component if applicable. | [optional] 
**Breadcrumb** | [**FlowBreadcrumbEntity**](FlowBreadcrumbEntity.md) | The breadcrumb of the process group. | [optional] 
**Flow** | [**FlowDTO**](FlowDTO.md) | The flow structure starting at this Process Group. | [optional] 
**LastRefreshed** | **string** | The time the flow for the process group was last refreshed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

