# IO.Swagger.Model.ControllerServiceDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the component. | [optional] 
**VersionedComponentId** | **string** | The ID of the corresponding component that is under version control | [optional] 
**ParentGroupId** | **string** | The id of parent process group of this component if applicable. | [optional] 
**Position** | [**PositionDTO**](PositionDTO.md) | The position of this component in the UI if applicable. | [optional] 
**Name** | **string** | The name of the controller service. | [optional] 
**Type** | **string** | The type of the controller service. | [optional] 
**Bundle** | [**BundleDTO**](BundleDTO.md) | The details of the artifact that bundled this processor type. | [optional] 
**ControllerServiceApis** | [**List&lt;ControllerServiceApiDTO&gt;**](ControllerServiceApiDTO.md) | Lists the APIs this Controller Service implements. | [optional] 
**Comments** | **string** | The comments for the controller service. | [optional] 
**State** | **string** | The state of the controller service. | [optional] 
**PersistsState** | **bool?** | Whether the controller service persists state. | [optional] 
**Restricted** | **bool?** | Whether the controller service requires elevated privileges. | [optional] 
**Deprecated** | **bool?** | Whether the ontroller service has been deprecated. | [optional] 
**MultipleVersionsAvailable** | **bool?** | Whether the controller service has multiple versions available. | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** | The properties of the controller service. | [optional] 
**Descriptors** | [**Dictionary&lt;string, PropertyDescriptorDTO&gt;**](PropertyDescriptorDTO.md) | The descriptors for the controller service properties. | [optional] 
**CustomUiUrl** | **string** | The URL for the controller services custom configuration UI if applicable. | [optional] 
**AnnotationData** | **string** | The annotation for the controller service. This is how the custom UI relays configuration to the controller service. | [optional] 
**ReferencingComponents** | [**List&lt;ControllerServiceReferencingComponentEntity&gt;**](ControllerServiceReferencingComponentEntity.md) | All components referencing this controller service. | [optional] 
**ValidationErrors** | **List&lt;string&gt;** | The validation errors from the controller service. These validation errors represent the problems with the controller service that must be resolved before it can be enabled. | [optional] 
**ValidationStatus** | **string** | Indicates whether the ControllerService is valid, invalid, or still in the process of validating (i.e., it is unknown whether or not the ControllerService is valid) | [optional] 
**ExtensionMissing** | **bool?** | Whether the underlying extension is missing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

