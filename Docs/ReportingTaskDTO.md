# IO.Swagger.Model.ReportingTaskDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the component. | [optional] 
**VersionedComponentId** | **string** | The ID of the corresponding component that is under version control | [optional] 
**ParentGroupId** | **string** | The id of parent process group of this component if applicable. | [optional] 
**Position** | [**PositionDTO**](PositionDTO.md) | The position of this component in the UI if applicable. | [optional] 
**Name** | **string** | The name of the reporting task. | [optional] 
**Type** | **string** | The fully qualified type of the reporting task. | [optional] 
**Bundle** | [**BundleDTO**](BundleDTO.md) | The details of the artifact that bundled this processor type. | [optional] 
**State** | **string** | The state of the reporting task. | [optional] 
**Comments** | **string** | The comments of the reporting task. | [optional] 
**PersistsState** | **bool?** | Whether the reporting task persists state. | [optional] 
**Restricted** | **bool?** | Whether the reporting task requires elevated privileges. | [optional] 
**Deprecated** | **bool?** | Whether the reporting task has been deprecated. | [optional] 
**MultipleVersionsAvailable** | **bool?** | Whether the reporting task has multiple versions available. | [optional] 
**SchedulingPeriod** | **string** | The frequency with which to schedule the reporting task. The format of the value willd epend on the valud of the schedulingStrategy. | [optional] 
**SchedulingStrategy** | **string** | The scheduling strategy that determines how the schedulingPeriod value should be interpreted. | [optional] 
**DefaultSchedulingPeriod** | **Dictionary&lt;string, string&gt;** | The default scheduling period for the different scheduling strategies. | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** | The properties of the reporting task. | [optional] 
**Descriptors** | [**Dictionary&lt;string, PropertyDescriptorDTO&gt;**](PropertyDescriptorDTO.md) | The descriptors for the reporting tasks properties. | [optional] 
**CustomUiUrl** | **string** | The URL for the custom configuration UI for the reporting task. | [optional] 
**AnnotationData** | **string** | The annotation data for the repoting task. This is how the custom UI relays configuration to the reporting task. | [optional] 
**ValidationErrors** | **List&lt;string&gt;** | Gets the validation errors from the reporting task. These validation errors represent the problems with the reporting task that must be resolved before it can be scheduled to run. | [optional] 
**ValidationStatus** | **string** | Indicates whether the Processor is valid, invalid, or still in the process of validating (i.e., it is unknown whether or not the Processor is valid) | [optional] 
**ActiveThreadCount** | **int?** | The number of active threads for the reporting task. | [optional] 
**ExtensionMissing** | **bool?** | Whether the underlying extension is missing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

