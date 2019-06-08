# IO.Swagger.Model.VersionedProcessGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | The component&#39;s unique identifier | [optional] 
**Name** | **string** | The component&#39;s name | [optional] 
**Comments** | **string** | The user-supplied comments for the component | [optional] 
**Position** | [**Position**](Position.md) | The component&#39;s position on the graph | [optional] 
**ProcessGroups** | [**List&lt;VersionedProcessGroup&gt;**](VersionedProcessGroup.md) | The child Process Groups | [optional] 
**RemoteProcessGroups** | [**List&lt;VersionedRemoteProcessGroup&gt;**](VersionedRemoteProcessGroup.md) | The Remote Process Groups | [optional] 
**Processors** | [**List&lt;VersionedProcessor&gt;**](VersionedProcessor.md) | The Processors | [optional] 
**InputPorts** | [**List&lt;VersionedPort&gt;**](VersionedPort.md) | The Input Ports | [optional] 
**OutputPorts** | [**List&lt;VersionedPort&gt;**](VersionedPort.md) | The Output Ports | [optional] 
**Connections** | [**List&lt;VersionedConnection&gt;**](VersionedConnection.md) | The Connections | [optional] 
**Labels** | [**List&lt;VersionedLabel&gt;**](VersionedLabel.md) | The Labels | [optional] 
**Funnels** | [**List&lt;VersionedFunnel&gt;**](VersionedFunnel.md) | The Funnels | [optional] 
**ControllerServices** | [**List&lt;VersionedControllerService&gt;**](VersionedControllerService.md) | The Controller Services | [optional] 
**VersionedFlowCoordinates** | [**VersionedFlowCoordinates**](VersionedFlowCoordinates.md) | The coordinates where the remote flow is stored, or null if the Process Group is not directly under Version Control | [optional] 
**Variables** | **Dictionary&lt;string, string&gt;** | The Variables in the Variable Registry for this Process Group (not including any ancestor or descendant Process Groups) | [optional] 
**ComponentType** | **string** |  | [optional] 
**GroupIdentifier** | **string** | The ID of the Process Group that this component belongs to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

