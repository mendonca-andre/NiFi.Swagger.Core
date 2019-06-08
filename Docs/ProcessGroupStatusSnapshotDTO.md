# IO.Swagger.Model.ProcessGroupStatusSnapshotDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the process group. | [optional] 
**Name** | **string** | The name of this process group. | [optional] 
**ConnectionStatusSnapshots** | [**List&lt;ConnectionStatusSnapshotEntity&gt;**](ConnectionStatusSnapshotEntity.md) | The status of all connections in the process group. | [optional] 
**ProcessorStatusSnapshots** | [**List&lt;ProcessorStatusSnapshotEntity&gt;**](ProcessorStatusSnapshotEntity.md) | The status of all processors in the process group. | [optional] 
**ProcessGroupStatusSnapshots** | [**List&lt;ProcessGroupStatusSnapshotEntity&gt;**](ProcessGroupStatusSnapshotEntity.md) | The status of all process groups in the process group. | [optional] 
**RemoteProcessGroupStatusSnapshots** | [**List&lt;RemoteProcessGroupStatusSnapshotEntity&gt;**](RemoteProcessGroupStatusSnapshotEntity.md) | The status of all remote process groups in the process group. | [optional] 
**InputPortStatusSnapshots** | [**List&lt;PortStatusSnapshotEntity&gt;**](PortStatusSnapshotEntity.md) | The status of all input ports in the process group. | [optional] 
**OutputPortStatusSnapshots** | [**List&lt;PortStatusSnapshotEntity&gt;**](PortStatusSnapshotEntity.md) | The status of all output ports in the process group. | [optional] 
**VersionedFlowState** | **string** | The current state of the Process Group, as it relates to the Versioned Flow | [optional] 
**FlowFilesIn** | **int?** | The number of FlowFiles that have come into this ProcessGroup in the last 5 minutes | [optional] 
**BytesIn** | **long?** | The number of bytes that have come into this ProcessGroup in the last 5 minutes | [optional] 
**Input** | **string** | The input count/size for the process group in the last 5 minutes (pretty printed). | [optional] 
**FlowFilesQueued** | **int?** | The number of FlowFiles that are queued up in this ProcessGroup right now | [optional] 
**BytesQueued** | **long?** | The number of bytes that are queued up in this ProcessGroup right now | [optional] 
**Queued** | **string** | The count/size that is queued in the the process group. | [optional] 
**QueuedCount** | **string** | The count that is queued for the process group. | [optional] 
**QueuedSize** | **string** | The size that is queued for the process group. | [optional] 
**BytesRead** | **long?** | The number of bytes read by components in this ProcessGroup in the last 5 minutes | [optional] 
**Read** | **string** | The number of bytes read in the last 5 minutes. | [optional] 
**BytesWritten** | **long?** | The number of bytes written by components in this ProcessGroup in the last 5 minutes | [optional] 
**Written** | **string** | The number of bytes written in the last 5 minutes. | [optional] 
**FlowFilesOut** | **int?** | The number of FlowFiles transferred out of this ProcessGroup in the last 5 minutes | [optional] 
**BytesOut** | **long?** | The number of bytes transferred out of this ProcessGroup in the last 5 minutes | [optional] 
**Output** | **string** | The output count/size for the process group in the last 5 minutes. | [optional] 
**FlowFilesTransferred** | **int?** | The number of FlowFiles transferred in this ProcessGroup in the last 5 minutes | [optional] 
**BytesTransferred** | **long?** | The number of bytes transferred in this ProcessGroup in the last 5 minutes | [optional] 
**Transferred** | **string** | The count/size transferred to/from queues in the process group in the last 5 minutes. | [optional] 
**BytesReceived** | **long?** | The number of bytes received from external sources by components within this ProcessGroup in the last 5 minutes | [optional] 
**FlowFilesReceived** | **int?** | The number of FlowFiles received from external sources by components within this ProcessGroup in the last 5 minutes | [optional] 
**Received** | **string** | The count/size sent to the process group in the last 5 minutes. | [optional] 
**BytesSent** | **long?** | The number of bytes sent to an external sink by components within this ProcessGroup in the last 5 minutes | [optional] 
**FlowFilesSent** | **int?** | The number of FlowFiles sent to an external sink by components within this ProcessGroup in the last 5 minutes | [optional] 
**Sent** | **string** | The count/size sent from this process group in the last 5 minutes. | [optional] 
**ActiveThreadCount** | **int?** | The active thread count for this process group. | [optional] 
**TerminatedThreadCount** | **int?** | The number of threads currently terminated for the process group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

