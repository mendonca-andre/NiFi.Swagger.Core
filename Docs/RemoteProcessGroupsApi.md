# IO.Swagger.Api.RemoteProcessGroupsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRemoteProcessGroup**](RemoteProcessGroupsApi.md#getremoteprocessgroup) | **GET** /remote-process-groups/{id} | Gets a remote process group
[**RemoveRemoteProcessGroup**](RemoteProcessGroupsApi.md#removeremoteprocessgroup) | **DELETE** /remote-process-groups/{id} | Deletes a remote process group
[**UpdateRemoteProcessGroup**](RemoteProcessGroupsApi.md#updateremoteprocessgroup) | **PUT** /remote-process-groups/{id} | Updates a remote process group
[**UpdateRemoteProcessGroupInputPort**](RemoteProcessGroupsApi.md#updateremoteprocessgroupinputport) | **PUT** /remote-process-groups/{id}/input-ports/{port-id} | Updates a remote port
[**UpdateRemoteProcessGroupInputPortRunStatus**](RemoteProcessGroupsApi.md#updateremoteprocessgroupinputportrunstatus) | **PUT** /remote-process-groups/{id}/input-ports/{port-id}/run-status | Updates run status of a remote port
[**UpdateRemoteProcessGroupOutputPort**](RemoteProcessGroupsApi.md#updateremoteprocessgroupoutputport) | **PUT** /remote-process-groups/{id}/output-ports/{port-id} | Updates a remote port
[**UpdateRemoteProcessGroupOutputPortRunStatus**](RemoteProcessGroupsApi.md#updateremoteprocessgroupoutputportrunstatus) | **PUT** /remote-process-groups/{id}/output-ports/{port-id}/run-status | Updates run status of a remote port
[**UpdateRemoteProcessGroupRunStatus**](RemoteProcessGroupsApi.md#updateremoteprocessgrouprunstatus) | **PUT** /remote-process-groups/{id}/run-status | Updates run status of a remote process group


<a name="getremoteprocessgroup"></a>
# **GetRemoteProcessGroup**
> RemoteProcessGroupEntity GetRemoteProcessGroup (string id)

Gets a remote process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRemoteProcessGroupExample
    {
        public void main()
        {
            var apiInstance = new RemoteProcessGroupsApi();
            var id = id_example;  // string | The remote process group id.

            try
            {
                // Gets a remote process group
                RemoteProcessGroupEntity result = apiInstance.GetRemoteProcessGroup(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteProcessGroupsApi.GetRemoteProcessGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 

### Return type

[**RemoteProcessGroupEntity**](RemoteProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeremoteprocessgroup"></a>
# **RemoveRemoteProcessGroup**
> RemoteProcessGroupEntity RemoveRemoteProcessGroup (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a remote process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveRemoteProcessGroupExample
    {
        public void main()
        {
            var apiInstance = new RemoteProcessGroupsApi();
            var id = id_example;  // string | The remote process group id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a remote process group
                RemoteProcessGroupEntity result = apiInstance.RemoveRemoteProcessGroup(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteProcessGroupsApi.RemoveRemoteProcessGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**RemoteProcessGroupEntity**](RemoteProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateremoteprocessgroup"></a>
# **UpdateRemoteProcessGroup**
> RemoteProcessGroupEntity UpdateRemoteProcessGroup (string id, RemoteProcessGroupEntity body)

Updates a remote process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRemoteProcessGroupExample
    {
        public void main()
        {
            var apiInstance = new RemoteProcessGroupsApi();
            var id = id_example;  // string | The remote process group id.
            var body = new RemoteProcessGroupEntity(); // RemoteProcessGroupEntity | The remote process group.

            try
            {
                // Updates a remote process group
                RemoteProcessGroupEntity result = apiInstance.UpdateRemoteProcessGroup(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteProcessGroupsApi.UpdateRemoteProcessGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 
 **body** | [**RemoteProcessGroupEntity**](RemoteProcessGroupEntity.md)| The remote process group. | 

### Return type

[**RemoteProcessGroupEntity**](RemoteProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateremoteprocessgroupinputport"></a>
# **UpdateRemoteProcessGroupInputPort**
> RemoteProcessGroupPortEntity UpdateRemoteProcessGroupInputPort (string id, string portId, RemoteProcessGroupPortEntity body)

Updates a remote port

Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRemoteProcessGroupInputPortExample
    {
        public void main()
        {
            var apiInstance = new RemoteProcessGroupsApi();
            var id = id_example;  // string | The remote process group id.
            var portId = portId_example;  // string | The remote process group port id.
            var body = new RemoteProcessGroupPortEntity(); // RemoteProcessGroupPortEntity | The remote process group port.

            try
            {
                // Updates a remote port
                RemoteProcessGroupPortEntity result = apiInstance.UpdateRemoteProcessGroupInputPort(id, portId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteProcessGroupsApi.UpdateRemoteProcessGroupInputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 
 **portId** | **string**| The remote process group port id. | 
 **body** | [**RemoteProcessGroupPortEntity**](RemoteProcessGroupPortEntity.md)| The remote process group port. | 

### Return type

[**RemoteProcessGroupPortEntity**](RemoteProcessGroupPortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateremoteprocessgroupinputportrunstatus"></a>
# **UpdateRemoteProcessGroupInputPortRunStatus**
> RemoteProcessGroupPortEntity UpdateRemoteProcessGroupInputPortRunStatus (string id, string portId, RemotePortRunStatusEntity body)

Updates run status of a remote port

Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRemoteProcessGroupInputPortRunStatusExample
    {
        public void main()
        {
            var apiInstance = new RemoteProcessGroupsApi();
            var id = id_example;  // string | The remote process group id.
            var portId = portId_example;  // string | The remote process group port id.
            var body = new RemotePortRunStatusEntity(); // RemotePortRunStatusEntity | The remote process group port.

            try
            {
                // Updates run status of a remote port
                RemoteProcessGroupPortEntity result = apiInstance.UpdateRemoteProcessGroupInputPortRunStatus(id, portId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteProcessGroupsApi.UpdateRemoteProcessGroupInputPortRunStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 
 **portId** | **string**| The remote process group port id. | 
 **body** | [**RemotePortRunStatusEntity**](RemotePortRunStatusEntity.md)| The remote process group port. | 

### Return type

[**RemoteProcessGroupPortEntity**](RemoteProcessGroupPortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateremoteprocessgroupoutputport"></a>
# **UpdateRemoteProcessGroupOutputPort**
> RemoteProcessGroupPortEntity UpdateRemoteProcessGroupOutputPort (string id, string portId, RemoteProcessGroupPortEntity body)

Updates a remote port

Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRemoteProcessGroupOutputPortExample
    {
        public void main()
        {
            var apiInstance = new RemoteProcessGroupsApi();
            var id = id_example;  // string | The remote process group id.
            var portId = portId_example;  // string | The remote process group port id.
            var body = new RemoteProcessGroupPortEntity(); // RemoteProcessGroupPortEntity | The remote process group port.

            try
            {
                // Updates a remote port
                RemoteProcessGroupPortEntity result = apiInstance.UpdateRemoteProcessGroupOutputPort(id, portId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteProcessGroupsApi.UpdateRemoteProcessGroupOutputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 
 **portId** | **string**| The remote process group port id. | 
 **body** | [**RemoteProcessGroupPortEntity**](RemoteProcessGroupPortEntity.md)| The remote process group port. | 

### Return type

[**RemoteProcessGroupPortEntity**](RemoteProcessGroupPortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateremoteprocessgroupoutputportrunstatus"></a>
# **UpdateRemoteProcessGroupOutputPortRunStatus**
> RemoteProcessGroupPortEntity UpdateRemoteProcessGroupOutputPortRunStatus (string id, string portId, RemotePortRunStatusEntity body)

Updates run status of a remote port

Note: This endpoint is subject to change as NiFi and it's REST API evolve.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRemoteProcessGroupOutputPortRunStatusExample
    {
        public void main()
        {
            var apiInstance = new RemoteProcessGroupsApi();
            var id = id_example;  // string | The remote process group id.
            var portId = portId_example;  // string | The remote process group port id.
            var body = new RemotePortRunStatusEntity(); // RemotePortRunStatusEntity | The remote process group port.

            try
            {
                // Updates run status of a remote port
                RemoteProcessGroupPortEntity result = apiInstance.UpdateRemoteProcessGroupOutputPortRunStatus(id, portId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteProcessGroupsApi.UpdateRemoteProcessGroupOutputPortRunStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 
 **portId** | **string**| The remote process group port id. | 
 **body** | [**RemotePortRunStatusEntity**](RemotePortRunStatusEntity.md)| The remote process group port. | 

### Return type

[**RemoteProcessGroupPortEntity**](RemoteProcessGroupPortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateremoteprocessgrouprunstatus"></a>
# **UpdateRemoteProcessGroupRunStatus**
> RemoteProcessGroupEntity UpdateRemoteProcessGroupRunStatus (string id, RemotePortRunStatusEntity body)

Updates run status of a remote process group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRemoteProcessGroupRunStatusExample
    {
        public void main()
        {
            var apiInstance = new RemoteProcessGroupsApi();
            var id = id_example;  // string | The remote process group id.
            var body = new RemotePortRunStatusEntity(); // RemotePortRunStatusEntity | The remote process group run status.

            try
            {
                // Updates run status of a remote process group
                RemoteProcessGroupEntity result = apiInstance.UpdateRemoteProcessGroupRunStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RemoteProcessGroupsApi.UpdateRemoteProcessGroupRunStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The remote process group id. | 
 **body** | [**RemotePortRunStatusEntity**](RemotePortRunStatusEntity.md)| The remote process group run status. | 

### Return type

[**RemoteProcessGroupEntity**](RemoteProcessGroupEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

