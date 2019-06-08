# IO.Swagger.Model.RemoteProcessGroupDTO
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the component. | [optional] 
**VersionedComponentId** | **string** | The ID of the corresponding component that is under version control | [optional] 
**ParentGroupId** | **string** | The id of parent process group of this component if applicable. | [optional] 
**Position** | [**PositionDTO**](PositionDTO.md) | The position of this component in the UI if applicable. | [optional] 
**TargetUri** | **string** | The target URI of the remote process group. If target uri is not set, but uris are set, then returns the first url in the urls. If neither target uri nor uris are set, then returns null. | [optional] 
**TargetUris** | **string** | The target URI of the remote process group. If target uris is not set but target uri is set, then returns a collection containing the single target uri. If neither target uris nor uris are set, then returns null. | [optional] 
**TargetSecure** | **bool?** | Whether the target is running securely. | [optional] 
**Name** | **string** | The name of the remote process group. | [optional] 
**Comments** | **string** | The comments for the remote process group. | [optional] 
**CommunicationsTimeout** | **string** | The time period used for the timeout when communicating with the target. | [optional] 
**YieldDuration** | **string** | When yielding, this amount of time must elapse before the remote process group is scheduled again. | [optional] 
**TransportProtocol** | **string** |  | [optional] 
**LocalNetworkInterface** | **string** | The local network interface to send/receive data. If not specified, any local address is used. If clustered, all nodes must have an interface with this identifier. | [optional] 
**ProxyHost** | **string** |  | [optional] 
**ProxyPort** | **int?** |  | [optional] 
**ProxyUser** | **string** |  | [optional] 
**ProxyPassword** | **string** |  | [optional] 
**AuthorizationIssues** | **List&lt;string&gt;** | Any remote authorization issues for the remote process group. | [optional] 
**ValidationErrors** | **List&lt;string&gt;** | The validation errors for the remote process group. These validation errors represent the problems with the remote process group that must be resolved before it can transmit. | [optional] 
**Transmitting** | **bool?** | Whether the remote process group is actively transmitting. | [optional] 
**InputPortCount** | **int?** | The number of remote input ports currently available on the target. | [optional] 
**OutputPortCount** | **int?** | The number of remote output ports currently available on the target. | [optional] 
**ActiveRemoteInputPortCount** | **int?** | The number of active remote input ports. | [optional] 
**InactiveRemoteInputPortCount** | **int?** | The number of inactive remote input ports. | [optional] 
**ActiveRemoteOutputPortCount** | **int?** | The number of active remote output ports. | [optional] 
**InactiveRemoteOutputPortCount** | **int?** | The number of inactive remote output ports. | [optional] 
**FlowRefreshed** | **string** | The timestamp when this remote process group was last refreshed. | [optional] 
**Contents** | [**RemoteProcessGroupContentsDTO**](RemoteProcessGroupContentsDTO.md) | The contents of the remote process group. Will contain available input/output ports. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

