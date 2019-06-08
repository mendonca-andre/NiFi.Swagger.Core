# IO.Swagger.Model.ProcessorConfigDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | **Dictionary&lt;string, string&gt;** | The properties for the processor. Properties whose value is not set will only contain the property name. | [optional] 
**Descriptors** | [**Dictionary&lt;string, PropertyDescriptorDTO&gt;**](PropertyDescriptorDTO.md) | Descriptors for the processor&#39;s properties. | [optional] 
**SchedulingPeriod** | **string** | The frequency with which to schedule the processor. The format of the value will depend on th value of schedulingStrategy. | [optional] 
**SchedulingStrategy** | **string** | Indcates whether the prcessor should be scheduled to run in event or timer driven mode. | [optional] 
**ExecutionNode** | **string** | Indicates the node where the process will execute. | [optional] 
**PenaltyDuration** | **string** | The amount of time that is used when the process penalizes a flowfile. | [optional] 
**YieldDuration** | **string** | The amount of time that must elapse before this processor is scheduled again after yielding. | [optional] 
**BulletinLevel** | **string** | The level at which the processor will report bulletins. | [optional] 
**RunDurationMillis** | **long?** | The run duration for the processor in milliseconds. | [optional] 
**ConcurrentlySchedulableTaskCount** | **int?** | The number of tasks that should be concurrently schedule for the processor. If the processor doesn&#39;t allow parallol processing then any positive input will be ignored. | [optional] 
**AutoTerminatedRelationships** | **List&lt;string&gt;** | The names of all relationships that cause a flow file to be terminated if the relationship is not connected elsewhere. This property differs from the &#39;isAutoTerminate&#39; property of the RelationshipDTO in that the RelationshipDTO is meant to depict the current configuration, whereas this property can be set in a DTO when updating a Processor in order to change which Relationships should be auto-terminated. | [optional] 
**Comments** | **string** | The comments for the processor. | [optional] 
**CustomUiUrl** | **string** | The URL for the processor&#39;s custom configuration UI if applicable. | [optional] 
**LossTolerant** | **bool?** | Whether the processor is loss tolerant. | [optional] 
**AnnotationData** | **string** | The annotation data for the processor used to relay configuration between a custom UI and the procesosr. | [optional] 
**DefaultConcurrentTasks** | **Dictionary&lt;string, string&gt;** | Maps default values for concurrent tasks for each applicable scheduling strategy. | [optional] 
**DefaultSchedulingPeriod** | **Dictionary&lt;string, string&gt;** | Maps default values for scheduling period for each applicable scheduling strategy. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

