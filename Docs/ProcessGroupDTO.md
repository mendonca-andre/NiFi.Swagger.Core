# IO.Swagger.Model.ProcessGroupDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the component. | [optional] 
**VersionedComponentId** | **string** | The ID of the corresponding component that is under version control | [optional] 
**ParentGroupId** | **string** | The id of parent process group of this component if applicable. | [optional] 
**Position** | [**PositionDTO**](PositionDTO.md) | The position of this component in the UI if applicable. | [optional] 
**Name** | **string** | The name of the process group. | [optional] 
**Comments** | **string** | The comments for the process group. | [optional] 
**Variables** | **Dictionary&lt;string, string&gt;** | The variables that are configured for the Process Group. Note that this map contains only those variables that are defined on this Process Group and not any variables that are defined in the parent Process Group, etc. I.e., this Map will not contain all variables that are accessible by components in this Process Group by rather only the variables that are defined for this Process Group itself. | [optional] 
**VersionControlInformation** | [**VersionControlInformationDTO**](VersionControlInformationDTO.md) | The Version Control information that indicates which Flow Registry, and where in the Flow Registry, this Process Group is tracking to; or null if this Process Group is not under version control | [optional] 
**RunningCount** | **int?** | The number of running components in this process group. | [optional] 
**StoppedCount** | **int?** | The number of stopped components in the process group. | [optional] 
**InvalidCount** | **int?** | The number of invalid components in the process group. | [optional] 
**DisabledCount** | **int?** | The number of disabled components in the process group. | [optional] 
**ActiveRemotePortCount** | **int?** | The number of active remote ports in the process group. | [optional] 
**InactiveRemotePortCount** | **int?** | The number of inactive remote ports in the process group. | [optional] 
**UpToDateCount** | **int?** | The number of up to date versioned process groups in the process group. | [optional] 
**LocallyModifiedCount** | **int?** | The number of locally modified versioned process groups in the process group. | [optional] 
**StaleCount** | **int?** | The number of stale versioned process groups in the process group. | [optional] 
**LocallyModifiedAndStaleCount** | **int?** | The number of locally modified and stale versioned process groups in the process group. | [optional] 
**SyncFailureCount** | **int?** | The number of versioned process groups in the process group that are unable to sync to a registry. | [optional] 
**InputPortCount** | **int?** | The number of input ports in the process group. | [optional] 
**OutputPortCount** | **int?** | The number of output ports in the process group. | [optional] 
**Contents** | [**FlowSnippetDTO**](FlowSnippetDTO.md) | The contents of this process group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

