# IO.Swagger.Api.ProcessorsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClearState**](ProcessorsApi.md#clearstate) | **POST** /processors/{id}/state/clear-requests | Clears the state for a processor
[**DeleteProcessor**](ProcessorsApi.md#deleteprocessor) | **DELETE** /processors/{id} | Deletes a processor
[**GetProcessor**](ProcessorsApi.md#getprocessor) | **GET** /processors/{id} | Gets a processor
[**GetProcessorDiagnostics**](ProcessorsApi.md#getprocessordiagnostics) | **GET** /processors/{id}/diagnostics | Gets diagnostics information about a processor
[**GetPropertyDescriptor**](ProcessorsApi.md#getpropertydescriptor) | **GET** /processors/{id}/descriptors | Gets the descriptor for a processor property
[**GetState**](ProcessorsApi.md#getstate) | **GET** /processors/{id}/state | Gets the state for a processor
[**TerminateProcessor**](ProcessorsApi.md#terminateprocessor) | **DELETE** /processors/{id}/threads | Terminates a processor, essentially \&quot;deleting\&quot; its threads and any active tasks
[**UpdateProcessor**](ProcessorsApi.md#updateprocessor) | **PUT** /processors/{id} | Updates a processor
[**UpdateRunStatus**](ProcessorsApi.md#updaterunstatus) | **PUT** /processors/{id}/run-status | Updates run status of a processor


<a name="clearstate"></a>
# **ClearState**
> ComponentStateEntity ClearState (string id)

Clears the state for a processor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearStateExample
    {
        public void main()
        {
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.

            try
            {
                // Clears the state for a processor
                ComponentStateEntity result = apiInstance.ClearState(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.ClearState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 

### Return type

[**ComponentStateEntity**](ComponentStateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocessor"></a>
# **DeleteProcessor**
> ProcessorEntity DeleteProcessor (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a processor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProcessorExample
    {
        public void main()
        {
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a processor
                ProcessorEntity result = apiInstance.DeleteProcessor(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.DeleteProcessor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**ProcessorEntity**](ProcessorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessor"></a>
# **GetProcessor**
> ProcessorEntity GetProcessor (string id)

Gets a processor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProcessorExample
    {
        public void main()
        {
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.

            try
            {
                // Gets a processor
                ProcessorEntity result = apiInstance.GetProcessor(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.GetProcessor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 

### Return type

[**ProcessorEntity**](ProcessorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprocessordiagnostics"></a>
# **GetProcessorDiagnostics**
> ProcessorEntity GetProcessorDiagnostics (string id)

Gets diagnostics information about a processor

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
    public class GetProcessorDiagnosticsExample
    {
        public void main()
        {
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.

            try
            {
                // Gets diagnostics information about a processor
                ProcessorEntity result = apiInstance.GetProcessorDiagnostics(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.GetProcessorDiagnostics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 

### Return type

[**ProcessorEntity**](ProcessorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpropertydescriptor"></a>
# **GetPropertyDescriptor**
> PropertyDescriptorEntity GetPropertyDescriptor (string id, string propertyName, string clientId = null)

Gets the descriptor for a processor property

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPropertyDescriptorExample
    {
        public void main()
        {
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.
            var propertyName = propertyName_example;  // string | The property name.
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 

            try
            {
                // Gets the descriptor for a processor property
                PropertyDescriptorEntity result = apiInstance.GetPropertyDescriptor(id, propertyName, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.GetPropertyDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 
 **propertyName** | **string**| The property name. | 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 

### Return type

[**PropertyDescriptorEntity**](PropertyDescriptorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstate"></a>
# **GetState**
> ComponentStateEntity GetState (string id)

Gets the state for a processor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStateExample
    {
        public void main()
        {
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.

            try
            {
                // Gets the state for a processor
                ComponentStateEntity result = apiInstance.GetState(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.GetState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 

### Return type

[**ComponentStateEntity**](ComponentStateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terminateprocessor"></a>
# **TerminateProcessor**
> ProcessorEntity TerminateProcessor (string id)

Terminates a processor, essentially \"deleting\" its threads and any active tasks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TerminateProcessorExample
    {
        public void main()
        {
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.

            try
            {
                // Terminates a processor, essentially \"deleting\" its threads and any active tasks
                ProcessorEntity result = apiInstance.TerminateProcessor(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.TerminateProcessor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 

### Return type

[**ProcessorEntity**](ProcessorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprocessor"></a>
# **UpdateProcessor**
> ProcessorEntity UpdateProcessor (string id, ProcessorEntity body)

Updates a processor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProcessorExample
    {
        public void main()
        {
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.
            var body = new ProcessorEntity(); // ProcessorEntity | The processor configuration details.

            try
            {
                // Updates a processor
                ProcessorEntity result = apiInstance.UpdateProcessor(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.UpdateProcessor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 
 **body** | [**ProcessorEntity**](ProcessorEntity.md)| The processor configuration details. | 

### Return type

[**ProcessorEntity**](ProcessorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterunstatus"></a>
# **UpdateRunStatus**
> ProcessorEntity UpdateRunStatus (string id, ProcessorRunStatusEntity body)

Updates run status of a processor

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
            var apiInstance = new ProcessorsApi();
            var id = id_example;  // string | The processor id.
            var body = new ProcessorRunStatusEntity(); // ProcessorRunStatusEntity | The processor run status.

            try
            {
                // Updates run status of a processor
                ProcessorEntity result = apiInstance.UpdateRunStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessorsApi.UpdateRunStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The processor id. | 
 **body** | [**ProcessorRunStatusEntity**](ProcessorRunStatusEntity.md)| The processor run status. | 

### Return type

[**ProcessorEntity**](ProcessorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

