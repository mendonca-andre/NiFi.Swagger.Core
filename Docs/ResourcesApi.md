# IO.Swagger.Api.ResourcesApi

All URIs are relative to *http://localhost/nifi-api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetResources**](ResourcesApi.md#getresources) | **GET** /resources | Gets the available resources that support access/authorization policies


<a name="getresources"></a>
# **GetResources**
> ResourcesEntity GetResources ()

Gets the available resources that support access/authorization policies

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetResourcesExample
    {
        public void main()
        {
            var apiInstance = new ResourcesApi();

            try
            {
                // Gets the available resources that support access/authorization policies
                ResourcesEntity result = apiInstance.GetResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResources: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResourcesEntity**](ResourcesEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

