# IO.Swagger.Model.InstantiateTemplateRequestEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginX** | **double?** | The x coordinate of the origin of the bounding box where the new components will be placed. | [optional] 
**OriginY** | **double?** | The y coordinate of the origin of the bounding box where the new components will be placed. | [optional] 
**TemplateId** | **string** | The identifier of the template. | [optional] 
**EncodingVersion** | **string** | The encoding version of the flow snippet. If not specified, this is automatically populated by the node receiving the user request. If the snippet is specified, the version will be the latest. If the snippet is not specified, the version will come from the underlying template. These details need to be replicated throughout the cluster to ensure consistency. | [optional] 
**Snippet** | [**FlowSnippetDTO**](FlowSnippetDTO.md) | A flow snippet of the template contents. If not specified, this is automatically populated by the node receiving the user request. These details need to be replicated throughout the cluster to ensure consistency. | [optional] 
**DisconnectedNodeAcknowledged** | **bool?** | Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

