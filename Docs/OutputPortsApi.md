# IO.Swagger.Api.OutputPortsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOutputPort**](OutputPortsApi.md#getoutputport) | **GET** /output-ports/{id} | Gets an output port
[**RemoveOutputPort**](OutputPortsApi.md#removeoutputport) | **DELETE** /output-ports/{id} | Deletes an output port
[**UpdateOutputPort**](OutputPortsApi.md#updateoutputport) | **PUT** /output-ports/{id} | Updates an output port
[**UpdateRunStatus**](OutputPortsApi.md#updaterunstatus) | **PUT** /output-ports/{id}/run-status | Updates run status of an output-port


<a name="getoutputport"></a>
# **GetOutputPort**
> PortEntity GetOutputPort (string id)

Gets an output port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOutputPortExample
    {
        public void main()
        {
            var apiInstance = new OutputPortsApi();
            var id = id_example;  // string | The output port id.

            try
            {
                // Gets an output port
                PortEntity result = apiInstance.GetOutputPort(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutputPortsApi.GetOutputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The output port id. | 

### Return type

[**PortEntity**](PortEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeoutputport"></a>
# **RemoveOutputPort**
> PortEntity RemoveOutputPort (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes an output port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveOutputPortExample
    {
        public void main()
        {
            var apiInstance = new OutputPortsApi();
            var id = id_example;  // string | The output port id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes an output port
                PortEntity result = apiInstance.RemoveOutputPort(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutputPortsApi.RemoveOutputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The output port id. | 
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

<a name="updateoutputport"></a>
# **UpdateOutputPort**
> PortEntity UpdateOutputPort (string id, PortEntity body)

Updates an output port

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateOutputPortExample
    {
        public void main()
        {
            var apiInstance = new OutputPortsApi();
            var id = id_example;  // string | The output port id.
            var body = new PortEntity(); // PortEntity | The output port configuration details.

            try
            {
                // Updates an output port
                PortEntity result = apiInstance.UpdateOutputPort(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutputPortsApi.UpdateOutputPort: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The output port id. | 
 **body** | [**PortEntity**](PortEntity.md)| The output port configuration details. | 

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

Updates run status of an output-port

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
            var apiInstance = new OutputPortsApi();
            var id = id_example;  // string | The port id.
            var body = new PortRunStatusEntity(); // PortRunStatusEntity | The port run status.

            try
            {
                // Updates run status of an output-port
                ProcessorEntity result = apiInstance.UpdateRunStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutputPortsApi.UpdateRunStatus: " + e.Message );
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

