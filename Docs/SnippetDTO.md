# IO.Swagger.Model.SnippetDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the snippet. | [optional] 
**Uri** | **string** | The URI of the snippet. | [optional] 
**ParentGroupId** | **string** | The group id for the components in the snippet. | [optional] 
**ProcessGroups** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The ids of the process groups in this snippet. These ids will be populated within each response. They can be specified when creating a snippet. However, once a snippet has been created its contents cannot be modified (these ids are ignored during update requests). | [optional] 
**RemoteProcessGroups** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The ids of the remote process groups in this snippet. These ids will be populated within each response. They can be specified when creating a snippet. However, once a snippet has been created its contents cannot be modified (these ids are ignored during update requests). | [optional] 
**Processors** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The ids of the processors in this snippet. These ids will be populated within each response. They can be specified when creating a snippet. However, once a snippet has been created its contents cannot be modified (these ids are ignored during update requests). | [optional] 
**InputPorts** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The ids of the input ports in this snippet. These ids will be populated within each response. They can be specified when creating a snippet. However, once a snippet has been created its contents cannot be modified (these ids are ignored during update requests). | [optional] 
**OutputPorts** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The ids of the output ports in this snippet. These ids will be populated within each response. They can be specified when creating a snippet. However, once a snippet has been created its contents cannot be modified (these ids are ignored during update requests). | [optional] 
**Connections** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The ids of the connections in this snippet. These ids will be populated within each response. They can be specified when creating a snippet. However, once a snippet has been created its contents cannot be modified (these ids are ignored during update requests). | [optional] 
**Labels** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The ids of the labels in this snippet. These ids will be populated within each response. They can be specified when creating a snippet. However, once a snippet has been created its contents cannot be modified (these ids are ignored during update requests). | [optional] 
**Funnels** | [**Dictionary&lt;string, RevisionDTO&gt;**](RevisionDTO.md) | The ids of the funnels in this snippet. These ids will be populated within each response. They can be specified when creating a snippet. However, once a snippet has been created its contents cannot be modified (these ids are ignored during update requests). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

