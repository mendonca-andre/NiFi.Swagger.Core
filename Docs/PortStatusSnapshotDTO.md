# IO.Swagger.Model.PortStatusSnapshotDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the port. | [optional] 
**GroupId** | **string** | The id of the parent process group of the port. | [optional] 
**Name** | **string** | The name of the port. | [optional] 
**ActiveThreadCount** | **int?** | The active thread count for the port. | [optional] 
**FlowFilesIn** | **int?** | The number of FlowFiles that have been accepted in the last 5 minutes. | [optional] 
**BytesIn** | **long?** | The size of hte FlowFiles that have been accepted in the last 5 minutes. | [optional] 
**Input** | **string** | The count/size of flowfiles that have been accepted in the last 5 minutes. | [optional] 
**FlowFilesOut** | **int?** | The number of FlowFiles that have been processed in the last 5 minutes. | [optional] 
**BytesOut** | **long?** | The number of bytes that have been processed in the last 5 minutes. | [optional] 
**Output** | **string** | The count/size of flowfiles that have been processed in the last 5 minutes. | [optional] 
**Transmitting** | **bool?** | Whether the port has incoming or outgoing connections to a remote NiFi. | [optional] 
**RunStatus** | **string** | The run status of the port. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

