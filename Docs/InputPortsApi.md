# IO.Swagger.Api.InputPortsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInputPort**](InputPortsApi.md#getinputport) | **GET** /input-ports/{id} | Gets an input port
[**RemoveInputPort**](InputPortsApi.md#removeinputport) | **DELETE** /input-ports/{id} | Deletes an input port
[**UpdateInputPort**](InputPortsApi.md#updateinputport) | **PUT** /input-ports/{id} | Updates an input port
[**UpdateRunStatus**](InputPortsApi.md#updaterunstatus) | **PUT** /input-ports/{id}/run-status | Updates run status of an input-port


<a name="getinputport"></a>
# **GetInputPort**
> PortEntity GetInputPort (string id)

Gets an input port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInputPortExample
    {
        public void main()
        {
            var apiInstance = new InputPortsApi();
            var id = id_example;  // string | The input port id.

            try
            {
                // Gets an input port
                PortEntity result = apiInstance.GetInputPort(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InputPortsApi.GetInputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The input port id. | 

### Return type

[**PortEntity**](PortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeinputport"></a>
# **RemoveInputPort**
> PortEntity RemoveInputPort (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes an input port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveInputPortExample
    {
        public void main()
        {
            var apiInstance = new InputPortsApi();
            var id = id_example;  // string | The input port id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes an input port
                PortEntity result = apiInstance.RemoveInputPort(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InputPortsApi.RemoveInputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The input port id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**PortEntity**](PortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinputport"></a>
# **UpdateInputPort**
> PortEntity UpdateInputPort (string id, PortEntity body)

Updates an input port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateInputPortExample
    {
        public void main()
        {
            var apiInstance = new InputPortsApi();
            var id = id_example;  // string | The input port id.
            var body = new PortEntity(); // PortEntity | The input port configuration details.

            try
            {
                // Updates an input port
                PortEntity result = apiInstance.UpdateInputPort(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InputPortsApi.UpdateInputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The input port id. | 
 **body** | [**PortEntity**](PortEntity.md)| The input port configuration details. | 

### Return type

[**PortEntity**](PortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterunstatus"></a>
# **UpdateRunStatus**
> ProcessorEntity UpdateRunStatus (string id, PortRunStatusEntity body)

Updates run status of an input-port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRunStatusExample
    {
        public void main()
        {
            var apiInstance = new InputPortsApi();
            var id = id_example;  // string | The port id.
            var body = new PortRunStatusEntity(); // PortRunStatusEntity | The port run status.

            try
            {
                // Updates run status of an input-port
                ProcessorEntity result = apiInstance.UpdateRunStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InputPortsApi.UpdateRunStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The port id. | 
 **body** | [**PortRunStatusEntity**](PortRunStatusEntity.md)| The port run status. | 

### Return type

[**ProcessorEntity**](ProcessorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

