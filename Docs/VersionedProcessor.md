# IO.Swagger.Model.VersionedProcessor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | The component&#39;s unique identifier | [optional] 
**Name** | **string** | The component&#39;s name | [optional] 
**Comments** | **string** | The user-supplied comments for the component | [optional] 
**Position** | [**Position**](Position.md) | The component&#39;s position on the graph | [optional] 
**Bundle** | [**Bundle**](Bundle.md) | Information about the bundle from which the component came | [optional] 
**Style** | **Dictionary&lt;string, string&gt;** | Stylistic data for rendering in a UI | [optional] 
**Type** | **string** | The type of Processor | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** | The properties for the processor. Properties whose value is not set will only contain the property name. | [optional] 
**PropertyDescriptors** | [**Dictionary&lt;string, VersionedPropertyDescriptor&gt;**](VersionedPropertyDescriptor.md) | The property descriptors for the processor. | [optional] 
**AnnotationData** | **string** | The annotation data for the processor used to relay configuration between a custom UI and the procesosr. | [optional] 
**SchedulingPeriod** | **string** | The frequency with which to schedule the processor. The format of the value will depend on th value of schedulingStrategy. | [optional] 
**SchedulingStrategy** | **string** | Indcates whether the prcessor should be scheduled to run in event or timer driven mode. | [optional] 
**ExecutionNode** | **string** | Indicates the node where the process will execute. | [optional] 
**PenaltyDuration** | **string** | The amout of time that is used when the process penalizes a flowfile. | [optional] 
**YieldDuration** | **string** | The amount of time that must elapse before this processor is scheduled again after yielding. | [optional] 
**BulletinLevel** | **string** | The level at which the processor will report bulletins. | [optional] 
**RunDurationMillis** | **long?** | The run duration for the processor in milliseconds. | [optional] 
**ConcurrentlySchedulableTaskCount** | **int?** | The number of tasks that should be concurrently schedule for the processor. If the processor doesn&#39;t allow parallol processing then any positive input will be ignored. | [optional] 
**AutoTerminatedRelationships** | **List&lt;string&gt;** | The names of all relationships that cause a flow file to be terminated if the relationship is not connected elsewhere. This property differs from the &#39;isAutoTerminate&#39; property of the RelationshipDTO in that the RelationshipDTO is meant to depict the current configuration, whereas this property can be set in a DTO when updating a Processor in order to change which Relationships should be auto-terminated. | [optional] 
**ComponentType** | **string** |  | [optional] 
**GroupIdentifier** | **string** | The ID of the Process Group that this component belongs to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

