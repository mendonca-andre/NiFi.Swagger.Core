# IO.Swagger.Model.ProcessorStatusSnapshotDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the processor. | [optional] 
**GroupId** | **string** | The id of the parent process group to which the processor belongs. | [optional] 
**Name** | **string** | The name of the prcessor. | [optional] 
**Type** | **string** | The type of the processor. | [optional] 
**RunStatus** | **string** | The state of the processor. | [optional] 
**ExecutionNode** | **string** | Indicates the node where the process will execute. | [optional] 
**BytesRead** | **long?** | The number of bytes read by this Processor in the last 5 mintues | [optional] 
**BytesWritten** | **long?** | The number of bytes written by this Processor in the last 5 minutes | [optional] 
**Read** | **string** | The number of bytes read in the last 5 minutes. | [optional] 
**Written** | **string** | The number of bytes written in the last 5 minutes. | [optional] 
**FlowFilesIn** | **int?** | The number of FlowFiles that have been accepted in the last 5 minutes | [optional] 
**BytesIn** | **long?** | The size of the FlowFiles that have been accepted in the last 5 minutes | [optional] 
**Input** | **string** | The count/size of flowfiles that have been accepted in the last 5 minutes. | [optional] 
**FlowFilesOut** | **int?** | The number of FlowFiles transferred to a Connection in the last 5 minutes | [optional] 
**BytesOut** | **long?** | The size of the FlowFiles transferred to a Connection in the last 5 minutes | [optional] 
**Output** | **string** | The count/size of flowfiles that have been processed in the last 5 minutes. | [optional] 
**TaskCount** | **int?** | The number of times this Processor has run in the last 5 minutes | [optional] 
**TasksDurationNanos** | **long?** | The number of nanoseconds that this Processor has spent running in the last 5 minutes | [optional] 
**Tasks** | **string** | The total number of task this connectable has completed over the last 5 minutes. | [optional] 
**TasksDuration** | **string** | The total duration of all tasks for this connectable over the last 5 minutes. | [optional] 
**ActiveThreadCount** | **int?** | The number of threads currently executing in the processor. | [optional] 
**TerminatedThreadCount** | **int?** | The number of threads currently terminated for the processor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

