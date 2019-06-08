# IO.Swagger.Model.VersionedRemoteGroupPort
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | The component&#39;s unique identifier | [optional] 
**Name** | **string** | The component&#39;s name | [optional] 
**Comments** | **string** | The user-supplied comments for the component | [optional] 
**Position** | [**Position**](Position.md) | The component&#39;s position on the graph | [optional] 
**RemoteGroupId** | **string** | The id of the remote process group that the port resides in. | [optional] 
**ConcurrentlySchedulableTaskCount** | **int?** | The number of task that may transmit flowfiles to the target port concurrently. | [optional] 
**UseCompression** | **bool?** | Whether the flowfiles are compressed when sent to the target port. | [optional] 
**BatchSize** | [**BatchSize**](BatchSize.md) | The batch settings for data transmission. | [optional] 
**ComponentType** | **string** |  | [optional] 
**TargetId** | **string** | The ID of the port on the target NiFi instance | [optional] 
**GroupIdentifier** | **string** | The ID of the Process Group that this component belongs to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

