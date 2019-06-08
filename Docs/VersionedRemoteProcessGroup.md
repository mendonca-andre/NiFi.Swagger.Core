# IO.Swagger.Model.VersionedRemoteProcessGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | The component&#39;s unique identifier | [optional] 
**Name** | **string** | The component&#39;s name | [optional] 
**Comments** | **string** | The user-supplied comments for the component | [optional] 
**Position** | [**Position**](Position.md) | The component&#39;s position on the graph | [optional] 
**TargetUri** | **string** | [DEPRECATED] The target URI of the remote process group. If target uri is not set, but uris are set, then returns the first uri in the uris. If neither target uri nor uris are set, then returns null. | [optional] 
**TargetUris** | **string** | The target URIs of the remote process group. If target uris is not set but target uri is set, then returns the single target uri. If neither target uris nor target uri is set, then returns null. | [optional] 
**CommunicationsTimeout** | **string** | The time period used for the timeout when communicating with the target. | [optional] 
**YieldDuration** | **string** | When yielding, this amount of time must elapse before the remote process group is scheduled again. | [optional] 
**TransportProtocol** | **string** | The Transport Protocol that is used for Site-to-Site communications | [optional] 
**LocalNetworkInterface** | **string** | The local network interface to send/receive data. If not specified, any local address is used. If clustered, all nodes must have an interface with this identifier. | [optional] 
**ProxyHost** | **string** |  | [optional] 
**ProxyPort** | **int?** |  | [optional] 
**ProxyUser** | **string** |  | [optional] 
**InputPorts** | [**List&lt;VersionedRemoteGroupPort&gt;**](VersionedRemoteGroupPort.md) | A Set of Input Ports that can be connected to, in order to send data to the remote NiFi instance | [optional] 
**OutputPorts** | [**List&lt;VersionedRemoteGroupPort&gt;**](VersionedRemoteGroupPort.md) | A Set of Output Ports that can be connected to, in order to pull data from the remote NiFi instance | [optional] 
**ComponentType** | **string** |  | [optional] 
**GroupIdentifier** | **string** | The ID of the Process Group that this component belongs to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

