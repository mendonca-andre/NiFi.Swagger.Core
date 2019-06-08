# IO.Swagger.Api.ConnectionsApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteConnection**](ConnectionsApi.md#deleteconnection) | **DELETE** /connections/{id} | Deletes a connection
[**GetConnection**](ConnectionsApi.md#getconnection) | **GET** /connections/{id} | Gets a connection
[**UpdateConnection**](ConnectionsApi.md#updateconnection) | **PUT** /connections/{id} | Updates a connection


<a name="deleteconnection"></a>
# **DeleteConnection**
> ConnectionEntity DeleteConnection (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a connection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteConnectionExample
    {
        public void main()
        {
            var apiInstance = new ConnectionsApi();
            var id = id_example;  // string | The connection id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a connection
                ConnectionEntity result = apiInstance.DeleteConnection(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectionsApi.DeleteConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**ConnectionEntity**](ConnectionEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconnection"></a>
# **GetConnection**
> ConnectionEntity GetConnection (string id)

Gets a connection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConnectionExample
    {
        public void main()
        {
            var apiInstance = new ConnectionsApi();
            var id = id_example;  // string | The connection id.

            try
            {
                // Gets a connection
                ConnectionEntity result = apiInstance.GetConnection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectionsApi.GetConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 

### Return type

[**ConnectionEntity**](ConnectionEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconnection"></a>
# **UpdateConnection**
> ConnectionEntity UpdateConnection (string id, ConnectionEntity body)

Updates a connection

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateConnectionExample
    {
        public void main()
        {
            var apiInstance = new ConnectionsApi();
            var id = id_example;  // string | The connection id.
            var body = new ConnectionEntity(); // ConnectionEntity | The connection configuration details.

            try
            {
                // Updates a connection
                ConnectionEntity result = apiInstance.UpdateConnection(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConnectionsApi.UpdateConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The connection id. | 
 **body** | [**ConnectionEntity**](ConnectionEntity.md)| The connection configuration details. | 

### Return type

[**ConnectionEntity**](ConnectionEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

