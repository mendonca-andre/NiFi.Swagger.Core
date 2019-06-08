# IO.Swagger.Model.RemoteProcessGroupStatusSnapshotDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the remote process group. | [optional] 
**GroupId** | **string** | The id of the parent process group the remote process group resides in. | [optional] 
**Name** | **string** | The name of the remote process group. | [optional] 
**TargetUri** | **string** | The URI of the target system. | [optional] 
**TransmissionStatus** | **string** | The transmission status of the remote process group. | [optional] 
**ActiveThreadCount** | **int?** | The number of active threads for the remote process group. | [optional] 
**FlowFilesSent** | **int?** | The number of FlowFiles sent to the remote process group in the last 5 minutes. | [optional] 
**BytesSent** | **long?** | The size of the FlowFiles sent to the remote process group in the last 5 minutes. | [optional] 
**Sent** | **string** | The count/size of the flowfiles sent to the remote process group in the last 5 minutes. | [optional] 
**FlowFilesReceived** | **int?** | The number of FlowFiles received from the remote process group in the last 5 minutes. | [optional] 
**BytesReceived** | **long?** | The size of the FlowFiles received from the remote process group in the last 5 minutes. | [optional] 
**Received** | **string** | The count/size of the flowfiles received from the remote process group in the last 5 minutes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

