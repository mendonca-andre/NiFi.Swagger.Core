# IO.Swagger.Api.ReportingTasksApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClearState**](ReportingTasksApi.md#clearstate) | **POST** /reporting-tasks/{id}/state/clear-requests | Clears the state for a reporting task
[**GetPropertyDescriptor**](ReportingTasksApi.md#getpropertydescriptor) | **GET** /reporting-tasks/{id}/descriptors | Gets a reporting task property descriptor
[**GetReportingTask**](ReportingTasksApi.md#getreportingtask) | **GET** /reporting-tasks/{id} | Gets a reporting task
[**GetState**](ReportingTasksApi.md#getstate) | **GET** /reporting-tasks/{id}/state | Gets the state for a reporting task
[**RemoveReportingTask**](ReportingTasksApi.md#removereportingtask) | **DELETE** /reporting-tasks/{id} | Deletes a reporting task
[**UpdateReportingTask**](ReportingTasksApi.md#updatereportingtask) | **PUT** /reporting-tasks/{id} | Updates a reporting task
[**UpdateRunStatus**](ReportingTasksApi.md#updaterunstatus) | **PUT** /reporting-tasks/{id}/run-status | Updates run status of a reporting task


<a name="clearstate"></a>
# **ClearState**
> ComponentStateEntity ClearState (string id)

Clears the state for a reporting task

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
            var apiInstance = new ReportingTasksApi();
            var id = id_example;  // string | The reporting task id.

            try
            {
                // Clears the state for a reporting task
                ComponentStateEntity result = apiInstance.ClearState(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingTasksApi.ClearState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The reporting task id. | 

### Return type

[**ComponentStateEntity**](ComponentStateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpropertydescriptor"></a>
# **GetPropertyDescriptor**
> PropertyDescriptorEntity GetPropertyDescriptor (string id, string propertyName)

Gets a reporting task property descriptor

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
            var apiInstance = new ReportingTasksApi();
            var id = id_example;  // string | The reporting task id.
            var propertyName = propertyName_example;  // string | The property name.

            try
            {
                // Gets a reporting task property descriptor
                PropertyDescriptorEntity result = apiInstance.GetPropertyDescriptor(id, propertyName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingTasksApi.GetPropertyDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The reporting task id. | 
 **propertyName** | **string**| The property name. | 

### Return type

[**PropertyDescriptorEntity**](PropertyDescriptorEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportingtask"></a>
# **GetReportingTask**
> ReportingTaskEntity GetReportingTask (string id)

Gets a reporting task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReportingTaskExample
    {
        public void main()
        {
            var apiInstance = new ReportingTasksApi();
            var id = id_example;  // string | The reporting task id.

            try
            {
                // Gets a reporting task
                ReportingTaskEntity result = apiInstance.GetReportingTask(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingTasksApi.GetReportingTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The reporting task id. | 

### Return type

[**ReportingTaskEntity**](ReportingTaskEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstate"></a>
# **GetState**
> ComponentStateEntity GetState (string id)

Gets the state for a reporting task

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
            var apiInstance = new ReportingTasksApi();
            var id = id_example;  // string | The reporting task id.

            try
            {
                // Gets the state for a reporting task
                ComponentStateEntity result = apiInstance.GetState(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingTasksApi.GetState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The reporting task id. | 

### Return type

[**ComponentStateEntity**](ComponentStateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removereportingtask"></a>
# **RemoveReportingTask**
> ReportingTaskEntity RemoveReportingTask (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a reporting task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveReportingTaskExample
    {
        public void main()
        {
            var apiInstance = new ReportingTasksApi();
            var id = id_example;  // string | The reporting task id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a reporting task
                ReportingTaskEntity result = apiInstance.RemoveReportingTask(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingTasksApi.RemoveReportingTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The reporting task id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**ReportingTaskEntity**](ReportingTaskEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereportingtask"></a>
# **UpdateReportingTask**
> ReportingTaskEntity UpdateReportingTask (string id, ReportingTaskEntity body)

Updates a reporting task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateReportingTaskExample
    {
        public void main()
        {
            var apiInstance = new ReportingTasksApi();
            var id = id_example;  // string | The reporting task id.
            var body = new ReportingTaskEntity(); // ReportingTaskEntity | The reporting task configuration details.

            try
            {
                // Updates a reporting task
                ReportingTaskEntity result = apiInstance.UpdateReportingTask(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingTasksApi.UpdateReportingTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The reporting task id. | 
 **body** | [**ReportingTaskEntity**](ReportingTaskEntity.md)| The reporting task configuration details. | 

### Return type

[**ReportingTaskEntity**](ReportingTaskEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterunstatus"></a>
# **UpdateRunStatus**
> ReportingTaskEntity UpdateRunStatus (string id, ReportingTaskRunStatusEntity body)

Updates run status of a reporting task

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
            var apiInstance = new ReportingTasksApi();
            var id = id_example;  // string | The reporting task id.
            var body = new ReportingTaskRunStatusEntity(); // ReportingTaskRunStatusEntity | The reporting task run status.

            try
            {
                // Updates run status of a reporting task
                ReportingTaskEntity result = apiInstance.UpdateRunStatus(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportingTasksApi.UpdateRunStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The reporting task id. | 
 **body** | [**ReportingTaskRunStatusEntity**](ReportingTaskRunStatusEntity.md)| The reporting task run status. | 

### Return type

[**ReportingTaskEntity**](ReportingTaskEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

