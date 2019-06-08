# IO.Swagger.Model.VersionedConnection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | The component&#39;s unique identifier | [optional] 
**Name** | **string** | The component&#39;s name | [optional] 
**Comments** | **string** | The user-supplied comments for the component | [optional] 
**Position** | [**Position**](Position.md) | The component&#39;s position on the graph | [optional] 
**Source** | [**ConnectableComponent**](ConnectableComponent.md) | The source of the connection. | [optional] 
**Destination** | [**ConnectableComponent**](ConnectableComponent.md) | The destination of the connection. | [optional] 
**LabelIndex** | **int?** | The index of the bend point where to place the connection label. | [optional] 
**ZIndex** | **long?** | The z index of the connection. | [optional] 
**SelectedRelationships** | **List&lt;string&gt;** | The selected relationship that comprise the connection. | [optional] 
**BackPressureObjectThreshold** | **long?** | The object count threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue. | [optional] 
**BackPressureDataSizeThreshold** | **string** | The object data size threshold for determining when back pressure is applied. Updating this value is a passive change in the sense that it won&#39;t impact whether existing files over the limit are affected but it does help feeder processors to stop pushing too much into this work queue. | [optional] 
**FlowFileExpiration** | **string** | The amount of time a flow file may be in the flow before it will be automatically aged out of the flow. Once a flow file reaches this age it will be terminated from the flow the next time a processor attempts to start work on it. | [optional] 
**Prioritizers** | **List&lt;string&gt;** | The comparators used to prioritize the queue. | [optional] 
**Bends** | [**List&lt;Position&gt;**](Position.md) | The bend points on the connection. | [optional] 
**LoadBalanceStrategy** | **string** | The Strategy to use for load balancing data across the cluster, or null, if no Load Balance Strategy has been specified. | [optional] 
**PartitioningAttribute** | **string** | The attribute to use for partitioning data as it is load balanced across the cluster. If the Load Balance Strategy is configured to use PARTITION_BY_ATTRIBUTE, the value returned by this method is the name of the FlowFile Attribute that will be used to determine which node in the cluster should receive a given FlowFile. If the Load Balance Strategy is unset or is set to any other value, the Partitioning Attribute has no effect. | [optional] 
**LoadBalanceCompression** | **string** | Whether or not compression should be used when transferring FlowFiles between nodes | [optional] 
**ComponentType** | **string** |  | [optional] 
**GroupIdentifier** | **string** | The ID of the Process Group that this component belongs to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

