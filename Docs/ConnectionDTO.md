# IO.Swagger.Model.ConnectionDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the component. | [optional] 
**VersionedComponentId** | **string** | The ID of the corresponding component that is under version control | [optional] 
**ParentGroupId** | **string** | The id of parent process group of this component if applicable. | [optional] 
**Position** | [**PositionDTO**](PositionDTO.md) | The position of this component in the UI if applicable. | [optional] 
**Source** | [**ConnectableDTO**](ConnectableDTO.md) | The source of the connection. | [optional] 
**Destination** | [**ConnectableDTO**](ConnectableDTO.md) | The destination of the connection. | [optional] 
**Name** | **string** | The name of the connection. | [optional] 
**LabelIndex** | **int?** | The index of the bend point where to place the connection label. | [optional] 
**GetzIndex** | **long?** | The z index of the connection. | [optional] 
**SelectedRelationships** | **List&lt;string&gt;** | The selected relationship that comprise the connection. | [optional] 
**AvailableRelationships** | **List&lt;string&gt;** | The relationships that the source of the connection currently supports. | [optional] 
**BackPressureObjectThreshold** | **long?** | The object count threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue. | [optional] 
**BackPressureDataSizeThreshold** | **string** | The object data size threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue. | [optional] 
**FlowFileExpiration** | **string** | The amount of time a flow file may be in the flow before it will be automatically aged out of the flow. Once a flow file reaches this age it will be terminated from the flow the next time a processor attempts to start work on it. | [optional] 
**Prioritizers** | **List&lt;string&gt;** | The comparators used to prioritize the queue. | [optional] 
**Bends** | [**List&lt;PositionDTO&gt;**](PositionDTO.md) | The bend points on the connection. | [optional] 
**LoadBalanceStrategy** | **string** | How to load balance the data in this Connection across the nodes in the cluster. | [optional] 
**LoadBalancePartitionAttribute** | **string** | The FlowFile Attribute to use for determining which node a FlowFile will go to if the Load Balancing Strategy is set to PARTITION_BY_ATTRIBUTE | [optional] 
**LoadBalanceCompression** | **string** | Whether or not data should be compressed when being transferred between nodes in the cluster. | [optional] 
**LoadBalanceStatus** | **string** | The current status of the Connection&#39;s Load Balancing Activities. Status can indicate that Load Balancing is not configured for the connection, that Load Balancing is configured but inactive (not currently transferring data to another node), or that Load Balancing is configured and actively transferring data to another node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

