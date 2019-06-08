# IO.Swagger.Model.RemoteProcessGroupPortDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the port. | [optional] 
**TargetId** | **string** | The id of the target port. | [optional] 
**VersionedComponentId** | **string** | The ID of the corresponding component that is under version control | [optional] 
**GroupId** | **string** | The id of the remote process group that the port resides in. | [optional] 
**Name** | **string** | The name of the target port. | [optional] 
**Comments** | **string** | The comments as configured on the target port. | [optional] 
**ConcurrentlySchedulableTaskCount** | **int?** | The number of task that may transmit flowfiles to the target port concurrently. | [optional] 
**Transmitting** | **bool?** | Whether the remote port is configured for transmission. | [optional] 
**UseCompression** | **bool?** | Whether the flowfiles are compressed when sent to the target port. | [optional] 
**Exists** | **bool?** | Whether the target port exists. | [optional] 
**TargetRunning** | **bool?** | Whether the target port is running. | [optional] 
**Connected** | **bool?** | Whether the port has either an incoming or outgoing connection. | [optional] 
**BatchSettings** | [**BatchSettingsDTO**](BatchSettingsDTO.md) | The batch settings for data transmission. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

