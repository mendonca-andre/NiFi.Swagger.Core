# IO.Swagger.Api.FunnelApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFunnel**](FunnelApi.md#getfunnel) | **GET** /funnels/{id} | Gets a funnel
[**RemoveFunnel**](FunnelApi.md#removefunnel) | **DELETE** /funnels/{id} | Deletes a funnel
[**UpdateFunnel**](FunnelApi.md#updatefunnel) | **PUT** /funnels/{id} | Updates a funnel


<a name="getfunnel"></a>
# **GetFunnel**
> FunnelEntity GetFunnel (string id)

Gets a funnel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFunnelExample
    {
        public void main()
        {
            var apiInstance = new FunnelApi();
            var id = id_example;  // string | The funnel id.

            try
            {
                // Gets a funnel
                FunnelEntity result = apiInstance.GetFunnel(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FunnelApi.GetFunnel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The funnel id. | 

### Return type

[**FunnelEntity**](FunnelEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removefunnel"></a>
# **RemoveFunnel**
> FunnelEntity RemoveFunnel (string id, string version = null, string clientId = null, bool? disconnectedNodeAcknowledged = null)

Deletes a funnel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveFunnelExample
    {
        public void main()
        {
            var apiInstance = new FunnelApi();
            var id = id_example;  // string | The funnel id.
            var version = version_example;  // string | The revision is used to verify the client is working with the latest version of the flow. (optional) 
            var clientId = clientId_example;  // string | If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. (optional) 
            var disconnectedNodeAcknowledged = true;  // bool? | Acknowledges that this node is disconnected to allow for mutable requests to proceed. (optional)  (default to false)

            try
            {
                // Deletes a funnel
                FunnelEntity result = apiInstance.RemoveFunnel(id, version, clientId, disconnectedNodeAcknowledged);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FunnelApi.RemoveFunnel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The funnel id. | 
 **version** | **string**| The revision is used to verify the client is working with the latest version of the flow. | [optional] 
 **clientId** | **string**| If the client id is not specified, new one will be generated. This value (whether specified or generated) is included in the response. | [optional] 
 **disconnectedNodeAcknowledged** | **bool?**| Acknowledges that this node is disconnected to allow for mutable requests to proceed. | [optional] [default to false]

### Return type

[**FunnelEntity**](FunnelEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefunnel"></a>
# **UpdateFunnel**
> FunnelEntity UpdateFunnel (string id, FunnelEntity body)

Updates a funnel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateFunnelExample
    {
        public void main()
        {
            var apiInstance = new FunnelApi();
            var id = id_example;  // string | The funnel id.
            var body = new FunnelEntity(); // FunnelEntity | The funnel configuration details.

            try
            {
                // Updates a funnel
                FunnelEntity result = apiInstance.UpdateFunnel(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FunnelApi.UpdateFunnel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The funnel id. | 
 **body** | [**FunnelEntity**](FunnelEntity.md)| The funnel configuration details. | 

### Return type

[**FunnelEntity**](FunnelEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

